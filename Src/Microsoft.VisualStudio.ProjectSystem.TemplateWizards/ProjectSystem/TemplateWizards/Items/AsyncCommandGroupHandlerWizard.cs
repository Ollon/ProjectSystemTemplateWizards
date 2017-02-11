// ----------------------------------------------------------------------------
//  <copyright file="AsyncCommandGroupHandlerWizard.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Text;
using EnvDTE;
using Microsoft.VisualStudio.Context;
using Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Generators;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Items
{
    internal class AsyncCommandGroupHandlerWizard : ItemTemplateWizardBase
    {
        protected override void RunStartedCore(Dictionary<string, string> replacementsDictionary)
        {
            string name = replacementsDictionary["$rootname$"];
            string rootnamespace = replacementsDictionary["$rootnamespace$"];
            ContextDiscovery discovery = new ContextDiscovery(_dte);
            discovery.DiscoverCore(out ProjectItemOrProject projectItemorProject);
            CodeAnalysis.Text.SourceText text = SourceCodeGenerator.GenerateAsyncCommandGroupHandlerSourceText(rootnamespace, name);
            string filePath = null;

            if (projectItemorProject.IsProject)
            {
                filePath = Path.Combine(Path.GetDirectoryName(projectItemorProject.Project.FullName), $"{name}.cs");
            }
            else
            {
                filePath = Path.Combine(projectItemorProject.ProjectItem.FileNames[0], $"{name}.cs");
            }

            File.WriteAllText(filePath, text.ToString(), Encoding.ASCII);

            ProjectItem projectItem = projectItemorProject.ProjectItem.ProjectItems.AddFromFile(filePath);

            Service.Open(projectItem);
        }
    }
}