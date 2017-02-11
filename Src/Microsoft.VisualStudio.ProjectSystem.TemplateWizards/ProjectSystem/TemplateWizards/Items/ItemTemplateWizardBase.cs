// ----------------------------------------------------------------------------
//  <copyright file="ItemTemplateWizardBase.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------
using System.Collections.Generic;
using System.IO;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services;
using Microsoft.VisualStudio.ProjectSystem.Utilities;
using Microsoft.VisualStudio.TemplateWizard;
using VSLangProj;
using VSLangProj110;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Items
{
    internal abstract class ItemTemplateWizardBase : AbstractTemplateWizard
    {
        protected DTE2 _dte;

        protected Project _currentProject;

        private IProjectSystemReferenceService _referenceService;

        private IProjectSystemPackageService _packageService;

        private EnvDTEProject _project;

        protected string RootNamespace;

        protected string RootName;


        public sealed override void ProjectFinishedGenerating(Project project)
        {
        }

        public override void RunFinished()
        {
            using (ThreadedWaitDialogProgressScope scope = new ThreadedWaitDialogProgressScope("Checking installed packages..."))
            {
                _packageService.InstallLatestPackages(scope,_currentProject);
            }


            using (ThreadedWaitDialogProgressScope scope = new ThreadedWaitDialogProgressScope("Checking resolved references..."))
            {
                // _referenceService.AddRequiredReferences(scope,_currentProject);

                Service.ReferenceService.EnsureReferences(scope, ReferencesOption.Common, _currentProject);
                Service.ReferenceService.EnsureReferences(scope, ReferencesOption.MSBuild, _currentProject);
                Service.ReferenceService.EnsureReferences(scope, ReferencesOption.Wpf, _currentProject);
                Service.ReferenceService.EnsureReferences(scope, ReferencesOption.EnvDTE, _currentProject);
                Service.ReferenceService.EnsureReferences(scope, ReferencesOption.Shell, _currentProject);
            }

            foreach (Reference reference in _project.References)
            {
                if (reference.Name.StartsWith("envdte", System.StringComparison.CurrentCultureIgnoreCase) ||
                    reference.Name.StartsWith("vslangproj", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    if (reference is Reference5 reference5)
                    {
                        reference5.EmbedInteropTypes = false;
                    }
                }
            }
            
            Refresher.RefreshProject(_currentProject);
        }

        public sealed override void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            _dte = (DTE2) automationObject;
            _currentProject = EnvDTEHelper.GetCurrentProject();
            _project = EnvDTEProject.From(_currentProject);
            _referenceService = new ProjectSystemReferenceService();
            _packageService = new ProjectSystemPackageService();

            RootNamespace = replacementsDictionary["$rootnamespace$"];
            RootName = replacementsDictionary["$rootname$"];

            if (RootName.Contains("."))
                RootName = Path.GetFileNameWithoutExtension(RootName);

            RunStartedCore(replacementsDictionary);
        }

        protected abstract void RunStartedCore(Dictionary<string, string> replacementsDictionary);


        public override void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {

        }

    }
}