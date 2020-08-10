using MarsQA_1.Helpers;
using MongoDB.Driver.Core.WireProtocol.Messages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1
{
    public class SkillsPage
    {
                
           private static IWebElement AddEducation => Driver.driver.FindElement(By.XPath("//a[contains(.,'Skills')]"));
           private static IWebElement ClickAddNew => Driver.driver.FindElement(By.XPath("//div[@class='ui teal button'][contains(.,'Add New')]")); 
           private static IWebElement Skills => Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]"));
           private static SelectElement Level => new SelectElement(Driver.driver.FindElement(By.XPath("//select[contains(@class,'ui fluid dropdown')]")));
           private static IWebElement ClickAdd => Driver.driver.FindElement(By.XPath("//input[contains(@class,'ui teal button ')]"));
           
           // validation for non abolity to add skills  
           private static IWebElement AlertMessage => Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner'][contains(.,'Please enter skill and experience level')]"));
           


        //ADDING SKILLS WITH NULL DATA IMPORTED FROOM DATA EXCEL FILE
        public static void Ski()
        {     
            //clicking add button  
            AddEducation.Click();
            //clicking add new button
            ClickAddNew.Click();
            //Populating and getting the Skill NULL data from the Excel
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Skills");
            Skills.SendKeys(ExcelLibHelper.ReadData(2, "Skills"));
            //Getting the Level NULL data from the Excel
            Level.SelectByText(ExcelLibHelper.ReadData(2, "Level"));
            //Clicking add button
            ClickAdd.Click();

            //Waiting for reading and getting the element of the Alert message
            Thread.Sleep(900);
            //Getting and displaying the text of the Alert message on to the output panel
            var T= AlertMessage.Text;
            Assert.AreEqual(T, "Please enter skill and experience level");
            Console.WriteLine(T);
                      
        }

    }
}
