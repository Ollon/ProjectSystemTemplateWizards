// ----------------------------------------------------------------------------
//  <copyright file="IProjectSystemReferenceService.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using EnvDTE;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public interface IProjectSystemReferenceService
    {
        void AddRequiredReferences(ThreadedWaitDialogProgressScope scope, Project project);
    }
}