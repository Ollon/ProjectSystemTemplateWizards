// ----------------------------------------------------------------------------
//  <copyright file="XamlPropertyRuleGenerator.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;
using System.IO;
using System.Text;
using EnvDTE;
using Microsoft.VisualStudio.ProjectSystem.Utilities;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Generators
{
    internal static class XamlPropertyRuleGenerator
    {
        public static void GenerateXamlPropertyRule(ThreadedWaitDialogProgressScope scope, ProjectItem folder, string content, string fileName, XamlPropertyRuleOption option = XamlPropertyRuleOption.XamlPropertyRule)
        {
            switch (option)
            {
                case XamlPropertyRuleOption.XamlPropertyRule:
                    GenerateXamlPropertyRuleCore(scope, folder, content, fileName);
                    break;
                case XamlPropertyRuleOption.XamlPropertyRuleNoCodeBehind:
                    GenerateXamlPropertyRuleNoCodeBehind(scope, folder, content, fileName);
                    break;
                case XamlPropertyRuleOption.XamlPropertyRuleProjectItemsSchema:
                    GenerateXamlPropertyRuleProjectItemsSchema(scope, folder, content, fileName);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(option), option, null);
            }
        }

        private static void GenerateXamlPropertyRuleCore(ThreadedWaitDialogProgressScope scope, ProjectItem folder, string content, string fileName)
        {
            scope.Update("Generating XamlPropertyRule",$"Creating {fileName}", $"Creating {fileName}",true);
            string directory = folder.FileNames[0];
            string xamlPropertyRulePath = Path.Combine(directory, fileName);
            string codeBehindFilePath = Path.Combine(directory, $"{fileName}.cs");
            string rootNamespace = folder.ContainingProject.Properties.Item("DefaultNamespace").Value.ToString();
            string codeBehindContent = GenerateCodeBehindContent(Path.GetFileNameWithoutExtension(fileName), rootNamespace);
            File.WriteAllText(xamlPropertyRulePath, content);
            scope.Update("Generating XamlPropertyRule CodeBehind", $"Creating {fileName}.cs", $"Creating {fileName}.cs", true);
            File.WriteAllText(codeBehindFilePath, codeBehindContent);
            SetXamlPropertyRuleBuildProperties(folder.ProjectItems.AddFromFile(xamlPropertyRulePath));
        }

        private static void GenerateXamlPropertyRuleNoCodeBehind(ThreadedWaitDialogProgressScope scope, ProjectItem folder, string content, string fileName)
        {
            scope.Update("Generating XamlPropertyRuleNoCodeBehind", $"Creating {fileName}", $"Creating {fileName}", true);
            string directory = folder.FileNames[0];
            string xamlPropertyRulePath = Path.Combine(directory, fileName);
            File.WriteAllText(xamlPropertyRulePath, content);
            SetXamlPropertyRuleNoCodeBehindBuildProperties(folder.ProjectItems.AddFromFile(xamlPropertyRulePath));
        }

        private static void GenerateXamlPropertyRuleProjectItemsSchema(ThreadedWaitDialogProgressScope scope, ProjectItem folder, string content, string fileName)
        {
            scope.Update("Generating XamlPropertyRuleProjectItemsSchema", $"Creating {fileName}", $"Creating {fileName}", true);
            string directory = folder.FileNames[0];
            string xamlPropertyRulePath = Path.Combine(directory, fileName);
            File.WriteAllText(xamlPropertyRulePath, content);
            SetXamlPropertyRuleProjectItemsSchemaBuildProperties(folder.ProjectItems.AddFromFile(xamlPropertyRulePath));
        }

        private static void SetXamlPropertyRuleNoCodeBehindBuildProperties(ProjectItem projectItem)
        {
            projectItem.Properties.Item("ItemType").Value = "XamlPropertyRuleNoCodeBehind";
        }
        private static void SetXamlPropertyRuleProjectItemsSchemaBuildProperties(ProjectItem projectItem)
        {
            projectItem.Properties.Item("ItemType").Value = "XamlPropertyRuleProjectItemsSchema";
        }
        private static void SetXamlPropertyRuleBuildProperties(ProjectItem projectItem)
        {
            projectItem.Properties.Item("ItemType").Value = "XamlPropertyRule";
            projectItem.SetBuildPropertyMetadata("Generator", "MSBuild:GenerateRuleSourceFromXaml");
        }

        public static string GenerateCodeBehindContent(string className, string rootNamespace)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"using System.Diagnostics.CodeAnalysis;");
            sb.AppendLine(@"");
            sb.AppendLine($@"namespace {rootNamespace}");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    [ExcludeFromCodeCoverage]");
            sb.AppendLine(@"    [SuppressMessage(""Style"", ""IDE0016:Use 'throw' expression"")]");
            sb.AppendLine($@"    internal partial class {className}");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"    }");
            sb.AppendLine(@"}");
            return sb.ToString();

        }
    }
}