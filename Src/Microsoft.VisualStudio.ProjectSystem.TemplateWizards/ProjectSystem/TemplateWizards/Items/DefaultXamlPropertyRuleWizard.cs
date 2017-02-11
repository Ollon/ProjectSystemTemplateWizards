// ----------------------------------------------------------------------------
//  <copyright file="DefaultXamlPropertyRuleWizard.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.VisualStudio.ProjectSystem.Utilities;
using EnvDTE;
using Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Factories;
using Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Generators;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Items
{
    internal class DefaultXamlPropertyRuleWizard : ItemTemplateWizardBase
    {
        protected override void RunStartedCore(Dictionary<string, string> replacementsDictionary)
        {
            using (ThreadedWaitDialogProgressScope scope = new ThreadedWaitDialogProgressScope("Generating XamlPropertyRules"))
            {
                ProjectItem rulesFolder = GetOrCreateRulesFolder();
                IXamlPropertyRuleContext context = XamlPropertyRuleFactory.CreateXamlPropertyRuleContext();

                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.AnalyzerReferenceContent, "AnalyzerReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.AppDesignerContent, "AppDesigner.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.AssemblyInfoContent, "AssemblyInfo.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.AssemblyReferenceContent, "AssemblyReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.CompilerCommandLineArgsContent, "CompilerCommandLineArgs.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.COMReferenceContent, "COMReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ConfigurationGeneralContent, "ConfigurationGeneral.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ConfigurationGeneralFileContent, "ConfigurationGeneralFile.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ContentContent, "Content.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.CSharpContent, "CSharp.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.DebuggerGeneralContent, "DebuggerGeneral.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.DotNetCliToolReferenceContent, "DotNetCliToolReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.EmbeddedResourceContent, "EmbeddedResource.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.FolderContent, "Folder.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.NoneContent, "None.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.NuGetRestoreContent, "NuGetRestore.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.PackageReferenceContent, "PackageReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ProjectDebuggerContent, "ProjectDebugger.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ProjectReferenceContent, "ProjectReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.PSDbgContent, "PSDbg.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ResolvedAnalyzerReferenceContent, "ResolvedAnalyzerReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ResolvedAssemblyReferenceContent, "ResolvedAssemblyReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ResolvedCOMReferenceContent, "ResolvedCOMReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ResolvedPackageReferenceContent, "ResolvedPackageReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ResolvedProjectReferenceContent, "ResolvedProjectReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ResolvedSdkReferenceContent, "ResolvedSdkReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.SdkReferenceContent, "SdkReference.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.SourceControlContent, "SourceControl.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.SpecialFolderContent, "SpecialFolder.xaml");
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.SubProjectContent, "SubProject.xaml");


                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.GeneralBrowseObjectContent, "GeneralBrowseObject.xaml", XamlPropertyRuleOption.XamlPropertyRuleNoCodeBehind);
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.CSharpBrowseObjectContent, "CSharpBrowseObject.xaml", XamlPropertyRuleOption.XamlPropertyRuleNoCodeBehind);
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.ProjectItemsSchemaContent, "ProjectItemsSchema.xaml", XamlPropertyRuleOption.XamlPropertyRuleProjectItemsSchema);
                XamlPropertyRuleGenerator.GenerateXamlPropertyRule(scope, rulesFolder, context.CSharpProjectItemsSchemaContent, "CSharpProjectItemsSchema.xaml", XamlPropertyRuleOption.XamlPropertyRuleProjectItemsSchema);

            }
        }

        private ProjectItem GetOrCreateRulesFolder()
        {
            return _dte.GetOrCreateFolder("Rules");
        }
    }
}