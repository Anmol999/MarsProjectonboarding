using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddSkills
    {
        

        [Then(@"I should not be able to add skills details to the profile")]
        public void ThenIShouldNotBeAbleToAddSkillsDetailsToTheProfile()
        {            
            //NEGATIVE SCENARIO WITH NULL DATA IMPORTED FROM THE EXCEL FILE
            SkillsPage.Ski();           
        }
    }
}
