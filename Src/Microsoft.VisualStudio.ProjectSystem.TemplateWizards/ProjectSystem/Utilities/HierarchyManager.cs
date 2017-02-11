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
    internal static class HierarchyManager
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
}