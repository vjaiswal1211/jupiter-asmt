using JupiterAssessment.Configuration;
using JupiterAssessment.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterAssessment.BaseClasses
{
    [TestClass]
    public class BaseClass

    {


        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            return option;
        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;

        }

        [AssemblyInitialize]

        public static void InitWebdriver (TestContext tc)

        {
            ObjectRepository.Config = new AppConfigReader();


            switch (ObjectRepository.Config.GetBrowser())

            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

               

            }

            ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut());
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait=(TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeout()));


        }
        [AssemblyCleanup]
        public static void TearDown()

        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();


            }




        }



    }
}
