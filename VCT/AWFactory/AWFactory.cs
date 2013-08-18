using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VCT.Module;
using VCT.VCTAW;
using VCT.WEB;
using VCT.TELNET;

namespace VCT.AWFactory
{
    /// <summary>
    /// AW 工厂(内部有针对不同控制入口的子工厂)
    /// </summary>
    public class AwFactory
    {
        WEBBaseAw _webAw;

        TELNETBaseAw _telnetAw;

        /// <summary>
        /// 控制入口方式用于控制入口
        /// </summary>
        CtrlType _ctrlType;

        public CtrlType CtrlType
        {
            set {
                _ctrlType = value;
            }
            get { return _ctrlType; }
        }

        /// <summary>
        /// 对于设备的类型选项是必须一开始便初始化完毕的
        /// </summary>
        /// <param name="terminalUserInfo"></param>
        public AwFactory(UserInfo terminalUserInfo)
        {
            DeviceType = terminalUserInfo.DeviceTyp;
        }

        /// <summary>
        /// 产品版本决定AW的版本
        /// </summary>
        DeviceType _deviceType;

        DeviceType DeviceType
        {
            get { return _deviceType; }
            set { _deviceType = value; }
        }

        /// <summary>
        /// WEB AW工厂(含有版本控制)
        /// </summary>
        public WEBBaseAw WEB
        {
            get
            {
                /*这儿是一段版本控制的逻辑处理*/
                if (_webAw == null)
                {
                    if (_deviceType == DeviceType.TEX0)
                        _webAw = new TEX0WEBAw();
                    else if (_deviceType == DeviceType.VCT)
                        _webAw = new WEBBaseAw();
                }
                return _webAw;
            }
        }

        /// <summary>
        /// TELNET AW工厂(含有版本控制)
        /// </summary>
        public TELNETBaseAw TELNET
        {
            get {
                if (_telnetAw == null)
                {
                    if (_deviceType == DeviceType.TEX0)
                        _telnetAw = new TEX0TELNETAw();
                    else if (_deviceType == DeviceType.VCT)
                        _telnetAw = new VCTTELNETAw();
                }
                return _telnetAw;
            }
        }

        /// <summary>
        /// 根据控制方式生成Aw
        /// </summary>
        /// <returns></returns>
        public VctAw AwCreateFactory()
        {
            if (_ctrlType == CtrlType.WEB)
                return WEB;
            else if (_ctrlType == CtrlType.TELNET)
                return TELNET;
            else
                throw new NotImplementedException();
        }

        /// <summary>
        /// 部分操作只能通过TELNET操作实现
        /// 只提供了TELNET的工厂,比如模拟遥控器操作
        /// </summary>
        /// <returns></returns>
        public TELNETBaseAw AwTelnet()
        {
            return TELNET;
        }
    }
}
