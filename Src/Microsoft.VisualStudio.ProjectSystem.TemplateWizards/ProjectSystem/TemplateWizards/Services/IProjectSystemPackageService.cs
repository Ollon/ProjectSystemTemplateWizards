// ----------------------------------------------------------------------------
//  <copyright file="IProjectSystemPackageService.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using EnvDTE;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public interface IProjectSystemPackageService
    {
        void InstallLatestPackages(ThreadedWaitDialogProgressScope scope, Project project);
    }
}