using System;
using System.Linq;
using BunningAssignment.Common;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using System.Net;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Configuration;
using System.Threading;

namespace BunningAssignment.Steps
{
    [Binding]
    public sealed class CommonSteps
    {
        string SearchPageURL = System.Configuration.ConfigurationManager.AppSettings["SearchPageURL"];

        string WishListURL = System.Configuration.ConfigurationManager.AppSettings["WishListURL"];

        [Given(@"I am on search page")]
        public void GivenSearchResultPage()
        {

            PropertiesCollection.driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromMilliseconds(60);

            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl(SearchPageURL);
      
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        [When(@"i go to wishlistpage")]
        public void WhenIGoToWishlistpage()
        {
            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl(WishListURL);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


    }

}

