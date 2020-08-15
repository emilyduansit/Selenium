using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing.Printing;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMotor()
        {
            TestTrademe.Pages.PageInit.Homepage.gotomotor();
            TestTrademe.Pages.PageInit.Motor.search();
            TestTrademe.Pages.Browser.close();
        }
    }
}
