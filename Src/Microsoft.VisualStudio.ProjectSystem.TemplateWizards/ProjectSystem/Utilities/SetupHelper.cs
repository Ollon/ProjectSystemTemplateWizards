// ----------------------------------------------------------------------------
//  <copyright file="SetupHelper.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;
using System.IO;
using Microsoft.VisualStudio.Setup.Configuration;

namespace Microsoft.VisualStudio.ProjectSystem.Utilities
{
    public static class SetupHelper
    {
        public static string VSVersionString
        {
            get
            {
                return $"{InstallVersion.Major}.{InstallVersion.Minor}";
            }
        }
        public static Version InstallVersion
        {
            get
            {
                return Version.Parse(InstallVersionString);
            }
        }
        public static string InstallVersionString
        {
            get
            {
                SetupInstance instance = SetupEnvironment.GetSetupInstance();
                return instance.InstallationVersion;

            }
        }
        public static string InstallPath
        {
            get
            {
                SetupInstance instance = SetupEnvironment.GetSetupInstance();
                return instance.InstallationPath;
            }
        }

        public static string PrivateAssembliesPath
        {
            get
            {
                return Path.Combine(InstallPath, "Common7", "IDE", "PrivateAssemblies");
            }
        }

        public static string PublicAssembliesPath
        {
            get
            {
                return Path.Combine(InstallPath, "Common7", "IDE", "PublicAssemblies");
            }
        }

        public static string MSBuildBinPath
        {
            get
            {
                return Path.Combine(InstallPath, "MSBuild", VSVersionString, "Bin");
            }
        }

        public static string IDEPath
        {
            get
            {
                return Path.Combine(InstallPath, "Common7", "IDE");
            }
        }
    }
}