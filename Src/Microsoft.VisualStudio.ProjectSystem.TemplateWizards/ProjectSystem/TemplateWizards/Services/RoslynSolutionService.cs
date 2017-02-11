// ----------------------------------------------------------------------------
//  <copyright file="RoslynSolutionService.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using EnvDTE;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.LanguageServices;
using RoslynProject = Microsoft.CodeAnalysis.Project;
using RoslynSolution = Microsoft.CodeAnalysis.Solution;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public class RoslynSolutionService
    {
        private readonly IImmutableDictionary<string, RoslynProject> projectDictionary;


        public RoslynSolutionService()
        {
            Workspace = GlobalServices.GetComponentModelService<VisualStudioWorkspace>();
            IEnumerable<KeyValuePair<string, RoslynProject>> projects = from p in Workspace.CurrentSolution.Projects
                select new KeyValuePair<string, RoslynProject>(p.Name, p);
            projectDictionary = ImmutableDictionary.CreateRange(projects);
            ReferenceService = new MetadataReferenceService(Workspace);
        }

        public VisualStudioWorkspace Workspace { get; }

        public IMetadataReferenceService ReferenceService { get; }

        public RoslynSolution RoslynSolution
        {
            get
            {
                return Workspace.CurrentSolution;
            }
        }

        public IEnumerable<RoslynProject> RoslynProjects
        {
            get
            {
                return RoslynSolution.Projects;
            }
        }

        public IEnumerable<EnvDTEProject> EnvDTEProjects
        {
            get
            {
                foreach (EnvDTE.Project dteProject in GlobalServices.DTE2.Solution.Projects)
                {
                    yield return EnvDTEProject.From(dteProject);
                }
            }
        }

        public RoslynProject this[string projectName]
        {
            get
            {
                return projectDictionary.TryGetValue(projectName, out RoslynProject project) ? project : null;
            }
        }

        public void Open(ProjectItem projectItem)
        {
            Window window = projectItem.Open(Constants.vsext_vk_Code);
            window.Activate();
        }
    }
}