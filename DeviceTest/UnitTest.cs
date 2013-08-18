using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VCT;
using VCT.VCTAW;
using VCT.Module;

namespace DeviceTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Application DeviceIns = new Application( new VctBase(new UserInfo()
            {
                DeviceTyp = DeviceType.TEX0,
                Name = "amdin",
                Pwd = "admin123",
            }));
            DeviceIns.WEB.Login();
            //DeviceIns.WEB.Conf.ScheduleConf("confName");
            DeviceIns.TELNET.TELLogin();
            DeviceIns.TELNET.LoginAction.TELLogin("admin", "admin");
            
            
        }
    }
}
