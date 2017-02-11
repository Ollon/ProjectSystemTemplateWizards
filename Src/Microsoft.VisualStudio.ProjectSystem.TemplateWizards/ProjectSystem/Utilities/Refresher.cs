// ----------------------------------------------------------------------------
//  <copyright file="EnvDTEHelper.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;
using EnvDTE;
using Microsoft.VisualStudio.Shell.Interop;

namespace Microsoft.VisualStudio.ProjectSystem.Utilities
{
    internal static class Refresher
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
}