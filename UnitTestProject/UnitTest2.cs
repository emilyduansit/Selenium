﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        [Obsolete]
        public void TestLucky()
        {
            TestTrademe.Pages.PageInit.Homepage.gotolucky();
            TestTrademe.Pages.PageInit.Motor.lucky();
            TestTrademe.Pages.Browser.back();
        }
    }
}
