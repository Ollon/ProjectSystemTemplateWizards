// ----------------------------------------------------------------------------
//  <copyright file="InstanceState.cs" company="Ollon, LLC">
//      Copyright © 2017 Ollon, LLC. All Rights Reserved.
//  </copyright>
// ----------------------------------------------------------------------------

using System;

namespace Microsoft.VisualStudio.Setup.Configuration
{
    /// <summary>
    ///     The state of an <see cref="T:Microsoft.VisualStudio.Setup.Configuration.ISetupInstance2" />.
    /// </summary>
    [Flags]
    public enum InstanceState : uint
    {
        None = 0,

        Local = 1,

        Registered = 2,

        NoRebootRequired = 4,

        NoErrors = 8,

        Complete = 4294967295
    }
}