using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AcmUITest.Pages;

namespace AutomationFramework.TestMethod
{
    [TestClass]
    public class UIValidation
    {
       

            public static IWebDriver myDriver;
                       
            
            #region Initialize

            [TestInitialize]
            public void Setup()
            {
                Driver mySample = new Driver();
                myDriver = Driver.Initialize();
            }

            #endregion Initialize
            [TestMethod]
            
            public void NaviagteToHomePage_ClickToTourButton_EnterEmailAndClickSubmitButton()
            {
            myDriver.Navigate().GoToUrl("http://www.aveasolutions.com/");

            
            }


            //Closing the browser   
            [TestCleanup]
            public void CloseDown()
            {
                myDriver.Close();
                myDriver.Quit();
               
            }
        }
    }

