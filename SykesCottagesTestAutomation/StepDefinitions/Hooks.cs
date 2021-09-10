using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;

namespace SykesCottagesTestAutomation
{
    [Binding]
    public class Hooks : CommonSteps
    {
        private readonly FeatureContext _featureContext;
        private readonly ScenarioContext _scenarioContext;
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        public static string ReportPath;
        public static string Environemt = "Live"; //Set base URL: Tech | Product | Cro | M&A | Live
        private string baseUrl = SetBaseUrl(Environemt); 

        public Hooks(SharedDriver context, FeatureContext featureContext, ScenarioContext scenarioContext) : base(context)
        {
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //Initialize the Report
            //DateTime now = DateTime.Now;
            var htmlReporter = new ExtentHtmlReporter(@"C:\Logs\ExtentReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            htmlReporter.Config.ReportName = "Automation Test Report";
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void StartTest()
        {
            SelectBrowser(BrowserType.Chrome); //Set browser: Chrome | Firefox | Edge

            shared.driver.Navigate().GoToUrl(baseUrl); //Launch website
            shared.driver.Manage().Window.Maximize(); //Maximise browser window
            System.Threading.Thread.Sleep(2000); //Wait for the page to load
            ClickIfDisplayed("Accept All Cookies"); //If pop-up displayed, accept cookies

            scenario = featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title); //Get scenario name
        }

        [AfterStep]
        public void InsertReportingSteps()
        {
            var stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

            if (_scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                else if(stepType == "When")
                    scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                else if(stepType == "Then")
                    scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                else if(stepType == "And")
                    scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);
            }
            else if (_scenarioContext.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
                else if(stepType == "When")
                    scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
                else if(stepType == "Then")
                    scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
                else if (stepType == "And")
                    scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
            }
        }

        [AfterScenario]
        public void EndTest()
        {
            shared.driver.Quit();
            shared.driver.Dispose();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
        }

        public enum BrowserType
        {
            Chrome,
            Firefox,
            Edge
        }

        internal void SelectBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers\Chrome");
                    break;
                case BrowserType.Firefox:
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"Drivers\Firefox", "geckodriver.exe");   
                    service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
                    shared.driver = new FirefoxDriver(service);
                    break;
                case BrowserType.Edge:
                    shared.driver = new EdgeDriver(edgeDriverDirectory: @"Drivers\Edge");
                    break;
                default:
                    shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers\Chrome");
                    break;
            }
        }

        public static string SetBaseUrl(string envType)
        {
            string url;
            if (envType == "Tech")
            {
                url = "https://tech.staging.sykescottages.co.uk/";
                return url;
            }
            if (envType == "Product")
            {
                url = "https://product.staging.sykescottages.co.uk/";
                return url;
            }
            if (envType == "Cro")
            {
                url = "https://cro.staging.sykescottages.co.uk";
                return url;
            }
            if (envType == "M&A")
            {
                url = "https://project.staging.sykescottages.co.uk";
                return url;
            }
            if (envType == "Live")
            {
                url = "https://www.sykescottages.co.uk/";
                return url;
            }
            url = "https://tech.staging.sykescottages.co.uk/";
            return url;
        }
    }
}