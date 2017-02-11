// ----------------------------------------------------------------------------
//  <copyright file="MetadataReferenceService.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.ProjectSystem.Utilities;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public partial class MetadataReferenceService : IMetadataReferenceService
    {
        private readonly Workspace _workspace;

        private readonly string _targetFrameworkVersion;

        public MetadataReferenceService(Workspace workspace, string targetFrameworkVersion = "v4.6")
        {
            _workspace = workspace;
            _targetFrameworkVersion = targetFrameworkVersion;
        }

        public void EnsureReferences(ThreadedWaitDialogProgressScope scope, ReferencesOption option, EnvDTE.Project project)
        {
            Project newProject = EquivalencyProvider.GetEquivalent(project);

            EnsureReferences(scope, option, newProject);
        }

        public void EnsureReferences(ThreadedWaitDialogProgressScope scope, ReferencesOption option, Project project)
        {
            IEnumerable<MetadataReference> optionReferences = GetList(option);
            ImmutableList<MetadataReference> currentReferences = project.MetadataReferences.ToImmutableList();

            foreach (MetadataReference reference in optionReferences)
            {
                scope.Update(
                    "Checking References",
                    $"Checking if reference {reference.Display} has resolved",
                    $"Checking if reference {reference.Display} has resolved",
                    true
                    );
                if (currentReferences.Contains(reference))
                {
                    continue;
                }

                scope.Update(
                    "Adding References",
                    $"Adding reference {reference.Display}",
                    $"Adding reference {reference.Display}"

                    );

                
                project = project.AddMetadataReference(reference);

                try
                {
                    _workspace.TryApplyChanges(project.Solution);
                }
                catch (Exception e)
                {
                    Debug.Print(e.Message);
                }
            }

            

        }

        private IEnumerable<MetadataReference> GetList(ReferencesOption option)
        {
            switch (option)
            {
                case ReferencesOption.Common:
                    return CommonReferences;
                case ReferencesOption.Wpf:
                    return WpfReferences;
                case ReferencesOption.MSBuild:
                    return MSBuildReferences;
                case ReferencesOption.Xaml:
                    return XamlReferences;
                case ReferencesOption.VSLangProj:
                    return VSLangProjReferences;
                case ReferencesOption.EnvDTE:
                    return EnvDTEReferences;
                case ReferencesOption.Shell:
                    return VisualStudioShellReferences;
                default:
                    throw new ArgumentOutOfRangeException(nameof(option), option, null);
            }
        }


    }
}