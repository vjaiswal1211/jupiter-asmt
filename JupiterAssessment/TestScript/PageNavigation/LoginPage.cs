using JupiterAssessment.BaseClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JupiterAssessment.TestScript.PageNavigation
{
    public class LoginPage : PageBase


       
    {
        private  IWebDriver driver;

        public LoginPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;

        }
        public  void InternalLogin ()
        {

          //  wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//img[@class='imgMicrosoftLogo']")));
           // driver.FindElement(By.XPath("//img[@class='imgMicrosoftLogo']")).Click();



            string Parenthandle = driver.CurrentWindowHandle;

            Console.WriteLine("ParentHandle is    " + Parenthandle);

            System.Collections.ObjectModel.ReadOnlyCollection<string> allhandles = driver.WindowHandles;

            foreach (var handle in allhandles)
            {

                Console.WriteLine(handle);

                Console.WriteLine("handles     >" + allhandles);

                if (handle == (Parenthandle))
                {

                    driver.SwitchTo().Window(handle);

                    try
                    {

                        Thread.Sleep(300);

                    }
                    catch (Exception e)
                    {

                        // TODO Auto-generated catch block

                        throw new Exception("Outer", e);

                    }

                    Console.WriteLine("Focus is shifted");


                  //  wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(" //*[@id=\"i0116\"]")));
                    driver.FindElement(By.XPath(" //*[@id=\"i0116\"]")).Click();

                    Console.WriteLine("Focus is shifted2");

                    driver.FindElement(By.XPath(" //*[@id=\"i0116\"]")).SendKeys("vishal.pdx@pdxuat.wildmouse.com");

                    driver.FindElement(By.XPath(" //*[@id=\"i0116\"]")).SendKeys(Keys.Enter);

                    //*************************************************************************************************************************************//*

                    ReadOnlyCollection<string> allhandles1 = driver.WindowHandles;

                    foreach (var handle1 in allhandles1)
                    {

                        Console.WriteLine(handle1);

                        Console.WriteLine("handles     >" + allhandles1);

                        if (handle1 == (handle))
                        {

                            driver.SwitchTo().Window(handle);

                            try
                            {

                                Thread.Sleep(2000);

                            }
                            catch (Exception e)
                            {

                                // TODO Auto-generated catch block

                                throw new Exception("Outer", e);

                            }

                            Console.WriteLine("Focus is shifted to work or personal account screen");

                            //***************************************************************************************************************************//*

                            ReadOnlyCollection<string> allhandles2 = driver.WindowHandles;

                            foreach (var handle2 in allhandles2)
                            {

                                Console.WriteLine(handle2);

                                Console.WriteLine("handles     >" + allhandles2);

                                if (handle2 == (handle1))
                                {

                                    driver.SwitchTo().Window(handle2);

                                    try
                                    {

                                        Thread.Sleep(1000);

                                    }
                                    catch (Exception e)
                                    {

                                        // TODO Auto-generated catch block


                                        throw new Exception("Outer", e);

                                    }

                                    Console.WriteLine("Focus is shifted to Password screen");
                                   // wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(" //*[@id=\"i0118\"]")));

                                    driver.FindElement(By.XPath(" //*[@id=\"i0118\"]")).Click();

                                    driver.FindElement(By.XPath(" //*[@id=\"i0118\"]")).SendKeys("Coda0256AX");

                                    // driver.findElement(By.xpath(" //*[@id=\"i0118\"]")).sendKeys(GetMFAToken());

                                    driver.FindElement(By.XPath(" //*[@id=\"i0118\"]")).SendKeys(Keys.Enter);

                                    //   *//*********************************************************************************************************************//*

                                }

                                //Stay Signed in

                                ReadOnlyCollection<string> allhandles3 = driver.WindowHandles;

                                foreach (String handle3 in allhandles3)
                                {

                                    Console.WriteLine(handle3);

                                    Console.WriteLine("handles     >" + allhandles3);

                                    if (handle3 == (handle2))
                                    {

                                        driver.SwitchTo().Window(handle3);

                                        try
                                        {

                                            Thread.Sleep(2000);

                                        }
                                        catch (Exception e)
                                        {

                                            // TODO Auto-generated catch block

                                            throw new Exception("Outer", e);

                                        }

                                        Console.WriteLine("Focus is shifted stay signed in screen");

                                        driver.FindElement(By.XPath("//*[@id=\"idSIButton9\"]")).SendKeys(Keys.Enter);


                                        Console.WriteLine("Yes is clicked and the User should be logged in ");

                                        string Parenthandle2 = driver.CurrentWindowHandle;

                                        Console.WriteLine("Parent handle 2 is " + Parenthandle2);

                                        driver.SwitchTo().Window(Parenthandle);

                                        Console.WriteLine("Parent handle is " + Parenthandle);

                                        Console.WriteLine("Focus is shifted to parent handle  and the User is IN");
                                    }

                                    try
                                    {

                                        Thread.Sleep(300);

                                    }
                                    catch (Exception e)
                                    {

                                        // TODO Auto-generated catch block

                                        throw new Exception("Outer", e);

                                    }

                                }
                            }
                        }
                    }
                }
            }

        }


    }
}
