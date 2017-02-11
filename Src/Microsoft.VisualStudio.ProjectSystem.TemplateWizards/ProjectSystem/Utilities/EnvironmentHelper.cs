using System;

namespace Microsoft.VisualStudio.ProjectSystem.Utilities
{
    public static class EnvironmentHelper
    {
        public static string ProgramFilesX86
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            }
        }
    }
}