using System.IO;

namespace Microsoft.VisualStudio.ProjectSystem.Utilities
{
    public static class ReferenceHelper
    {
        public static string SystemPath
        {
            get
            {
                return Path.Combine(FrameworkHelper.Net46Path, "System.dll");
            }
        }

        public static string SystemXamlPath
        {
            get
            {
                return Path.Combine(FrameworkHelper.Net46Path, "System.Xaml.dll");
            }
        }

        public static string SystemComponentModelCompositionPath
        {
            get
            {
                return Path.Combine(FrameworkHelper.Net46Path, "System.ComponentModel.Composition.dll");
            }
        }

        public static string PresentationCorePath
        {
            get
            {
                return Path.Combine(FrameworkHelper.Net46Path, "PresentationCore.dll");
            }
        }

        public static string WindowsBasePath
        {
            get
            {
                return Path.Combine(FrameworkHelper.Net46Path, "WindowsBase.dll");
            }
        }

        public static string CustomMarshalersPath
        {
            get
            {
                return Path.Combine(SetupHelper.MSBuildBinPath, "CustomMarshalers.dll");
            }
        }
        public static string MicrosoftBuildPath
        {
            get
            {
                return Path.Combine(SetupHelper.MSBuildBinPath, "Microsoft.Build.dll");
            }
        }

        public static string MicrosoftBuildFrameworkPath
        {
            get
            {
                return Path.Combine(SetupHelper.MSBuildBinPath, "Microsoft.Build.Framework.dll");
            }
        }

        public static string MicrosoftBuildUtilitiesCorePath
        {
            get
            {
                return Path.Combine(SetupHelper.MSBuildBinPath, "Microsoft.Build.Utilities.Core.dll");
            }
        }

        public static string MicrosoftBuildTasksCorePath
        {
            get
            {
                return Path.Combine(SetupHelper.MSBuildBinPath, "Microsoft.Build.Tasks.Core.dll");
            }
        }
    }
}