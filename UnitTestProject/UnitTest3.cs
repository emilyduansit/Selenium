﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        [Obsolete]
        public void TestImageKey()
        {
            TestTrademe.Pages.PageInit.Homepage.gotomotor();
            TestTrademe.Pages.PageInit.Motor.map();
            TestTrademe.Pages.PageInit.Car.assermaplink();
            TestTrademe.Pages.Browser.close();
        }
    }
}
