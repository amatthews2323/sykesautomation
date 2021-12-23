using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Drawing;
using WebDriverManager.DriverConfigs.Impl;

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

        public void SelectBrowser(string browser)
        {
            
            switch (browser)
            {
                case "Chrome":
                    shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers", new ChromeOptions { Proxy = null });
                    //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    
                    //ChromeOptions options = new ChromeOptions();
                    //options.AddArguments("load-extension=/C:/Users/gary.smith/AppData/Local/Google/Chrome/User Data/Default/Extensions/bmhfelbhbkeoldaiphchjibggnoodpcj/0.1.6_0");
                    //shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers", options);
                    break;
                case "Firefox":
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"Drivers", "geckodriver.exe");
                    service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                    shared.driver = new FirefoxDriver(service);
                    break;
                case "Edge":
                    shared.driver = new EdgeDriver(edgeDriverDirectory: @"Drivers");
                    break;
                default:
                    shared.driver = new ChromeDriver(new ChromeOptions { Proxy = null });
                    break;
            }
        }

        public void SetBrowserSize(string viewpoint = "Max", int width = 768, int height = 1024)
        {
            Console.WriteLine("Set browser size to " + viewpoint);
            if (viewpoint.Contains("Max") | viewpoint.Contains(""))
            {
                shared.driver.Manage().Window.Maximize(); //Maximise
            }
            if (viewpoint == "Desktop")
            {
                shared.driver.Manage().Window.Size = new Size(1460, 640); //Laptop dimentions
            }
            if (viewpoint == "Tablet")
            {
                shared.driver.Manage().Window.Size = new Size(768, 1024); //iPad dimensions
            }
            if (viewpoint == "Mobile")
            {
                shared.driver.Manage().Window.Size = new Size(375, 812); //iPhone X dimensions
            }
            if (viewpoint == "Custom")
            {
                shared.driver.Manage().Window.Size = new Size(width, height);
            }
            //shared.driver.Manage().Window.Maximize(); //Maximise by default
        }

        public void LaunchWebsite(string domain = "", string path = "")
        {
            //Check for domain override
            if (domain == "")
            {
                domain = SetBaseUrl(Hooks.Environemt);
            }

            SelectBrowser(Hooks.Browser); //Set the driver and browser
            shared.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30); //Set the timeout to 30 seconds

            //Check for experiments
            if (Hooks.Experiments != "")
            {
                shared.driver.Navigate().GoToUrl(domain + path + "/?dev_tools=product"); //Launch website with Dev Tools activated                                                 
                ApplyExperiment(Hooks.Experiments);
            }
            else
            {
                shared.driver.Navigate().GoToUrl(domain + path); //Launch website
            }
        }

        public void ApplyExperiment(string experimentIds)
        {
            Click("Dev Tools");
            var array = experimentIds.Split(",");
            for (int i = 0; i < array.Length; i++)
            {
                string Experiment = array[i].ToString().Trim();
                Type("experiment-search", Experiment);
                WaitASecond();
                shared.driver.FindElement(By.XPath("//li[contains(@data-name,\"" + Experiment + "\")]")).Click();
            }
            shared.driver.Navigate().Refresh();
            WaitASecond();
            SetBrowserSize(Hooks.BrowserSize, Hooks.PageWidth, Hooks.PageHeight);
        }

        public string XPath(string value1, string value2, string element = "*")
        {
            return "//"+ element +"[@*=\""+ value1 +"\"]|//"+ element +"[contains(text(),\"" + value1 + "\")]|//" + element + "[@*=\"" + value2 + "\"]|//" + element + "[contains(text(),\"" + value2 + "\")]";
        }

        public void WaitASecond(int seconds = 1)
        {
            int value = seconds * 1000;
            System.Threading.Thread.Sleep(value);
        }

        public void WaitUntilExists(string value1, string value2 = "Alternative value")
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(XPath(value1, value2))));
        }

        public void WaitUntilVisible(string value1, string value2 = "Alternative value")
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(XPath(value1, value2))));
        }

        public void WaitUntilClickable(string value1, string value2 = "Alternative value")
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(XPath(value1, value2))));
        }

        public void CloseAllPopups()
        {
            WaitASecond(1);
            //If the pop-up is displayed, accept cookies
            ClickIfDisplayed("Accept All Cookies");
            //Dismiss the tint overlay 
            ClickIfDisplayed("nonenquiry6941");
            //If any alerts are displayed, close them
            try
            {
                if (shared.driver.FindElement(By.XPath("//*[@*=\"close c-alert__close js-alert-close\"]")).Displayed)
                {
                    while (shared.driver.FindElement(By.XPath("//*[@*=\"close c-alert__close js-alert-close\"]")).Displayed)
                    {
                        shared.driver.FindElement(By.XPath("//*[@*=\"close c-alert__close js-alert-close\"]")).Click();
                        WaitASecond();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No alerts found");
            }
        }

        public void ScrollTo(string value1, string value2 = "Alternative value")
        {
            string scrollElementIntoMiddle = "var viewPortHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);"
                                           + "var elementTop = arguments[0].getBoundingClientRect().top;"
                                           + "window.scrollBy(0, elementTop-(viewPortHeight/2));";
            ((IJavaScriptExecutor)shared.driver).ExecuteScript(scrollElementIntoMiddle, shared.driver.FindElement(By.XPath(XPath(value1, value2))));
            WaitASecond(2);
        }

        public void AssertPageTitle(string title)
        {
            string pageTitle = shared.driver.Title;
            Console.WriteLine("Assert the page title \"" + pageTitle + "\" matches \"" + pageTitle + "\"");
            Assert.IsTrue(pageTitle.Contains(title), "Page title \"" + pageTitle + "\" does not match \"" + title + "\"");
        }

        public void AssertText(string value1, string value2 = "Alternative value")
        {
            Console.WriteLine("Assert the following text is present on the page: " + value1);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[contains(text(),\"" + value1 + "\")]|//*[contains(text(),\"" + value2 + "\")]|//*[contains(., \"" + value1 + "\")]|//*[contains(., \"" + value2 + "\")]")).Count != 0, "Text not found");
        }

        public void AssertElement(string value1, string value2 = "Alternative value")
        {
            Console.WriteLine("Assert the following element is present on the page: " + value1);
            Assert.IsTrue(shared.driver.FindElements(By.XPath(XPath(value1, value2))).Count != 0, "Element not found");
        }

        public void AssertElementNotPresent(string value1, string value2 = "Alternative value")
        {
            Console.WriteLine("Assert the following element is present on the page: " + value1);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[@*=\""+ value1 +"\"]|//*[contains(text(),\"" + value1 + "\")]|//*[@*=\"" + value2 + "\"]|//*[contains(text(),\"" + value2 + "\")]")).Count == 0, "Element displayed in error");
        }

        public void Click(string value1, string value2 = "Alternative value")
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(XPath(value1, value2))));
            Console.WriteLine("Click the \"" + value1 + "\" button");
            element.Click();
            WaitASecond();
        }

        public void ClickButton(string value1, string value2 = "Alternative value")
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(XPath(value1, value2, "button"))));
            Console.WriteLine("Click \"" + value1 + "\"");
            element.Click();
            WaitASecond();
        }

        public void ClickIfDisplayed(string value1, string value2 = "Alternative value")
        {
            try
            {
                if (shared.driver.FindElement(By.XPath(XPath(value1, value2))).Displayed)
                {
                    Console.WriteLine("Click \"" + value1 + "\"");
                    shared.driver.FindElement(By.XPath(XPath(value1, value2))).Click();
                    WaitASecond(1);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(value1 + " not found");
            }
        }

        public void MouseOver(string value1, string value2 = "Alternative value")
        {
            IWebElement element = shared.driver.FindElement(By.XPath(XPath(value1, value2)));
            Actions action = new Actions(shared.driver);
            action.MoveToElement(element).Perform();
            WaitASecond();
        }

        public void Type(string value1, string text, string value2 = "Alternative value")
        {
            Console.WriteLine("Type \"" + text + "\" into the \"" + value1 + "\" field");
            IWebElement element = shared.driver.FindElement(By.XPath(XPath(value1, value2, "input")));
            element.Clear();
            element.SendKeys(text);
        }

        public void TypeIfDisplayed(string value1, string text, string value2 = "Alternative value")
        {
            try
            {
                if (shared.driver.FindElement(By.XPath(XPath(value1, value2, "input"))).Displayed)
                {
                    Console.WriteLine("Type " + text + " into the " + value1 + " field");
                    IWebElement element = shared.driver.FindElement(By.XPath(XPath(value1, value2, "input")));
                    element.Clear();
                    element.SendKeys(text);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(value1 + " not found");
            }
        }

        public string GetJavaScriptText(string jsObject)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)shared.driver;
            string jsText = (string)js.ExecuteScript("return " + jsObject);
            Console.WriteLine("JS text: " + jsText);
            return jsText;
        }

        public string GetPostcode()
        {
            return Faker.Address.UkPostCode().ToUpper();
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
