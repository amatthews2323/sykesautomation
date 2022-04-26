using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace SykesCottagesTestAutomation
{
    [Binding]
    public class Hooks : CommonSteps
    {
        public static string Environemt = "Live";   //Set base URL: Tech | Product | Cro | Project | Live
        public static string Browser = "Edge";      //Set browser: Chrome | Firefox | Edge
        public static string Experiments = "";      //Set experiment(s) - comma separated list

        public static string EnableReporting = "Y"; //Turn on Extent Reports
        public static string ReportName = "Random Test";    //Name of the report folder: RegressionSuite | SmokeTest

        public static string AcceptCookies = "Y";   //Dismiss the cookie popup
        public static string DismissPopups = "";    //Dismiss popups, alerts and surveys

        public static string Screenshots = "Y";     //Take a screenshot at the end of each scenario

        public static string BrowserSize = "Tablet";      //Set the browser window size: Max | Desktop | Tablet | Mobile | Custom
        public static int PageWidth = 768;          //Set the browser window width: 768 (iPhone)
        public static int PageHeight = 1024;        //Set the browser window height: 1024 (iPhone)

        public static int TimeOut = 10; //Set pageload timeout

        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        public static string ReportPath;
        private readonly ScenarioContext _scenarioContext;

        public Hooks(SharedDriver context, ScenarioContext scenarioContext) : base(context)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            if (EnableReporting.Contains("Y"))
            {
                //Name of directory
                string reportDir = @"C://AutomatedTestResults//" + DateTime.Now.ToString("yyyy-MM-dd") + "//" + ReportName + "_" + Environemt + "_" + Browser;
                if (BrowserSize != "")
                {
                    reportDir += "_" + BrowserSize;
                }
                // If directory does not exist, create it
                if (!Directory.Exists(reportDir))
                {
                    Directory.CreateDirectory(reportDir);
                }
                //Set report directory
                var htmlReporter = new ExtentHtmlReporter(@reportDir + "//" + ReportName + ".html");
                //Set report theme
                htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                //Set report name
                string ExtentReportName = ReportName + " | Environment: " + Environemt + " | Browser: " + Browser;
                if (Experiments != "")
                {
                    ExtentReportName = ExtentReportName + " | Experiments: " + Experiments;
                }
                if (BrowserSize != "")
                {
                    ExtentReportName = ExtentReportName + " | Size: " + BrowserSize;
                }
                htmlReporter.Config.ReportName = ExtentReportName;
                //Initialise report
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
            }
            else
            {
                Console.WriteLine("Extert Reports not enabled");
            }
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            if (EnableReporting.Contains("Y"))
            {
                featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title); //Create dynamic feature name
            }
        }

        [BeforeScenario]
        public void StartTest()
        {
            if (EnableReporting.Contains("Y"))
            {
                scenario = featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title); //Get scenario name
            }
        }

        [AfterStep]
        public void InsertReportingSteps()
        {
            if (EnableReporting.Contains("Y"))
            {
                var stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

                if (_scenarioContext.TestError == null)
                {
                    if (stepType == "Given")
                        scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                    else if (stepType == "When")
                        scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                    else if (stepType == "Then")
                        scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                    else if (stepType == "And")
                        scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);
                }
                else if (_scenarioContext.TestError != null)
                {
                    var mediaEntity = TakeScreenshot(_scenarioContext.ScenarioInfo.Title.Trim());
                    if (stepType == "Given")
                        scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, mediaEntity);
                    else if (stepType == "When")
                        scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, mediaEntity);
                    else if (stepType == "Then")
                        scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, mediaEntity);
                    else if (stepType == "And")
                        scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, mediaEntity);
                }
            }
        }

        [AfterScenario]
        public void EndTest()
        {
            if (EnableReporting.Contains("Y") & Screenshots.Contains("Y"))
            {
                Screenshot(_scenarioContext.ScenarioInfo.Title.Trim() + " " + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss"));
            }
            shared.driver.Quit();
            shared.driver.Dispose();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
        }

        public MediaEntityModelProvider TakeScreenshot(string Name)
        {
            var screenshot = ((ITakesScreenshot)shared.driver).GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, Name).Build();
        }
    }
}