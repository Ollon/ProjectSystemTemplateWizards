// ----------------------------------------------------------------------------
//  <copyright file="ISetupPropertyStore.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.Setup.Configuration
{
    /// <summary>Provides named properties.</summary>
    /// <remarks>
    ///     You can get this from an <see cref="T:Microsoft.VisualStudio.Setup.Configuration.ISetupInstance" />,
    ///     <see cref="T:Microsoft.VisualStudio.Setup.Configuration.ISetupPackageReference" />, or derivative.
    /// </remarks>
    [Guid("c601c175-a3be-44bc-91f6-4568d230fc83")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ISetupPropertyStore
    {
        /// <summary>
        ///     Gets an array of property names in this property store.
        /// </summary>
        /// <returns>An array of property names in this property store.</returns>
        [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)]
        string[] GetNames();

        /// <summary>
        ///     Gets the value of a named property in this property store.
        /// </summary>
        /// <param name="pwszName">The name of the property to get.</param>
        /// <returns>The value of the property.</returns>
        object GetValue([MarshalAs(UnmanagedType.LPWStr)] [In] string pwszName);
    }
}