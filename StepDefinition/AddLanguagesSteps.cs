using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class AddLanguagesDetails
    {
        
        [Then(@"I should be able to add language's details to the profile")]
        public void ThenIShouldBeAbleToAddLanguageSDetailsToTheProfile()
        {
            //ADDING THE LANGUAGE WITH VALID DATA IMPORTED FROM EXCEL
            LanguagePage.Lang();
            
        }

        [Then(@"I Should be able to update language's details to the profile")]
        public void ThenIShouldBeAbleToUpdateLanguageSDetailsToTheProfile()
        {
            //UPDATING THE ADDED LANGUAGEWITH VALID DATA IMPORTED FROM EXCEL 
            //AND DELETING THE UPDATED LANGUAGE
            LanguagePage.NewLang();
            LanguagePage.DeleteNewLanguage();
        }

    }
}
