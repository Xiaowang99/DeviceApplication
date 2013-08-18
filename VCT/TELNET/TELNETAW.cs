using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VCT.VCTAW;

namespace VCT.TELNET
{
    /// <summary>
    /// TELNET AW入口的基类
    /// </summary>
    public class TELNETBaseAw
        : VctAw
    {
        /// <summary>
        /// 【warning】如果基本方法不在VctAw内就会引用不到,这里先试验一下
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        public void TelnetLogin(string name, string pwd) { }

        /// <summary>
        /// 【warning】如果基本方法不在VctAw内就会引用不到,这里先试验一下
        /// </summary>
        public void TelnetLogout() { }
    }

    /// <summary>
    /// TEX0 TELNET AW
    /// </summary>
    public class TEX0TELNETAw
        : TELNETBaseAw
    { }

    /// <summary>
    /// VCT TELNET AW
    /// </summary>
    public class VCTTELNETAw
        : TELNETBaseAw
    { }
}
