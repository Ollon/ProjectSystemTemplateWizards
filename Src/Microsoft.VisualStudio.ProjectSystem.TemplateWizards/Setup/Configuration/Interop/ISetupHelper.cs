// ----------------------------------------------------------------------------
//  <copyright file="ISetupHelper.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.Setup.Configuration
{
    /// <summary>Helper functions.</summary>
    [Guid("42B21B78-6192-463E-87BF-D577838F1D5C")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ISetupHelper
    {
        /// <summary>
        ///     Parses a dotted quad version string into a 64-bit unsigned integer.
        /// </summary>
        /// <param name="version">The dotted quad version string to parse, e.g. 1.2.3.4.</param>
        /// <returns>A 64-bit unsigned integer representing the version. You can compare this to other versions.</returns>
        ulong ParseVersion([MarshalAs(UnmanagedType.LPWStr)] [In] string version);

        /// <summary>
        ///     Parses a dotted quad version string into a 64-bit unsigned integer.
        /// </summary>
        /// <param name="versionRange">
        ///     The string containing 1 or 2 dotted quad version strings to parse, e.g. [1.0,) that means
        ///     1.0.0.0 or newer.
        /// </param>
        /// <param name="minVersion">
        ///     A 64-bit unsigned integer representing the minimum version, which may be 0. You can compare
        ///     this to other versions.
        /// </param>
        /// <param name="maxVersion">
        ///     A 64-bit unsigned integer representing the maximum version, which may be MAXULONGLONG. You can
        ///     compare this to other versions.
        /// </param>
        void ParseVersionRange([MarshalAs(UnmanagedType.LPWStr)] [In] string versionRange, [MarshalAs(UnmanagedType.U8)] out ulong minVersion, [MarshalAs(UnmanagedType.U8)] out ulong maxVersion);
    }
}