using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrademe.Pages
{
    public class Car
    {

        [FindsBy(How = How.CssSelector, Using = "a[tabindex='0']")]
        private IWebElement maplink;

        public void assermaplink()
        {

            Assert.IsTrue(Browser.driver.FindElement(By.CssSelector("a[tabindex='0']")).Displayed);
        }

    }
}
