﻿using NUnit.Framework;
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


        [FindsBy(How = How.CssSelector, Using = "a[href*='search?q=motor'")]
        private IWebElement maplink;

        [Obsolete]
        public void search()
        {

            WebDriverWait wait = new WebDriverWait(Browser.driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href*='motorco']")));        


            Assert.IsTrue(Browser.driver.FindElement(By.CssSelector("a[href*='motorco']")).Displayed);

        }

        [Obsolete]
        public void lucky()
        {
            WebDriverWait wait = new WebDriverWait(Browser.driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href*='motorco']")));


            Assert.IsTrue(Browser.driver.FindElement(By.CssSelector("a[href*='motorco.co.nz']")).Displayed);
        }

        [Obsolete]
        public void map()
        {
            WebDriverWait wait = new WebDriverWait(Browser.driver, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[tabindex='0']")));

            maplink.Click();
            
        }


    }
}
