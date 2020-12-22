using System;
using AlpsFrameWork.BaseClasses;
using AlpsFrameWork.Configuration;
using AlpsFrameWork.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlpsFrameWork
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           // IConfig config = new AppConfigReader();
           ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
        }

    }
}
