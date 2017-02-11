using System.IO;

namespace Microsoft.VisualStudio.ProjectSystem.Utilities
{
    public static class FrameworkHelper
    {

        public static string ReferenceAssembliesPath
        {
            get
            {
                return FrameworkEnvironment.GetFolderPath(FrameworkEnvironment.SpecialFolder.ReferenceAssemblies);
            }
        }

        public static string NETFrameworkPath
        {
            get
            {
                return FrameworkEnvironment.GetFolderPath(FrameworkEnvironment.SpecialFolder.NETFrameworkPath);
            }
        }
        public static string Net46Path
        {
            get
            {
                return Path.Combine(NETFrameworkPath, "v4.6");
            }
        }
    }
}