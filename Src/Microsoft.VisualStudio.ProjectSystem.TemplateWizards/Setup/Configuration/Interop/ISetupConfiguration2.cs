// ----------------------------------------------------------------------------
//  <copyright file="ISetupConfiguration2.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.Setup.Configuration
{
    /// <summary>
    ///     Gets information about product instances set up on the machine.
    /// </summary>
    [Guid("26AAB78C-4A60-49D6-AF3B-3C35BC93365D")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ISetupConfiguration2 : ISetupConfiguration
    {
        /// <summary>Enumerates all completed product instances installed.</summary>
        /// <returns>An enumeration of installed product instances.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        new IEnumSetupInstances EnumInstances();

        /// <summary>Gets the instance for the current process path.</summary>
        /// <returns>The instance for the current process path.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        new ISetupInstance GetInstanceForCurrentProcess();

        /// <summary>Gets the instance for the given path.</summary>
        /// <param name="path">Path used to determine instance</param>
        /// <returns>The instance for the given path.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        new ISetupInstance GetInstanceForPath([MarshalAs(UnmanagedType.LPWStr)] [In] string path);

        /// <summary>Enumerates all product instances.</summary>
        /// <returns>An enumeration of all product instances.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        IEnumSetupInstances EnumAllInstances();
    }
}