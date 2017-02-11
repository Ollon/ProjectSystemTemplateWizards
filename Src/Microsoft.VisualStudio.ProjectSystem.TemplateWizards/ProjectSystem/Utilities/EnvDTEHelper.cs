// ----------------------------------------------------------------------------
//  <copyright file="EnvDTEHelper.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services;

namespace Microsoft.VisualStudio.ProjectSystem.Utilities
{
    internal static class EnvDTEHelper
    {
        public static Project GetCurrentProject()
        {
            SelectedItem selectedItem = GetSelectedItem();
            return selectedItem.Project ?? selectedItem.ProjectItem.ContainingProject;
        }

        public static SelectedItem GetSelectedItem()
        {
            return GlobalServices.DTE2.SelectedItems.Item(1);
        }

        public static ProjectItem GetOrCreateFolder(this DTE2 dte, string folderName)
        {
            ProjectItems projectItems = dte.GetSelectedProjectItems();

            if (projectItems.ContainingProject.TryFindProjectItemByName(folderName, out ProjectItem foundItem))
            {
                return foundItem;
            }

            return projectItems.AddFolder(folderName);
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

        public static IEnumerable<string> GetFolders(this ProjectItem projectItem)
        {
            if (projectItem.Kind != ItemTypeGuids.PhysicalFolder)
                throw new Exception("ProjectItem supplied must be a physical folder!");


            Project project = projectItem.ContainingProject;
            DirectoryInfo selectedFolder = new DirectoryInfo( projectItem.FileNames[0] );
            DirectoryInfo rootFolder = new DirectoryInfo( Path.GetDirectoryName(project.FullName) );

            return ComputeFolders(rootFolder.FullName, selectedFolder.FullName);

        }


        private static IEnumerable<string> ComputeFolders(string startFolder, string endFolder)
        {
            List<string> list = new List<string>();
            if (startFolder == endFolder) return list;
            DirectoryInfo startDirectory = new DirectoryInfo(startFolder);
            DirectoryInfo endDirectory = new DirectoryInfo(endFolder);
            string fullStartDirectoryPath = startDirectory.FullName;
            string fullEndDirectoryPath = endDirectory.FullName;
            string startPath = fullEndDirectoryPath.Replace(fullStartDirectoryPath, string.Empty);
            string[] split = startPath.Split('\\');
            for (int i = 1; i < split.Length - 1; i++)
            {
                list.Add(split[i]);
            }

            return list;
        }

    }
}