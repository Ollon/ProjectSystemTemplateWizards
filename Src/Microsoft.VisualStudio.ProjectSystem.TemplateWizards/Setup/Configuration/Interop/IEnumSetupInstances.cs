// ----------------------------------------------------------------------------
//  <copyright file="IEnumSetupInstances.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.Setup.Configuration
{
    /// <summary>
    ///     A enumerator of installed <see cref="T:Microsoft.VisualStudio.Setup.Configuration.ISetupInstance" /> objects.
    /// </summary>
    [Guid("6380BCFF-41D3-4B2E-8B2E-BF8A6810C848")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface IEnumSetupInstances
    {
        /// <summary>
        ///     Retrieves the next set of product instances in the enumeration sequence.
        /// </summary>
        /// <param name="celt">The number of product instances to retrieve.</param>
        /// <param name="rgelt">
        ///     A pointer to an array of <see cref="T:Microsoft.VisualStudio.Setup.Configuration.ISetupInstance" />
        ///     .
        /// </param>
        /// <param name="pceltFetched">
        ///     A pointer to the number of product instances retrieved. If celt is 1 this parameter may be
        ///     NULL.
        /// </param>
        void Next([MarshalAs(UnmanagedType.U4)] [In] int celt, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] [Out] ISetupInstance[] rgelt, [MarshalAs(UnmanagedType.U4)] out int pceltFetched);

        /// <summary>
        ///     Skips the next set of product instances in the enumeration sequence.
        /// </summary>
        /// <param name="celt">The number of product instances to skip.</param>
        void Skip([MarshalAs(UnmanagedType.U4)] [In] int celt);

        /// <summary>Resets the enumeration sequence to the beginning.</summary>
        void Reset();

        /// <summary>
        ///     Creates a new enumeration object in the same state as the current enumeration object: the new object points to the
        ///     same place in the enumeration sequence.
        /// </summary>
        /// <returns>
        ///     A pointer to a pointer to a new
        ///     <see cref="T:Microsoft.VisualStudio.Setup.Configuration.IEnumSetupInstances" /> interface. If the method fails,
        ///     this parameter is undefined.
        /// </returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        IEnumSetupInstances Clone();
    }
}