using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VCT.AWFactory;
using DsAuto.AW.AOP;
using VCT.Module;

namespace VCT.VCTAW
{
    /// <summary>
    /// 该类是为所有的module提供具体实现细节
    /// </summary>
    public class VctBase
        : PublicModule.IConf,
        PublicModule.IConfCtrl,
        PublicModule.IDeviceConfig,
        PublicModule.ILog,
        PublicModule.ISendAux,

        WEBPublicModule.LoginAction,

        TELNETPublicModule.TELLoginAction
    {
        /// <summary>
        /// 一个AW绑定一个用户(这样子的设计是不是不够细致？)
        /// </summary>
        UserInfo _terminalInfo;

        public UserInfo TerminalInfo 
        {
            get { return _terminalInfo; }
            set { _terminalInfo = value; }
        }

        /// <summary>
        /// AW的入口(与一个用户进行绑定)
        /// </summary>
        /// <param name="terminalInfo"></param>
        public VctBase(UserInfo terminalInfo)
        {
            TerminalInfo = terminalInfo;
            _awFactory = new AwFactory(_terminalInfo);
        }

        /// <summary>
        /// 工厂
        /// </summary>
        AwFactory _awFactory;

        public VctBase()
        {
            _awFactory = new AwFactory(_terminalInfo);
        }

        /// <summary>
        /// VctBase通过CtrlType来控制工厂
        /// </summary>
        public CtrlType _ctrlType
        {
            set
            {
                _awFactory.CtrlType = value;
            }
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 00:50:00", "创建会议")]
        public void ScheduleConf(string confName)
        {
            _awFactory.AwCreateFactory().ScheduleConf(confName);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 00:52:00", "结束会议")]
        public void EndConf(string confName)
        {
            _awFactory.AwCreateFactory().EndConf(confName);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 00:54:00", "延长会议时间")]
        public void ProlongConf(string confName, int minutes)
        {
            _awFactory.AwCreateFactory().ProlongConf(confName, minutes);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:22:00", "加入会议")]
        public void JoinConf(string confName)
        {
            _awFactory.AwCreateFactory().JoinConf(confName);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 00:55:00", "呼叫会场入会")]
        public void CallSite(string siteName)
        {
            _awFactory.AwTelnet().CallSite(siteName);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 00:57:00", "挂断会场")]
        public void HangUp(string siteName)
        {
            _awFactory.AwCreateFactory().HangUp(siteName);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 00:57:00", "申请主席")]
        public void RequestChair(string siteName, string pwd)
        {
            _awFactory.AwCreateFactory().RequestChair(siteName, pwd);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 00:58:00", "释放主席")]
        public void FreeChair(string siteName)
        {
            _awFactory.AwTelnet().FreeChair(siteName);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:03:00", "设置视频源")]
        public void SetVedioSource(string siteName, string srcSiteName)
        {
            _awFactory.AwCreateFactory().SetVedioSource(siteName, srcSiteName);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:06:00", "广播会场")]
        public void BroadCast(string siteName)
        {
            _awFactory.AwCreateFactory().BroadCast(siteName);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:07:00", "取消广播视频源")]
        public void CancelBroadCast(string siteName)
        {
            _awFactory.AwCreateFactory().CancelBroadCast(siteName);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:08:00", "设置多画面的格式")]
        public void SetMultiPic(string siteList, string mulPicFormat)
        {
            _awFactory.AwTelnet().SetMultiPic(siteList, mulPicFormat);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:15:00", "设置设备IP地址")]
        public void NetWork(string ip)
        {
            _awFactory.AwTelnet().NetWork(ip);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:16:00", "设置设备的GK地址与GK服务器的IP")]
        public void Gk(string gkId, string gkIp)
        {
            _awFactory.AwTelnet().Gk(gkId, gkIp);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:17:00", "设置设备的SIP地址与SIP服务器的IP")]
        public void Sip(string sipId, string sipIp)
        {
            _awFactory.AwTelnet().Sip(sipId, sipIp);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:18:00", "是否自动接听呼叫")]
        public void ConfAnswer(bool isAnswer)
        {
            _awFactory.AwCreateFactory().ConfAnswer(isAnswer);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:20:00", "设置音量大小")]
        public void Volume(int volume)
        {
            _awFactory.AwCreateFactory().Volume(volume);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:21:00", "设置光线明暗")]
        public void Light(int light)
        {
            _awFactory.AwCreateFactory().Light(light);
        }

        /// <summary>
        /// 导出设备日志到制定文件夹
        /// </summary>
        /// <param name="filePath"></param>
        [AuthorInfo("创建", "w00196360", "2013/8/16 01:24:00", "导出日志文件")]
        public void GetLog(string filePath)
        {
            _awFactory.AwCreateFactory().GetLog(filePath);
        }

        /// <summary>
        /// 删除日志文件
        /// </summary>
        /// <param name="logNmae"></param>
        [AuthorInfo("创建", "w00196360", "2013/8/16 01:24:00", "删除日志文件")]
        public void DeleteLog(string logNmae)
        {
            _awFactory.AwCreateFactory().DeleteLog(logNmae);
        }

        /// <summary>
        /// 发送辅流
        /// </summary>
        /// <param name="siteName"></param>
        [AuthorInfo("创建", "w00196360", "2013/8/16 01:26:00", "给制定的终端发送辅流")]
        public void SendAux(string siteName)
        {
            _awFactory.AwTelnet().SendAux(siteName);
        }

        /// <summary>
        /// 停止辅流
        /// </summary>
        [AuthorInfo("创建", "w00196360", "2013/8/16 01:27:00", "结束辅流发送")]
        public void StopSendAux()
        {
            _awFactory.AwTelnet().StopSendAux();
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:27:00", "登入")]
        public void Login(string name, string pwd)
        {
            _awFactory.AwCreateFactory().Login(name, pwd);
        }

        [AuthorInfo("创建", "w00196360", "2013/8/16 01:27:00", "登出")]
        public void Logout()
        {
            _awFactory.AwCreateFactory().Logout();
        }

        [AuthorInfo("创建", "w00196360", "2013/8/17 01:27:00", "登入")]
        public void TELLogin(string name, string pwd)
        {
            _awFactory.TELNET.TelnetLogin(name, pwd);
        }

        /// <summary>
        /// TELNET模块的登出操作s
        /// </summary>
        [AuthorInfo("创建", "w00196360", "2013/8/17 01:27:00", "登出")]
        public void TELLogout()
        {
            _awFactory.TELNET.TelnetLogout();
        }

       
    }
}
