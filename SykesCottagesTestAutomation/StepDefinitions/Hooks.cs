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

        readonly string url = "https://tech.staging.sykescottages.co.uk/";

        [BeforeScenario]
        public void StartTest()
        {
            //EdgeDriver
            shared.driver = new EdgeDriver(edgeDriverDirectory: @"Drivers\Edge");

            //FirefoxDriver 
            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"Drivers\Firefox", "geckodriver.exe");   
            //service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            //shared.driver = new FirefoxDriver(service);

            //ChromeDriver
            //shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers\Chrome");

            shared.driver.Navigate().GoToUrl(url);

            //Maximise browser window
            shared.driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);

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
    }
}