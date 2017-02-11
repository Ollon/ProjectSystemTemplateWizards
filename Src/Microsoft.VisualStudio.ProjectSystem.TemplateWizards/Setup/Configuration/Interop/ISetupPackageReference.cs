// ----------------------------------------------------------------------------
//  <copyright file="ISetupPackageReference.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.Setup.Configuration
{
    /// <summary>A reference to a package.</summary>
    /// <remarks>
    ///     You can enumerate all properties of basic types by casting to an
    ///     <see cref="T:Microsoft.VisualStudio.Setup.Configuration.ISetupPropertyStore" />.
    /// </remarks>
    [Guid("DA8D8A16-B2B6-4487-A2F1-594CCCCD6BF5")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ISetupPackageReference
    {
        /// <summary>Gets the general package identifier.</summary>
        /// <returns>The general package identifier.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetId();

        /// <summary>Gets the version of the package.</summary>
        /// <returns>The version of the package.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetVersion();

        /// <summary>Gets the target process architecture of the package.</summary>
        /// <returns>The target process architecture of the package.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetChip();

        /// <summary>Gets the language and optional region identifier.</summary>
        /// <returns>The language and optional region identifier.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetLanguage();

        /// <summary>Gets the build branch of the package.</summary>
        /// <returns>The build branch of the package.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetBranch();

        /// <summary>Gets the type of the package.</summary>
        /// <returns>The type of the package.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetType();

        /// <summary>
        ///     Gets the unique identifier consisting of all defined tokens.
        /// </summary>
        /// <returns>The unique identifier consisting of all defined tokens.</returns>
        [return: MarshalAs(UnmanagedType.BStr)]
        string GetUniqueId();

        /// <summary>
        ///     Gets a value indicating whether the package refers to an external extension.
        /// </summary>
        /// <returns>A value indicating whether the package refers to an external extension.</returns>
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool GetIsExtension();
    }
}