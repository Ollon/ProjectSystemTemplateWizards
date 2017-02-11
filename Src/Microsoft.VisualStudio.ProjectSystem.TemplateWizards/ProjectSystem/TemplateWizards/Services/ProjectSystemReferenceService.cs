// ----------------------------------------------------------------------------
//  <copyright file="ProjectSystemReferenceService.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using EnvDTE;
using Microsoft.VisualStudio.ProjectSystem.Utilities;
using VSLangProj;
using VSLangProj110;
using VSLangProj80;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public class ProjectSystemReferenceService : IProjectSystemReferenceService
    {
        private static readonly Dictionary<string, string> ReferenceDictionary = new Dictionary<string, string>()
        {
            {"System", ReferenceHelper.SystemPath},
            {"System.Xaml", ReferenceHelper.SystemXamlPath},
            {"PresentationCore", ReferenceHelper.PresentationCorePath},
            {"CustomMarshalers", ReferenceHelper.CustomMarshalersPath},
            {"WindowsBase", ReferenceHelper.WindowsBasePath},
            {"System.ComponentModel.Composition", ReferenceHelper.SystemComponentModelCompositionPath},
            {"Microsoft.Build", ReferenceHelper.MicrosoftBuildPath},
            {"Microsoft.Build.Framework", ReferenceHelper.MicrosoftBuildFrameworkPath},
            {"Microsoft.Build.Utilities.Core", ReferenceHelper.MicrosoftBuildUtilitiesCorePath},
            {"Microsoft.Build.Tasks.Core", ReferenceHelper.MicrosoftBuildTasksCorePath},
        };

        public void AddRequiredReferences(ThreadedWaitDialogProgressScope scope, Project project)
        {
            VSProject vsproject = project.Object as VSProject;
            string[] referenceNames = GetReferences(vsproject).Select(r => r.Name).ToArray();
            foreach (KeyValuePair<string, string> kvp in ReferenceDictionary)
            {
                scope.Update(
                    "Checking Reference",
                    $"Checking if reference {kvp.Key} has resolved",
                    $"Checking if reference {kvp.Key} has resolved",
                    true
                );
                IEnumerable<string> enumerable = referenceNames;
                if (!enumerable.Contains(kvp.Key))
                {
                    try
                    {
                        scope.Update(
                            "Adding Reference",
                            $"Adding reference {kvp.Key} with path {kvp.Value}",
                            $"Adding reference {kvp.Key} with path {kvp.Value}",
                            true
                        );
                        Reference newreference = vsproject.References.Add(kvp.Value);
                    }
                    catch (Exception e)
                    {
                        Debug.Print(e.Message);
                    }
                }
            }
        }

        private static IEnumerable<Reference> GetReferences(VSProject project)
        {
            if (project?.References == null)
            {
                yield break;
            }
            foreach (Reference reference in project?.References)
            {
                yield return reference;
            }
        }
    }
}