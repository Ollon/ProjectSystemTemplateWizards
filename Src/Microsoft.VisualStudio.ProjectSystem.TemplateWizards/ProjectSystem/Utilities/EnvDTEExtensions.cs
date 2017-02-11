using System;
using System.Collections.Generic;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace Microsoft.VisualStudio.ProjectSystem.Utilities
{
    internal static class EnvDTEExtensions
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
        public static IVsHierarchy GetProjectHierarchy(this DTE2 dte)
        {
            Project project = dte.GetSelectedProject();
            string uniqueName = project.UniqueName;
            IVsSolution solution = (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));
            solution.GetProjectOfUniqueName(uniqueName, out IVsHierarchy hierarchy);
            return hierarchy;
        }
        public static ProjectItem GetOrCreateFolder(this DTE2 dte)
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

        private static ProjectItems GetSelectedProjectItems(this DTE2 dte)
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

        private static Project GetSelectedProject(this DTE2 dte)
        {
            SelectedItem selectedItem = dte.SelectedItems.Item(1);
            if (selectedItem.Project != null)
                return selectedItem.Project;
            return selectedItem.ProjectItem.ContainingProject;
        }
    }
}