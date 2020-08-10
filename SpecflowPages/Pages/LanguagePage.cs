using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsQA_1
{
    public class LanguagePage
    {

        //adding language
        private static IWebElement AddLanguage => Driver.driver.FindElement(By.XPath("//a[@class='item active'][contains(.,'Languages')]"));
        private static IWebElement ClickAddNew => Driver.driver.FindElement(By.XPath("(//div[@class='ui teal button '][contains(.,'Add New')])[1]"));
        private static IWebElement Language => Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]"));
        private static SelectElement Level => new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@class,'ui dropdown')]")));
        private static IWebElement ClickAdd => Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']"));


        //Updateing language
        private static IWebElement UpdateLanguageButton => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));


        ////validating Laguage add
        private static IWebElement AlertMessageAddLanguage => Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]"));        
        ////Validating the update Language
        private static IWebElement AlertMessageUpdateLanguage => Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]"));
        //validating Laguage delete
        private static IWebElement AlertMessageDeleteLanguage => Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        //Cancelling the alert popup
        private static IWebElement AlertCancelButton => Driver.driver.FindElement(By.XPath("//a[@href='#']"));
        
       


        //ADDING THE LANGUAGE WITH VALID DAT IMPORTED FROM DATA EXCEL FILE
        public static void Lang()
        {
            // Adding Language
            AddLanguage.Click();
            //clickinmg the add new button
            ClickAddNew.Click();
            //Populating and getting the Language Valid data from the Excel
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");
            var languageToAdd = ExcelLibHelper.ReadData(2, "Language");
            //getting the Level Valid data from the Excel
            Language.SendKeys(languageToAdd);
            //ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");
            Level.SelectByText(ExcelLibHelper.ReadData(2, "Level"));
            //click to add language
            ClickAdd.Click();

            //VALIDATING THE DELETE LANGUAGE BY THE ALERT MESSAGE
            //Waiting for appearence and getting the xpath of the Alert message
            Thread.Sleep(900);
            // // Getting and displaying the text of the Alert message on to the output panel (for addition of the education deatils)
            var TAddLanguage = AlertMessageAddLanguage.Text;
            Console.WriteLine(TAddLanguage);

        }


        //UPDATING THE LANGUAGE WITH VALID DAT IMPORTED FROM DATA EXCEL FILE
        public static void NewLang()
        {
            Thread.Sleep(3000);
            //Cancelling Alert of language addition
            AlertCancelButton.Click();
            string languageToAdd = ExcelLibHelper.ReadData(2, "Language");
            var recordsCount = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]")).Count;
            for (int i = 1; i <= recordsCount; i++)
            {
                var recordLanguage = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                IWebElement webElementEditButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i"));

                if (recordLanguage == languageToAdd)
                {

                    webElementEditButton.Click();
                    IWebElement LanguageEditField = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input"));
                    LanguageEditField.Clear();
                    LanguageEditField.SendKeys(ExcelLibHelper.ReadData(3, "Language"));
                    UpdateLanguageButton.Click();
                    break;
                }
            }

            //VALIDATING THE DELETE LANGUAGE BY THE ALERT MESSAGE
            //Waiting for appearence and getting the xpath of the Alert message
            Thread.Sleep(900);
            // Getting and displaying the text of the Alert message on to the output panel (for addition of the education deatils)
            var TupdateLanguage = AlertMessageUpdateLanguage.Text;
            Console.WriteLine(TupdateLanguage);
        }


        //CLEARING THE UPATED DATA
        public static void DeleteNewLanguage()
        {
            Thread.Sleep(5000);
            //Cancelling Alert of language updation
            AlertCancelButton.Click();
            string LanguageToDelete = ExcelLibHelper.ReadData(3, "Language");
            var LanguageFieldRecordCount = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr")).Count;
            for (int i = 1; i <= LanguageFieldRecordCount; i++)
            {
                var LanguageFileText = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                if (LanguageFileText == LanguageToDelete)
                {
                    IWebElement LanguageDeleteButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i"));
                    LanguageDeleteButton.Click();
                    Thread.Sleep(3000);
                    break;
                }
            }
            //VALIDATING THE DELETE LANGUAGE BY THE ALERT MESSAGE
            //Waiting for appearence and getting the xpath of the Alert message
            Thread.Sleep(900);
            // Getting and displaying the text of the Alert message on to the output panel (for addition of the education deatils)
            var TLanguageDelete = AlertMessageDeleteLanguage.Text;
            Console.WriteLine(TLanguageDelete);

        }
    }
}
