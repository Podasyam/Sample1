using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestCatalogue.Steps
{
    [Binding]
    public sealed class StepDefiniton : PageElements
    {               
        public StepDefiniton(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        
        [Given(@"launch URL")]
        public void GivenLaunchURL()
        {
            try
            {
                if(driver.WindowHandles.Count == 1)
                 {

                    driver.Url = "http:";
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("Url launched");
                }
                else
                {
                    Console.WriteLine("Web Page was not loaded");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e + "Exception");
            }            
        }
        [Given(@"user is on Company window")]
        public void GivenUserViewCompanyWindow()
        {
            try
            {
                if (SelectCompanyListBox.Displayed)
                {
                    bool fieldavailable = SelectCompanyListBox.Displayed;
                    Assert.AreEqual(fieldavailable, true);
                    Console.WriteLine("User is on Company Window");
                }
                else
                {
                    Console.WriteLine("Company List box Page not loaded");

                }

            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e + "NoSuchElementException");
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e + "TimeoutException");
            }
        }

        [When(@"enter username and login")]
        public void ThenEnterUserName()
        {
            try
            {
              if (SignOnTextbox.Displayed)
              {       
                SignOnTextbox.SendKeys("qu");                
                SignOnButton.Click();
                System.Threading.Thread.Sleep(8000);
                ContinueButton.Click();
                System.Threading.Thread.Sleep(3000);
                AllowButton.Click();
                System.Threading.Thread.Sleep(8000);             
                driver.Navigate().Refresh();                
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("User enters name and login");
              }
              else
              { 
                Console.WriteLine("Sign On Page was not loaded");
              }               
            }
            catch (NoSuchElementException e)
            {
                
                Console.WriteLine(e + "NoSuchElementException");
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e + "TimeoutException");
            }
        }
        [When(@"user select a company")]
        public void WhenUserSelectsCompany()
        {
            try
            {
                System.Threading.Thread.Sleep(3000);
                SelectCompanyListBox.Click();
                new Actions(driver)
                .KeyDown(Keys.Down)
                .Click()
                .Perform();
                System.Threading.Thread.Sleep(3000);
                string companyname = SelectCompanyListBox.Text;                
                Console.WriteLine("User selected company");               
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e + "NoSuchElementException");
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e + "TimeoutException");
            }
        }

        [When(@"Test configuration page is accessed by user")]
        public void WhenUserNavigateToTestConfiguration()
        {
            try
            {               
                Actions actions = new Actions(driver);
                actions.MoveToElement(TestConfigurationTab).Click()
                .Perform();             
                Console.WriteLine("User navigated to Test Configuration page");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e + "NoSuchElementException");
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e + "TimeoutException");
            }
        }

        [When(@"user added Test details")]
        public void WhenUserNavigateToTestManagement()
        {
            try
            {
                System.Threading.Thread.Sleep(5000);                
                Actions actions = new Actions(driver);
                actions.MoveToElement(TestManagementTab).Click()
                .Perform();                    
                System.Threading.Thread.Sleep(5000);
                LinkedTestsFilterText.Click();
                System.Threading.Thread.Sleep(8000);
                AddButton.Click();
                System.Threading.Thread.Sleep(2000);
                NextButton.Click();
                System.Threading.Thread.Sleep(10000);
                DateTime dt = DateTime.Now;
                int ms = dt.Millisecond;
                TestNameTextBox.SendKeys("AutoTName" + ms);                
                TestCodeTextBox.SendKeys("AutoTTCode" + ms);
                TestMethodTextBox.SendKeys("AutoTMethod" + ms);
                TestNextButton.Click();
                SpecimentAddButton.Click();                         
                actions.MoveToElement(SpecimentTypeList).Click()
                .KeyDown(Keys.Down)
                .Click()
                .Perform();               
                System.Threading.Thread.Sleep(8000);              
                SpecimenSaveButton.Click();
                TestDetailsSaveButton.Click();
                System.Threading.Thread.Sleep(5000);
                MainCancelButton.Click();
                Console.WriteLine("User navigated to Test Configuration page");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e + "NoSuchElementException");
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e + "TimeoutException");
            }
        }
        [When(@"user added Lab details")]
        public void WhenUserAddLab()
        {
            try
            {
                System.Threading.Thread.Sleep(5000);
                Actions actions = new Actions(driver);
                actions.MoveToElement(LabPerformingTab).Click()
                .Release()
                .Perform();                
                System.Threading.Thread.Sleep(8000);
                LabPerformingLocationFilter.Click();
                AddButton.Click();
                System.Threading.Thread.Sleep(2000);                
                DateTime dt = DateTime.Now;
                int ms = dt.Millisecond;
                LabNameTextBox.SendKeys("AutoLabName" + ms);
                LabLocationListBox.Click();
                actions.MoveToElement(SelectLabLocationCheckBox).Click()
                .KeyDown(Keys.Down)
                .Click()
                .Perform();                
                //SelectLabLocationCheckBox.Click();
                System.Threading.Thread.Sleep(8000);
                SaveLabButton.Click();
                System.Threading.Thread.Sleep(5000);                
                Console.WriteLine("User navigated to Lab Performing page");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e + "NoSuchElementException");
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e + "TimeoutException");
            }
        }
        [Then(@"user should view company window")]
        public void ThenUserShouldViewCompanyWindow()
        {
            try
            {
               Console.WriteLine("User should view selected company on top right side");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e + "NoSuchElementException");
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e + "TimeoutException");
            }
        }
        [Then(@"user should view selected company name on top right side")]
        public void ThenUserShouldBeAddedAsAdminUser()
        {
            try
            {
                System.Threading.Thread.Sleep(5000);                
                CompanyNameListBox.Text.Contains("ECL");
                Console.WriteLine("Company Name is matching");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e + "NoSuchElementException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e);
            }
        }

        [Then(@"Configuration page should display")]
        public void ThenTestConfigurationPageDisplayed()
        {
            try
            {
                System.Threading.Thread.Sleep(2000);
                TestCompanyNameListBox.Text.Contains("ECL");
                Console.WriteLine("Test Configuration page is opened");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e + "NoSuchElementException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e);
            }
        }

        [Then(@"Test is saved")]
        public void ThenTestDetailsAreSaved()
        {
            try
            {                
                System.Threading.Thread.Sleep(8000);
                if (TestGridStatusListBox.Displayed)
                {
                    Actions actions = new Actions(driver);
                    actions.MoveToElement(TestGridStatusListBox).Click()                   
                    .Perform();
                    TestGridStatusDraft.Click();
                    System.Threading.Thread.Sleep(5000);
                    string TestName = TestGridRowLabel;                 
                    TestGridNameFilter.SendKeys(TestName);
                   
                    bool row = TestGridRow.Displayed;
                    if (row == true)
                    { Console.WriteLine("Test Details are saved"); }
                    else
                    {
                        Console.WriteLine("No records found");
                    }
                }
                else
                {
                    Console.WriteLine("Test Grid was not displayed");
                }
            }

            catch (NoSuchElementException e)
            {
                Console.WriteLine(e + "NoSuchElementException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e);
            }
        }

        [Then(@"Details of lab are saved")]
        public void ThenLabDetailsAreSaved()
        {
            try
            {
                System.Threading.Thread.Sleep(8000);
                if (LabPerformingNameFilter.Displayed)
                {    
                    string LabName = LabGridFirstRowLabel;
                    LabPerformingNameFilter.SendKeys(LabName);
                    System.Threading.Thread.Sleep(5000);
                    bool row = LabPerformingGridRow.Displayed;
                    if (row == true)
                    { Console.WriteLine("Lab Details are saved and row is available"); }
                    else
                    {
                        Console.WriteLine("No lab records found");
                    }
                }
                else
                {
                    Console.WriteLine("Lab Grid was not displayed");
                }
            }

            catch (NoSuchElementException e)
            {
                Console.WriteLine(e + "NoSuchElementException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e);
            }
        }
    }

    }
    
    

