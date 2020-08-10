using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;



namespace MarsQA_1.Utils
{ 
    [Binding]
    public class Start : Driver
    {
       
        [BeforeScenario]
        public void Setup()
        {            
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            //call the SignIn class
            SignIn.SigninStep();
            //NavigateToProfilePage.Nav();
        }


        //[Test]
        //public void Test1addLanguages()
        //{          
        // LanguagePage.Lang();                
        //}


        //[Test]
        //public void Test2addEduction()
        //{
        // EductaionPage.Edu( College, Deg, Tit, Countr);;
        //}


        //[Test]
        //public void Test3addSkills()
        //{
        // SkillsPage.Ski();
        //}


        [AfterScenario]
        public void TearDown()
        {
            // // Screenshot
            // string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            //test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            // //Close the browser
            // Close();

            // // end test. (Reports)
            // CommonMethods.Extent.EndTest(test);

            // // calling Flush writes everything to the log file (Reports)
            // CommonMethods.Extent.Flush();
            Thread.Sleep(900);
            driver.Quit();
        }

       
    }
}
