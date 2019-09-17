using Microsoft.eShopWeb.FunctionalTests.EndToEnd.ViewModels;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.eShopWeb.FunctionalTests.EndToEnd.Pages
{
    public class BasketPage : Page
    {
        private const string rowItemSelector = 
            "div.esh-catalog-items.row > article.esh-basket-items.row";

        public int NumberOfItems =>
            WebDriver.FindElements(By.CssSelector(rowItemSelector)).Count();
 
        public ProductViewModel[] Items => new ProductViewModel[0];
    }
}