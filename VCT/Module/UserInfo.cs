using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VCT.Module
{
    /// <summary>
    /// 设备详细信息
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 用户名
        /// </summary>
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        string pwd;

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }

        /// <summary>
        /// 设备类型(老式：VCT, 新式: TEX0)
        /// </summary>
        DeviceType deviceType;

        public DeviceType DeviceTyp
        {
            get { return deviceType; }
            set { deviceType = value; }
        }

        /// <summary>
        /// 初始化用户信息(默认是VCT用户,admin/admin)
        /// </summary>
        public UserInfo()
        {
            DeviceTyp = DeviceType.VCT;
            Name = "admin";
            Pwd = "admin";
        }
    }
}
