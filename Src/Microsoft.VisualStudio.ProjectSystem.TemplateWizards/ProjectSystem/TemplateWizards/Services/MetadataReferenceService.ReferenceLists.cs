// ----------------------------------------------------------------------------
//  <copyright file="MetadataReferenceService.ReferenceLists.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public partial class MetadataReferenceService
    {
        public IImmutableList<MetadataReference> CommonReferences
        {
            get
            {
                return ImmutableList.CreateRange(
                    new[]
                    {
                        System,
                        SystemCore,
                        SystemXml,
                        SystemXmlLinq,
                        SystemComponentModelComposition,
                        MicrosoftCSharp
                    }
                );
            }
        }

        public IImmutableList<MetadataReference> WpfReferences
        {
            get
            {
                return ImmutableList.CreateRange(
                    new[]
                    {
                        SystemXaml,
                        PresentationCore,
                        PresentationFramework,
                        WindowsBase,
                        CustomMarshalers
                    }
                );
            }
        }

        public IImmutableList<MetadataReference> MSBuildReferences
        {
            get
            {
                return ImmutableList.CreateRange(
                    new[]
                    {
                        MicrosoftBuild,
                        MicrosoftBuildFramework,
                        MicrosoftBuildTasksCore,
                        MicrosoftBuildUtilitiesCore
                    }
                );
            }
        }

        public IImmutableList<MetadataReference> XamlReferences
        {
            get
            {
                return ImmutableList.CreateRange(
                    new[]
                    {
                        System,
                        SystemCore,
                        SystemXaml,
                        PresentationCore,
                        PresentationFramework,
                        WindowsBase,
                        CustomMarshalers,
                        MicrosoftBuild,
                        MicrosoftBuildFramework,
                        MicrosoftBuildTasksCore,
                        MicrosoftBuildUtilitiesCore
                    }
                );
            }
        }

        public IImmutableList<MetadataReference> VSLangProjReferences
        {
            get
            {
                return ImmutableList.CreateRange(
                    new[]
                    {
                        VSLangProj,
                        VSLangProj2,
                        VSLangProj80,
                        VSLangProj90,
                        VSLangProj100,
                        VSLangProj110,
                        VSLangProj140
                    }
                );
            }
        }

        public IImmutableList<MetadataReference> EnvDTEReferences
        {
            get
            {
                return ImmutableList.CreateRange(
                    new[]
                    {
                        EnvDTE,
                        EnvDTE80,
                        EnvDTE90,
                        EnvDTE90a,
                        EnvDTE100
                    }
                );
            }
        }

        public IImmutableList<MetadataReference> VisualStudioShellReferences
        {
            get
            {
                return ImmutableList.CreateRange(
                    new[]
                    {
                        MicrosoftVisualStudioShell150,
                        MicrosoftVisualStudioShellFramework,
                        MicrosoftVisualStudioShellInterop,
                        MicrosoftVisualStudioShellInterop80,
                        MicrosoftVisualStudioShellInterop90,
                        MicrosoftVisualStudioOLEInterop,
                        MicrosoftVisualStudioTextManagerInterop,
                        MicrosoftVisualStudioUtilities,
                        MicrosoftVisualStudioThreading,
                        MicrosoftVisualStudioImaging
                    }
                );
            }
        }

    }
}