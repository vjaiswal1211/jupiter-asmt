using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterAssessment.CompnentHelper
{
   public  class ButtonHelper
   {
        private static IWebElement element;
        public static void ClickButton(By Locator)

        {
            element = GenericHelper.GetElement(Locator);

            element.Click();

        }

    }


}

