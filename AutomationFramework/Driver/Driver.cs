
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.IE;

namespace AcmUITest.Pages
{
    public class Driver
    {
        #region Constructors

       
        #endregion

        public static IWebDriver myDriver;




        #region Components
        public static int ProcessID { get; set; }
        #endregion

        #region Methods

        public static IWebDriver Initialize()
        {
            InternetExplorerOptions IEcaps = new InternetExplorerOptions();
            IEcaps.IgnoreZoomLevel = true;
            IEcaps.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            myDriver = new InternetExplorerDriver(IEcaps);
            myDriver.Manage().Window.Maximize();


            return myDriver;
            
        }

        public static void Close()
        {
            myDriver.Close();
            myDriver.Quit();
        }


       


        #endregion

        #region Validations

        #endregion


    }
}
