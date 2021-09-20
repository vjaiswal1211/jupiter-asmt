using JupiterAssessment.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterAssessment.CompnentHelper
{
   public class NavigationHelper
    {
        public static void NavigateToUrl(String Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);

        }

    }
}
