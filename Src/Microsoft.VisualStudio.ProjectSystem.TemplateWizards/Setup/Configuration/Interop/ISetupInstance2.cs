// ----------------------------------------------------------------------------
//  <copyright file="ISetupInstance2.cs" company="Ollon, LLC">
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
    [Guid("89143C9A-05AF-49B0-B717-72E218A2185C")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ISetupInstance2 : ISetupInstance
    {
        /// <summary>
        ///     Gets the instance identifier (should match the name of the parent instance directory).
        /// </summary>
        /// <returns>The instance identifier.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetInstanceId();

        /// <summary>
        ///     Gets the local date and time when the installation was originally installed.
        /// </summary>
        /// <returns>The local date and time when the installation was originally installed.</returns>
        [return: MarshalAs(UnmanagedType.Struct)]
        new FILETIME GetInstallDate();

        /// <summary>
        ///     Gets the unique name of the installation, often indicating the branch and other information used for telemetry.
        /// </summary>
        /// <returns>The unique name of the installation, often indicating the branch and other information used for telemetry.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetInstallationName();

        /// <summary>
        ///     Gets the path to the installation root of the product.
        /// </summary>
        /// <returns>The path to the installation root of the product.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetInstallationPath();

        /// <summary>
        ///     Gets the version of the product installed in this instance.
        /// </summary>
        /// <returns>The version of the product installed in this instance.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetInstallationVersion();

        /// <summary>
        ///     Gets the display name (title) of the product installed in this instance.
        /// </summary>
        /// <param name="lcid">The LCID for the display name.</param>
        /// <returns>The display name (title) of the product installed in this instance.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetDisplayName([MarshalAs(UnmanagedType.U4)] [In] int lcid = 0);

        /// <summary>
        ///     Gets the description of the product installed in this instance.
        /// </summary>
        /// <param name="lcid">The LCID for the description.</param>
        /// <returns>The description of the product installed in this instance.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetDescription([MarshalAs(UnmanagedType.U4)] [In] int lcid = 0);

        /// <summary>
        ///     Resolves the optional relative path to the root path of the instance.
        /// </summary>
        /// <param name="pwszRelativePath">A relative path within the instance to resolve, or NULL to get the root path.</param>
        /// <returns>
        ///     The full path to the optional relative path within the instance. If the relative path is NULL, the root path
        ///     will always terminate in a backslash.
        /// </returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string ResolvePath([MarshalAs(UnmanagedType.LPWStr)] [In] string pwszRelativePath = null);

        /// <summary>Gets the state of the instance.</summary>
        /// <returns>The state of the instance.</returns>
        [return: MarshalAs(UnmanagedType.U4)]
        InstanceState GetState();

        /// <summary>
        ///     Gets an array of package references registered to the instance.
        /// </summary>
        /// <returns>An array of package references registered to the instance.</returns>
        [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UNKNOWN)]
        ISetupPackageReference[] GetPackages();

        /// <summary>
        ///     Gets a package reference to the product registered to the instance
        /// </summary>
        /// <returns>
        ///     A package reference to the product registered to the instance. This may be null if
        ///     <see cref="M:Microsoft.VisualStudio.Setup.Configuration.ISetupInstance2.GetState" /> does not return
        ///     <see cref="F:Microsoft.VisualStudio.Setup.Configuration.InstanceState.Complete" />.
        /// </returns>
        ISetupPackageReference GetProduct();

        /// <summary>
        ///     Gets the relative path to the product application, if available.
        /// </summary>
        /// <returns>The relative path to the product application, if available.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetProductPath();

        /// <summary>Gets the error state of the instance, if available.</summary>
        /// <returns>The error state of the instance, if available.</returns>
        ISetupErrorState GetErrors();

        /// <summary>
        ///     Gets a value indicating whether the instance can be launched.
        /// </summary>
        /// <returns>Whether the instance can be launched.</returns>
        /// <remarks>
        ///     An instance could have had errors during install but still be launched. Some features may not work correctly, but
        ///     others will.
        /// </remarks>
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool IsLaunchable();

        /// <summary>
        ///     Gets a value indicating whether the instance is complete.
        /// </summary>
        /// <returns>Whether the instance is complete.</returns>
        /// <remarks>
        ///     An instance is complete if it had no errors during install, resume, or repair.
        /// </remarks>
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool IsComplete();

        /// <summary>Gets product-specific properties.</summary>
        /// <returns>
        ///     An <see cref="T:Microsoft.VisualStudio.Setup.Configuration.ISetupPropertyStore" /> of product-specific
        ///     properties, or null if no properties are defined.
        /// </returns>
        ISetupPropertyStore GetProperties();

        /// <summary>
        ///     Gets the directory path to the setup engine that installed the instance.
        /// </summary>
        /// <returns>The directory path to the setup engine that installed the instance.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetEnginePath();
    }
}