using System;
using System.Configuration;
using System.Threading;
using JupiterAssessment.CompnentHelper;
using JupiterAssessment.Configuration;
using JupiterAssessment.Interfaces;
using JupiterAssessment.Settings;
using JupiterAssessment.TestScript.PageNavigation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace JupiterAssessment
{
    [TestClass]
    public class JupiterAssignmentTest 
    {

        private  TestContext _testContext;


       public TestContext TestContext

        {
            get { return _testContext; }
            set { _testContext = value; }
        }



        [TestMethod]

         [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\..\DataFiles\Testing1.csv", "Testing1#csv", DataAccessMethod.Sequential)]
        // [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"F:\Vishal\ChromeDriverC#\JupiterAssessment\JupiterAssessment\DataFiles\Testing1.csv", "Testing1#csv", DataAccessMethod.Sequential)]
        [Description("Validate that Error Messages are gone")]
        public void TestCase1()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("Contact"));
            ButtonHelper.ClickButton(By.XPath("//a[contains(text(),'Submit')]"));
            IWebElement AlertFailure = ObjectRepository.Driver.FindElement(By.XPath("//div[@class='alert alert-error ng-scope']"));
            Assert.AreEqual(true, AlertFailure.Displayed);
            // TextBoxHelper.TypeInTextBox(By.XPath("//input[@id='forename']"), "Tester");
            TextBoxHelper.TypeInTextBox(By.XPath("//input[@id='forename']"), TestContext.DataRow["FirstName"].ToString());
            Thread.Sleep(2000);
            TextBoxHelper.TypeInTextBox(By.XPath("//input[@id='email']"), TestContext.DataRow["Email"].ToString());
            TextBoxHelper.TypeInTextBox(By.XPath("//textarea[@id='message']"),TestContext.DataRow["Description"].ToString());
            ButtonHelper.ClickButton(By.XPath("//a[contains(text(),'Submit')]"));
            IWebElement ValiationIsNot = ObjectRepository.Driver.FindElement(By.XPath("//div[@class='alert alert-info ng-scope']"));
            Assert.AreEqual(true,ValiationIsNot.Displayed);
            
        }



        [TestMethod]
        [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=F:\Vishal\ChromeDriverC#\JupiterAssessment\JupiterAssessment\DataFiles\ExcelData.xlsx;","TestExcelData$", DataAccessMethod.Sequential)]
        [Description("Validate Successful submissions message")]
        public void TestCase2()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("Contact"));
            TextBoxHelper.TypeInTextBox(By.XPath("//input[@id='forename']"), TestContext.DataRow["FirstName"].ToString());
            TextBoxHelper.TypeInTextBox(By.XPath("//input[@id='email']"), TestContext.DataRow["Email"].ToString());
            TextBoxHelper.TypeInTextBox(By.XPath("//textarea[@id='message']"), TestContext.DataRow["Description"].ToString());
            ButtonHelper.ClickButton(By.XPath("//a[contains(text(),'Submit')]"));
            IWebElement AlertSuccess = ObjectRepository.Driver.FindElement(By.XPath("//div[@class='alert alert-success']"));
            Assert.AreEqual(true, AlertSuccess.Displayed);
        }

        [TestMethod]
        [Description("Validate Errors")]
        public void TestCase3()
            {
                NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
                LinkHelper.ClickLink(By.LinkText("Contact"));
                TextBoxHelper.TypeInTextBox(By.XPath("//input[@id='forename']"), "Tester");
                TextBoxHelper.TypeInTextBox(By.XPath("//input[@id='email']"), "Test@test");
                IWebElement EmailValidation = ObjectRepository.Driver.FindElement(By.XPath("//span[@id='email-err']"));
                Assert.AreEqual(true, EmailValidation.Displayed);
            }

        [TestMethod]
        [Description("Verify Items in the Cart")]
        public void TestCase4()
        {


                 NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
                 LinkHelper.ClickLink(By.LinkText("Shop"));
                 ButtonHelper.ClickButton(By.XPath("//li[@id='product-6']//a[@class='btn btn-success']"));
                 ButtonHelper.ClickButton(By.XPath("//li[@id='product-6']//a[@class='btn btn-success']"));
                 ButtonHelper.ClickButton(By.XPath("//li[@id='product-4']//a[@class='btn btn-success']"));
                 ButtonHelper.ClickButton(By.PartialLinkText("Cart"));
          
            string Total = ObjectRepository.Driver.FindElement(By.XPath("//strong[contains(text(),'Total: 31.97')]")).Text;
            Assert.AreEqual("Total: 31.97", Total);
           
        }


      //  [TestMethod]
        [Description("Verify Items in the Cart")]
        public void LogIntoPdx()
        {


            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

            LoginPage Lp = new LoginPage(ObjectRepository.Driver);
            Lp.InternalLogin();
           
      

        }


    }
}
