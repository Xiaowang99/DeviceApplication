using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VCT.VCTAW;

namespace VCT
{
    /// <summary>
    /// 面向用户的入口
    /// </summary>
    public class Application
    {
        /// <summary>
        /// 入口
        /// </summary>
        public Application(VctBase terminalAw)
        {
            aw = terminalAw;
        }

        /// <summary>
        /// 为所有module提供AW的入口
        /// </summary>
        VctBase aw;

        internal VctBase AW
        {
            get
            {
                if (aw == null)
                    aw = new VctBase();

                return aw;
            }
        }

        /// <summary>
        /// WEB控制入口
        /// </summary>
        WEBPublicModule.Module _web;

        /// <summary>
        /// TELNET控制入口
        /// </summary>
        TELNETPublicModule.Module _telnet;

        /// <summary>
        /// 对外的WEB控制入口
        /// </summary>
        public WEBPublicModule.Module WEB
        {
            get {
                AW._ctrlType = Module.CtrlType.WEB;
                if (_web == null)
                {
                    _web = new WEBPublicModule.Module(AW);
                }
                return _web;
            }
        }

        /// <summary>
        /// 对外的TELNET控制入口
        /// </summary>
        public TELNETPublicModule.Module TELNET
        {
            get
            {
                AW._ctrlType = Module.CtrlType.TELNET;
                if (_telnet == null)
                    _telnet = new TELNETPublicModule.Module(AW);
                return _telnet;
            }

        }
    }
}
