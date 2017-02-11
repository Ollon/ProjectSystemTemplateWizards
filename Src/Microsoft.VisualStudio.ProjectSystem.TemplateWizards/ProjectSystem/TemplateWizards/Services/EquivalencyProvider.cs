// ----------------------------------------------------------------------------
//  <copyright file="EquivalencyProvider.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;
using EnvDTE;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.LanguageServices;
using Project = EnvDTE.Project;
using RoslynDocument = Microsoft.CodeAnalysis.Document;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public static class EquivalencyProvider
    {
        public static Project GetEquivalent(CodeAnalysis.Project roslynProject)
        {
            foreach (Project dteProject in GlobalServices.DTE2.Solution.Projects)
            {
                if (dteProject.FullName.Equals(roslynProject.FilePath, System.StringComparison.CurrentCultureIgnoreCase))
                {
                    return dteProject;
                }
            }
            throw new CouldNotFindEquivalentProjectException(nameof(roslynProject));
        }

        public static CodeAnalysis.Project GetEquivalent(Project dteproject)
        {
            foreach (CodeAnalysis.Project roslynProject in GlobalServices.GetComponentModelService<VisualStudioWorkspace>().CurrentSolution.Projects)
            {
                if (roslynProject.FilePath.Equals(dteproject.FullName, System.StringComparison.CurrentCultureIgnoreCase))
                    return roslynProject;
            }

            throw new CouldNotFindEquivalentProjectException(nameof(dteproject));
        }

        public static RoslynDocument GetEquivalent(ProjectItem projectItem)
        {
            foreach (CodeAnalysis.Project roslynProject in GlobalServices.CurrentSolution.Projects)
            {
                foreach (RoslynDocument document in roslynProject.Documents)
                {
                    if (projectItem.FileNames[0].Equals(document.FilePath, System.StringComparison.CurrentCultureIgnoreCase))
                    {
                        return document;
                    }
                }
            }

            throw new CouldNotFindEquivalentDocumentException(nameof(projectItem));
        }
    }
}