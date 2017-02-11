// ----------------------------------------------------------------------------
//  <copyright file="XamlPropertyRuleWizard.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Text;
using EnvDTE;
using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualStudio.Context;
using Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Generators;
using Microsoft.VisualStudio.ProjectSystem.Utilities;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Items
{
    internal class XamlPropertyRuleWizard : ItemTemplateWizardBase
    {
        protected override void RunStartedCore(Dictionary<string, string> replacementsDictionary)
        {

            ContextDiscovery discovery = new ContextDiscovery(_dte);
            discovery.DiscoverCore(out ProjectItemOrProject projectItemorProject);
            SourceText text = SourceCodeGenerator.GenerateXamlPropertyRuleSourceText(RootName);
            string codeBehindText = XamlPropertyRuleGenerator.GenerateCodeBehindContent(RootName, RootNamespace);
            string filePath = null;
            string codeBehindPath = null;

            if (projectItemorProject.IsProject)
            {
                string directory = Path.GetDirectoryName(projectItemorProject.Project.FullName);
                filePath = Path.Combine(directory, $"{RootName}.xaml");
                codeBehindPath = Path.Combine(directory, $"{RootName}.xaml.cs");
            }
            else
            {
                filePath = Path.Combine(projectItemorProject.ProjectItem.FileNames[0], $"{RootName}.xaml");
                codeBehindPath = Path.Combine(projectItemorProject.ProjectItem.FileNames[0], $"{RootName}.xaml.cs");
            }

            File.WriteAllText(codeBehindPath, codeBehindText);
            File.WriteAllText(filePath, text.ToString(), Encoding.ASCII);

            ProjectItem projectItem = projectItemorProject.ProjectItem.ProjectItems.AddFromFile(filePath);

            SetXamlPropertyRuleBuildProperties(projectItem);

        }

        private static void SetXamlPropertyRuleBuildProperties(ProjectItem projectItem)
        {
            projectItem.Properties.Item("ItemType").Value = "XamlPropertyRule";
            projectItem.SetBuildPropertyMetadata("Generator", "MSBuild:GenerateRuleSourceFromXaml");
        }
    }
}