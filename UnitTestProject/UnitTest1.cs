﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing.Printing;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [System.Obsolete]
        public void TestMotor()
        {
            TestTrademe.Pages.PageInit.Homepage.gotomotor();
            TestTrademe.Pages.PageInit.Motor.search();   
            TestTrademe.Pages.Browser.back();
        }
    }
}
