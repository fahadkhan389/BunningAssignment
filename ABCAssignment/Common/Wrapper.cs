using System;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace BunningAssignment.Common
{
    public class Wrapper
    {


        public static void FilltextBox(IWebElement element, string value)
        {
            element.SendKeys(value);

        }

        public static Boolean IsElementPresent(IWebElement element)

        {
            try
            {
                if (element.Displayed && element.Enabled)
                {
                    return true;
                }
            }

            catch(Exception e) {
                Console.WriteLine(e);
                
            }
            return false;
        }




        public static void ClickElement(IWebElement element)
        {
            element.Click();
            Thread.Sleep(5000);

        }
        
        
    }
}

