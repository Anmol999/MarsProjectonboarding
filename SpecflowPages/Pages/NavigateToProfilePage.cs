using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1
{
    public class NavigateToProfilePage
    {
        public static IWebElement AddProfile => Driver.driver.FindElement(By.XPath("(//a[@class='item'][contains(.,'Profile')])[2]"));
        
        
        public static void Nav()
        {
            
            AddProfile.Click();

        }

    }

}
