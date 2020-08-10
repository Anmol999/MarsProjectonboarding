using MarsQA_1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class Login
    {
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            ////launch the browser
            //Initialize();
            //Helpers.ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            ////call the SignIn class
            //SignIn.SigninStep();
        }

        
    }
}
