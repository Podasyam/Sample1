using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestCatalogue.Utility
{
    public class ExtentReport
    {

        public static ExtentReports _extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        public static string dir = AppDomain.CurrentDomain.BaseDirectory;
        public static string testResultPath = dir.Replace("bin\\Debug\\netcoreapp3.1", "TestResults");

        public static void ExtentReportInit()
        {
            var htmlReporter = new ExtentHtmlReporter(testResultPath);
            htmlReporter.Config.ReportName = "Automation Status Report";
            htmlReporter.Config.DocumentTitle = "Automation Status Report";
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            htmlReporter.Start();

            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(htmlReporter);
            _extentReports.AddSystemInfo("Instance", "QA");
            _extentReports.AddSystemInfo("Application", "ProjectName");
            _extentReports.AddSystemInfo("Browser", "Chrome");
            _extentReports.AddSystemInfo("OS", "Windows");
           
            _scenario = _extentReports.CreateTest("Testsuite Execution");
        }       

        public string AddScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;            
            string screenshotLocation = Path.Combine(testResultPath, scenarioContext.ScenarioInfo.Title + ".png");
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            var img = screenshot.AsBase64EncodedString;
            //screenshot.SaveAsFile(screenshotLocation);
            //return screenshotLocation;
            return img;
        }

        public static void LogScreenshot(string info, string image)
        {
            if (image != null)
            {
                _scenario.Info(info, MediaEntityBuilder.CreateScreenCaptureFromBase64String(image).Build());
            }
            else 
            {
                Console.WriteLine("Image is not attached");

            }


            
        }
        public static void ExtentReportTearDown()
        {
            _extentReports.Flush();
        }

    }
}
