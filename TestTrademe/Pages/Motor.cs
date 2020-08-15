using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrademe.Pages
{
    public class Motor
    {
        [FindsBy(How = How.CssSelector, Using = "a[href*='motorco']']")]
        private IWebElement motorcolink;



        public void search()
        {

            WebDriverWait wait = new WebDriverWait(Browser.driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href*='motorco']")));        


            Assert.IsTrue(Browser.driver.FindElement(By.CssSelector("a[href*='motorco']")).Displayed);

        }
    }
}
