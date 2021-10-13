﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace SykesCottagesTestAutomation
{
    [Binding]
    public class CommonSteps
    {
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

        public void LaunchWebsite(string domain = "", string path = "")
        {
            //Check for domain override
            if (domain == "")
            {
                domain = SetBaseUrl(Hooks.Environemt);
            }

            SelectBrowser(Hooks.Browser); //Set driver and browser

            //Check for experiments
            if (Hooks.Experiments != "")
            {
                shared.driver.Navigate().GoToUrl(domain + path + "/?dev_tools=product"); //Launch website with Dev Tools activated
                
                //Apply experiments
                Click("Dev Tools");
                var array = Hooks.Experiments.Split(",");
                for (int i = 0; i < array.Length; i++)
                {
                    string Experiment = array[i].ToString().Trim();
                    Type("experiment-search", Experiment);
                    WaitASecond();
                    shared.driver.FindElement(By.XPath("//li[contains(@data-name,'" + Experiment + "')]")).Click();
                }
                shared.driver.Navigate().Refresh();
                WaitASecond(2);
            }
            else
            {
                shared.driver.Navigate().GoToUrl(domain + path); //Launch website
            }
            shared.driver.Manage().Window.Maximize(); //Maximise the browser window
            WaitASecond(2);
            ClickIfDisplayed("Accept All Cookies"); //If the pop-up is displayed, accept cookies
        }

        public void SelectBrowser(string browser)
        {
            //string browser = Environment.GetEnvironmentVariable("browser", EnvironmentVariableTarget.Process);

            switch (browser)
            {
                case "Chrome":
                    shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers\Chrome");
                    //shared.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
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

        public void WaitASecond(int seconds = 1)
        {
            int value = seconds * 1000;
            System.Threading.Thread.Sleep(value);
        }

        public void WaitUntilExists(string value)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")));
        }

        public void WaitUntilVisible(string value)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")));
        }

        public void WaitUntilClickable(string value)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")));
        }

        public void ScrollTo(string value)
        {
            WaitASecond(2);
            string scrollElementIntoMiddle = "var viewPortHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);"
                                           + "var elementTop = arguments[0].getBoundingClientRect().top;"
                                           + "window.scrollBy(0, elementTop-(viewPortHeight/2));";
            ((IJavaScriptExecutor)shared.driver).ExecuteScript(scrollElementIntoMiddle, shared.driver.FindElement(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")));
            WaitASecond(2);
            WaitUntilVisible(value);
        }

        public void AssertPageTitle(string title)
        {
            string pageTitle = shared.driver.Title;
            Assert.IsTrue(pageTitle.Contains(title), "Page title '" + pageTitle + "' does not match '" + title + "'");
        }

        public void AssertText(string text)
        {
            Console.WriteLine("Assert the following text is present on the page: " + text);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[contains(text(),'" + text + "')]")).Count != 0, "Text not found");
        }

        public void AssertElement(string value)
        {
            Console.WriteLine("Assert the following element is present on the page: " + value);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")).Count != 0, "Element not found");
        }

        public void Click(string value)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")));
            element.Click();
            WaitASecond(2);
        }

        public void ClickIfDisplayed(string value)
        {
            try
            {
                if (shared.driver.FindElement(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")).Displayed)
                {
                    shared.driver.FindElement(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]")).Click();
                    WaitASecond(2);
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
            WaitASecond(2);
        }

        public void Type(string value, string text)
        {
            IWebElement element = shared.driver.FindElement(By.XPath("//input[@*='" + value + "']|//input[contains(text(),'" + value + "')]"));
            element.Clear();
            element.SendKeys(text);
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


        public void Screenshot(string title = "")
        {
            //Take the screenshot
            Screenshot image = ((ITakesScreenshot)shared.driver).GetScreenshot();
            //Save the screenshot
            image.SaveAsFile("C://Logs//Screenshot_" + title + ".png", ScreenshotImageFormat.Png);
        }
    }
}
