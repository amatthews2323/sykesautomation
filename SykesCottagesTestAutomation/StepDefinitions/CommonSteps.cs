using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace SykesCottagesTestAutomation
{
    [Binding]
    public class CommonSteps
    {
        public string baseUrl = SetBaseUrl(Hooks.Environemt);

        public class SharedDriver
        {
            public IWebDriver driver;
        }

        protected SharedDriver shared;

        public CommonSteps(SharedDriver context)
        {
            shared = context;
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
                url = "https://cro.staging.sykescottages.co.uk/";
                return url;
            }
            if (envType == "Project")
            {
                url = "https://project.staging.sykescottages.co.uk/";
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

        public void LaunchBrowser(string domain = "", string path = "")
        {
            if (domain == "")
            {
                domain = baseUrl;
            }

            SelectBrowser(Hooks.Browser); //Select driver

            //Check for experiments
            if (Hooks.Experiments != "")
            {
                shared.driver.Navigate().GoToUrl(domain + path + "/?dev_tools=product"); //Launch website
                shared.driver.Manage().Window.Maximize(); //Maximise browser window
                System.Threading.Thread.Sleep(2000); //Wait for the page to load
                ClickIfDisplayed("Accept All Cookies"); //If pop-up displayed, accept cookies
                
                //Apply experiments
                Click("Dev Tools");
                var primeArray = Hooks.Experiments.Split(",");
                for (int i = 0; i < primeArray.Length; i++)
                {
                    string Experiment = primeArray[i].ToString().Trim();
                    Type("experiment-search", Experiment);
                    System.Threading.Thread.Sleep(1000);
                    shared.driver.FindElement(By.XPath("//li[contains(@data-name,'" + Experiment + "')]")).Click();
                }
                shared.driver.Navigate().Refresh();
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                shared.driver.Navigate().GoToUrl(domain + path); //Launch website
                shared.driver.Manage().Window.Maximize(); //Maximise browser window
                System.Threading.Thread.Sleep(2000); //Wait for the page to load
                ClickIfDisplayed("Accept All Cookies"); //If pop-up displayed, accept cookies
            }
        }

        public void SelectBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers\Chrome");
                    break;
                case "Firefox":
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"Drivers\Firefox", "geckodriver.exe");
                    service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
                    shared.driver = new FirefoxDriver(service);
                    break;
                case "Edge":
                    shared.driver = new EdgeDriver(edgeDriverDirectory: @"Drivers\Edge");
                    break;
                default:
                    shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers\Chrome");
                    break;
            }
        }

        public void ScrollTo(string value)
        {
            string scrollElementIntoMiddle = "var viewPortHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);"
                                           + "var elementTop = arguments[0].getBoundingClientRect().top;"
                                           + "window.scrollBy(0, elementTop-(viewPortHeight/2));";
            ((IJavaScriptExecutor)shared.driver).ExecuteScript(scrollElementIntoMiddle, shared.driver.FindElement(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")));
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")));
            System.Threading.Thread.Sleep(2000);
        }

        public void AssertPageTitle(string title)
        {
            string pageTitle = shared.driver.Title;
            Assert.IsTrue(pageTitle.Contains(title), "Page title '" + pageTitle + "' does not match '" + title + "'");
        }

        public void AssertText(string text)
        {
            Console.WriteLine("Assert the following text is present on the page: " + text);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[contains(text(),'" + text + "')]")).Count != 0);
        }

        public void Click(string value)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")));
            element.Click();
            System.Threading.Thread.Sleep(2000);
        }

        public void ClickIfDisplayed(string value)
        {
            try
            {
                if (shared.driver.FindElement(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")).Displayed)
                {
                    shared.driver.FindElement(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")).Click();
                    System.Threading.Thread.Sleep(2000);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Accept cookies button not found");
            }
        }

        public void MouseOver(string value)
        {
            IWebElement element = shared.driver.FindElement(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]"));
            Actions action = new Actions(shared.driver);
            action.MoveToElement(element).Perform();
            System.Threading.Thread.Sleep(2000);
        }

        public void Type(string value, string text)
        {
            shared.driver.FindElement(By.XPath("//input[@*='" + value + "']|//input[contains(text(),'" + value + "')]")).Clear();
            shared.driver.FindElement(By.XPath("//input[@*='" + value + "']|//input[contains(text(),'" + value + "')]")).SendKeys(text);
        }

        public static Dictionary<string, string> ToDictionary(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }
    }
}
