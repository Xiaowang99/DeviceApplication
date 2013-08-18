using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DsAuto.AW.AOP;
using DsAuto.AW.Aw;
using DsAuto.AW;

/// <summary>
/// 本类中主要定义了Vct设备的功能接口(包括WEB,TELNET,SSH等各个入口的功能)
/// 所有的AW必须要从此类继承
/// </summary>
namespace VCT.VCTAW
{
    /// <summary>
    /// 会议类操作
    /// </summary>
    public interface IConf
    {
        [AuthorInfo("创建","w00196360","2013/8/15 00:50:00","创建会议")]
        void ScheduleConf(string confName);

        [AuthorInfo("创建", "w00196360", "2013/8/15 00:52:00", "结束会议")]
        void EndConf(string confName);

        [AuthorInfo("创建", "w00196360", "2013/8/15 00:54:00", "延长会议时间")]
        void ProlongConf(string confName, int minutes);

        [AuthorInfo("创建", "w00196360", "2013/8/15 01:22:00", "加入会议")]
        void JoinConf(string confName);
    }

    /// <summary>
    /// 会议控制类操作
    /// </summary>
    public interface IConfCtrl
    {
        [AuthorInfo("创建", "w00196360", "2013/8/15 00:55:00", "呼叫会场入会")]
        void CallSite(string siteName);

        [AuthorInfo("创建", "w00196360", "2013/8/15 00:57:00", "挂断会场")]
        void HangUp(string siteName);

        [AuthorInfo("创建", "w00196360", "2013/8/15 00:57:00", "申请主席")]
        void RequestChair(string siteName, string pwd);

        [AuthorInfo("创建", "w00196360", "2013/8/15 00:58:00", "释放主席")]
        void FreeChair(string siteName);

        [AuthorInfo("创建", "w00196360", "2013/8/15 01:03:00", "设置视频源")]
        void SetVedioSource(string siteName, string srcSiteName);

        [AuthorInfo("创建", "w00196360", "2013/8/15 01:06:00", "广播会场")]
        void BroadCast(string siteName);

        [AuthorInfo("创建", "w00196360", "2013/8/15 01:07:00", "取消广播视频源")]
        void CancelBroadCast(string siteName);

        [AuthorInfo("创建", "w00196360", "2013/8/15 01:08:00", "设置多画面的格式")]
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
        [AuthorInfo("创建", "w00196360", "2013/8/15 01:15:00", "设置设备IP地址")]
        void NetWork(string ip);

        [AuthorInfo("创建", "w00196360", "2013/8/15 01:16:00", "设置设备的GK地址与GK服务器的IP")]
        void Gk(string gkId, string gkIp);

        [AuthorInfo("创建", "w00196360", "2013/8/15 01:17:00", "设置设备的SIP地址与SIP服务器的IP")]
        void Sip(string sipId, string sipIp);

        [AuthorInfo("创建", "w00196360", "2013/8/15 01:18:00", "是否自动接听呼叫")]
        void ConfAnswer(bool isAnswer);

        [AuthorInfo("创建", "w00196360", "2013/8/15 01:20:00", "设置音量大小")]
        void Volume(int volume);

        [AuthorInfo("创建", "w00196360", "2013/8/15 01:21:00", "设置光线明暗")]
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
        [AuthorInfo("创建", "w00196360", "2013/8/15 01:24:00", "导出日志文件")]
        void GetLog(string filePath);

        /// <summary>
        /// 删除日志文件
        /// </summary>
        /// <param name="logNmae"></param>
        [AuthorInfo("创建", "w00196360", "2013/8/15 01:24:00", "删除日志文件")]
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
        [AuthorInfo("创建", "w00196360", "2013/8/15 01:26:00", "给制定的终端发送辅流")]
        void SendAux(string siteName);

        /// <summary>
        /// 停止辅流
        /// </summary>
        [AuthorInfo("创建", "w00196360", "2013/8/15 01:27:00", "结束辅流发送")]
        void StopSendAux();
    }

    public interface ILoginAction
    {
        void Login(string name, string pwd);

        void Logout();
    }

    /// <summary>
    /// 所有的控制入口都要继承此类
    /// </summary>
    public class VctAw :
        AwBase,
        IConf,
        IConfCtrl,
        IDeviceConfig,
        ILog,
        ISendAux
    {
        #region[IConf 会议类操作]
        public virtual void ScheduleConf(string confName)
        {
            throw new NotImplementedException();
        }
        
        public virtual void EndConf(string confName)
        {
            throw new NotImplementedException();
        }

        public virtual void ProlongConf(string confName, int minutes)
        {
            throw new NotImplementedException();
        }

        public virtual void JoinConf(string confName)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region[IConfCtrl 会议控制类操作]
        public virtual void CallSite(string siteName)
        {
            throw new NotImplementedException();
        }

        public virtual void HangUp(string siteName)
        {
            throw new NotImplementedException();
        }

        public virtual void RequestChair(string siteName, string pwd)
        {
            throw new NotImplementedException();
        }

        public virtual void FreeChair(string siteName)
        {
            throw new NotImplementedException();
        }

        public virtual void SetVedioSource(string siteName, string srcSiteName)
        {
            throw new NotImplementedException();
        }

        public virtual void BroadCast(string siteName)
        {
            throw new NotImplementedException();
        }

        public virtual void CancelBroadCast(string siteName)
        {
            throw new NotImplementedException();
        }

        public virtual void SetMultiPic(string siteList, string mulPicFormat)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region[IDeviceConfig 设备配置类操作]
        public virtual void NetWork(string ip)
        {
            throw new NotImplementedException();
        }

        public virtual void Gk(string gkId, string gkIp)
        {
            throw new NotImplementedException();
        }

        public virtual void Sip(string sipId, string sipIp)
        {
            throw new NotImplementedException();
        }

        public virtual void ConfAnswer(bool isAnswer)
        {
            throw new NotImplementedException();
        }

        public virtual void Volume(int volume)
        {
            throw new NotImplementedException();
        }

        public virtual void Light(int light)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region[ILog 设备日志类操作]
        public virtual void GetLog(string filePath)
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteLog(string logNmae)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region[ISendAux 辅流类操作]
        public virtual void SendAux(string siteName)
        {
            throw new NotImplementedException();
        }

        public virtual void StopSendAux()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region[登陆登出类]
        public virtual void Login(string name, string pwd)
        {
            throw new NotImplementedException();
        }

        public virtual void Logout()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
