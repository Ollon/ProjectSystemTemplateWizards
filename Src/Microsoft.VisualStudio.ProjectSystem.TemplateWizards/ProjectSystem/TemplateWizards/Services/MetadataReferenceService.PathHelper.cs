using System;
using System.IO;
using Microsoft.VisualStudio.ProjectSystem.Utilities;

namespace Microsoft.VisualStudio.ProjectSystem.TemplateWizards.Services
{
    public partial class MetadataReferenceService
    {
        private static string ProgramFilesX86Folder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            }
        }

        private static string MicrosoftNetReferneceAssembliesFolder
        {
            get
            {
                return Path.Combine(ProgramFilesX86Folder, @"Reference Assemblies\Microsoft\Framework\.NETFramework");
            }
        }

        private string FrameworkFolder
        {
            get
            {
                return Path.Combine(MicrosoftNetReferneceAssembliesFolder, _targetFrameworkVersion);
            }
        }

        private static string MSBuildBinFolder
        {
            get
            {
                return SetupHelper.MSBuildBinPath;
            }
        }

        private static string PublicAssembliesFolder
        {
            get
            {
                return SetupHelper.PublicAssembliesPath;
            }
        }

        private static string PrivateAssembliesFolder
        {
            get
            {
                return SetupHelper.PrivateAssembliesPath;
            }
        }

        private static string IDEFolder
        {
            get
            {
                return SetupHelper.IDEPath;
            }
        }
    }
}