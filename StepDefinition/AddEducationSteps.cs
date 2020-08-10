using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddEducationSteps
    {
        [Given(@"Seller login to the website")]
        public void GivenSellerLoginToTheWebsite()
        {
            //ScenarioContext.Current.Pending();
        }
        [Given(@"navigate to profile page")]
        public void GivenNavigateToProfilePage()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to add education datails like '(.*)','(.*)','(.*)','(.*)' to the profile")]
        public void ThenIShouldBeAbleToAddEducationDatailsLikeToTheProfile(string College, string Deg, string Tit, string Countr)
        {
            
            EductaionPage.Edu( College, Deg, Tit, Countr);
        }

        [Then(@"I should be able to delete the education details with added '(.*)','(.*)','(.*)','(.*)'")]
        public void ThenIShouldBeAbleToDeleteTheEducationDetailsWithAdded(string College, string Deg, string Tit, string Countr)
        {
            EductaionPage.DeleteEdu(College, Deg, Tit, Countr);
        }       
    }
}
