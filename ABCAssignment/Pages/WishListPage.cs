using BunningAssignment.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunningsAssign.Pages
{
    class WishListPage
    {
        public WishListPage()
        {

            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//a[@href='javascript:window.print();']")]
        public IWebElement VerifyItem { get; set; }




        public void VerifyWIshListItem()

        {

            Assert.IsTrue(Wrapper.IsElementPresent(VerifyItem));

        }
    }

}

