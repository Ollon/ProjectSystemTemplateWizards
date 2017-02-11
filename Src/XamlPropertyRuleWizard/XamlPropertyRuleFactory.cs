
using System;
using System.Text;


public static class XamlPropertyRuleFactory
{
    public static IXamlPropertyRuleContext CreateXamlPropertyRuleContext()
    {
        return new XamlPropertyRuleContext(
            GenerateAnalyzerReferenceContent(),
            GenerateAppDesignerContent(),
            GenerateAssemblyInfoContent(),
            GenerateAssemblyReferenceContent(),
            GenerateCompilerCommandLineArgsContent(),
            GenerateCOMReferenceContent(),
            GenerateConfigurationGeneralContent(),
            GenerateConfigurationGeneralFileContent(),
            GenerateContentContent(),
            GenerateCSharpBrowseObjectContent(),
            GenerateCSharpProjectItemsSchemaContent(),
            GenerateCSharpContent(),
            GenerateDebuggerGeneralContent(),
            GenerateDotNetCliToolReferenceContent(),
            GenerateEmbeddedResourceContent(),
            GenerateFolderContent(),
            GenerateGeneralBrowseObjectContent(),
            GenerateNoneContent(),
            GenerateNuGetRestoreContent(),
            GeneratePackageReferenceContent(),
            GenerateProjectDebuggerContent(),
            GenerateProjectItemsSchemaContent(),
            GenerateProjectReferenceContent(),
            GeneratePSDbgContent(),
            GenerateResolvedAnalyzerReferenceContent(),
            GenerateResolvedAssemblyReferenceContent(),
            GenerateResolvedCOMReferenceContent(),
            GenerateResolvedPackageReferenceContent(),
            GenerateResolvedProjectReferenceContent(),
            GenerateResolvedSdkReferenceContent(),
            GenerateSdkReferenceContent(),
            GenerateSourceControlContent(),
            GenerateSpecialFolderContent(),
            GenerateSubProjectContent()
        );

    }

    private static string GenerateAnalyzerReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""AnalyzerReference""");
        sb.AppendLine(@"    DisplayName=""Analyzer Reference""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""Analyzer reference properties""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" ItemType=""Analyzer"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateAppDesignerContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""AppDesigner""");
        sb.AppendLine(@"    DisplayName=""AppDesigner""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""General""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" Label=""Configuration"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""FolderName"" Visible=""false"" Default=""Properties"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""Configuration"" HasConfigurationCondition=""false"" PersistedName=""AppDesignerFolder""/>");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty  Name=""ContentsVisibleOnlyInShowAllFiles"" Visible=""false"" Default=""false"" ReadOnly=""true"">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""Configuration"" HasConfigurationCondition=""false"" PersistedName=""AppDesignerFolderContentsVisibleOnlyInShowAllFiles""/>");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateAssemblyInfoContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--");
        sb.AppendLine(@"    TODO: Reference the rule from the targets file using the PropertyPageSchema tag");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    Example: Including the following in the targets file will add a new property page in the project properties dialog.");
        sb.AppendLine(@"    <PropertyPageSchema Include=""$(MSBuildThisFileDirectory)Rules\assemblyinfo.xaml;"">");
        sb.AppendLine(@"      <Context>Project</Context>");
        sb.AppendLine(@"    </PropertyPageSchema>");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    For more information, please refer to the following blog post:");
        sb.AppendLine(@"    http://blogs.msdn.com/b/vsproject/archive/2009/06/18/platform-extensibility-part-2.aspx");
        sb.AppendLine(@"-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"	Name=""AssemblyInfo""");
        sb.AppendLine(@"	DisplayName=""Assembly Info""");
        sb.AppendLine(@"	PageTemplate=""tool""");
        sb.AppendLine(@"	Description=""Allows editing the assembly information""");
        sb.AppendLine(@"	xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" HasConfigurationCondition=""True""/>");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <Rule.Categories>");
        sb.AppendLine(@"        <Category Name=""AssemblyInfo"" DisplayName=""Assembly Information"" Description=""Properties that provide metada related to the assembly""/>");
        sb.AppendLine(@"    </Rule.Categories>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""AssemblyTitle"" DisplayName=""Assembly Title"" Description=""The output name for the assembly"" Category=""AssemblyInfo"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""AssemblyInfo"" HasConfigurationCondition=""false"" PersistedName=""AssemblyTitle""  />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""AssemblyDescription"" DisplayName=""Assembly Description"" Description=""A short description of the assembly"" Category=""AssemblyInfo"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""AssemblyInfo"" HasConfigurationCondition=""false"" PersistedName=""AssemblyDescription""  />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""AssemblyConfiguration"" DisplayName=""Assembly Configuration"" Description=""The configuration (i.e., Debug, Release, etc.) of the assembly"" Category=""AssemblyInfo"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""AssemblyInfo"" HasConfigurationCondition=""false"" PersistedName=""AssemblyConfiguration""  />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""AssemblyCompany"" DisplayName=""Assembly Company"" Description=""Represents the owning company/individual of this assembly"" Category=""AssemblyInfo"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""AssemblyInfo"" HasConfigurationCondition=""false"" PersistedName=""AssemblyCompany""  />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""AssemblyProduct"" DisplayName=""Assembly Product"" Description=""The parent product of this assembly"" Category=""AssemblyInfo"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""AssemblyInfo"" HasConfigurationCondition=""false"" PersistedName=""AssemblyProduct""  />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""AssemblyCopyright"" DisplayName=""Assembly Copyright"" Description=""The copyright for the assembly."" Category=""AssemblyInfo"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""AssemblyInfo"" HasConfigurationCondition=""false"" PersistedName=""AssemblyCopyright"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""AssemblyTrademark"" DisplayName=""Assembly Trademark"" Description=""The trademark for the assembly."" Category=""AssemblyInfo"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""AssemblyInfo"" HasConfigurationCondition=""false"" PersistedName=""AssemblyTrademark"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""AssemblyCulture"" DisplayName=""Assembly Culture"" Description=""The culture for the assembly."" Category=""AssemblyInfo"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""AssemblyInfo"" HasConfigurationCondition=""false"" PersistedName=""AssemblyCulture"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <EnumProperty Name=""CLSCompliant"" DisplayName=""CLS Compliant"" Category=""AssemblyInfo"">");
        sb.AppendLine(@"        <EnumValue Name=""false"" DisplayName=""False""/>");
        sb.AppendLine(@"        <EnumValue Name=""true"" DisplayName=""True""/>");
        sb.AppendLine(@"        <EnumProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""AssemblyInfo"" HasConfigurationCondition=""false"" PersistedName=""CLSCompliant""  />");
        sb.AppendLine(@"        </EnumProperty.DataSource>");
        sb.AppendLine(@"    </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <EnumProperty Name=""ComVisible"" DisplayName=""Com Visible""  Category=""AssemblyInfo"">");
        sb.AppendLine(@"        <EnumValue Name=""false"" DisplayName=""False""/>");
        sb.AppendLine(@"        <EnumValue Name=""true"" DisplayName=""True""/>");
        sb.AppendLine(@"        <EnumProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""AssemblyInfo"" HasConfigurationCondition=""false"" PersistedName=""ComVisible""  />");
        sb.AppendLine(@"        </EnumProperty.DataSource>");
        sb.AppendLine(@"    </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringListProperty Name=""InternalsVisibleTo"" DisplayName=""Internals Visible To"" Category=""AssemblyInfo"" Separator="";"" >");
        sb.AppendLine(@"        <StringListProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""AssemblyInfo"" HasConfigurationCondition=""false"" PersistedName=""InternalsVisibleTo"" />");
        sb.AppendLine(@"        </StringListProperty.DataSource>");
        sb.AppendLine(@"    </StringListProperty>");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateAssemblyReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""AssemblyReference""");
        sb.AppendLine(@"    DisplayName=""Assembly Reference""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""Assembly reference properties""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" ItemType=""Reference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringListProperty Name=""Aliases""");
        sb.AppendLine(@"                        DisplayName=""Aliases""");
        sb.AppendLine(@"                        Description=""A comma-delimited list of aliases to this reference.""");
        sb.AppendLine(@"                        Separator="","" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""CopyLocal""");
        sb.AppendLine(@"                DisplayName=""Copy Local""");
        sb.AppendLine(@"                Description=""Indicates whether the reference will be copied to the output directory."">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" ItemType=""Reference"" HasConfigurationCondition=""False"" PersistedName=""Private"" />");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""EmbedInteropTypes""");
        sb.AppendLine(@"                  DisplayName=""Embed Interop Types""");
        sb.AppendLine(@"                  Description=""Indicates whether types defined in this assembly will be embedded into the target assembly."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""SpecificVersion"" ");
        sb.AppendLine(@"                  DisplayName=""Specific Version""");
        sb.AppendLine(@"                  Description=""Indicates whether this assembly can be resolved without regard to multi-targeting rules for assembly resolution."">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""AssemblyReference"" ItemType=""Reference"" HasConfigurationCondition=""False""/>");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RequiredTargetFramework"" DisplayName=""Required Target Framework"" Visible=""False"" />");
        sb.AppendLine(@"    <StringProperty Name=""HintPath"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""SDKName"" Visible=""false"" />");
        sb.AppendLine(@"    <BoolProperty Name=""IsWinMDFile"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""ImageRuntime""");
        sb.AppendLine(@"                    DisplayName=""Runtime Version""");
        sb.AppendLine(@"                    Description=""The CLR runtime version targeted by this assembly.""");
        sb.AppendLine(@"                    Visible=""False""");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateCompilerCommandLineArgsContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""CompilerCommandLineArgs""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <!-- Rule represents the CompilerCommandLineArgs item containing the split arguments that we get back from CompileDesignTime  -->");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""CompilerCommandLineArgs "" ItemType=""CompilerCommandLineArgs "" HasConfigurationCondition=""False""");
        sb.AppendLine(@"                  SourceType=""TargetResults"" MSBuildTarget=""CompileDesignTime"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateCOMReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule Name=""ComReference"" DisplayName=""COM Reference"" PageTemplate=""generic"" Description=""COM reference properties"" xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectFile"" ItemType=""COMReference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"  <StringProperty Name=""Guid"" DisplayName=""CLSID"" Description=""The GUID of the COM server."" />");
        sb.AppendLine(@"  <StringProperty Name=""Lcid"" DisplayName=""Locale"" Description=""The LCID of the COM server."" />");
        sb.AppendLine(@"  <IntProperty Name=""VersionMajor"" />");
        sb.AppendLine(@"  <IntProperty Name=""VersionMinor"" />");
        sb.AppendLine(@"  <BoolProperty Name=""Isolated"" />");
        sb.AppendLine(@"  <StringProperty Name=""WrapperTool"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateConfigurationGeneralContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"	Name=""ConfigurationGeneral""");
        sb.AppendLine(@"	DisplayName=""General""");
        sb.AppendLine(@"	PageTemplate=""generic""");
        sb.AppendLine(@"	Description=""General""");
        sb.AppendLine(@"    OverrideMode=""Replace""");
        sb.AppendLine(@"	xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    <Rule.Categories>");
        sb.AppendLine(@"        <Category Name=""General"" DisplayName=""General"" Description=""General"" />");
        sb.AppendLine(@"    </Rule.Categories>");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" Label=""Configuration"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"    <StringProperty Name=""ApplicationIcon"" DisplayName=""Application Icon"" />");
        sb.AppendLine(@"    <StringListProperty Name=""ProjectTypeGuids"" Visible=""True"" ReadOnly=""True""/>");
        sb.AppendLine(@"    <StringProperty Name=""ProjectGuid"" Visible=""False"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ImplicitProjectFile"" Label=""Globals"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""TargetFrameworkIdentifier"" DisplayName=""Target Framework Identifier"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" PersistedName=""TargetFrameworkIdentifier"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""TargetFrameworks"" DisplayName=""Target Frameworks"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" PersistedName=""TargetFrameworks"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""TargetFramework"" DisplayName=""Target Framework"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" PersistedName=""TargetFramework"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""TargetFrameworkProfile"" DisplayName=""Target Framework Profile"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" PersistedName=""TargetFrameworkProfile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""TargetFrameworkVersion"" DisplayName=""Target Framework Version"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" PersistedName=""TargetFrameworkVersion"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>    ");
        sb.AppendLine(@"    <StringProperty Name=""TargetFrameworkMoniker"" DisplayName=""Target Framework Moniker"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFileWithInterception"" PersistedName=""TargetFrameworkMoniker"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""TargetPath"" />");
        sb.AppendLine(@"    <StringProperty Name=""DocumentationFile"" DisplayName=""XML doc comments file"" />");
        sb.AppendLine(@"    <StringProperty Name=""AssemblyName"" />");
        sb.AppendLine(@"    <StringProperty Name=""Name"" />");
        sb.AppendLine(@"    <StringProperty Name=""RootNamespace"" DisplayName=""Root namespace"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" Label=""Configuration"" HasConfigurationCondition=""false"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""OutputName"" />");
        sb.AppendLine(@"    <StringProperty Name=""OutputPath"" />");
        sb.AppendLine(@"    <StringProperty Name=""BaseIntermediateOutputPath"" />");
        sb.AppendLine(@"    <EnumProperty Name=""OutputType"">");
        sb.AppendLine(@"        <EnumValue Name=""Library"" DisplayName=""Class Library"" />");
        sb.AppendLine(@"        <EnumValue Name=""exe"" DisplayName=""Console Application"" />");
        sb.AppendLine(@"        <EnumValue Name=""winexe"" DisplayName=""Windows Application"" />");
        sb.AppendLine(@"        <EnumValue Name=""AppContainerExe"" DisplayName=""Windows Store app"" />");
        sb.AppendLine(@"        <EnumValue Name=""WinMDObj"" DisplayName=""WinMD"" />");
        sb.AppendLine(@"    </EnumProperty>");
        sb.AppendLine(@"    <StringListProperty Name=""AvailablePlatforms"" Separator="","" />");
        sb.AppendLine(@"    <BoolProperty Name=""Optimize"" Description=""Should compiler optimize output?"" />");
        sb.AppendLine(@"    <StringProperty Name=""MSBuildProjectDirectory"" Visible=""false""/>");
        sb.AppendLine(@"    <StringProperty Name=""DefaultPlatform"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""PackageAction"" Visible=""false"" Description=""The MSBuild target to use when packaging a project."" />");
        sb.AppendLine(@"    <StringProperty Name=""DefaultContentType"" Visible=""false"" Description=""The default content type name to use when adding files."" />");
        sb.AppendLine(@"    <StringProperty Name=""VCInstallDir"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""VSInstallDir"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""Platform"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""Configuration"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""DebuggerSymbolsPath"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""IntDir"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""TargetPlatformWinMDLocation"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""SDKReferenceDirectoryRoot"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""SDKReferenceRegistryRoot"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""SDKExtensionDirectoryRoot"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""SDKIdentifier"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""SDKVersion"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""TargetPlatformIdentifier"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""TargetPlatformVersion"" Visible=""false"" />");
        sb.AppendLine(@"    <BoolProperty Name=""WindowsAppContainer"" Visible=""false"" />");
        sb.AppendLine(@"    <BoolProperty Name=""WinMDAssembly"" Visible=""false"" />");
        sb.AppendLine(@"    <EnumProperty Name=""TargetRuntime"" Visible=""false"">");
        sb.AppendLine(@"        <EnumValue Name=""Managed"" />");
        sb.AppendLine(@"        <EnumValue Name=""Native"" />");
        sb.AppendLine(@"        <EnumValue Name=""AppHost"" DisplayName=""Windows app"" />");
        sb.AppendLine(@"    </EnumProperty>");
        sb.AppendLine(@"    <StringProperty Name=""AssemblySearchPaths"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""WinRTReferenceTabs"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""AssemblyReferenceTabs"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""MinimumVisualStudioVersion"" Visible=""false"" />");
        sb.AppendLine(@"    <BoolProperty Name=""SuppressOutOfDateMessageOnBuild"" Visible=""false"" Description=""True to just build out-of-date projects without ever prompting the user to confirm."" />");
        sb.AppendLine(@"    <BoolProperty Name=""ShowAllFiles"" Visible=""False"">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""UserFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"    <BoolProperty Name=""AutoRefresh"" Visible=""False"">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""UserFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"    <StringProperty Name=""AddItemTemplatesGuid"" Visible=""False"" />");
        sb.AppendLine(@"    <StringProperty Name=""ProjectUISubcaption"" Visible=""False"" />");
        sb.AppendLine(@"    <StringProperty Name=""SharedItemContextSubProjectGuid"" Visible=""False"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""UserFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""OneAppCapabilities"" Visible=""False"" />");
        sb.AppendLine(@"    <StringProperty Name=""SharedProjectAppliesTo"" Visible=""False"" Description=""Capability match expression that at a minimum tests for the language of the Shared Project; used to filter Add Shared Project Reference choices.""/>");
        sb.AppendLine(@"    <BoolProperty Name=""AlwaysUseNumericalSuffixInItemNames"" Visible=""False"" Description=""Indicates if names of newly added items should always be suffixed with a number."" />  ");
        sb.AppendLine(@"    <StringProperty Name=""LanguageServiceName"" ReadOnly=""True"" Visible=""False"" Description=""Represents the LanguageName that is passed to Roslyn"" />");
        sb.AppendLine(@"    <StringProperty Name=""TemplateLanguage"" ReadOnly=""True"" Visible=""False"" Description=""Represent the language that is persisted in items and project templates"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateConfigurationGeneralFileContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"  Name=""ConfigurationGeneralFile""");
        sb.AppendLine(@"  DisplayName=""General""");
        sb.AppendLine(@"  PageTemplate=""generic""");
        sb.AppendLine(@"  Description=""Project item general properties""");
        sb.AppendLine(@"  xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectFile"" HasConfigurationCondition=""False"" ItemType=""{}{AnyType}"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <Rule.Categories>");
        sb.AppendLine(@"    <Category Name=""Advanced"" DisplayName=""Advanced"" />");
        sb.AppendLine(@"    <Category Name=""Misc"" DisplayName=""Misc"" />");
        sb.AppendLine(@"  </Rule.Categories>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <DynamicEnumProperty");
        sb.AppendLine(@"    Name=""{}{ItemType}""");
        sb.AppendLine(@"    DisplayName=""Build Action""");
        sb.AppendLine(@"    Category=""Advanced""");
        sb.AppendLine(@"    Description=""How the file relates to the build and deployment processes.""");
        sb.AppendLine(@"    EnumProvider=""ItemTypes"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <EnumProperty");
        sb.AppendLine(@"      Name=""CopyToOutputDirectory""");
        sb.AppendLine(@"      DisplayName=""Copy to Output Directory""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      Description=""Specifies the source file will be copied to the output directory."">");
        sb.AppendLine(@"    <EnumValue Name=""Never"" DisplayName=""Do not copy"" />");
        sb.AppendLine(@"    <EnumValue Name=""Always"" DisplayName=""Copy always"" />");
        sb.AppendLine(@"    <EnumValue Name=""PreserveNewest"" DisplayName=""Copy if newer"" />");
        sb.AppendLine(@"  </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""Identity""");
        sb.AppendLine(@"      Visible=""false""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""The item specified in the Include attribute."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""{}{AnyType}"" PersistedName=""Identity"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""FullPath""");
        sb.AppendLine(@"      DisplayName=""Full Path""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""Location of the file."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""{}{AnyType}"" PersistedName=""FullPath"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""FileNameAndExtension""");
        sb.AppendLine(@"      DisplayName=""File Name""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""Name of the file or folder."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""{}{AnyType}"" PersistedName=""FileNameAndExtension"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""URL"" ReadOnly=""true"" Visible=""false"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""{}{AnyType}"" PersistedName=""FullPath"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""DependentUpon"" Visible=""False"" Description=""The leaf name of the file that this item appears as a child to in the project tree."" />");
        sb.AppendLine(@"  <BoolProperty Name=""Visible"" Visible=""false"" />");
        sb.AppendLine(@"  <StringProperty Name=""Link"" Visible=""false"" />");
        sb.AppendLine(@"  <StringProperty Name=""Extension"" Visible=""False"" ReadOnly=""true"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""{}{AnyType}"" PersistedName=""Extension"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""GeneratorTarget"" Visible=""false"" />");
        sb.AppendLine(@"  <EnumProperty Name=""SubType"" Visible=""false"">");
        sb.AppendLine(@"    <EnumValue Name=""Designer"" />");
        sb.AppendLine(@"    <EnumValue Name=""Component"" />");
        sb.AppendLine(@"    <EnumValue Name=""Control"" />");
        sb.AppendLine(@"    <EnumValue Name=""Form"" />");
        sb.AppendLine(@"    <EnumValue Name=""Code"" />");
        sb.AppendLine(@"  </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""LastGenOutput"" Visible=""false"" Description=""The filename of the last file generated as a result of the SFG."" />");
        sb.AppendLine(@"  <BoolProperty Name=""DesignTime"" Visible=""false"" Description=""A value indicating whether this file has a designer."" />");
        sb.AppendLine(@"  <BoolProperty Name=""AutoGen"" Visible=""false"" Description=""A value indicating whether this is a generated file."" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateContentContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"  Name=""Content""");
        sb.AppendLine(@"  DisplayName=""File Properties""");
        sb.AppendLine(@"  PageTemplate=""generic""");
        sb.AppendLine(@"  Description=""File Properties""");
        sb.AppendLine(@"  xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectFile"" HasConfigurationCondition=""False"" ItemType=""Content"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <Rule.Categories>");
        sb.AppendLine(@"    <Category Name=""Advanced"" DisplayName=""Advanced"" />");
        sb.AppendLine(@"    <Category Name=""Misc"" DisplayName=""Misc"" />");
        sb.AppendLine(@"  </Rule.Categories>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <DynamicEnumProperty");
        sb.AppendLine(@"      Name=""{}{ItemType}""");
        sb.AppendLine(@"      DisplayName=""Build Action""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      Description=""How the file relates to the build and deployment processes.""");
        sb.AppendLine(@"      EnumProvider=""ItemTypes"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <EnumProperty");
        sb.AppendLine(@"      Name=""CopyToOutputDirectory""");
        sb.AppendLine(@"      DisplayName=""Copy to Output Directory""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      Description=""Specifies the source file will be copied to the output directory."">");
        sb.AppendLine(@"    <EnumValue Name=""Never"" DisplayName=""Do not copy"" />");
        sb.AppendLine(@"    <EnumValue Name=""Always"" DisplayName=""Copy always"" />");
        sb.AppendLine(@"    <EnumValue Name=""PreserveNewest"" DisplayName=""Copy if newer"" />");
        sb.AppendLine(@"  </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"    Name=""Identity""");
        sb.AppendLine(@"    Visible=""false""");
        sb.AppendLine(@"    ReadOnly=""true""");
        sb.AppendLine(@"    Category=""Misc""");
        sb.AppendLine(@"    Description=""The item specified in the Include attribute."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""Content"" PersistedName=""Identity"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""FullPath""");
        sb.AppendLine(@"      DisplayName=""Full Path""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""Location of the file."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""Content"" PersistedName=""FullPath"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"    Name=""FileNameAndExtension""");
        sb.AppendLine(@"    DisplayName=""File Name""");
        sb.AppendLine(@"    ReadOnly=""true""");
        sb.AppendLine(@"    Category=""Misc""");
        sb.AppendLine(@"    Description=""Name of the file or folder."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""Content"" PersistedName=""FileNameAndExtension"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <BoolProperty Name=""Visible"" Visible=""false"" />");
        sb.AppendLine(@"  <StringProperty Name=""DependentUpon"" Visible=""false"">");
        sb.AppendLine(@"    <StringProperty.Metadata>");
        sb.AppendLine(@"      <NameValuePair Name=""DoNotCopyAcrossProjects"" Value=""true"" />");
        sb.AppendLine(@"    </StringProperty.Metadata>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""Link"" Visible=""false"">");
        sb.AppendLine(@"    <StringProperty.Metadata>");
        sb.AppendLine(@"      <NameValuePair Name=""DoNotCopyAcrossProjects"" Value=""true"" />");
        sb.AppendLine(@"    </StringProperty.Metadata>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateCSharpBrowseObjectContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright, Microsoft Corporation, All rights reserved.-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"  Name=""CSharp""");
        sb.AppendLine(@"  DisplayName=""File Properties""");
        sb.AppendLine(@"  PageTemplate=""generic""");
        sb.AppendLine(@"  Description=""File Properties""");
        sb.AppendLine(@"  xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectFile"" Label=""Configuration"" ItemType=""Compile"" HasConfigurationCondition=""false"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <Rule.Categories>");
        sb.AppendLine(@"    <Category Name=""Advanced"" DisplayName=""Advanced"" />");
        sb.AppendLine(@"    <Category Name=""Misc"" DisplayName=""Misc"" />");
        sb.AppendLine(@"  </Rule.Categories>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <DynamicEnumProperty");
        sb.AppendLine(@"      Name=""{}{ItemType}""");
        sb.AppendLine(@"      DisplayName=""Build Action""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      Description=""How the file relates to the build and deployment processes.""");
        sb.AppendLine(@"      EnumProvider=""ItemTypes"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <EnumProperty");
        sb.AppendLine(@"      Name=""CopyToOutputDirectory""");
        sb.AppendLine(@"      DisplayName=""Copy to Output Directory""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      Description=""Specifies the source file will be copied to the output directory."">");
        sb.AppendLine(@"    <EnumValue Name=""Never"" DisplayName=""Do not copy"" />");
        sb.AppendLine(@"    <EnumValue Name=""Always"" DisplayName=""Copy always"" />");
        sb.AppendLine(@"    <EnumValue Name=""PreserveNewest"" DisplayName=""Copy if newer"" />");
        sb.AppendLine(@"  </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""Identity""");
        sb.AppendLine(@"      Visible=""false""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""The item specified in the Include attribute."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""Compile"" PersistedName=""Identity"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""FullPath""");
        sb.AppendLine(@"      DisplayName=""Full Path""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""Location of the file."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""Compile"" PersistedName=""FullPath"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""FileNameAndExtension""");
        sb.AppendLine(@"      DisplayName=""File Name""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""Name of the file or folder."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""Compile"" PersistedName=""FileNameAndExtension"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""URL"" ReadOnly=""true"" Visible=""false"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""Compile"" PersistedName=""FullPath"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <EnumProperty Name=""SubType"" Visible=""false"">");
        sb.AppendLine(@"    <EnumValue Name=""Designer"" />");
        sb.AppendLine(@"    <EnumValue Name=""Component"" />");
        sb.AppendLine(@"    <EnumValue Name=""Control"" />");
        sb.AppendLine(@"    <EnumValue Name=""Form"" />");
        sb.AppendLine(@"    <EnumValue Name=""Code"" />");
        sb.AppendLine(@"  </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""Extension"" Visible=""False"" ReadOnly=""true"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""Compile"" PersistedName=""Extension"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateCSharpProjectItemsSchemaContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright, Microsoft Corporation, All rights reserved.-->");
        sb.AppendLine(@"<ProjectSchemaDefinitions");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <ContentType");
        sb.AppendLine(@"        Name=""CSharpFile""");
        sb.AppendLine(@"        DisplayName=""C# file""");
        sb.AppendLine(@"        ItemType=""Compile"">");
        sb.AppendLine(@"    </ContentType>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <ItemType Name=""Compile"" DisplayName=""C# compiler""/>");
        sb.AppendLine(@"");
        sb.AppendLine(@"	<FileExtension Name="".cs"" ContentType=""CSharpFile""/>");
        sb.AppendLine(@"</ProjectSchemaDefinitions>");
        sb.AppendLine(@"");
        return sb.ToString();
    }

    private static string GenerateCSharpContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"	Name=""CSharp""");
        sb.AppendLine(@"	DisplayName=""C#""");
        sb.AppendLine(@"	PageTemplate=""tool""");
        sb.AppendLine(@"	Description=""C# source file""");
        sb.AppendLine(@"	xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectFile"" Label=""Configuration"" ItemType=""Compile"" HasConfigurationCondition=""false"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"  <Rule.Categories>");
        sb.AppendLine(@"    <Category Name=""Advanced"" DisplayName=""Advanced"" />");
        sb.AppendLine(@"    <Category Name=""Misc"" DisplayName=""Misc"" />");
        sb.AppendLine(@"  </Rule.Categories>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <DynamicEnumProperty Name=""{}{ItemType}"" DisplayName=""Build Action""  Category=""Advanced""");
        sb.AppendLine(@"                   Description=""How the file relates to the build and deployment processes.""");
        sb.AppendLine(@"                   EnumProvider=""ItemTypes"" />");
        sb.AppendLine(@"  <EnumProperty");
        sb.AppendLine(@"      Name=""CopyToOutputDirectory""");
        sb.AppendLine(@"      DisplayName=""Copy to Output Directory""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      Description=""Specifies the source file will be copied to the output directory."">");
        sb.AppendLine(@"    <EnumValue Name=""Never"" DisplayName=""Do not copy"" />");
        sb.AppendLine(@"    <EnumValue Name=""Always"" DisplayName=""Copy always"" />");
        sb.AppendLine(@"    <EnumValue Name=""PreserveNewest"" DisplayName=""Copy if newer"" />");
        sb.AppendLine(@"  </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""Generator""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      DisplayName=""Custom Tool""");
        sb.AppendLine(@"      Description=""Specifies the tool that transforms a file at design time and places the output of that transformation into another file. For example, a dataset (.xsd) file comes with a default custom tool."" />");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""CustomToolNamespace""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      DisplayName=""Custom Tool Namespace""");
        sb.AppendLine(@"      Description=""The namespace into which the output of the custom tool is placed."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <BoolProperty Name=""ExcludedFromBuild"" DisplayName=""Excluded From Build"">");
        sb.AppendLine(@"    <BoolProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFile"" Label=""Configuration"" ItemType=""Compile"" HasConfigurationCondition=""true"" />");
        sb.AppendLine(@"    </BoolProperty.DataSource>");
        sb.AppendLine(@"  </BoolProperty>");
        sb.AppendLine(@"  <BoolProperty Name=""Visible"" Visible=""false"" />");
        sb.AppendLine(@"  <StringProperty Name=""DependentUpon"" Visible=""false"">");
        sb.AppendLine(@"    <StringProperty.Metadata>");
        sb.AppendLine(@"      <NameValuePair Name=""DoNotCopyAcrossProjects"" Value=""true"" />");
        sb.AppendLine(@"    </StringProperty.Metadata>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""Link"" Visible=""false"">");
        sb.AppendLine(@"    <StringProperty.Metadata>");
        sb.AppendLine(@"      <NameValuePair Name=""DoNotCopyAcrossProjects"" Value=""true"" />");
        sb.AppendLine(@"    </StringProperty.Metadata>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""SubType"" Visible=""false"" />");
        sb.AppendLine(@"  <StringProperty Name=""LastGenOutput"" Visible=""false"" Description=""The filename of the last file generated as a result of the SFG."" />");
        sb.AppendLine(@"  <BoolProperty Name=""DesignTime"" Visible=""false"" Description=""A value indicating whether this file has a designer."" />");
        sb.AppendLine(@"  <BoolProperty Name=""AutoGen"" Visible=""false"" Description=""A value indicating whether this is a generated file."" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateDebuggerGeneralContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.-->");
        sb.AppendLine(@"<Rule Name=""DebuggerGeneralProperties""");
        sb.AppendLine(@"      DisplayName=""Debugger General Properties""");
        sb.AppendLine(@"      Description=""General Debugger options""");
        sb.AppendLine(@"      xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""UserFile"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"  ");
        sb.AppendLine(@"  <StringProperty Name=""SymbolsPath"" DisplayName=""Symbol Search Path""");
        sb.AppendLine(@"                  Description=""The search path used by the debugger to locate symbols."">");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""DebuggerFlavor"" Visible=""false""");
        sb.AppendLine(@"                  Description=""The debug rule selected as the active debugger."">");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <EnumProperty Name=""ImageClrType"" Visible=""false""");
        sb.AppendLine(@"                  Description=""The 'hidden' property we pass to debuggers to let them know if this is a managed project."">");
        sb.AppendLine(@"    <EnumProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""UserFile"" HasConfigurationCondition=""false"" PersistedName=""_TargetImageClrType"" />");
        sb.AppendLine(@"    </EnumProperty.DataSource>");
        sb.AppendLine(@"    <EnumValue Name=""Native"" DisplayName=""Native Image"" Description=""The executable image to debug is a fully native application."" />");
        sb.AppendLine(@"    <EnumValue Name=""Mixed"" DisplayName=""Mixed Image"" Description=""The executable image to debug is a mixture of native and managed code."" />");
        sb.AppendLine(@"    <EnumValue Name=""Managed"" DisplayName=""Managed Image"" Description=""The executable image to debug is a fully managed application."" />");
        sb.AppendLine(@"  </EnumProperty>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateDotNetCliToolReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""DotNetCliToolReference""");
        sb.AppendLine(@"    DisplayName=""Package""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""Package""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" ItemType=""DotNetCliToolReference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    <StringProperty Name=""Description"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""Description"" ");
        sb.AppendLine(@"                    Description=""Dependency description."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Version""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Version""");
        sb.AppendLine(@"                    Description=""Version of dependency."">");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""IncludeAssets"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""IncludeAssets""");
        sb.AppendLine(@"                    Description=""Assets to include from this reference"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""ExcludeAssets"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""ExcludeAssets""");
        sb.AppendLine(@"                    Description=""Assets to exclude from this reference"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""PrivateAssets"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""PrivateAssets""");
        sb.AppendLine(@"                    Description=""Assets that are private in this reference"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Name"" ");
        sb.AppendLine(@"                    Visible=""True"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""OriginalItemSpec"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" ");
        sb.AppendLine(@"                    Description=""The evaluated item name of the original reference item whose resolution resulted in this resolved reference item."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Path"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Type"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RuntimeIdentifier"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""TargetFramework"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""FrameworkName"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""FrameworkVersion"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateEmbeddedResourceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"	Name=""EmbeddedResource""");
        sb.AppendLine(@"	DisplayName=""Embedded Resource""");
        sb.AppendLine(@"	PageTemplate=""generic""");
        sb.AppendLine(@"	Description=""Embedded resources""");
        sb.AppendLine(@"	xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectFile"" HasConfigurationCondition=""False"" ItemType=""EmbeddedResource"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"  <Rule.Categories>");
        sb.AppendLine(@"    <Category Name=""Advanced"" DisplayName=""Advanced"" />");
        sb.AppendLine(@"    <Category Name=""Misc"" DisplayName=""Misc"" />");
        sb.AppendLine(@"  </Rule.Categories>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <DynamicEnumProperty Name=""{}{ItemType}"" DisplayName=""Build Action""  Category=""Advanced""");
        sb.AppendLine(@"                     Description=""How the file relates to the build and deployment processes.""");
        sb.AppendLine(@"                     EnumProvider=""ItemTypes"" />");
        sb.AppendLine(@"  <EnumProperty");
        sb.AppendLine(@"      Name=""CopyToOutputDirectory""");
        sb.AppendLine(@"      DisplayName=""Copy to Output Directory""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      Description=""Specifies the source file will be copied to the output directory."">");
        sb.AppendLine(@"    <EnumValue Name=""Never"" DisplayName=""Do not copy"" />");
        sb.AppendLine(@"    <EnumValue Name=""Always"" DisplayName=""Copy always"" />");
        sb.AppendLine(@"    <EnumValue Name=""PreserveNewest"" DisplayName=""Copy if newer"" />");
        sb.AppendLine(@"  </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""Generator""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      DisplayName=""Custom Tool""");
        sb.AppendLine(@"      Description=""Specifies the tool that transforms a file at design time and places the output of that transformation into another file. For example, a dataset (.xsd) file comes with a default custom tool."" />");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""CustomToolNamespace""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      DisplayName=""Custom Tool Namespace""");
        sb.AppendLine(@"      Description=""The namespace into which the output of the custom tool is placed."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""Identity""");
        sb.AppendLine(@"      Visible=""false""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""The item specified in the Include attribute."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""EmbeddedResource"" PersistedName=""Identity"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""FullPath""");
        sb.AppendLine(@"      DisplayName=""Full Path""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""Location of the file."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""EmbeddedResource"" PersistedName=""FullPath"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""FileNameAndExtension""");
        sb.AppendLine(@"      DisplayName=""File Name""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""Name of the file or folder."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""EmbeddedResource"" PersistedName=""FileNameAndExtension"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""URL"" ReadOnly=""true"" Visible=""false"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""EmbeddedResource"" PersistedName=""FullPath"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <BoolProperty Name=""Visible"" Visible=""false"" />");
        sb.AppendLine(@"  <StringProperty Name=""DependentUpon"" Visible=""false"" />");
        sb.AppendLine(@"  <StringProperty Name=""Link"" Visible=""false"" />");
        sb.AppendLine(@"  <StringProperty Name=""Extension"" Visible=""False"" ReadOnly=""true"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""EmbeddedResource"" PersistedName=""Extension"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""LastGenOutput"" Visible=""false"" Description=""The filename of the last file generated as a result of the SFG."" />");
        sb.AppendLine(@"  <BoolProperty Name=""DesignTime"" Visible=""false"" Description=""A value indicating whether this file has a designer."" />");
        sb.AppendLine(@"  <BoolProperty Name=""AutoGen"" Visible=""false"" Description=""A value indicating whether this is a generated file."" />");
        sb.AppendLine(@"  <StringProperty Name=""CustomTool"" Visible=""false"" Description=""DTE Property for accessing the Generator property."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFile"" ItemType=""EmbeddedResource"" PersistedName=""Generator"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateFolderContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"  Name=""Folder""");
        sb.AppendLine(@"  DisplayName=""General""");
        sb.AppendLine(@"  PageTemplate=""generic""");
        sb.AppendLine(@"  Description=""Empty folder placeholders""");
        sb.AppendLine(@"  xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectInstance"" HasConfigurationCondition=""False"" ItemType=""Folder"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""Identity"" Visible=""false"" ReadOnly=""true"" Category=""Misc"" />");
        sb.AppendLine(@"  <StringProperty Name=""FullPath"" DisplayName=""Full Path"" ReadOnly=""true"" Category=""Misc"" />");
        sb.AppendLine(@"  <StringProperty Name=""FileNameAndExtension"" DisplayName=""Folder Name"" ReadOnly=""true"" Category=""Misc"">");
        sb.AppendLine(@"      <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectInstance"" ItemType=""Folder"" PersistedName=""FileNameAndExtension"" />");
        sb.AppendLine(@"      </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateGeneralBrowseObjectContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright, Microsoft Corporation, All rights reserved.-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"  Name=""ConfigurationGeneralBrowseObject""");
        sb.AppendLine(@"  DisplayName=""General""");
        sb.AppendLine(@"  PageTemplate=""generic""");
        sb.AppendLine(@"  Description=""General""");
        sb.AppendLine(@"  OverrideMode= ""Replace""");
        sb.AppendLine(@"  xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <Rule.Categories>");
        sb.AppendLine(@"    <Category Name=""General"" DisplayName=""General"" Description=""General"" />");
        sb.AppendLine(@"  </Rule.Categories>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectFile"" Label=""Configuration"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""ApplicationIcon"" DisplayName=""Application Icon"" />");
        sb.AppendLine(@"  <StringProperty Name=""TargetFrameworkMoniker"" DisplayName=""Target Framework Moniker"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFileWithInterception"" PersistedName=""TargetFrameworkMoniker"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""AssemblyName"" DisplayName=""Assembly Name"" />");
        sb.AppendLine(@"  <StringProperty Name=""Name"" Visible=""False"" />");
        sb.AppendLine(@"  <StringProperty Name=""RootNamespace"" DisplayName=""Root namespace"" />");
        sb.AppendLine(@"  <StringProperty Name=""DefaultNamespace"" DisplayName=""Default namespace"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource PersistedName=""RootNamespace"" Persistence=""ProjectFile"" Label=""Configuration"" HasConfigurationCondition=""false"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <IntProperty Name=""TargetFramework"" Visible=""False"" ReadOnly=""True"">");
        sb.AppendLine(@"    <IntProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFileWithInterception"" PersistedName=""TargetFramework"" />");
        sb.AppendLine(@"    </IntProperty.DataSource>");
        sb.AppendLine(@"  </IntProperty>");
        sb.AppendLine(@"  <StringProperty Name=""OutputName"" Visible=""False"" />");
        sb.AppendLine(@"  <DynamicEnumProperty Name=""OutputType"" DisplayName=""Output Type"" EnumProvider=""OutputTypeEnumProvider"" />");
        sb.AppendLine(@"  <EnumProperty Name=""OutputTypeEx"" DisplayName=""Output Type"">");
        sb.AppendLine(@"    <EnumValue Name=""winexe"" DisplayName=""0"" />");
        sb.AppendLine(@"    <EnumValue Name=""exe"" DisplayName=""1"" />");
        sb.AppendLine(@"    <EnumValue Name=""library"" DisplayName=""2"" />");
        sb.AppendLine(@"    <EnumValue Name=""appcontainerexe"" DisplayName=""3"" />");
        sb.AppendLine(@"    <EnumValue Name=""winmdobj"" DisplayName=""4"" />");
        sb.AppendLine(@"    <EnumProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFile"" PersistedName=""OutputType"" />");
        sb.AppendLine(@"    </EnumProperty.DataSource>");
        sb.AppendLine(@"  </EnumProperty>");
        sb.AppendLine(@"  <StringProperty Name=""StartupObject"" DisplayName=""Type that contains the entry point"" />");
        sb.AppendLine(@"  <StringProperty Name=""ApplicationManifest"" DisplayName=""Application Manifest"" >");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFileWithInterception"" PersistedName=""ApplicationManifest"" HasConfigurationCondition=""false"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""Win32ResourceFile"" DisplayName=""Win32 Resource File"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFile"" PersistedName=""Win32Resource"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""DefineConstants"" DisplayName=""Define Constants""/>");
        sb.AppendLine(@"    <EnumProperty Name=""PlatformTarget"" DisplayName=""Platform Target""/>");
        sb.AppendLine(@"    <StringProperty Name=""Prefer32Bit"" DisplayName=""Prefer 32Bit""/>");
        sb.AppendLine(@"    <StringProperty Name=""AllowUnsafeBlocks""  Default=""False""  DisplayName=""Allow unsafe code""/>");
        sb.AppendLine(@"    <StringProperty Name=""Optimize"" DisplayName=""Optimize""/>");
        sb.AppendLine(@"    <EnumProperty Name=""WarningLevel"" DisplayName=""Warning Level""/>");
        sb.AppendLine(@"    <StringProperty Name=""NoWarn"" DisplayName=""Supress Warning""/>");
        sb.AppendLine(@"    <BoolProperty Name=""TreatWarningsAsErrors"" Visible=""True""  Default=""False"" Description=""Treat warnings as errors"" />");
        sb.AppendLine(@"    <StringProperty Name=""OutputPath"" DisplayName=""Output Path""/>");
        sb.AppendLine(@"    <StringProperty Name=""DocumentationFile"" DisplayName=""Documentation file""/>");
        sb.AppendLine(@"    <EnumProperty Name=""GenerateSerializationAssemblies"" DisplayName=""Generate serialization assemblies"">");
        sb.AppendLine(@"        <EnumValue Name=""Auto"" DisplayName=""Auto"" IsDefault=""True"" />");
        sb.AppendLine(@"        <EnumValue Name=""On"" DisplayName=""On"" />");
        sb.AppendLine(@"        <EnumValue Name=""Off"" DisplayName=""Off"" />");
        sb.AppendLine(@"    </EnumProperty>");
        sb.AppendLine(@"    <EnumProperty Name=""LanguageVersion"" DisplayName=""Language version""/>");
        sb.AppendLine(@"    <EnumProperty Name=""ErrorReport"" DisplayName=""Error report""/>");
        sb.AppendLine(@"    <EnumProperty Name=""DebugInfo"" DisplayName=""Debug Info"">");
        sb.AppendLine(@"        <EnumProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" PersistedName=""DebugType"" />");
        sb.AppendLine(@"        </EnumProperty.DataSource>");
        sb.AppendLine(@"    </EnumProperty>");
        sb.AppendLine(@"    <StringProperty Name=""DebugSymbols"" DisplayName=""Debug symbols""/>");
        sb.AppendLine(@"    <EnumProperty Name=""FileAlignment"" DisplayName=""File Alignment""/>");
        sb.AppendLine(@"    <StringProperty Name=""BaseAddress"" DisplayName=""Base address"" />");
        sb.AppendLine(@"    <StringProperty Name=""PreBuildEvent"" DisplayName=""Pre Build Event""/>");
        sb.AppendLine(@"    <StringProperty Name=""PostBuildEvent"" DisplayName=""Post Build Event""/>");
        sb.AppendLine(@"    <EnumProperty Name=""RunPostBuildEvent"" DisplayName=""Run Post Build Event"">");
        sb.AppendLine(@"        <EnumValue Name=""Always"" DisplayName=""Always"" />");
        sb.AppendLine(@"        <EnumValue Name=""OnBuildSuccess"" DisplayName=""On successful build""  IsDefault=""True"" />");
        sb.AppendLine(@"        <EnumValue Name=""OnOutputUpdated"" DisplayName=""When the build updates the project output"" />");
        sb.AppendLine(@"    </EnumProperty>");
        sb.AppendLine(@"    <StringProperty Name=""ReferencePath"" DisplayName=""Reference Path""/>");
        sb.AppendLine(@"    <StringProperty Name=""FileName"" DisplayName=""Project File"" ReadOnly=""True"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFile"" PersistedName=""MSBuildProjectFile"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""FullPath"" DisplayName=""Project Folder"" ReadOnly=""True"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFile"" PersistedName=""MSBuildProjectDirectory"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""LocalPath"" ReadOnly=""True"" Visible=""False"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFile"" PersistedName=""MSBuildProjectDirectory"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <!--AssemblyInfo properties-->");
        sb.AppendLine(@"  <StringProperty Name=""Title"" DisplayName=""Assembly Title"">");
        sb.AppendLine(@"      <StringProperty.DataSource>");
        sb.AppendLine(@"          <DataSource Persistence=""SourceFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"      </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""Description"" DisplayName=""Assembly Description"">");
        sb.AppendLine(@"      <StringProperty.DataSource>");
        sb.AppendLine(@"          <DataSource Persistence=""SourceFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"      </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""Company"" DisplayName=""Company"">");
        sb.AppendLine(@"      <StringProperty.DataSource>");
        sb.AppendLine(@"          <DataSource Persistence=""SourceFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"      </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""Product"" DisplayName=""Product"">");
        sb.AppendLine(@"      <StringProperty.DataSource>");
        sb.AppendLine(@"          <DataSource Persistence=""SourceFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"      </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""Copyright"" DisplayName=""Copyright"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""SourceFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""Trademark"" DisplayName=""Trademark"">");
        sb.AppendLine(@"      <StringProperty.DataSource>");
        sb.AppendLine(@"          <DataSource Persistence=""SourceFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"      </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""AssemblyVersion"" DisplayName=""Assembly Version"">");
        sb.AppendLine(@"      <StringProperty.DataSource>");
        sb.AppendLine(@"          <DataSource Persistence=""SourceFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"      </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""AssemblyFileVersion"" DisplayName=""Assembly FileVersion"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""SourceFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""AssemblyGuid"" DisplayName=""Assembly Guid"">");
        sb.AppendLine(@"      <StringProperty.DataSource>");
        sb.AppendLine(@"          <DataSource Persistence=""SourceFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"      </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""NeutralResourcesLanguage"" DisplayName=""Neutral Resources Language"">");
        sb.AppendLine(@"      <StringProperty.DataSource>");
        sb.AppendLine(@"          <DataSource Persistence=""SourceFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"      </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""ComVisible"" DisplayName=""ComVisible"">");
        sb.AppendLine(@"      <StringProperty.DataSource>");
        sb.AppendLine(@"          <DataSource Persistence=""SourceFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"      </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""SignAssembly"" DisplayName=""Sign the assembly"" />");
        sb.AppendLine(@"  <StringProperty Name=""DelaySign"" DisplayName=""Delay sign only"" />");
        sb.AppendLine(@"  <StringProperty Name=""AssemblyOriginatorKeyFile"" DisplayName=""Strong name key file"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFileWithInterception"" PersistedName=""AssemblyOriginatorKeyFile"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateNoneContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright, Microsoft Corporation, All rights reserved.-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"  Name=""None""");
        sb.AppendLine(@"  DisplayName=""General""");
        sb.AppendLine(@"  PageTemplate=""generic""");
        sb.AppendLine(@"  Description=""Non-build items""");
        sb.AppendLine(@"  xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectFile"" HasConfigurationCondition=""False"" ItemType=""None"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"  <Rule.Categories>");
        sb.AppendLine(@"    <Category Name=""Advanced"" DisplayName=""Advanced"" />");
        sb.AppendLine(@"    <Category Name=""Misc"" DisplayName=""Misc"" />");
        sb.AppendLine(@"  </Rule.Categories>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <DynamicEnumProperty Name=""{}{ItemType}"" DisplayName=""Build Action""  Category=""Advanced""");
        sb.AppendLine(@"                     Description=""How the file relates to the build and deployment processes.""");
        sb.AppendLine(@"                     EnumProvider=""ItemTypes"" />");
        sb.AppendLine(@"  <EnumProperty");
        sb.AppendLine(@"      Name=""CopyToOutputDirectory""");
        sb.AppendLine(@"      DisplayName=""Copy to Output Directory""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      Description=""Specifies the source file will be copied to the output directory."">");
        sb.AppendLine(@"    <EnumValue Name=""Never"" DisplayName=""Do not copy"" />");
        sb.AppendLine(@"    <EnumValue Name=""Always"" DisplayName=""Copy always"" />");
        sb.AppendLine(@"    <EnumValue Name=""PreserveNewest"" DisplayName=""Copy if newer"" />");
        sb.AppendLine(@"  </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""Generator""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      DisplayName=""Custom Tool""");
        sb.AppendLine(@"      Description=""Specifies the tool that transforms a file at design time and places the output of that transformation into another file. For example, a dataset (.xsd) file comes with a default custom tool."" />");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""CustomToolNamespace""");
        sb.AppendLine(@"      Category=""Advanced""");
        sb.AppendLine(@"      DisplayName=""Custom Tool Namespace""");
        sb.AppendLine(@"      Description=""The namespace into which the output of the custom tool is placed."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""Identity""");
        sb.AppendLine(@"      Visible=""false""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""The item specified in the Include attribute."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""None"" PersistedName=""Identity"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""FullPath""");
        sb.AppendLine(@"      DisplayName=""Full Path""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""Location of the file."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""None"" PersistedName=""FullPath"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty");
        sb.AppendLine(@"      Name=""FileNameAndExtension""");
        sb.AppendLine(@"      DisplayName=""File Name""");
        sb.AppendLine(@"      ReadOnly=""true""");
        sb.AppendLine(@"      Category=""Misc""");
        sb.AppendLine(@"      Description=""Name of the file or folder."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""None"" PersistedName=""FileNameAndExtension"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""URL"" ReadOnly=""true"" Visible=""false"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""None"" PersistedName=""FullPath"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <BoolProperty Name=""Visible"" Visible=""false"" />");
        sb.AppendLine(@"  <StringProperty Name=""DependentUpon"" Visible=""false"" />");
        sb.AppendLine(@"  <StringProperty Name=""Link"" Visible=""false"" />");
        sb.AppendLine(@"  <StringProperty Name=""Extension"" Visible=""False"" ReadOnly=""true"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""Intrinsic"" ItemType=""None"" PersistedName=""Extension"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"  <StringProperty Name=""LastGenOutput"" Visible=""false"" Description=""The filename of the last file generated as a result of the SFG."" />");
        sb.AppendLine(@"  <BoolProperty Name=""DesignTime"" Visible=""false"" Description=""A value indicating whether this file has a designer."" />");
        sb.AppendLine(@"  <BoolProperty Name=""AutoGen"" Visible=""false"" Description=""A value indicating whether this is a generated file."" />");
        sb.AppendLine(@"  <StringProperty Name=""CustomTool"" Visible=""false"" Description=""DTE Property for accessing the Generator property."">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""ProjectFile"" ItemType=""None"" PersistedName=""Generator"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateNuGetRestoreContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""NuGetRestore""");
        sb.AppendLine(@"    DisplayName=""NuGetRestore""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""General Configuration Properties used in NuGet Restore""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" Label=""Configuration"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""TargetFrameworkIdentifier"" DisplayName=""Target Framework Identifier"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" PersistedName=""TargetFrameworkIdentifier"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""TargetFrameworks"" DisplayName=""Target Frameworks"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" PersistedName=""TargetFrameworks"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""TargetFramework"" DisplayName=""Target Framework"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" PersistedName=""TargetFramework"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""TargetFrameworkProfile"" DisplayName=""Target Framework Profile"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" PersistedName=""TargetFrameworkProfile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""TargetFrameworkVersion"" DisplayName=""Target Framework Version"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" PersistedName=""TargetFrameworkVersion"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>    ");
        sb.AppendLine(@"    <StringProperty Name=""TargetFrameworkMoniker"" DisplayName=""Target Framework Moniker"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFileWithInterception"" PersistedName=""TargetFrameworkMoniker"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""BaseIntermediateOutputPath"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""MSBuildProjectDirectory"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""PackageTargetFallback"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RuntimeIdentifier"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RuntimeIdentifiers"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GeneratePackageReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""PackageReference""");
        sb.AppendLine(@"    DisplayName=""Package""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""Package""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" ItemType=""PackageReference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    <StringProperty Name=""Description"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""Description"" ");
        sb.AppendLine(@"                    Description=""Dependency description."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Version""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Version""");
        sb.AppendLine(@"                    Description=""Version of dependency."">");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""IncludeAssets"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""IncludeAssets""");
        sb.AppendLine(@"                    Description=""Assets to include from this reference"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""ExcludeAssets"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""ExcludeAssets""");
        sb.AppendLine(@"                    Description=""Assets to exclude from this reference"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""PrivateAssets"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""PrivateAssets""");
        sb.AppendLine(@"                    Description=""Assets that are private in this reference"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Name"" ");
        sb.AppendLine(@"                    Visible=""True"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""OriginalItemSpec"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" ");
        sb.AppendLine(@"                    Description=""The evaluated item name of the original reference item whose resolution resulted in this resolved reference item."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Path"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Type"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RuntimeIdentifier"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""TargetFramework"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""FrameworkName"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""FrameworkVersion"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateProjectDebuggerContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"");
        sb.AppendLine(@"<Rule Name=""ProjectDebugger""");
        sb.AppendLine(@"      DisplayName=""Start""");
        sb.AppendLine(@"      PageTemplate=""Debugger""");
        sb.AppendLine(@"      Description=""Web debugging options""");
        sb.AppendLine(@"      xmlns:sys=""clr-namespace:System;assembly=mscorlib""");
        sb.AppendLine(@"      xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""");
        sb.AppendLine(@"      xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"  ");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectFile""  HasConfigurationCondition=""False""/>");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <!-- the command which appears in the debugger dropdown -->");
        sb.AppendLine(@"  <Rule.Metadata>");
        sb.AppendLine(@"    <sys:Guid x:Key=""DebugTargetTypeCommandGuid"">568ABDF7-D522-474D-9EED-34B5E5095BA5</sys:Guid>");
        sb.AppendLine(@"    <sys:UInt32 x:Key=""DebugTargetTypeCommandId"">0x100</sys:UInt32>");
        sb.AppendLine(@"    <sys:String x:Key=""DebugTargetDropdownEnum"">ActiveDebugProfile</sys:String>  ");
        sb.AppendLine(@"  </Rule.Metadata>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <DynamicEnumProperty Name=""ActiveDebugProfile"" DisplayName=""Debug Target"" EnumProvider=""DebugProfileProvider""");
        sb.AppendLine(@"                       Description=""Specifies the profile to use for debugging"">");
        sb.AppendLine(@"    <DynamicEnumProperty.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""UserFile"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </DynamicEnumProperty.DataSource>");
        sb.AppendLine(@"  </DynamicEnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""ActiveDebugFramework"" ReadOnly=""False"" Visible=""False"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""UserFile"" HasConfigurationCondition=""false"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""ActiveDebugRuntime"" ReadOnly=""False"" Visible=""False"">");
        sb.AppendLine(@"    <StringProperty.DataSource>");
        sb.AppendLine(@"      <DataSource Persistence=""UserFile"" HasConfigurationCondition=""false"" />");
        sb.AppendLine(@"    </StringProperty.DataSource>");
        sb.AppendLine(@"  </StringProperty>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateProjectItemsSchemaContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright, Microsoft Corporation, All rights reserved.-->");
        sb.AppendLine(@"<ProjectSchemaDefinitions");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <ContentType");
        sb.AppendLine(@"        Name=""Text""");
        sb.AppendLine(@"        DisplayName=""Text file""");
        sb.AppendLine(@"        ItemType=""Content"">");
        sb.AppendLine(@"    </ContentType>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <ContentType");
        sb.AppendLine(@"        Name=""XML""");
        sb.AppendLine(@"        DisplayName=""Xml file""");
        sb.AppendLine(@"        ItemType=""Content"">");
        sb.AppendLine(@"    </ContentType>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <ContentType");
        sb.AppendLine(@"        Name=""HTML""");
        sb.AppendLine(@"        DisplayName=""Html file""");
        sb.AppendLine(@"        ItemType=""Content"">");
        sb.AppendLine(@"    </ContentType>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <ContentType");
        sb.AppendLine(@"        Name=""CSS""");
        sb.AppendLine(@"        DisplayName=""Cascading style sheet""");
        sb.AppendLine(@"        ItemType=""Content"">");
        sb.AppendLine(@"    </ContentType>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <ContentType");
        sb.AppendLine(@"        Name=""Json""");
        sb.AppendLine(@"        DisplayName=""Json file""");
        sb.AppendLine(@"        ItemType=""Content"">");
        sb.AppendLine(@"    </ContentType>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <ContentType");
        sb.AppendLine(@"      Name=""Font""");
        sb.AppendLine(@"      DisplayName=""Font file""");
        sb.AppendLine(@"      ItemType=""Content"">");
        sb.AppendLine(@"    </ContentType>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <ContentType");
        sb.AppendLine(@"      Name=""Media""");
        sb.AppendLine(@"      DisplayName=""Media file""");
        sb.AppendLine(@"      ItemType=""Content"">");
        sb.AppendLine(@"    </ContentType>");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    <ContentType");
        sb.AppendLine(@"      Name=""Image""");
        sb.AppendLine(@"      DisplayName=""Image file""");
        sb.AppendLine(@"      ItemType=""Content"">");
        sb.AppendLine(@"    </ContentType>");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    <ContentType");
        sb.AppendLine(@"      Name=""EmbeddedResource""");
        sb.AppendLine(@"      DisplayName=""Embedded resource""");
        sb.AppendLine(@"      ItemType=""EmbeddedResource"">");
        sb.AppendLine(@"      <NameValuePair Name=""DefaultMetadata_Generator"" Value=""ResXFileCodeGenerator"" />");
        sb.AppendLine(@"    </ContentType>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <ItemType Name=""None"" DisplayName=""None""/>");
        sb.AppendLine(@"    <ItemType Name=""Content"" DisplayName=""Content"" />");
        sb.AppendLine(@"    <ItemType Name=""EmbeddedResource"" DisplayName=""Embedded resource ""/>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <FileExtension Name="".asax"" ContentType=""Asax"" />");
        sb.AppendLine(@"    <FileExtension Name="".asmx"" ContentType=""HTML"" />");
        sb.AppendLine(@"    <FileExtension Name="".asp"" ContentType=""AspPage"" />");
        sb.AppendLine(@"    <FileExtension Name="".txt"" ContentType=""Text"" />");
        sb.AppendLine(@"    <FileExtension Name="".resx"" ContentType=""EmbeddedResource"" />");
        sb.AppendLine(@"    <FileExtension Name="".html"" ContentType=""HTML"" />");
        sb.AppendLine(@"    <FileExtension Name="".htm"" ContentType=""HTML"" />");
        sb.AppendLine(@"    <FileExtension Name="".css"" ContentType=""CSS"" />");
        sb.AppendLine(@"    <FileExtension Name="".cur"" ContentType=""CUR"" />");
        sb.AppendLine(@"    <FileExtension Name="".vbS"" ContentType=""Script"" />");
        sb.AppendLine(@"    <FileExtension Name="".jS"" ContentType=""Script"" />");
        sb.AppendLine(@"    <FileExtension Name="".xml"" ContentType=""XML"" />");
        sb.AppendLine(@"    <FileExtension Name="".mht"" ContentType=""MHT"" />");
        sb.AppendLine(@"    <FileExtension Name="".manifest"" ContentType=""Manifest"" />");
        sb.AppendLine(@"    <FileExtension Name="".rdlc"" ContentType=""RDLC"" />");
        sb.AppendLine(@"    <FileExtension Name="".cd"" ContentType=""ClassDiagram"" />");
        sb.AppendLine(@"    <FileExtension Name="".licenses"" ContentType=""Licenses"" />");
        sb.AppendLine(@"    <FileExtension Name="".json"" ContentType=""Json"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <!-- Image formats -->");
        sb.AppendLine(@"    <FileExtension Name="".jpeg"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".jpe"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".jpg"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".jfif"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".exif"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".gif"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".tiff"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".tif"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".png"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".bmp"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".dib"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".rle"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".ico"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".wdp"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".dds"" ContentType=""Image"" />");
        sb.AppendLine(@"    <FileExtension Name="".tga"" ContentType=""Image"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <!-- Audio formats-->");
        sb.AppendLine(@"    <FileExtension Name="".wav"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".wma"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".au"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".aif"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".aiff"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".aifc"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".mid"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".midi"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".mp3"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".snd"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".rmi"" ContentType=""Media"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <!-- Video formats-->");
        sb.AppendLine(@"    <FileExtension Name="".avi"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".wmv"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".mov"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".qt"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".mpe"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".mpeg"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".mpg"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".mp2"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".mp4"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".asx"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".asf"" ContentType=""Media"" />");
        sb.AppendLine(@"    <FileExtension Name="".webm"" ContentType=""Media"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <!-- Font formats -->");
        sb.AppendLine(@"    <FileExtension Name="".ttf"" ContentType=""Font"" />");
        sb.AppendLine(@"    <FileExtension Name="".odttf"" ContentType=""Font"" />");
        sb.AppendLine(@"    <FileExtension Name="".otf"" ContentType=""Font"" />");
        sb.AppendLine(@"    <FileExtension Name="".compositefont"" ContentType=""Font"" />");
        sb.AppendLine(@"    <FileExtension Name="".ttc"" ContentType=""Font"" />");
        sb.AppendLine(@"    <FileExtension Name="".tte"" ContentType=""Font"" />");
        sb.AppendLine(@"    <FileExtension Name="".woff"" ContentType=""Font"" />");
        sb.AppendLine(@"    <FileExtension Name="".eot"" ContentType=""Font"" />");
        sb.AppendLine(@"</ProjectSchemaDefinitions>");
        sb.AppendLine(@"");
        return sb.ToString();
    }

    private static string GenerateProjectReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"	Name=""ProjectReference""");
        sb.AppendLine(@"	DisplayName=""Project Reference""");
        sb.AppendLine(@"	PageTemplate=""generic""");
        sb.AppendLine(@"	Description=""Project reference properties""");
        sb.AppendLine(@"	xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" ItemType=""ProjectReference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""ReferenceOutputAssembly""");
        sb.AppendLine(@"                  DisplayName=""Reference Output Assembly""");
        sb.AppendLine(@"				  Description=""A value indicating whether the compiler should include a reference to the target project's primary output assembly."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""CopyLocalSatelliteAssemblies""");
        sb.AppendLine(@"                  DisplayName=""Copy Local Satellite Assemblies""");
        sb.AppendLine(@"				  Description=""Indicates whether the satellite assemblies of the reference target should be copied into this project's output directory."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""LinkLibraryDependencies"" Visible=""False"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""UseLibraryDependencyInputs"" Visible=""False"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Project"" ");
        sb.AppendLine(@"                    Visible=""False""");
        sb.AppendLine(@"                    Description=""the Guid the solution tracks an individual project reference target with"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""ReferencedProjectIdentifier"" Visible=""False"" Description=""The old (VS2010 beta) way to store the Guid the solution tracks an individual project reference target with"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""CopyLocal""");
        sb.AppendLine(@"                  DisplayName=""Copy Local""");
        sb.AppendLine(@"                  Description=""Indicates whether the reference will be copied to the output directory."">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile""");
        sb.AppendLine(@"                        ItemType=""ProjectReference""");
        sb.AppendLine(@"                        HasConfigurationCondition=""False""");
        sb.AppendLine(@"                        PersistedName=""Private"" />");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""IncludeAssets"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""IncludeAssets""");
        sb.AppendLine(@"                    Description=""Assets to include from this reference"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""ExcludeAssets"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""ExcludeAssets""");
        sb.AppendLine(@"                    Description=""Assets to exclude from this reference"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""PrivateAssets"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""PrivateAssets""");
        sb.AppendLine(@"                    Description=""Assets that are private in this reference"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GeneratePSDbgContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright, Microsoft Corporation, All rights reserved.-->");
        sb.AppendLine(@"        ");
        sb.AppendLine(@"<!--TODO: Update the following files with the specified content");
        sb.AppendLine(@"");
        sb.AppendLine(@"    *BuildSystem\DeployedBuildSystem\CustomProject.Default.props* - update the value of the existing DebuggerFlavor element to use the new debugger");
        sb.AppendLine(@"    <PropertyGroup>");
        sb.AppendLine(@"      <DebuggerFlavor>PSDbg</DebuggerFlavor>");
        sb.AppendLine(@"    </PropertyGroup>");
        sb.AppendLine(@"-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"	Name=""PSDbg""");
        sb.AppendLine(@"	DisplayName=""PowerShell Debugger""");
        sb.AppendLine(@"	PageTemplate=""debugger""");
        sb.AppendLine(@"	Description=""PowerShell Debugger options""");
        sb.AppendLine(@"	xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""UserFileWithXamlDefaults"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""PSDbgCommand"" DisplayName=""Command""");
        sb.AppendLine(@"                Default=""$(SystemRoot)\System32\WindowsPowerShell\v1.0\powershell.exe""");
        sb.AppendLine(@"                Description=""The debug command to execute."">");
        sb.AppendLine(@"        <StringProperty.ValueEditors>");
        sb.AppendLine(@"            <ValueEditor EditorType=""DefaultFindFullPathPropertyEditor"" DisplayName=""&lt;regsvr32.exe&gt;"">");
        sb.AppendLine(@"                <ValueEditor.Metadata>");
        sb.AppendLine(@"                    <NameValuePair Name=""Exename"" Value=""regsvr32.exe"" />");
        sb.AppendLine(@"                </ValueEditor.Metadata>");
        sb.AppendLine(@"            </ValueEditor>");
        sb.AppendLine(@"            <ValueEditor EditorType=""DefaultStringPropertyEditor"" DisplayName=""&lt;Edit...&gt;""/>");
        sb.AppendLine(@"            <ValueEditor EditorType=""DefaultFilePropertyEditor"" DisplayName=""&lt;Browse...&gt;"">");
        sb.AppendLine(@"                <ValueEditor.Metadata>");
        sb.AppendLine(@"                    <NameValuePair Name=""Filters"" Value=""Executables (*.exe)|*.exe"" />");
        sb.AppendLine(@"                </ValueEditor.Metadata>");
        sb.AppendLine(@"            </ValueEditor>");
        sb.AppendLine(@"        </StringProperty.ValueEditors>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""PSDbgCommandArguments"" DisplayName=""Command Arguments""");
        sb.AppendLine(@"                Description=""The command line arguments to pass to the application.""");
        sb.AppendLine(@"                Default=""-NoExit -Command &quot;Import-Module .\$(AssemblyTitle) -Force -Verbose&quot;"">");
        sb.AppendLine(@"        <Argument Property=""PSDbgCommand"" />");
        sb.AppendLine(@"        ");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <StringProperty Name=""PSDbgWorkingDirectory"" DisplayName=""Working Directory""");
        sb.AppendLine(@"                Default=""$(OutputPath)""");
        sb.AppendLine(@"                Description=""The application's working directory. By default, the directory containing the project file.""");
        sb.AppendLine(@"                Subtype=""folder""/>");
        sb.AppendLine(@"    <BoolProperty Name=""PSDbgDebuggerAttach"" DisplayName=""Attach""");
        sb.AppendLine(@"                Default=""False""");
        sb.AppendLine(@"                Description=""Specifies whether the debugger should attempt to attach to an existing process when debugging starts."" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateResolvedAnalyzerReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""ResolvedAnalyzerReference""");
        sb.AppendLine(@"    DisplayName=""Resolved Analyzer Reference""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""Resolved Analyzer reference properties""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" ItemType=""Analyzer"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""OriginalItemSpec"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" ");
        sb.AppendLine(@"                    Description=""The evaluated item name of the original reference item whose resolution resulted in this resolved reference item."">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""Intrinsic"" ItemType=""Analyzer"" PersistedName=""FullPath"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateResolvedAssemblyReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""ResolvedAssemblyReference""");
        sb.AppendLine(@"    DisplayName=""Resolved Assembly Reference""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""Resolved reference""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ResolvedReference"" ItemType=""Reference"" HasConfigurationCondition=""False"" ");
        sb.AppendLine(@"                    SourceType=""TargetResults"" MSBuildTarget=""ResolveAssemblyReferencesDesignTime"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringListProperty Name=""Aliases""");
        sb.AppendLine(@"                        DisplayName=""Aliases""");
        sb.AppendLine(@"                        Description=""A comma-delimited list of aliases to this reference.""");
        sb.AppendLine(@"                        Separator="","">");
        sb.AppendLine(@"        <StringListProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" ItemType=""Reference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringListProperty.DataSource>");
        sb.AppendLine(@"    </StringListProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""CopyLocal""");
        sb.AppendLine(@"                  DisplayName=""Copy Local""");
        sb.AppendLine(@"                  Description=""Indicates whether the reference will be copied to the output directory."">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" ItemType=""Reference"" HasConfigurationCondition=""False"" PersistedName=""Private"" />");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Culture"" ");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    Visible=""False""");
        sb.AppendLine(@"                    DisplayName=""Culture"" ");
        sb.AppendLine(@"                    Description=""The value of the culture field from the assembly metadata."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Description"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" ");
        sb.AppendLine(@"                    Visible=""False""");
        sb.AppendLine(@"                    DisplayName=""Description"" ");
        sb.AppendLine(@"                    Description=""The value of the Title field from the assembly metadata."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""EmbedInteropTypes""");
        sb.AppendLine(@"                  DisplayName=""Embed Interop Types""");
        sb.AppendLine(@"                  Description=""Indicates whether types defined in this assembly will be embedded into the target assembly."">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" ItemType=""Reference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <EnumProperty Name=""FileType""");
        sb.AppendLine(@"                  ReadOnly=""True""");
        sb.AppendLine(@"                  Visible=""False""");
        sb.AppendLine(@"                  DisplayName=""File Type""");
        sb.AppendLine(@"                  Description=""The file type of the reference."">");
        sb.AppendLine(@"        <EnumValue Name=""Assembly"" DisplayName="".NET assembly"" />");
        sb.AppendLine(@"        <EnumValue Name=""ActiveX"" DisplayName=""COM type library"" />");
        sb.AppendLine(@"        <EnumValue Name=""Native Assembly"" DisplayName=""Native Assembly"" />");
        sb.AppendLine(@"    </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Identity""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Identity""");
        sb.AppendLine(@"                    Description=""Security identity of the referenced assembly (see System.Reflection.Assembly.Evidence or System.Security.Policy.Evidence)."">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource PersistedName=""{}{Identity}"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""ResolvedPath""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Path""");
        sb.AppendLine(@"                    Description=""Location of the file being referenced."">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource PersistedName=""Identity"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RuntimeVersion""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    Visible=""False""");
        sb.AppendLine(@"                    DisplayName=""Runtime Version""");
        sb.AppendLine(@"                    Description=""Version of the .NET runtime this assembly was compiled against."">");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""SpecificVersion"" ");
        sb.AppendLine(@"                  DisplayName=""Specific Version""");
        sb.AppendLine(@"                  Description=""Indicates whether this assembly can be resolved without regard to multi-targeting rules for assembly resolution."">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""AssemblyReference"" ItemType=""Reference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""StrongName""");
        sb.AppendLine(@"                  ReadOnly=""True""");
        sb.AppendLine(@"                  Visible=""False""");
        sb.AppendLine(@"                  DisplayName=""Strong Name""");
        sb.AppendLine(@"                  Description=""True indicates that the reference has been signed with a key-pair."">");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Version""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Version""");
        sb.AppendLine(@"                    Description=""Version of reference."">");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RequiredTargetFramework"" DisplayName=""Required Target Framework"" Visible=""False"" />");
        sb.AppendLine(@"    <StringProperty Name=""HintPath"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""SDKIdentity"" Visible=""false"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <!-- This is the metadata we store on the reference item when we add it. -->");
        sb.AppendLine(@"    <BoolProperty Name=""IsWinMDFile"" Visible=""false"" Description=""Indicates whether the project system ascertained that this is a WinMD (as opposed to an assembly)"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <!-- These are metadata added to the resolved item by MSBuild that we don't show to the user but use internally. -->");
        sb.AppendLine(@"    <BoolProperty Name=""WinMDFile"" Visible=""false"" ReadOnly=""True"" Description=""Indicates whether the build system ascertained that this is a WinMD (as opposed to an assembly)"" />");
        sb.AppendLine(@"    <StringProperty Name=""Name"" Visible=""false"" ReadOnly=""True"" />");
        sb.AppendLine(@"    <StringProperty Name=""OriginalItemSpec"" Visible=""False"" ReadOnly=""True"" Description=""The evaluated item name of the original reference item whose resolution resulted in this resolved reference item."" />");
        sb.AppendLine(@"    <StringProperty Name=""ReferenceFromSDK"" Visible=""False"" ReadOnly=""True"" Description=""The SDK that this reference came from when using the expand SDK target."" />");
        sb.AppendLine(@"    <StringProperty Name=""FusionName"" Visible=""False"" ReadOnly=""True"" Description=""The full fusion name of the resolved assembly."" />");
        sb.AppendLine(@"    <StringProperty Name=""ResolvedFrom"" Visible=""False"" ReadOnly=""True"" Description=""{}What repository held the reference that was used to resolve this.  (&quot;{GAC}&quot; if it was in the GAC)."" />");
        sb.AppendLine(@"    <StringProperty Name=""FrameworkFile"" Visible=""False"" ReadOnly=""True"" Description=""Is this file a framework file. Ie Found in the target framework directory or in the redist list."" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateResolvedCOMReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""ResolvedCOMReference""");
        sb.AppendLine(@"    DisplayName=""Resolved COM Reference""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""Resolved reference""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ResolvedReference"" ItemType=""COMReference"" HasConfigurationCondition=""False"" ");
        sb.AppendLine(@"                    SourceType=""TargetResults"" MSBuildTarget=""ResolveComReferencesDesignTime"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Guid""");
        sb.AppendLine(@"                    DisplayName=""CLSID""");
        sb.AppendLine(@"                    Description=""The GUID of the COM server.""");
        sb.AppendLine(@"                    Visible=""False"" />");
        sb.AppendLine(@"    <IntProperty Name=""VersionMajor"" Visible=""False"" />");
        sb.AppendLine(@"    <IntProperty Name=""VersionMinor"" Visible=""False"" />");
        sb.AppendLine(@"    <StringProperty Name=""WrapperTool"" Visible=""False"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringListProperty Name=""Aliases""");
        sb.AppendLine(@"                        DisplayName=""Aliases""");
        sb.AppendLine(@"                        Description=""A comma-delimited list of aliases to this reference.""");
        sb.AppendLine(@"                        Separator="","">");
        sb.AppendLine(@"        <StringListProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" ItemType=""COMReference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringListProperty.DataSource>");
        sb.AppendLine(@"    </StringListProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""CopyLocal""");
        sb.AppendLine(@"                  DisplayName=""Copy Local""");
        sb.AppendLine(@"                  Description=""Indicates whether the reference will be copied to the output directory."">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" ItemType=""COMReference"" HasConfigurationCondition=""False"" PersistedName=""Private"" />");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Culture"" ");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    Visible=""False""");
        sb.AppendLine(@"                    DisplayName=""Culture"" ");
        sb.AppendLine(@"                    Description=""The value of the culture field from the assembly metadata."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Description"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" ");
        sb.AppendLine(@"                    Visible=""False""");
        sb.AppendLine(@"                    DisplayName=""Description"" ");
        sb.AppendLine(@"                    Description=""The value of the Title field from the assembly metadata."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""EmbedInteropTypes""");
        sb.AppendLine(@"                  DisplayName=""Embed Interop Types""");
        sb.AppendLine(@"                  Description=""Indicates whether types defined in this assembly will be embedded into the target assembly."">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" ItemType=""COMReference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <EnumProperty Name=""FileType""");
        sb.AppendLine(@"                  ReadOnly=""True""");
        sb.AppendLine(@"                  Visible=""False""");
        sb.AppendLine(@"                  DisplayName=""File Type""");
        sb.AppendLine(@"                  Description=""The file type of the reference."">");
        sb.AppendLine(@"        <EnumValue Name=""Assembly"" DisplayName="".NET assembly"" />");
        sb.AppendLine(@"        <EnumValue Name=""ActiveX"" DisplayName=""COM type library"" />");
        sb.AppendLine(@"        <EnumValue Name=""Native Assembly"" DisplayName=""Native Assembly"" />");
        sb.AppendLine(@"    </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Identity""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Identity""");
        sb.AppendLine(@"                    Description=""Security identity of the referenced assembly (see System.Reflection.Assembly.Evidence or System.Security.Policy.Evidence)."">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource PersistedName=""{}{Identity}"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""ResolvedPath""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Path""");
        sb.AppendLine(@"                    Description=""Location of the file being referenced."">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource PersistedName=""Identity"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RuntimeVersion""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    Visible=""False""");
        sb.AppendLine(@"                    DisplayName=""Runtime Version""");
        sb.AppendLine(@"                    Description=""Version of the .NET runtime this assembly was compiled against."">");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""SpecificVersion"" ");
        sb.AppendLine(@"                  DisplayName=""Specific Version""");
        sb.AppendLine(@"                  Visible=""False""");
        sb.AppendLine(@"                  Description=""Indicates whether this assembly can be resolved without regard to multi-targeting rules for assembly resolution."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""StrongName""");
        sb.AppendLine(@"                  ReadOnly=""True""");
        sb.AppendLine(@"                  Visible=""False""");
        sb.AppendLine(@"                  DisplayName=""Strong Name""");
        sb.AppendLine(@"                  Description=""True indicates that the reference has been signed with a key-pair."">");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Version""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Version""");
        sb.AppendLine(@"                    Description=""Version of reference."">");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RequiredTargetFramework"" DisplayName=""Required Target Framework"" Visible=""False"" />");
        sb.AppendLine(@"    <StringProperty Name=""HintPath"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""SDKIdentity"" Visible=""false"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <!-- This is the metadata we store on the reference item when we add it. -->");
        sb.AppendLine(@"    <BoolProperty Name=""IsWinMDFile"" Visible=""false"" Description=""Indicates whether the project system ascertained that this is a WinMD (as opposed to an assembly)"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <!-- These are metadata added to the resolved item by MSBuild that we don't show to the user but use internally. -->");
        sb.AppendLine(@"    <BoolProperty Name=""WinMDFile"" Visible=""false"" ReadOnly=""True"" Description=""Indicates whether the build system ascertained that this is a WinMD (as opposed to an assembly)"" />");
        sb.AppendLine(@"    <StringProperty Name=""OriginalItemSpec"" Visible=""False"" ReadOnly=""True"" Description=""The evaluated item name of the original reference item whose resolution resulted in this resolved reference item."" />");
        sb.AppendLine(@"    <StringProperty Name=""FusionName"" Visible=""False"" ReadOnly=""True"" />");
        sb.AppendLine(@"    <StringProperty Name=""Name"" Visible=""false"" ReadOnly=""True"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateResolvedPackageReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""ResolvedPackageReference""");
        sb.AppendLine(@"    DisplayName=""Package""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""Package""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"   ");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ResolvedReference"" ItemType=""PackageReference"" HasConfigurationCondition=""False"" ");
        sb.AppendLine(@"                    SourceType=""TargetResults"" MSBuildTarget=""ResolvePackageDependenciesDesignTime"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Description"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" ");
        sb.AppendLine(@"                    Visible=""True""");
        sb.AppendLine(@"                    DisplayName=""Description"" ");
        sb.AppendLine(@"                    Description=""Dependency description."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Version""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Version""");
        sb.AppendLine(@"                    Description=""Version of dependency."">");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Name"" ");
        sb.AppendLine(@"                    Visible=""True"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    <StringProperty Name=""OriginalItemSpec"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" ");
        sb.AppendLine(@"                    Description=""The evaluated item name of the original reference item whose resolution resulted in this resolved reference item."" />");
        sb.AppendLine(@"    ");
        sb.AppendLine(@"    <StringProperty Name=""Path"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Type"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RuntimeIdentifier"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""TargetFramework"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""FrameworkName"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""FrameworkVersion"" ");
        sb.AppendLine(@"                    Visible=""False"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringListProperty Name=""Dependencies""");
        sb.AppendLine(@"                        DisplayName=""Dependencies""");
        sb.AppendLine(@"                        Visible=""false""");
        sb.AppendLine(@"                        Description=""A semicolon-delimited list of direct dependencies of current dependency.""");
        sb.AppendLine(@"                        Separator="";"">");
        sb.AppendLine(@"        <StringListProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ResolvedReference"" ItemType=""PackageReference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringListProperty.DataSource>");
        sb.AppendLine(@"    </StringListProperty>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateResolvedProjectReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""ResolvedProjectReference""");
        sb.AppendLine(@"    DisplayName=""Resolved Project Reference""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""Resolved reference""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ResolvedReference"" ItemType=""ProjectReference"" HasConfigurationCondition=""False"" ");
        sb.AppendLine(@"                    SourceType=""TargetResults"" MSBuildTarget=""ResolveProjectReferencesDesignTime"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringListProperty Name=""Aliases""");
        sb.AppendLine(@"                        DisplayName=""Aliases""");
        sb.AppendLine(@"                        Description=""A comma-delimited list of aliases to this reference.""");
        sb.AppendLine(@"                        Separator="","">");
        sb.AppendLine(@"        <StringListProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" ItemType=""ProjectReference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </StringListProperty.DataSource>");
        sb.AppendLine(@"    </StringListProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""CopyLocal""");
        sb.AppendLine(@"                  DisplayName=""Copy Local""");
        sb.AppendLine(@"                  Description=""Indicates whether the reference will be copied to the output directory."">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" ItemType=""ProjectReference"" HasConfigurationCondition=""False"" PersistedName=""Private"" />");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Culture"" ");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Culture"" ");
        sb.AppendLine(@"                    Description=""The value of the culture field from the assembly metadata."">");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Description"" ");
        sb.AppendLine(@"                    ReadOnly=""True"" ");
        sb.AppendLine(@"                    DisplayName=""Description"" ");
        sb.AppendLine(@"                    Description=""The value of the Title field from the assembly metadata."">");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""EmbedInteropTypes""");
        sb.AppendLine(@"                  DisplayName=""Embed Interop Types""");
        sb.AppendLine(@"                  Description=""Indicates whether types defined in this assembly will be embedded into the target assembly."">");
        sb.AppendLine(@"        <BoolProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectFile"" ItemType=""ProjectReference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"        </BoolProperty.DataSource>");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <EnumProperty Name=""FileType""");
        sb.AppendLine(@"                  ReadOnly=""True""");
        sb.AppendLine(@"                  Visible=""False""");
        sb.AppendLine(@"                  DisplayName=""File Type""");
        sb.AppendLine(@"                  Description=""The file type of the reference."">");
        sb.AppendLine(@"        <EnumValue Name=""Assembly"" DisplayName="".NET assembly"" />");
        sb.AppendLine(@"        <EnumValue Name=""ActiveX"" DisplayName=""COM type library"" />");
        sb.AppendLine(@"        <EnumValue Name=""Native Assembly"" DisplayName=""Native Assembly"" />");
        sb.AppendLine(@"    </EnumProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Identity""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Identity""");
        sb.AppendLine(@"                    Description=""Security identity of the referenced assembly (see System.Reflection.Assembly.Evidence or System.Security.Policy.Evidence)."">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource PersistedName=""{}{Identity}"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""ResolvedPath""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Path""");
        sb.AppendLine(@"                    Description=""Location of the file being referenced."">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource PersistedName=""Identity"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RuntimeVersion""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    Visible=""False""");
        sb.AppendLine(@"                    DisplayName=""Runtime Version""");
        sb.AppendLine(@"                    Description=""Version of the .NET runtime this assembly was compiled against."">");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""SpecificVersion"" ");
        sb.AppendLine(@"                  DisplayName=""Specific Version""");
        sb.AppendLine(@"                  Visible=""False""");
        sb.AppendLine(@"                  Description=""Indicates whether this assembly can be resolved without regard to multi-targeting rules for assembly resolution."" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <BoolProperty Name=""StrongName""");
        sb.AppendLine(@"                  ReadOnly=""True""");
        sb.AppendLine(@"                  Visible=""False""");
        sb.AppendLine(@"                  DisplayName=""Strong Name""");
        sb.AppendLine(@"                  Description=""True indicates that the reference has been signed with a key-pair."">");
        sb.AppendLine(@"    </BoolProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""Version""");
        sb.AppendLine(@"                    ReadOnly=""True""");
        sb.AppendLine(@"                    DisplayName=""Version""");
        sb.AppendLine(@"                    Description=""Version of reference."">");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""RequiredTargetFramework"" DisplayName=""Required Target Framework"" Visible=""False"" />");
        sb.AppendLine(@"    <StringProperty Name=""HintPath"" Visible=""false"" />");
        sb.AppendLine(@"    <StringProperty Name=""SDKIdentity"" Visible=""false"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <!-- This is the metadata we store on the reference item when we add it. -->");
        sb.AppendLine(@"    <BoolProperty Name=""IsWinMDFile"" Visible=""false"" Description=""Indicates whether the project system ascertained that this is a WinMD (as opposed to an assembly)"" />");
        sb.AppendLine(@"    <StringProperty Name=""Project"" ");
        sb.AppendLine(@"                    Visible=""False""");
        sb.AppendLine(@"                    Description=""the Guid the solution tracks an individual project reference target with"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <!-- These are metadata added to the resolved item by MSBuild that we don't show to the user but use internally. -->");
        sb.AppendLine(@"    <BoolProperty Name=""WinMDFile"" Visible=""false"" ReadOnly=""True"" Description=""Indicates whether the build system ascertained that this is a WinMD (as opposed to an assembly)"" />");
        sb.AppendLine(@"    <StringProperty Name=""OriginalItemSpec"" Visible=""False"" ReadOnly=""True"" Description=""The evaluated item name of the original reference item whose resolution resulted in this resolved reference item."" />");
        sb.AppendLine(@"    <StringProperty Name=""FusionName"" Visible=""False"" ReadOnly=""True"" />");
        sb.AppendLine(@"    <StringProperty Name=""Name"" Visible=""false"" ReadOnly=""True"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateResolvedSdkReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"    Name=""ResolvedSdkReference""");
        sb.AppendLine(@"    DisplayName=""Resolved SDK Reference""");
        sb.AppendLine(@"    PageTemplate=""generic""");
        sb.AppendLine(@"    Description=""Resolved SDK reference""");
        sb.AppendLine(@"    xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ResolvedReference"" ItemType=""SDKReference"" HasConfigurationCondition=""False""");
        sb.AppendLine(@"                    SourceType=""TargetResults"" MSBuildTarget=""ResolveSDKReferencesDesignTime"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"    <StringProperty Name=""AppXLocation"" DisplayName=""App Package Location"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <!-- This property should be the same as the one for the ResolvedReference item -->");
        sb.AppendLine(@"    <StringProperty Name=""OriginalItemSpec"" Visible=""false"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""FrameworkIdentity"" DisplayName=""FrameworkIdentity"" />");
        sb.AppendLine(@"");
        sb.AppendLine(@"    <StringProperty Name=""DisplayName"" DisplayName=""Display Name"" Visible=""False""/>");
        sb.AppendLine(@"    <BoolProperty Name=""CopyPayload"" DisplayName=""Copy Payload"" />");
        sb.AppendLine(@"    <BoolProperty Name=""ExpandContent"" DisplayName=""Expand Content"" />");
        sb.AppendLine(@"    <BoolProperty Name=""ExpandReferenceAssemblies"" DisplayName=""Expand Reference Assemblies"" />");
        sb.AppendLine(@"    <BoolProperty Name=""CopyLocalExpandedReferenceAssemblies"" DisplayName=""Copy Local Expanded Reference Assemblies"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateSdkReferenceContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!-- Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information. -->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"	Name=""SdkReference""");
        sb.AppendLine(@"	DisplayName=""SDK Reference""");
        sb.AppendLine(@"	PageTemplate=""generic""");
        sb.AppendLine(@"	Description=""SDK reference properties""");
        sb.AppendLine(@"	xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"    <Rule.DataSource>");
        sb.AppendLine(@"        <DataSource Persistence=""ProjectFile"" ItemType=""SDKReference"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"    </Rule.DataSource>");
        sb.AppendLine(@"    <StringProperty Name=""SDKRootFolder"" DisplayName=""SDK Root"" />");
        sb.AppendLine(@"    <StringProperty Name=""AppXLocation"" DisplayName=""App Package Location"" />");
        sb.AppendLine(@"    <StringProperty Name=""FrameworkIdentity"" DisplayName=""FrameworkIdentity"" />");
        sb.AppendLine(@"    <BoolProperty Name=""CopyPayload"" DisplayName=""Copy Payload"" />");
        sb.AppendLine(@"    <StringProperty Name=""CopyPayloadToSubDirectory"" DisplayName=""Copy Payload to Subdirectory"" />");
        sb.AppendLine(@"    <BoolProperty Name=""ExpandContent"" DisplayName=""Expand Content"" />");
        sb.AppendLine(@"    <BoolProperty Name=""ExpandReferenceAssemblies"" DisplayName=""Expand Reference Assemblies"" />");
        sb.AppendLine(@"    <BoolProperty Name=""CopyLocalExpandedReferenceAssemblies"" DisplayName=""Copy Local Expanded Reference Assemblies"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateSourceControlContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"  Name=""SourceControl""");
        sb.AppendLine(@"  DisplayName=""Source control""");
        sb.AppendLine(@"  PageTemplate=""generic""");
        sb.AppendLine(@"  Description=""General""");
        sb.AppendLine(@"  xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectFile"" Label=""Globals"" HasConfigurationCondition=""False"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"  <StringProperty Name=""SccProjectName"" />");
        sb.AppendLine(@"  <StringProperty Name=""SccProvider"" />");
        sb.AppendLine(@"  <StringProperty Name=""SccAuxPath"" />");
        sb.AppendLine(@"  <StringProperty Name=""SccLocalPath"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateSpecialFolderContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"	Name=""SpecialFolder""");
        sb.AppendLine(@"	DisplayName=""General""");
        sb.AppendLine(@"	PageTemplate=""generic""");
        sb.AppendLine(@"	Description=""Special folders""");
        sb.AppendLine(@"	xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"	<Rule.DataSource>");
        sb.AppendLine(@"		<DataSource Persistence=""ProjectInstance"" HasConfigurationCondition=""False"" ItemType=""SpecialFolder"" />");
        sb.AppendLine(@"	</Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"	<StringProperty Name=""Identity"" Visible=""false"" ReadOnly=""true"" Category=""Misc"" />");
        sb.AppendLine(@"	<StringProperty Name=""FullPath"" DisplayName=""Full Path"" ReadOnly=""true"" Category=""Misc"" />");
        sb.AppendLine(@"    <StringProperty Name=""FileNameAndExtension"" DisplayName=""Folder Name"" ReadOnly=""true"" Category=""Misc"">");
        sb.AppendLine(@"        <StringProperty.DataSource>");
        sb.AppendLine(@"            <DataSource Persistence=""ProjectInstance"" ItemType=""SpecialFolder"" PersistedName=""FileNameAndExtension"" />");
        sb.AppendLine(@"        </StringProperty.DataSource>");
        sb.AppendLine(@"    </StringProperty>");
        sb.AppendLine(@"    <EnumProperty Name=""DisableAddItem"" Visible=""False"">");
        sb.AppendLine(@"        <EnumValue Name=""Recursive"" />");
        sb.AppendLine(@"        <EnumValue Name=""TopDirectoryOnly"" />");
        sb.AppendLine(@"    </EnumProperty>");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private static string GenerateSubProjectContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
        sb.AppendLine(@"<!--Copyright, Microsoft Corporation, All rights reserved.-->");
        sb.AppendLine(@"<Rule");
        sb.AppendLine(@"  Name=""SubProject""");
        sb.AppendLine(@"  DisplayName=""General""");
        sb.AppendLine(@"  PageTemplate=""generic""");
        sb.AppendLine(@"  Description=""Projects that must be built as part of the containing project, but without an actual build dependency""");
        sb.AppendLine(@"  xmlns=""http://schemas.microsoft.com/build/2009/properties"">");
        sb.AppendLine(@"  <Rule.DataSource>");
        sb.AppendLine(@"    <DataSource Persistence=""ProjectFile"" HasConfigurationCondition=""False"" ItemType=""SubProject"" />");
        sb.AppendLine(@"  </Rule.DataSource>");
        sb.AppendLine(@"");
        sb.AppendLine(@"  <StringProperty Name=""ProjectTypeGuid"" Visible=""False"" />");
        sb.AppendLine(@"  <StringProperty Name=""ProjectId"" Visible=""False"" />");
        sb.AppendLine(@"  <BoolProperty Name=""VirtualProject"" Visible=""False"" />");
        sb.AppendLine(@"</Rule>");
        return sb.ToString();
    }

    private sealed class XamlPropertyRuleContext : IXamlPropertyRuleContext
    {
        public XamlPropertyRuleContext(
            string analyzerReferenceContent,
            string appDesignerContent,
            string assemblyInfoContent,
            string assemblyReferenceContent,
            string compilerCommandLineArgsContent,
            string cOMReferenceContent,
            string configurationGeneralContent,
            string configurationGeneralFileContent,
            string contentContent,
            string cSharpBrowseObjectContent,
            string cSharpProjectItemsSchemaContent,
            string cSharpContent,
            string debuggerGeneralContent,
            string dotNetCliToolReferenceContent,
            string embeddedResourceContent,
            string folderContent,
            string generalBrowseObjectContent,
            string noneContent,
            string nuGetRestoreContent,
            string packageReferenceContent,
            string projectDebuggerContent,
            string projectItemsSchemaContent,
            string projectReferenceContent,
            string pSDbgContent,
            string resolvedAnalyzerReferenceContent,
            string resolvedAssemblyReferenceContent,
            string resolvedCOMReferenceContent,
            string resolvedPackageReferenceContent,
            string resolvedProjectReferenceContent,
            string resolvedSdkReferenceContent,
            string sdkReferenceContent,
            string sourceControlContent,
            string specialFolderContent,
            string subProjectContent
        )
        {
            AnalyzerReferenceContent = analyzerReferenceContent;
            AppDesignerContent = appDesignerContent;
            AssemblyInfoContent = assemblyInfoContent;
            AssemblyReferenceContent = assemblyReferenceContent;
            CompilerCommandLineArgsContent = compilerCommandLineArgsContent;
            COMReferenceContent = cOMReferenceContent;
            ConfigurationGeneralContent = configurationGeneralContent;
            ConfigurationGeneralFileContent = configurationGeneralFileContent;
            ContentContent = contentContent;
            CSharpBrowseObjectContent = cSharpBrowseObjectContent;
            CSharpProjectItemsSchemaContent = cSharpProjectItemsSchemaContent;
            CSharpContent = cSharpContent;
            DebuggerGeneralContent = debuggerGeneralContent;
            DotNetCliToolReferenceContent = dotNetCliToolReferenceContent;
            EmbeddedResourceContent = embeddedResourceContent;
            FolderContent = folderContent;
            GeneralBrowseObjectContent = generalBrowseObjectContent;
            NoneContent = noneContent;
            NuGetRestoreContent = nuGetRestoreContent;
            PackageReferenceContent = packageReferenceContent;
            ProjectDebuggerContent = projectDebuggerContent;
            ProjectItemsSchemaContent = projectItemsSchemaContent;
            ProjectReferenceContent = projectReferenceContent;
            PSDbgContent = pSDbgContent;
            ResolvedAnalyzerReferenceContent = resolvedAnalyzerReferenceContent;
            ResolvedAssemblyReferenceContent = resolvedAssemblyReferenceContent;
            ResolvedCOMReferenceContent = resolvedCOMReferenceContent;
            ResolvedPackageReferenceContent = resolvedPackageReferenceContent;
            ResolvedProjectReferenceContent = resolvedProjectReferenceContent;
            ResolvedSdkReferenceContent = resolvedSdkReferenceContent;
            SdkReferenceContent = sdkReferenceContent;
            SourceControlContent = sourceControlContent;
            SpecialFolderContent = specialFolderContent;
            SubProjectContent = subProjectContent;

        }

        public string AnalyzerReferenceContent { get; }
        public string AppDesignerContent { get; }
        public string AssemblyInfoContent { get; }
        public string AssemblyReferenceContent { get; }
        public string CompilerCommandLineArgsContent { get; }
        public string COMReferenceContent { get; }
        public string ConfigurationGeneralContent { get; }
        public string ConfigurationGeneralFileContent { get; }
        public string ContentContent { get; }
        public string CSharpBrowseObjectContent { get; }
        public string CSharpProjectItemsSchemaContent { get; }
        public string CSharpContent { get; }
        public string DebuggerGeneralContent { get; }
        public string DotNetCliToolReferenceContent { get; }
        public string EmbeddedResourceContent { get; }
        public string FolderContent { get; }
        public string GeneralBrowseObjectContent { get; }
        public string NoneContent { get; }
        public string NuGetRestoreContent { get; }
        public string PackageReferenceContent { get; }
        public string ProjectDebuggerContent { get; }
        public string ProjectItemsSchemaContent { get; }
        public string ProjectReferenceContent { get; }
        public string PSDbgContent { get; }
        public string ResolvedAnalyzerReferenceContent { get; }
        public string ResolvedAssemblyReferenceContent { get; }
        public string ResolvedCOMReferenceContent { get; }
        public string ResolvedPackageReferenceContent { get; }
        public string ResolvedProjectReferenceContent { get; }
        public string ResolvedSdkReferenceContent { get; }
        public string SdkReferenceContent { get; }
        public string SourceControlContent { get; }
        public string SpecialFolderContent { get; }
        public string SubProjectContent { get; }

    }

}



