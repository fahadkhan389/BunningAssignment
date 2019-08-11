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
    public class ProductDetailPage
    {
        public ProductDetailPage()
        {

            PageFactory.InitElements(PropertiesCollection.driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//button[@data-action='add-to-wish-list']")]
        public IWebElement AddwishlistBtn { get; set; }

        public void ClickAddWishList()

        {
            Wrapper.ClickElement(AddwishlistBtn);
        }



    }

}
    
