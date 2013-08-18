using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DsAuto.AW.AOP;

namespace VCT.VCTAW
{
    /// <summary>
    /// 所有控制入口(公共接口)
    /// </summary>
    public class PublicModule
    {
        /// <summary>
        /// 会议类操作
        /// </summary>
        public interface IConf
        {
            [AuthorInfo("创建", "w00196360", "2013/8/16 00:50:00", "创建会议")]
            void ScheduleConf(string confName);

            [AuthorInfo("创建", "w00196360", "2013/8/16 00:52:00", "结束会议")]
            void EndConf(string confName);

            [AuthorInfo("创建", "w00196360", "2013/8/16 00:54:00", "延长会议时间")]
            void ProlongConf(string confName, int minutes);

            [AuthorInfo("创建", "w00196360", "2013/8/16 01:22:00", "加入会议")]
            void JoinConf(string confName);
        }

        /// <summary>
        /// 会议控制类操作
        /// </summary>
        public interface IConfCtrl
        {
            [AuthorInfo("创建", "w00196360", "2013/8/16 00:55:00", "呼叫会场入会")]
            void CallSite(string siteName);

            [AuthorInfo("创建", "w00196360", "2013/8/16 00:57:00", "挂断会场")]
            void HangUp(string siteName);

            [AuthorInfo("创建", "w00196360", "2013/8/16 00:57:00", "申请主席")]
            void RequestChair(string siteName, string pwd);

            [AuthorInfo("创建", "w00196360", "2013/8/16 00:58:00", "释放主席")]
            void FreeChair(string siteName);

            [AuthorInfo("创建", "w00196360", "2013/8/16 01:03:00", "设置视频源")]
            void SetVedioSource(string siteName, string srcSiteName);

            [AuthorInfo("创建", "w00196360", "2013/8/16 01:06:00", "广播会场")]
            void BroadCast(string siteName);

            [AuthorInfo("创建", "w00196360", "2013/8/16 01:07:00", "取消广播视频源")]
            void CancelBroadCast(string siteName);

            [AuthorInfo("创建", "w00196360", "2013/8/16 01:08:00", "设置多画面的格式")]
            void SetMultiPic(string siteList, string mulPicFormat);

        }

        /// <summary>
        /// 设备配置类操作
        /// </summary>
        public interface IDeviceConfig
        {
            /// <summary>
            /// 设置设备IP地址
            /// </summary>
            /// <param name="ip"></param>
            [AuthorInfo("创建", "w00196360", "2013/8/16 01:15:00", "设置设备IP地址")]
            void NetWork(string ip);

            [AuthorInfo("创建", "w00196360", "2013/8/16 01:16:00", "设置设备的GK地址与GK服务器的IP")]
            void Gk(string gkId, string gkIp);

            [AuthorInfo("创建", "w00196360", "2013/8/16 01:17:00", "设置设备的SIP地址与SIP服务器的IP")]
            void Sip(string sipId, string sipIp);

            [AuthorInfo("创建", "w00196360", "2013/8/16 01:18:00", "是否自动接听呼叫")]
            void ConfAnswer(bool isAnswer);

            [AuthorInfo("创建", "w00196360", "2013/8/16 01:20:00", "设置音量大小")]
            void Volume(int volume);

            [AuthorInfo("创建", "w00196360", "2013/8/16 01:21:00", "设置光线明暗")]
            void Light(int light);
        }

        /// <summary>
        /// 设备日志查询类操作
        /// </summary>
        public interface ILog
        {
            /// <summary>
            /// 导出设备日志到制定文件夹
            /// </summary>
            /// <param name="filePath"></param>
            [AuthorInfo("创建", "w00196360", "2013/8/16 01:24:00", "导出日志文件")]
            void GetLog(string filePath);

            /// <summary>
            /// 删除日志文件
            /// </summary>
            /// <param name="logNmae"></param>
            [AuthorInfo("创建", "w00196360", "2013/8/16 01:24:00", "删除日志文件")]
            void DeleteLog(string logNmae);
        }

        /// <summary>
        /// 辅流选项
        /// </summary>
        public interface ISendAux
        {
            /// <summary>
            /// 发送辅流
            /// </summary>
            /// <param name="siteName"></param>
            [AuthorInfo("创建", "w00196360", "2013/8/16 01:26:00", "给制定的终端发送辅流")]
            void SendAux(string siteName);

            /// <summary>
            /// 停止辅流
            /// </summary>
            [AuthorInfo("创建", "w00196360", "2013/8/16 01:27:00", "结束辅流发送")]
            void StopSendAux();
        }

        /// <summary>
        /// 公共接口模块
        /// </summary>
        public class Module
        {
            /// <summary>
            /// 基类的AW(第三层位置处)
            /// 这儿真不想打开public控制层
            /// </summary>
            public VctBase AW;

            public Module(VctBase aw)
            {
                AW = aw;
            }

            /// <summary>
            /// 会议操作模块
            /// </summary>
            public IConf Conf
            {
                get { return AW; }
            }

            /// <summary>
            /// 会议控制模块
            /// </summary>
            public IConfCtrl ConfCtrl
            {
                get { return AW; }
            }

            /// <summary>
            /// 设备配置模块
            /// </summary>
            public IDeviceConfig DeviceConfig
            {
                get { return AW; }
            }

            /// <summary>
            /// 设备日志模块
            /// </summary>
            public ILog Log
            {
                get { return AW; }
            }

            /// <summary>
            /// 辅流操作模块
            /// </summary>
            public ISendAux AuxStream
            {
                get { return AW; }
            }
        }
    }

    public class WEBPublicModule
        : PublicModule
    {
        public interface LoginAction
        {
            void Login(string name, string pwd);

            void Logout();
        }

        public class Module : PublicModule.Module
        {
            public Module(VctBase aw)
                : base(aw)
            { }

            /// <summary>
            /// 登陆(用户名密码在userInfo中指定)
            /// </summary>
            public void Login()
            {
                this.AW.Login(this.AW.TerminalInfo.Name, this.AW.TerminalInfo.Pwd);
            }

            /// <summary>
            /// 登出
            /// </summary>
            public void Logout()
            {
                this.AW.Logout();
            }
        }
    }

    /// <summary>
    /// TELNET模块的对外接口
    /// </summary>
    public class TELNETPublicModule
        : PublicModule
    {
        public interface TELLoginAction
        {
            /// <summary>
            /// TELNET 模块的登陆操作
            /// </summary>
            /// <param name="name"></param>
            /// <param name="pwd"></param>
            void TELLogin(string name, string pwd);

            /// <summary>
            /// TELNET模块的登出操作
            /// </summary>
            void TELLogout();
        }

        /// <summary>
        /// 对面接口
        /// </summary>
        public class Module : PublicModule.Module
        {
            public Module(VctBase aw)
                : base(aw)
            {
                AW = aw;
            }

            /// <summary>
            /// TELNET 模块的登陆操作
            /// </summary>
            /// <param name="name"></param>
            /// <param name="pwd"></param>
            public void TELLogin()
            {
                this.AW.TELLogin( this.AW.TerminalInfo.Name, this.AW.TerminalInfo.Pwd);
            }

            /// <summary>
            /// TELNET模块的登出操作s
            /// </summary>
            public void TELLogout()
            {
                this.AW.TELLogout();
            }

            /// <summary>
            /// 登陆模块
            /// </summary>
            public TELLoginAction LoginAction
            {
                get
                {
                    return this.AW;
                }
            }
        }
    }
}
