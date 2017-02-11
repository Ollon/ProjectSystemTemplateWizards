using System;
using System.Collections.Generic;
using System.IO;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.TemplateWizard;
using System.Text;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio;

internal class XamlPropertyRuleWizard : IWizard
{
    private DTE _dte;
    string _rootNamespace;
    Project _currentProject;


    public void BeforeOpeningFile(ProjectItem projectItem) { }
    public void ProjectFinishedGenerating(Project project) { }
    public void ProjectItemFinishedGenerating(ProjectItem projectItem) { }
    public void RunFinished()
    {
        Refresher.RefreshProject(_currentProject);
    }

    public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
    {
        _dte = (DTE)automationObject;

        

        ProjectItem rulesFolder = _dte.GetOrCreateFolder();

        _currentProject = rulesFolder.ContainingProject;

        _rootNamespace = rulesFolder.ContainingProject.Properties.Item("DefaultNamespace").Value.ToString();

        IXamlPropertyRuleContext context = XamlPropertyRuleFactory.CreateXamlPropertyRuleContext();

        WriteXamlPropertyRuleFile(rulesFolder, context.AnalyzerReferenceContent, "AnalyzerReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.AppDesignerContent, "AppDesigner.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.AssemblyInfoContent, "AssemblyInfo.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.AssemblyReferenceContent, "AssemblyReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.CompilerCommandLineArgsContent, "CompilerCommandLineArgs.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.COMReferenceContent, "COMReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.ConfigurationGeneralContent, "ConfigurationGeneral.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.ConfigurationGeneralFileContent, "ConfigurationGeneralFile.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.ContentContent, "Content.xaml");
        
        
        WriteXamlPropertyRuleFile(rulesFolder, context.CSharpContent, "CSharp.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.DebuggerGeneralContent, "DebuggerGeneral.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.DotNetCliToolReferenceContent, "DotNetCliToolReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.EmbeddedResourceContent, "EmbeddedResource.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.FolderContent, "Folder.xaml");
        
        WriteXamlPropertyRuleFile(rulesFolder, context.NoneContent, "None.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.NuGetRestoreContent, "NuGetRestore.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.PackageReferenceContent, "PackageReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.ProjectDebuggerContent, "ProjectDebugger.xaml");
        
        WriteXamlPropertyRuleFile(rulesFolder, context.ProjectReferenceContent, "ProjectReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.PSDbgContent, "PSDbg.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.ResolvedAnalyzerReferenceContent, "ResolvedAnalyzerReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.ResolvedAssemblyReferenceContent, "ResolvedAssemblyReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.ResolvedCOMReferenceContent, "ResolvedCOMReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.ResolvedPackageReferenceContent, "ResolvedPackageReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.ResolvedProjectReferenceContent, "ResolvedProjectReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.ResolvedSdkReferenceContent, "ResolvedSdkReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.SdkReferenceContent, "SdkReference.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.SourceControlContent, "SourceControl.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.SpecialFolderContent, "SpecialFolder.xaml");
        WriteXamlPropertyRuleFile(rulesFolder, context.SubProjectContent, "SubProject.xaml");



        WriteXamlPropertyRuleNoCodeBehindFile(rulesFolder, context.GeneralBrowseObjectContent, "GeneralBrowseObject.xaml");
        WriteXamlPropertyRuleNoCodeBehindFile(rulesFolder, context.CSharpBrowseObjectContent, "CSharpBrowseObject.xaml");
        WriteXamlPropertyRuleProjectItemsSchemaFile(rulesFolder, context.ProjectItemsSchemaContent, "ProjectItemsSchema.xaml");
        WriteXamlPropertyRuleProjectItemsSchemaFile(rulesFolder, context.CSharpProjectItemsSchemaContent, "CSharpProjectItemsSchema.xaml");




    }

    private void WriteXamlPropertyRuleFile(ProjectItem folder, string content, string fileName)
    {
        string directory = folder.FileNames[0];
        string filePath = Path.Combine(directory, fileName);
        string codeBehindFilePath = Path.Combine(directory, $"{fileName}.cs");
        string codeBehindContent = 
            GenerateCodeBehindContent(Path.GetFileNameWithoutExtension(filePath), _rootNamespace);
        File.WriteAllText(filePath, content);
        File.WriteAllText(codeBehindFilePath, codeBehindContent);
        ProjectItem xamlPropertyRule = folder.ProjectItems.AddFromFile(filePath);
        SetXamlPropertyRuleBuildProperties(xamlPropertyRule);
        //ProjectItem codeBehind = folder.ProjectItems.AddFromFile(codeBehindFilePath);
        //SetCodeBehindBuildProperties(codeBehind, fileName);
    }

    private void WriteXamlPropertyRuleNoCodeBehindFile(ProjectItem folder, string content, string fileName)
    {
        string directory = folder.FileNames[0];
        string filePath = Path.Combine(directory, fileName);
        File.WriteAllText(filePath, content);
        ProjectItem xamlPropertyRule = folder.ProjectItems.AddFromFile(filePath);
        SetXamlPropertyRuleNoCodeBehindBuildProperties(xamlPropertyRule);
    }

    private void WriteXamlPropertyRuleProjectItemsSchemaFile(ProjectItem folder, string content, string fileName)
    {
        string directory = folder.FileNames[0];
        string filePath = Path.Combine(directory, fileName);
        File.WriteAllText(filePath, content);
        ProjectItem xamlPropertyRule = folder.ProjectItems.AddFromFile(filePath);
        SetXamlPropertyRuleProjectItemsSchemaBuildProperties(xamlPropertyRule);
    }

    private void SetCodeBehindBuildProperties(ProjectItem projectItem, string fileName)
    {
        projectItem.SetBuildPropertyMetadata("SubType", "Designer");
        projectItem.SetBuildPropertyMetadata("DependentUpon", fileName);
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





    private static string GenerateCodeBehindContent(string className, string rootNamespace)
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

    public bool ShouldAddProjectItem(string filePath) { return true; }

}


public static class EnvDTEExtensions
{
    public static void SetBuildPropertyMetadata(this ProjectItem projectItem, string name, string value)
    {
        Project project = projectItem.ContainingProject;
        string uniqueName = project.UniqueName;
        IVsSolution solution = (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));
        solution.GetProjectOfUniqueName(uniqueName, out IVsHierarchy hierarchy);
        if (hierarchy != null)
        {
            if (hierarchy is IVsBuildPropertyStorage buildPropertyStorage)
            {
                string fullPath = (string)projectItem.Properties.Item("FullPath").Value;
                hierarchy.ParseCanonicalName(fullPath, out uint itemId);
                buildPropertyStorage.SetItemAttribute(itemId, name, value);
            }
        }
    }
    public static IVsBuildPropertyStorage GetBuildPropertyStorage(this DTE dte)
    {
        return dte.GetProjectHierarchy() as IVsBuildPropertyStorage;
    }
    public static IVsHierarchy GetProjectHierarchy(this DTE dte)
    {
        Project project = dte.GetSelectedProject();
        string uniqueName = project.UniqueName;
        IVsSolution solution = (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));
        solution.GetProjectOfUniqueName(uniqueName, out IVsHierarchy hierarchy);
        return hierarchy;
    }
    public static ProjectItem GetOrCreateFolder(this DTE dte)
    {
        ProjectItems projectItems = dte.GetSelectedProjectItems();
        
        if (projectItems.ContainingProject.TryFindProjectItemByName("Rules", out ProjectItem foundItem))
        {
            return foundItem;
        }

        return projectItems.AddFolder("Rules");
    }
    public static bool TryFindProjectItemByName(this Project project, string name, out ProjectItem foundItem)
    {
        foundItem = FindProjectItemByNameCore(project, name);
        if (foundItem == null)
            return false;
        return true;
    }

    private static ProjectItems GetSelectedProjectItems(this DTE dte)
    {
        SelectedItem item = dte.SelectedItems.Item(1);
        if (item.ProjectItem != null)
            return item.ProjectItem.ProjectItems;
        else
        {
            return item.Project.ProjectItems;
        }
    }

    private static ProjectItem FindProjectItemByNameCore(Project project, string projectItemName)
    {
        ProjectItem result = null;
        IEnumerable<ProjectItem> projectItems = project.GetAllProjectItems();
        foreach (ProjectItem item in projectItems)
        {
            if (item.Name.Equals(projectItemName, StringComparison.CurrentCultureIgnoreCase))
                result = item;
        }
        return result;
    }
    public static IEnumerable<ProjectItem> GetAllProjectItems(this Project project)
    {
        return GetAllProjectItems(project.ProjectItems, true);
    }

    private static IEnumerable<ProjectItem> GetAllProjectItems(ProjectItems collection, bool recursive = true)
    {
        foreach (ProjectItem item in collection)
        {
            yield return item;
            if (recursive)
            {
                IEnumerable<ProjectItem> children = GetAllProjectItems(item.ProjectItems, recursive);
                if (children != null)
                {
                    foreach (ProjectItem childItem in children)
                        yield return childItem;
                }
            }
        }
    }

    private static Project GetSelectedProject(this DTE dte)
    {
        SelectedItem selectedItem = dte.SelectedItems.Item(1);
        if (selectedItem.Project != null)
            return selectedItem.Project;
        return selectedItem.ProjectItem.ContainingProject;
    }
}


public static class Refresher
{
    public static void RefreshProject(Project project)
    {
        try
        {
            project.Save();
        }
        catch (Exception)
        {
        }

        IVsHierarchy projectHierarchy = HierarchyManager.GetEquivalent(project);
        if (projectHierarchy != null)
        {
            Guid projectGuid = HierarchyManager.GetProjectGuid(projectHierarchy);
            HierarchyManager.EnsureProjectIsLoaded(projectGuid);
            HierarchyManager.UnloadProject(projectGuid);
            HierarchyManager.ReloadHierarchy(projectGuid);
            HierarchyManager.EnsureProjectIsLoaded(projectGuid);
        }
    }

}
public static class HierarchyManager
{
    public static IVsHierarchy GetHierarchy(ProjectItem projectItem, out uint itemId)
    {
        string uniqueName = projectItem.ContainingProject.UniqueName;
        GlobalServices.Solution.GetProjectOfUniqueName(uniqueName, out IVsHierarchy hierarchy);
        hierarchy.ParseCanonicalName(projectItem.FileNames[0], out itemId);
        return hierarchy;
    }

    public static IVsHierarchy GetHierarchy(Project project)
    {
        string uniqueName = project.UniqueName;
        GlobalServices.Solution.GetProjectOfUniqueName(uniqueName, out IVsHierarchy hierarchy);
        return hierarchy;
    }

    public static void SetBuildProperty(ProjectItem projectItem, string propertyName, string propertyValue)
    {
        IVsHierarchy hierarchy = GetHierarchy(projectItem, out uint itemId);
        if (hierarchy is IVsBuildPropertyStorage storage)
        {
            storage.SetItemAttribute(itemId, propertyName, propertyValue);
        }
    }

    private const uint VSITEMID_ROOT = 0xFFFFFFFE;
    public static IVsHierarchy GetEquivalent(Project project)
    {
        GlobalServices.Solution.GetProjectOfUniqueName(project.FullName, out IVsHierarchy hierarchy);
        return hierarchy;
    }
    public static Guid GetProjectGuid(IVsHierarchy projectHierarchy)
    {
        int hr;

        hr = projectHierarchy.GetGuidProperty(VSITEMID_ROOT, (int)__VSHPROPID.VSHPROPID_ProjectIDGuid, out Guid projectGuid);
        ErrorHandler.ThrowOnFailure(hr);

        return projectGuid;
    }

    public static void ReloadHierarchy(Guid projectGuid)
    {
        int hr;
        hr = GlobalServices.Solution4.ReloadProject(ref projectGuid);
        ErrorHandler.ThrowOnFailure(hr);
    }

    public static void UnloadProject(Guid projectGuid)
    {
        int hr;

        hr = GlobalServices.Solution4.UnloadProject(ref projectGuid, (uint)_VSProjectUnloadStatus.UNLOADSTATUS_UnloadedByUser);
        ErrorHandler.ThrowOnFailure(hr);
    }

    public static void EnsureProjectIsLoaded(Guid projectGuid)
    {
        GlobalServices.Solution4.EnsureProjectIsLoaded(ref projectGuid, (uint)__VSBSLFLAGS.VSBSLFLAGS_None);
    }
}



public static partial class GlobalServices
{
    public static TServiceInterface GetService<TService, TServiceInterface>()
    {
        return (TServiceInterface)Package.GetGlobalService(typeof(TService));
    }

    public static IVsFindSymbol FindSymbol
    {
        get
        {
            return GetService<SVsObjectSearch, IVsFindSymbol>();
        }
    }

    public static IVsSolutionBuildManager SolutionBuildManager
    {
        get
        {
            return GetService<SVsSolutionBuildManager, IVsSolutionBuildManager>();
        }
    }

    public static IVsSolution Solution
    {
        get
        {
            return GetService<SVsSolution, IVsSolution>();
        }
    }

    public static IVsSolution4 Solution4
    {
        get
        {
            return GetService<SVsSolution, IVsSolution4>();
        }
    }

    public static IVsSolutionPersistence SolutionPersistence
    {
        get
        {
            return GetService<SVsSolutionPersistence, IVsSolutionPersistence>();
        }
    }

    public static IVsShell Shell
    {
        get
        {
            return GetService<SVsShell, IVsShell>();
        }
    }

    public static IVsUIShell UIShell
    {
        get
        {
            return GetService<SVsUIShell, IVsUIShell>();
        }
    }
    public static DTE DTE
    {
        get
        {
            return GetService<SDTE, DTE>();
        }
    }

    public static DTE2 DTE2
    {
        get
        {
            return GetService<SDTE, DTE2>();
        }
    }

    public static IVsRunningDocumentTable RDT
    {
        get
        {
            return GetService<SVsRunningDocumentTable, IVsRunningDocumentTable>();
        }
    }

    public static IVsMonitorSelection MonitorSelection
    {
        get
        {
            return GetService<SVsShellMonitorSelection, IVsMonitorSelection>();
        }
    }

    public static IVsMonitorUserContext MonitorUserContext
    {
        get
        {
            return GetService<SVsMonitorUserContext, IVsMonitorUserContext>();
        }
    }

    public static IVsObjectManager2 ObjectManager
    {
        get
        {
            return GetService<SVsObjectManager, IVsObjectManager2>();
        }
    }

    public static IVsResourceManager ResourceManager
    {
        get
        {
            return GetService<SVsResourceManager, IVsResourceManager>();
        }
    }

    public static IVsSccManagerTooltip SccManagerTootip
    {
        get
        {
            return GetService<SVsSccManager, IVsSccManagerTooltip>();
        }
    }

    public static IVsActivityLog ActivityLog
    {
        get
        {
            return GetService<SVsActivityLog, IVsActivityLog>();
        }
    }

}