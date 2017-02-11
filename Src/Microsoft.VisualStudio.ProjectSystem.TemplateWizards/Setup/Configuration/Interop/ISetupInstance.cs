// ----------------------------------------------------------------------------
//  <copyright file="ISetupInstance.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Runtime.InteropServices;
using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;

namespace Microsoft.VisualStudio.Setup.Configuration
{
    /// <summary>Information about an instance of a product.</summary>
    /// <remarks>
    ///     You can enumerate all properties of basic types by casting to an
    ///     <see cref="T:Microsoft.VisualStudio.Setup.Configuration.ISetupPropertyStore" />.
    /// </remarks>
    [Guid("B41463C3-8866-43B5-BC33-2B0676F7F42E")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ISetupInstance
    {
        /// <summary>
        ///     Gets the instance identifier (should match the name of the parent instance directory).
        /// </summary>
        /// <returns>The instance identifier.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetInstanceId();

        /// <summary>
        ///     Gets the local date and time when the installation was originally installed.
        /// </summary>
        /// <returns>The local date and time when the installation was originally installed.</returns>
        [return: MarshalAs(UnmanagedType.Struct)]
        FILETIME GetInstallDate();

        /// <summary>
        ///     Gets the unique name of the installation, often indicating the branch and other information used for telemetry.
        /// </summary>
        /// <returns>The unique name of the installation, often indicating the branch and other information used for telemetry.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetInstallationName();

        /// <summary>
        ///     Gets the path to the installation root of the product.
        /// </summary>
        /// <returns>The path to the installation root of the product.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetInstallationPath();

        /// <summary>
        ///     Gets the version of the product installed in this instance.
        /// </summary>
        /// <returns>The version of the product installed in this instance.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetInstallationVersion();

        /// <summary>
        ///     Gets the display name (title) of the product installed in this instance.
        /// </summary>
        /// <param name="lcid">The LCID for the display name.</param>
        /// <returns>The display name (title) of the product installed in this instance.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetDisplayName([MarshalAs(UnmanagedType.U4)] [In] int lcid = 0);

        /// <summary>
        ///     Gets the description of the product installed in this instance.
        /// </summary>
        /// <param name="lcid">The LCID for the description.</param>
        /// <returns>The description of the product installed in this instance.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetDescription([MarshalAs(UnmanagedType.U4)] [In] int lcid = 0);

        /// <summary>
        ///     Resolves the optional relative path to the root path of the instance.
        /// </summary>
        /// <param name="pwszRelativePath">A relative path within the instance to resolve, or NULL to get the root path.</param>
        /// <returns>
        ///     The full path to the optional relative path within the instance. If the relative path is NULL, the root path
        ///     will always terminate in a backslash.
        /// </returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string ResolvePath([MarshalAs(UnmanagedType.LPWStr)] [In] string pwszRelativePath = null);
    }
}