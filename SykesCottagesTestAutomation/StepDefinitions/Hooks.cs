using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using TechTalk.SpecFlow;

namespace SykesCottagesTestAutomation
{
    [Binding]
    public class Hooks : CommonSteps
    {
        public Hooks(SharedDriver context) : base(context)
        {
        }

        readonly string tech = "https://tech.staging.sykescottages.co.uk/";
        readonly string prod = "https://product.staging.sykescottages.co.uk/";
        readonly string cro = "https://cro.staging.sykescottages.co.uk";
        readonly string ma = "https://project.staging.sykescottages.co.uk";

        [BeforeScenario]
        public void StartTest()
        {
            SelectBrowser(BrowserType.Edge); //Set browser: Chrome | Friefox | Edge
            shared.driver.Navigate().GoToUrl(prod); //Launch website: tech | prod | cro | ma
            shared.driver.Manage().Window.Maximize(); //Maximise browser window
            System.Threading.Thread.Sleep(2000); //Wait for the page to load

            //If pop-up displayed, accept cookies
            IWebElement acceptCookiesButton = shared.driver.FindElement(By.XPath("//button[contains(text(),'Accept All Cookies')]"));
            try
            {
                if (acceptCookiesButton.Displayed)
                {
                    acceptCookiesButton.Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Accept cookies button not found");
            }
        }

        [AfterScenario]
        public void EndTest()
        {
            shared.driver.Quit();
            shared.driver.Dispose();
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
    }
}