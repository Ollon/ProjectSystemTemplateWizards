// ----------------------------------------------------------------------------
//  <copyright file="ISetupFailedPackageReference.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.Setup.Configuration
{
    /// <summary>A reference to a failed package.</summary>
    /// <remarks>
    ///     You can enumerate all properties of basic types by casting to an
    ///     <see cref="T:Microsoft.VisualStudio.Setup.Configuration.ISetupPropertyStore" />.
    /// </remarks>
    [Guid("E73559CD-7003-4022-B134-27DC650B280F")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ISetupFailedPackageReference : ISetupPackageReference
    {
        /// <summary>Gets the general package identifier.</summary>
        /// <returns>The general package identifier.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetId();

        /// <summary>Gets the version of the package.</summary>
        /// <returns>The version of the package.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetVersion();

        /// <summary>Gets the target process architecture of the package.</summary>
        /// <returns>The target process architecture of the package.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetChip();

        /// <summary>Gets the language and optional region identifier.</summary>
        /// <returns>The language and optional region identifier.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetLanguage();

        /// <summary>Gets the build branch of the package.</summary>
        /// <returns>The build branch of the package.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetBranch();

        /// <summary>Gets the type of the package.</summary>
        /// <returns>The type of the package.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetType();

        /// <summary>
        ///     Gets the unique identifier consisting of all defined tokens.
        /// </summary>
        /// <returns>The unique identifier consisting of all defined tokens.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        new string GetUniqueId();

        /// <summary>
        ///     Gets a value indicating whether the package refers to an external extension.
        /// </summary>
        /// <returns>A value indicating whether the package refers to an external extension.</returns>
        [return: MarshalAs(UnmanagedType.VariantBool)]
        new bool GetIsExtension();
    }
}