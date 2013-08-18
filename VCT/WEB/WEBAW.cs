using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VCT.VCTAW;
using DsAuto.AW.AOP;

namespace VCT.WEB
{
    /// <summary>
    /// 如果你不想重载那个方法,那么在使用的时候将会抛notImplementException的异常
    /// </summary>
    public class WEBBaseAw
        : VctAw
    {
        /// <summary>
        /// 【warning】如果基本方法不在VctAw内就会引用不到,这里先试验一下
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        [AuthorInfo("创建", "w00196360", "2013/8/15 00:50:00", "WEB登陆操作")]
        public override void Login(string name, string pwd)
        { }

        /// <summary>
        /// 【warning】如果基本方法不在VctAw内就会引用不到,这里先试验一下
        /// </summary>
        [AuthorInfo("创建", "w00196360", "2013/8/15 00:50:00", "WEB登陆操作")]
        public override void Logout()
        { }
    }

    /// <summary>
    /// VCT的WEB AW
    /// </summary>
    public class VCTWEBAw
        : WEBBaseAw
    {
        
    }

    /// <summary>
    /// TEX0的WEB AW
    /// </summary>
    public class TEX0WEBAw
        : WEBBaseAw
    {
 
    }
}
