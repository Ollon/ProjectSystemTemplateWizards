using System;
using System.IO;

namespace Microsoft.VisualStudio.ProjectSystem.Utilities
{
    public static class FrameworkEnvironment
    {
        public enum SpecialFolder
        {
            ReferenceAssemblies,
            NETFrameworkPath
        }

        public static string GetFolderPath(SpecialFolder folder)
        {
            switch (folder)
            {
                case SpecialFolder.ReferenceAssemblies:
                    return Path.Combine(EnvironmentHelper.ProgramFilesX86, "ReferenceAssemblies");
                case SpecialFolder.NETFrameworkPath:
                    return Path.Combine(EnvironmentHelper.ProgramFilesX86, "ReferenceAssemblies", "Microsoft", "Framework", ".NETFramework");
                default:
                    throw new ArgumentOutOfRangeException(nameof(folder), folder, null);
            }
        }
    }
}