// ----------------------------------------------------------------------------
//  <copyright file="ISetupErrorState.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.Setup.Configuration
{
    /// <summary>Information about the error state of the instance.</summary>
    [Guid("46DCCD94-A287-476A-851E-DFBC2FFDBC20")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ISetupErrorState
    {
        /// <summary>Gets an array of failed package references.</summary>
        /// <returns>An array of failed package references.</returns>
        [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UNKNOWN)]
        ISetupFailedPackageReference[] GetFailedPackages();

        /// <summary>Gets an array of skipped package references.</summary>
        /// <returns>An array of skipped package references.</returns>
        [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UNKNOWN)]
        ISetupPackageReference[] GetSkippedPackages();
    }
}