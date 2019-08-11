using BunningAssignment.Common;
using BunningsAssign.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BunningsAssign.Steps
{
    [Binding]
    public sealed class AddingWishListProductSteps
    {
        [Given(@"I Click on Search Button from search Result page")]
        public void GivenIClickOnSearchButtonFromSearchResultPage()
        {
            SearchPage mypage = new SearchPage();
            mypage.ClickSearch();


        }

        [Given(@"I select any random paint from search Result page")]
        public void GivenISelectAnyRandomPaintFromSearchResultPage()
        {
            SearchPage mypage = new SearchPage();
            mypage.SelectPaint();
        }

        [Given(@"I click Add to Wishlist button from product detail page")]
        public void GivenIClickAddToCartButtonFromProductDetailPage()
        {
            ProductDetailPage mypage = new ProductDetailPage();
            mypage.ClickAddWishList();
        
        }

        

        [Then(@"paint should be added in wish list page")]
        public void ThenPaintShouldBeAddedInWishListPage()
        {
            
            WishListPage mypage = new WishListPage();
            mypage.VerifyWIshListItem();

        }

    }
}
