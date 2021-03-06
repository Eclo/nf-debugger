﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Tools.Debugger
{
    internal class CachedDeviceInfo
    {
        public string TargetName;
        public string PlatformName;
        public int BaudRate;

        public CachedDeviceInfo(
            string targetName,
            string platformName,
            int baudRate = 0)
        {
            TargetName = targetName;
            PlatformName = platformName;
            BaudRate = baudRate;
        }

    }
}
