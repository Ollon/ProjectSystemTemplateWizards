// ----------------------------------------------------------------------------
//  <copyright file="MetadataReferenceService.References.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.IO;
using Microsoft.CodeAnalysis;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public partial class MetadataReferenceService
    {
        public MetadataReference MicrosoftCSharp
        {
            get
            {
                string path = Path.Combine(FrameworkFolder, "Microsoft.CSharp.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference System
        {
            get
            {
                string path = Path.Combine(FrameworkFolder, "System.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference SystemCore
        {
            get
            {
                string path = Path.Combine(FrameworkFolder, "System.Core.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference SystemXml
        {
            get
            {
                string path = Path.Combine(FrameworkFolder, "System.Xml.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference SystemXmlLinq
        {
            get
            {
                string path = Path.Combine(FrameworkFolder, "System.Xml.Linq.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference SystemXaml
        {
            get
            {
                string path = Path.Combine(FrameworkFolder, "System.Xaml.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference SystemComponentModelComposition
        {
            get
            {
                string path = Path.Combine(FrameworkFolder, "System.ComponentModel.Composition.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference PresentationCore
        {
            get
            {
                string path = Path.Combine(FrameworkFolder, "PresentationCore.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference PresentationFramework
        {
            get
            {
                string path = Path.Combine(FrameworkFolder, "PresentationFramework.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference WindowsBase
        {
            get
            {
                string path = Path.Combine(FrameworkFolder, "WindowsBase.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference CustomMarshalers
        {
            get
            {
                string path = Path.Combine(FrameworkFolder, "CustomMarshalers.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftBuild
        {
            get
            {
                string path = Path.Combine(MSBuildBinFolder, "Microsoft.Build.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftBuildFramework
        {
            get
            {
                string path = Path.Combine(MSBuildBinFolder, "Microsoft.Build.Framework.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftBuildUtilitiesCore
        {
            get
            {
                string path = Path.Combine(MSBuildBinFolder, "Microsoft.Build.Utilities.Core.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftBuildTasksCore
        {
            get
            {
                string path = Path.Combine(MSBuildBinFolder, "Microsoft.Build.Tasks.Core.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference VSLangProj
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "VSLangProj.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference VSLangProj2
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "VSLangProj2.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference VSLangProj80
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "VSLangProj80.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference VSLangProj90
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "VSLangProj90.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference VSLangProj100
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "VSLangProj100.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference VSLangProj110
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "VSLangProj110.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference VSLangProj140
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "VSLangProj140.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference EnvDTE
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "EnvDTE.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference EnvDTE80
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "EnvDTE80.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference EnvDTE90
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "EnvDTE90.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference EnvDTE90a
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "EnvDTE90a.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference EnvDTE100
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "EnvDTE100.dll");
                return MetadataReference.CreateFromFile(path).WithEmbedInteropTypes(false);
            }
        }

        public MetadataReference MicrosoftVisualStudioShell150
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "Microsoft.VisualStudio.Shell.15.0.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftVisualStudioShellFramework
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "Microsoft.VisualStudio.Shell.Framework.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftVisualStudioShellInterop
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "Microsoft.VisualStudio.Shell.Interop.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftVisualStudioShellInterop80
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "Microsoft.VisualStudio.Shell.Interop.8.0.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftVisualStudioShellInterop90
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "Microsoft.VisualStudio.Shell.Interop.9.0.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }
        public MetadataReference MicrosoftVisualStudioOLEInterop
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "Microsoft.VisualStudio.OLE.Interop.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftVisualStudioTextManagerInterop
        {
            get
            {
                string path = Path.Combine(PublicAssembliesFolder, "Microsoft.VisualStudio.TextManager.Interop.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftVisualStudioUtilities
        {
            get
            {
                string path = Path.Combine(IDEFolder, "Microsoft.VisualStudio.Utilities.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftVisualStudioImaging
        {
            get
            {
                string path = Path.Combine(IDEFolder, "Microsoft.VisualStudio.Imaging.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }

        public MetadataReference MicrosoftVisualStudioThreading
        {
            get
            {
                string path = Path.Combine(PrivateAssembliesFolder, "Microsoft.VisualStudio.Threading.dll");
                return MetadataReference.CreateFromFile(path);
            }
        }
    }
}