using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VCT.Module
{
    /// <summary>
    /// 产品控制方式
    /// </summary>
    public enum CtrlType
    {
        /// <summary>
        /// WEB入口
        /// </summary>
        WEB,
        /// <summary>
        /// TELNET入口
        /// </summary>
        TELNET,
        /// <summary>
        /// SSH入口
        /// </summary>
        SSH,
        /// <summary>
        /// HTTP入口
        /// </summary>
        HTTPAPI,
        /// <summary>
        /// HID入口
        /// </summary>
        HID,
        /// <summary>
        /// RC入口
        /// </summary>
        RC,
    }

    /// <summary>
    /// 产品版本类型
    /// </summary>
    public enum DeviceType
    {
        /// <summary>
        /// VCT型号
        /// </summary>
        VCT,
        /// <summary>
        /// TEX0型号
        /// </summary>
        TEX0,
    }
}
