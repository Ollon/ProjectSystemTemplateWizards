// ----------------------------------------------------------------------------
//  <copyright file="ProjectSystemPackageService.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;
using System.Collections;
using System.Diagnostics;
using EnvDTE;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public class ProjectSystemPackageService : IProjectSystemPackageService
    {
        private static readonly string[] packageIdList =
        {
            "System.Collections.Immutable",
            "Microsoft.Tpl.Dataflow",
            "Microsoft.VisualStudio.Composition",
            "Microsoft.VisualStudio.ProjectSystem",
            "Microsoft.VisualStudio.ProjectSystem.SDK",
            "Microsoft.VisualStudio.ProjectSystem.SDK.Tools",
            "Microsoft.VisualStudio.SDK.VsixSuppression",
            "Microsoft.VisualStudio.ImageCatalog",
            "Microsoft.VisualStudio.Imaging.Interop.14.0.DesignTime"
        };

        public void InstallLatestPackages(ThreadedWaitDialogProgressScope scope, Project project)
        {
            foreach (string packageId in packageIdList)
            {
                scope.Update(
                    "Checking Packages",
                    $"Checking if package {packageId} is installed",
                    $"Checking if package {packageId} is installed",
                    true
                );
                if (GlobalServices.InstallerServices.IsPackageInstalled(project, packageId))
                {
                    continue;
                }
                try
                {
                    scope.Update(
                        "Installing Package",
                        $"Installing latest package {packageId}",
                        $"Installing latest package {packageId}",
                        true
                    );
                    GlobalServices.PackageInstaller2.InstallLatestPackage(null, project, packageId, true, false);
                }
                catch (Exception e)
                {
                    Debug.Print(e.Message);
                }
            }
        }
    }
}