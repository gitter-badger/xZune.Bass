﻿// Project: xZune.Bass (https://github.com/higankanshi/xZune.Bass)
// Filename: PointerConfigureType.cs
// Version: 20160215

namespace xZune.Bass.Interop.Core.Flags
{
    /// <summary>
    ///     Some configure type of <see cref="GetConfigPtr" /> and <see cref="SetConfigPtr" />.
    /// </summary>
    public enum PointerConfigureType
    {
        /// <summary>
        ///     "User-Agent" header.
        /// </summary>
        NetAgent = Internal.PointerConfigureType.NetAgent,

        /// <summary>
        ///     Proxy server settings.
        /// </summary>
        NetProxy = Internal.PointerConfigureType.NetProxy,

        IosNotify = Internal.PointerConfigureType.IosNotify
    }
}