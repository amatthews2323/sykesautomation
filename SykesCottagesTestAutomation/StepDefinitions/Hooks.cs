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
    public class Hooks : MethodLibrary
    {
        public static string environemt = "Cro"; //Set base URL: Tech | Product | Cro | Project | Live
        public static string browser = "Edge"; //Set browser: Chrome | Firefox | Edge
        public static string domainOverride = ""; //Overrides the test URL

        public static bool screenshots = false; //Take a screenshot at the end of each scenario
        public static bool reporting = false; //Turn on Extent Reports
        public static string reportName = "LYPRegressionSuite"; //Name of the report: LYPRegressionSuite | LYPSmokeTest | TOBSmokeTest | ActiveExperiments | DigitalOnboarding | FormSubmission
        public static string reportDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "//OneDrive - Sykes Cottages Ltd//AutomatedTestResults"; //Location for reports and screenshots

        public static bool acceptCookies = true; //Dismiss the cookie popup
        public static bool dismissPopups = true; //Dismiss popups, alerts and surveys

        public static string browserSize = "Fullscreen"; //Set the browser window size: Fullscreen | Desktop | Tablet | Mobile | Custom
        public static int pageWidth = 768; //Set the browser window width: 768 (iPhone)
        public static int pageHeight = 1024; //Set the browser window height: 1024 (iPhone)

        public static string experiments = ""; //Set experiment(s) - comma separated list

        public static int timeOut = 30; //Set pageload timeout

        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        public static string reportPath;
        private readonly ScenarioContext _scenarioContext;

        public Hooks(SharedDriver context, ScenarioContext scenarioContext) : base(context)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //if (EnableReporting.Contains("Y"))
            if (reporting == true)
            {
                //Name of directory
                string reportDir = Hooks.reportDir + "//" + DateTime.Now.ToString("yyyy-MM-dd") + "//" + reportName + "_" + environemt + "_" + browser;
                if (browserSize != "")
                {
                    reportDir += "_" + browserSize;
                }
                Console.WriteLine("Report location: " + Hooks.reportDir);
                // If directory does not exist, create it
                if (!Directory.Exists(reportDir))
                {
                    Directory.CreateDirectory(reportDir);
                }
                //Set report directory
                var htmlReporter = new ExtentHtmlReporter(@reportDir + "//" + reportName + ".html");
                //Set report theme
                htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                //Set report name
                string ExtentReportName = reportName + " | Environment: " + environemt + " | Browser: " + browser;
                if (experiments != "")
                {
                    ExtentReportName = ExtentReportName + " | Experiments: " + experiments;
                }
                if (browserSize != "")
                {
                    ExtentReportName = ExtentReportName + " | Size: " + browserSize;
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
            if (reporting == true)
            {
                featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title); //Create dynamic feature name
            }
        }

        [BeforeScenario]
        public void StartTest()
        {
            if (reporting == true)
            {
                scenario = featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title); //Get scenario name
            }
        }

        [AfterStep]
        public void InsertReportingSteps()
        {
            if (reporting == true)
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
            if (screenshots == true)
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