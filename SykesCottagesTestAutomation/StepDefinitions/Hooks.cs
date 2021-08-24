using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SykesCottagesTestAutomation
{
    [Binding]
    public class Hooks : CommonSteps
    {
        readonly string url = "https://tech.staging.sykescottages.co.uk/";
        //public IWebDriver driver;

        public Hooks(SharedDriver context) : base(context)
        {
        }

        [BeforeScenario]
        public void StartTest()
        {
            //driver = new FirefoxDriver
            shared.driver = new ChromeDriver(@"C:\Users\gary.smith\AppData\Roaming\Microsoft\Windows\Start Menu\Programs")
            {
                Url = url
            };

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