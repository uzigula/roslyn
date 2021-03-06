﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.Shell.Interop
{
    // TODO: Remove this definition of IComWrapper and use the one from the VSSDK
    // (Microsoft.VisualStudio.Shell.Interop.14.0.DesignTime) when it is available.
    [ComImport]
    [Guid("CBD71F2C-6BC5-4932-B851-B93EB3151386")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IComWrapper
    {
        IntPtr GCHandlePtr { get; }
    }
}
