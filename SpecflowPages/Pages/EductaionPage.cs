using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1
{
    public class EductaionPage
    {   //Adding the education details
        private static IWebElement AddEducation => Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Education')]"));
        private static IWebElement ClickAddNew => Driver.driver.FindElement(By.XPath("(//div[@class='ui teal button '][contains(.,'Add New')])[2]"));
        private static IWebElement CollegeName => Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'College/University Name')]"));
        private static IWebElement Degree => Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Degree')]"));
        private static SelectElement Country => new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@name,'country')]")));
        private static SelectElement Year => new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@name,'yearOfGraduation')]")));
        private static SelectElement Title => new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@name,'title')]")));
        private static IWebElement ClickAdd => Driver.driver.FindElement(By.XPath("//input[contains(@class,'ui teal button ')]"));

        //Validation for education addition
        private static IWebElement AlertMessageAdd => Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner'][contains(.,'Education has been added')]"));

        //Deleting the education details
        private static IWebElement DeleteButton => Driver.driver.FindElement(By.XPath("//i[contains(@class,'remove icon')]"));

        //Validation for education deletion
        private static IWebElement AlertMessageDelete => Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner'][contains(.,'Education entry successfully removed')]"));
        //Cancelling the alert popup
        private static IWebElement AlertCancelButton => Driver.driver.FindElement(By.XPath("//a[@href='#']"));

        //ADDING EDUCATION WITH VALID DATA IMPORTED FROM BDD
        public static void Edu( string College, string Deg, string Countr, string Tit)
        {
                // Clicking the add button
                AddEducation.Click();
                 //clicking the add new button 
                ClickAddNew.Click();
                //Getting the data from the the BDD for the required deatils
                CollegeName.SendKeys(College);
                Degree.SendKeys(Deg);
                Country.SelectByText(Countr);
                Title.SelectByText(Tit);
                Year.SelectByIndex(1);
                 //Clicking the add button
                ClickAdd.Click();
                //Waiting for appearence and getting the xpath of the Alert message
                Thread.Sleep(900);
                 // Getting and displaying the text of the Alert message on to the output panel (for addition of the education deatils)
                 var TAdd= AlertMessageAdd.Text;                
                Console.WriteLine(TAdd); ;

        }


        ////DELETING EDUCATION WITH VALID DATA IMPORTED FROM BDD
        public static void DeleteEdu(string College, string Deg, string Countr, string Tit)
        {
                  Thread.Sleep(1500);
                //Cancelling the alert popup
               AlertCancelButton.Click();


                //Deletion of the added language          
           var UniversityFieldRecordCount = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]")).Count;
                                            
            for(int i = 1; i <= UniversityFieldRecordCount; i++ )
           {
               var UniversityFileText = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]")).Text;
                
                if (UniversityFileText == College )
                {
                   IWebElement EducationDeleteButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody["+ i +"]/tr/td[6]/span[2]/i"));
                                                                                         
                    EducationDeleteButton.Click();
                   Thread.Sleep(3000);
                   break;
               }
           }

            //Waiting for appearence and getting the xpath of the Alert message
            Thread.Sleep(900);
                 // Getting and displaying the text of the Alert message on to the output panel (for deletion of the education deatils)
                  var TDelete = AlertMessageDelete.Text;
                 Console.WriteLine(TDelete); ;
        }

    }
}
