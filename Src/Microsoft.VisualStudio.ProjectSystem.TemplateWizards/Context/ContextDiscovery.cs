//-----------------------------------------------------------------------
// <copyright file="ContextDiscovery.cs" company="Ollon, LLC">
//     Copyright (c) Ollon, LLC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using EnvDTE;
using EnvDTE80;

namespace Microsoft.VisualStudio.Context
{
    /// <summary>
    /// Discovers the current context in Visual Studio.
    /// </summary>
    public class ContextDiscovery
    {
        private readonly DTE2 _dte;
        public ContextDiscovery(DTE2 dte)
        {
            _dte = dte;
        }

        public VisualStudioContext Discover()
        {
            SelectedItems selectdItems = _dte.SelectedItems;
            SelectedItem selectedItem = selectdItems.Item(1);
            Project project = selectedItem.Project;
            ProjectItem projectItem = selectedItem.ProjectItem;
            if (projectItem != null)
            {
                return GetContextCore(projectItem.Kind);
            }
            if (project != null)
            {
                return GetContextCore(project.Kind);
            }
            return VisualStudioContext.SolutionNode;
        }
        public VisualStudioContext DiscoverCore(out ProjectItemOrProject projectItemOrProject)
        {
            SelectedItems selectdItems = _dte.SelectedItems;
            SelectedItem selectedItem = selectdItems.Item(1);
            Project project = selectedItem.Project;
            ProjectItem projectItem = selectedItem.ProjectItem;
            projectItemOrProject = ProjectItemOrProject.From(selectedItem);
            if (projectItem != null)
            {
                return GetContextCore(projectItem.Kind);
            }
            if (project != null)
            {
                return GetContextCore(project.Kind);
            }
            
            return VisualStudioContext.SolutionNode;
        }
        private static VisualStudioContext GetContextCore(string kind)
        {
            switch (kind)
            {
                case VisualStudioContextGuids.PhysicalFile:
                    {
                        return VisualStudioContext.PhysicalFile;
                    }
                case VisualStudioContextGuids.PhysicalFolder:
                    {
                        return VisualStudioContext.PhysicalFolder;
                    }
                case VisualStudioContextGuids.VirtualFolder:
                    {
                        return VisualStudioContext.VirtualFolder;
                    }
                case VisualStudioContextGuids.SubProject:
                    {
                        return VisualStudioContext.Subproject;
                    }
                case VisualStudioContextGuids.SolutionFolder:
                    {
                        return VisualStudioContext.SolutionFolder;
                    }
                case VisualStudioContextGuids.VisualBasicProject:
                    {
                        return VisualStudioContext.VisualBasicProject;
                    }
                case VisualStudioContextGuids.CSharpProject:
                    {
                        return VisualStudioContext.CSharpProject;
                    }
                case VisualStudioContextGuids.CppProject:
                    {
                        return VisualStudioContext.CppProject;
                    }
                case VisualStudioContextGuids.WebProject:
                    {
                        return VisualStudioContext.WebProject;
                    }
                case VisualStudioContextGuids.SolutionItem:
                    {
                        return VisualStudioContext.SolutionItem;
                    }
                default:
                    throw new Exception($"Guid Not Found! Cannot determine context from '{kind}'");
            }
        }
    }
}

