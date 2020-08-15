using System;
using TechTalk.SpecFlow;

namespace TestTrademe.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"gotohomepage")]
        public void GivenGotohomepage()
        {
            Pages.PageInit.Homepage.gotomotor();
        }
        
        [Given(@"clickmotor")]
        public void GivenClickmotor()
        {
         //   ScenarioContext.Current.Pending();
        }
        
        [When(@"input car name and click search")]
        public void WhenInputCarNameAndClickSearch()
        {
        //    ScenarioContext.Current.Pending();
        }
        
        [Then(@"get search results")]
        public void ThenGetSearchResults()
        {
            Pages.Browser.close();
        }
    }
}
