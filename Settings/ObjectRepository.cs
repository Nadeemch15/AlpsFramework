using AlpsFrameWork.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlpsFrameWork.BaseClasses
{
    class ObjectRepository
    {
        public static IWebDriver Driver { get; set; }
        public static IConfig Config{ get; set; }
    }
}
