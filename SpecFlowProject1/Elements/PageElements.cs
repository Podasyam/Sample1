using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestCatalogue.Steps
{
    [Binding]
    public class PageElements
    {

        public IWebDriver driver;
        

        public PageElements(IWebDriver driver)
        {
            this.driver = driver;

        }
        public IWebElement FindElement(string locator, int timeoutSeconds)// Wait the element is available in a certain interval of time
        {
            //FluentWait Declaration           
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(timeoutSeconds),
                PollingInterval = TimeSpan.FromSeconds(5)
            };
            return fluentWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));                
        }


  

        public IWebElement SignOnTextbox
        {
            get
            {
                string _Xpath = "//*[@id='identifierInput']";
                FindElement(_Xpath, 50);
                IWebElement _signontxtbox = driver.FindElement(By.Id("identifierInput"));
                return _signontxtbox;
            }
        }
        public IWebElement SignOnButton
        {
            get
            {
                string _Xpath = "//*[@id='postButton']";
                FindElement(_Xpath, 50);
                IWebElement _signonbtn = driver.FindElement(By.Id("postButton"));
                return _signonbtn;
            }
        }

        public IWebElement AllowButton
        {
            get
            {
                string _Xpath = "//*[@id='allowButton']";
                FindElement(_Xpath, 50);
                IWebElement _allownbtn = driver.FindElement(By.Id("allowButton"));
                return _allownbtn;
            }
        }

        public IWebElement ContinueButton
        {
            get
            {
                string _Xpath = "//*[@id='idSIButton9']";
                FindElement(_Xpath, 50);
                IWebElement _continuebtn = driver.FindElement(By.Id("idSIButton9"));
                return _continuebtn;
            }
        }

        public IWebElement UserNameTextbox
        {
            get
            {
                string _Xpath = "//input[@name='username']";
                FindElement(_Xpath, 50);
                IWebElement _usernametxtbox = driver.FindElement(By.XPath(_Xpath));                
                return _usernametxtbox;
            }
        }
      
        public IWebElement LoginButton
        {
            get
            {
                string _Xpath = "//button[@title='Login']";
                FindElement(_Xpath, 20);
                IWebElement _loginbutton = driver.FindElement(By.XPath(_Xpath));               
                return _loginbutton;
            }
        }
        public IWebElement SelectCompanyListBox
        {
            get
            {
                string _Xpath = "/html/body/app-root/testcatalogue-landing-page/p-dialog/div/div/div[2]/p-dropdown/div/span";
                FindElement(_Xpath, 20);
                IWebElement _selectcompany = driver.FindElement(By.XPath(_Xpath));               
                return _selectcompany;
            }
        }
        public IWebElement CompanyNameListBox
        {
            get
            {
                string _Xpath = "//*[@id='pr_id_4_label']";
                FindElement(_Xpath, 3);
                IWebElement _admintab = driver.FindElement(By.Id(_Xpath));                
                return _admintab;
            }
        }

        public IWebElement TestConfigurationTab
        {
            get
            {
                string _Xpath = "//span[normalize-space()='Test Configurations']";
                FindElement(_Xpath, 3);
                IWebElement _testconfigtab = driver.FindElement(By.XPath(_Xpath));
                return _testconfigtab;
            }
        }
        public IWebElement TestCompanyNameListBox
        {
            get
            {
                string _Xpath = "//input[@id='companyName']";
                FindElement(_Xpath, 3);
                IWebElement _selecttesttype = driver.FindElement(By.XPath("//input[@id='companyName']"));
                return _selecttesttype;
            }
        }

        public IWebElement TestManagementTab
        {
            get
            {
                string _Xpath = "//span[normalize-space()='Test Management']";
                FindElement(_Xpath, 3);
                IWebElement _testconfigtab = driver.FindElement(By.XPath("//span[normalize-space()='Test Management']"));
                return _testconfigtab;
            }
        }

        public IWebElement LinkedTestsFilterText
        {
            get
            {
                string _Xpath = "//th[7]//input[@id='VRC_SetupOverview_txtFilterType_1']";
                FindElement(_Xpath, 10);
                IWebElement _testconfigtab = driver.FindElement(By.XPath("//th[7]//input[@id='VRC_SetupOverview_txtFilterType_1']"));
                return _testconfigtab;
            }
        }
        public IWebElement AddButton
        {
            get
            {
                
                string _Xpath = "//button[normalize-space()='Add']";
                FindElement(_Xpath, 30);
                IWebElement _addbutton = driver.FindElement(By.XPath("//button[normalize-space()='Add']"));
                return _addbutton;
            }
        }

        public IWebElement NextButton
        {
            get
            {
                
                string _Xpath = "//button[@id='Viracor_AddTest_Next']";
                FindElement(_Xpath, 10);
                IWebElement _nextbutton = driver.FindElement(By.XPath("//button[@id='Viracor_AddTest_Next']"));
                return _nextbutton;
            }
        }

        public IWebElement TestNameTextBox
        {
            get
            {
                System.Threading.Thread.Sleep(10000);
                string _Xpath = "//input[@placeholder='Test Name']";
                FindElement(_Xpath, 3);
                IWebElement _testconfigtab = driver.FindElement(By.XPath("//input[@placeholder='Test Name']"));
                return _testconfigtab;
            }
        }
        public IWebElement TestCodeTextBox
        {
            get
            {
                string _Xpath = "//input[@placeholder='Test Code']";
                FindElement(_Xpath, 3);
                IWebElement _testconfigtab = driver.FindElement(By.XPath("//input[@placeholder='Test Code']"));
                return _testconfigtab;
            }
        }

        public IWebElement TestMethodTextBox
        {
            get
            {
                string _Xpath = "//input[@placeholder='Method Details']";
                FindElement(_Xpath, 3);
                IWebElement _testconfigtab = driver.FindElement(By.XPath("//input[@placeholder='Method Details']"));
                return _testconfigtab;
            }
        }
        public IWebElement TestNextButton
        {
            get
            {
                string _Xpath = "//div[@class='position-absolute']//span[1]//button[contains(text(), 'Next ')]";
                FindElement(_Xpath, 3);
                IWebElement _webelement = driver.FindElement(By.XPath("//div[@class='position-absolute']//span[1]//button[contains(text(), 'Next ')]"));
                return _webelement;
            }
        }

        public IWebElement TestDetailsSaveButton
        {
            get
            {
                string _Xpath = "//button[@id='addStorage' and contains(text(), 'Save ')]";
                FindElement(_Xpath, 10);
                IWebElement _webelement = driver.FindElement(By.XPath("//button[@id='addStorage' and contains(text(), 'Save ')]"));
                return _webelement;
            }
        }
        public IWebElement SpecimentAddButton
        {
            get
            {
                string _Xpath = "//button[@id='addStorage' and contains(text(), 'Add ')]";
                FindElement(_Xpath, 10);
                IWebElement _webelement = driver.FindElement(By.XPath("//button[@id='addStorage' and contains(text(), 'Add ')]"));
                return _webelement;
            }
        }
        public IWebElement SpecimentTypeList
        {
            get
            {
                string _Xpath = "//textbox-field/div/span[ ' * ']/../../div[contains(text(), 'Specimen Type')]/../p-dropdown[@optionlabel='label']";
                FindElement(_Xpath, 30);
                IWebElement _webelement = driver.FindElement(By.XPath("//textbox-field/div/span[ ' * ']/../../div[contains(text(), 'Specimen Type')]/../p-dropdown[@optionlabel='label']"));
                return _webelement;
            }
        }

        public IWebElement ShipmentConditionList
        {
            get
            {
                string _Xpath = "//textbox-field/div/span[ ' * ']/../../div[contains(text(), 'Preferred Shipment Condition')]/../p-dropdown[@optionlabel='label']";
                FindElement(_Xpath, 30);
                IWebElement _webelement = driver.FindElement(By.XPath("//textbox-field/div/span[ ' * ']/../../div[contains(text(), 'Preferred Shipment Condition')]/../p-dropdown[@optionlabel='label']"));
                return _webelement;
            }
        }

        public IWebElement SpecimenSaveButton
        {
            get
            {
                string _Xpath = "//*[@id='saveSpecimen']";
                FindElement(_Xpath, 20);
                IWebElement _webelement = driver.FindElement(By.Id("saveSpecimen"));
                return _webelement;
            }
        }

        public IWebElement MainCancelButton
        {
            get
            {
                string _Xpath = "addStorage";
                IWebElement _webelement = driver.FindElement(By.Id(_Xpath));
                return _webelement;
            }
        }

        public IWebElement TestGridStatusListBox
        {
            get
            {
                string _Xpath = "//p-multiselect//div[contains(text(), '1 items selected')]";
                FindElement(_Xpath, 20);
                IWebElement _webelement = driver.FindElement(By.XPath(_Xpath));
                return _webelement;
            }
        }
        public IWebElement TestGridStatusDraft
        {
            get
            {
                string _Xpath = "//p-multiselectitem[1]/li/span[contains(text(),'Draft')]";
                FindElement(_Xpath, 20);
                IWebElement _webelement = driver.FindElement(By.XPath(_Xpath));
                return _webelement;
            }
        }
        public string TestGridRowLabel
        {
            get
            {
                string _Xpath = "//tbody/tr[1]/td[2]";
                FindElement(_Xpath, 20);
                IWebElement _webelement = driver.FindElement(By.XPath(_Xpath));               
                string _elementText = _webelement.Text;
                return _elementText;
            }
        }
        public IWebElement TestGridNameFilter
        {
            get
            {
                string _Xpath = "//th[@id='VRC_TestManagement_btnType_1' and contains(text(), ' Name ')]/../../tr//th[2]//input[@id='VRC_SetupOverview_txtFilterType_1']";                
                IWebElement _webelement = driver.FindElement(By.XPath(_Xpath));
                return _webelement;
            }
        }

        public IWebElement TestGridRow
        {
            get
            {
                string _Xpath = "//tbody/tr[1]/td[2]";
                FindElement(_Xpath, 20);
                IWebElement _webelement = driver.FindElement(By.XPath(_Xpath));                
                return _webelement;
            }
        }
        public IWebElement LabPerformingTab
        {
            get
            {
                string _Xpath = "//span[normalize-space()='Lab Performing']";
                FindElement(_Xpath, 3);
                IWebElement _Labtab = driver.FindElement(By.XPath(_Xpath));
                return _Labtab;
            }
        }
        public IWebElement LabNameTextBox
        {
            get
            {
                System.Threading.Thread.Sleep(10000);
                string _Xpath = "//input[@id='labName']";
                FindElement(_Xpath, 3);
                IWebElement _labnametxtbox = driver.FindElement(By.XPath(_Xpath));
                return _labnametxtbox;
            }
        }
        public IWebElement LabLocationListBox
        {
            get
            {
                System.Threading.Thread.Sleep(10000);
                string _Xpath = "//p-multiselect//div[contains(text(), '--Select Country--')]";
                FindElement(_Xpath, 3);
                IWebElement _lablocationlistbox = driver.FindElement(By.XPath(_Xpath));
                return _lablocationlistbox;
            }
        }

        public IWebElement SelectLabLocationCheckBox
        {
            get
            {
                string _Xpath = "//p-multiselectitem[5]/li/span[contains(text(),'AMERICAN SAMOA')]";
                FindElement(_Xpath, 20);
                IWebElement _webelement = driver.FindElement(By.XPath(_Xpath));
                return _webelement;
            }
        }
        public IWebElement SaveLabButton
        {
            get
            {
                string _Xpath = "saveLabPerforming";
                IWebElement _webelement = driver.FindElement(By.Id(_Xpath));
                return _webelement;
            }
        }
        public string LabGridFirstRowLabel
        {
            get
            {
                string _Xpath = "//tbody/tr[1]/td[1]";
                FindElement(_Xpath, 20);
                IWebElement _webelement = driver.FindElement(By.XPath(_Xpath));
                string _elementText = _webelement.Text;
                return _elementText;
            }
        }
        public IWebElement LabPerformingNameFilter
        {
            get
            {
                string _Xpath = "//th[@id='VRC_TestManagement_btnType_1' and contains(text(), ' Name ')]/../../tr//th[1]//input[@id='VRC_SetupOverview_txtFilterType_1']";
                FindElement(_Xpath, 20);
                IWebElement _webelement = driver.FindElement(By.XPath(_Xpath));                
                return _webelement;
            }
        }
        public IWebElement LabPerformingLocationFilter
        {
            get
            {
                string _Xpath = "//th[@id='VRC_TestManagement_btnType_1' and contains(text(), ' Name ')]/../../tr//th[2]//input[@id='VRC_SetupOverview_txtFilterType_1']";
                FindElement(_Xpath, 20);
                IWebElement _webelement = driver.FindElement(By.XPath(_Xpath));
                return _webelement;
            }
        }
        public IWebElement LabPerformingGridRow
        {
            get
            {
                string _Xpath = "//tbody/tr[1]/td[1]";
                FindElement(_Xpath, 20);
                IWebElement _webelement = driver.FindElement(By.XPath(_Xpath));
                return _webelement;
            }
        }
    }
}
    

