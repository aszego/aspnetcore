// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Components
{
    internal static class PlatformInfo
    {
        public static bool IsWebAssembly { get; }

        static PlatformInfo()
        {
            IsWebAssembly = OperatingSystem.IsBrowser();
        }
    }
}
