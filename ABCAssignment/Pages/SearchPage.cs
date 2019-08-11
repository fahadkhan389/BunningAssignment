using BunningAssignment.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunningsAssign.Pages
{
    class SearchPage
    {
        public SearchPage()
        {

            PageFactory.InitElements(PropertiesCollection.driver, this);

        }

        [FindsBy(How = How.XPath, Using = "/html//div[@id='headerMainMenu']/div[@class='header-search']//input[@type='text']")]
        public IWebElement Searchboxtxt { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".search-container_btn-submit [focusable]")]
        public IWebElement SearBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='codified-product-tile__product-image__image--product']")]
        public IWebElement SelectpaintElement { get; set; }


        

        public void Search(string Searchtext)

        {
            Wrapper.FilltextBox(Searchboxtxt, Searchtext);
        }

        public void ClickSearch()

        {
            Wrapper.ClickElement(SearBtn);
        }

        public void SelectPaint()

        {
            Wrapper.ClickElement(SelectpaintElement);
        }
      

    }

}

    

