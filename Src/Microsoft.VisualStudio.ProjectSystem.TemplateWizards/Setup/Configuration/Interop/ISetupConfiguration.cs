// ----------------------------------------------------------------------------
//  <copyright file="ISetupConfiguration.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.Setup.Configuration
{
    /// <summary>
    ///     Gets information about product instances set up on the machine.
    /// </summary>
    [Guid("42843719-DB4C-46C2-8E7C-64F1816EFD5B")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ISetupConfiguration
    {
        /// <summary>Enumerates all product instances installed.</summary>
        /// <returns>An enumeration of installed product instances.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        IEnumSetupInstances EnumInstances();

        /// <summary>Gets the instance for the current process path.</summary>
        /// <returns>The instance for the current process path.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        ISetupInstance GetInstanceForCurrentProcess();

        /// <summary>Gets the instance for the given path.</summary>
        /// <param name="path">Path used to determine instance</param>
        /// <returns>The instance for the given path.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        ISetupInstance GetInstanceForPath([MarshalAs(UnmanagedType.LPWStr)] [In] string path);
    }
}