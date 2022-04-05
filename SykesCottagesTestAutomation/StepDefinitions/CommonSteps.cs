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
using System.IO;
using WDSE.ScreenshotMaker;
using WDSE.Decorators;
using WDSE;

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
                    var options = new ChromeOptions();
                    options.AddArgument("no-sandbox");
                    //options.AddArguments("load-extension=/Users/gary.smith/AppData/Local/Google/Chrome/User Data/Default/Extensions/bmhfelbhbkeoldaiphchjibggnoodpcj/0.1.6_0"); //Option for adding extesions to Chrome
                    shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers", options, TimeSpan.FromMinutes(3));
                    //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); //For launching Chrome via a build pipeline
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
            if (viewpoint.Contains("Max") | viewpoint.Contains("max") | viewpoint.Contains(""))
            {
                Console.WriteLine("Set browser size to maximum");
                shared.driver.Manage().Window.Maximize(); //Maximise
            }
            if (viewpoint == "Desktop" | viewpoint == "desktop")
            {
                Console.WriteLine("Set browser size to desktop");
                shared.driver.Manage().Window.Size = new Size(1460, 640); //Laptop screen dimentions
            }
            if (viewpoint == "Tablet" | viewpoint == "tablet")
            {
                Console.WriteLine("Set browser size to tablet");
                shared.driver.Manage().Window.Size = new Size(820, 1180); //iPad Air dimensions
            }
            if (viewpoint == "Mobile" | viewpoint == "mobile")
            {
                Console.WriteLine("Set browser size to mobile");
                shared.driver.Manage().Window.Size = new Size(375, 812); //iPhone X dimensions
            }
            if (viewpoint == "Custom" | viewpoint == "custom")
            {
                Console.WriteLine("Set browser size to " + width + " by " + height);
                shared.driver.Manage().Window.Size = new Size(width, height);
            }
        }

        public void LaunchWebsite(string domain = "", string path = "")
        {
            //Check for domain override
            if (domain == "")
            {
                domain = SetBaseUrl(Hooks.Environemt);
            }

            SelectBrowser(Hooks.Browser); //Set the driver and browser
            shared.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Hooks.TimeOut); //Set the timeout to 30 seconds

            shared.driver.Navigate().GoToUrl(domain + path); //Launch website

            //Check for experiments
            if (Hooks.Experiments != "")
            {
                WaitASecond(3);
                //If Dev Tools not found, launch website with Dev Tools activated
                if (shared.driver.FindElements(By.XPath("//a[text()='Dev Tools']")).Count == 0)
                {
                    //Console.WriteLine("Dev Tools not found");
                    shared.driver.Navigate().GoToUrl(domain + path + "/?dev_tools=product"); 
                }
                ApplyExperiment(Hooks.Experiments);
            }
/*            else
            {
                shared.driver.Navigate().GoToUrl(domain + path); //Launch website
            }*/
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

        public string XPath(string value1, string element = "*")
        {
            return "//"+ element +"[@*=\""+ value1 +"\"]|//"+ element +"[contains(text(),\"" + value1 + "\")]|//" + element + "[contains(@class,\"" + value1 + "\")]|//" + element + "[contains(@id,\"" + value1 + "\")]";
        }

        public void WaitASecond(int seconds = 1)
        {
            int value = seconds * 1000;
            System.Threading.Thread.Sleep(value);
        }

        public void WaitUntilExists(string value1)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(XPath(value1))));
        }

        public void WaitUntilVisible(string value1)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(XPath(value1))));
        }

        public void WaitUntilClickable(string value1)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(XPath(value1))));
        }

        public void CloseAllPopups(string acceptCookies = "Yes", string dismissAlerts = "Yes")
        {
            WaitASecond(2);
            if (acceptCookies == "Yes")
            {
                ClickIfDisplayed("Accept All Cookies");
            }

            if (shared.driver.FindElements(By.XPath("//*[@*='_hj-1tTKm__styles__surveyContainer _hj-2UlJh__styles__positionRight _hj-3BmV5__styles__openingAnimation']")).Count != 0)
            {
                ClickIfDisplayed("_hj-102w7__styles__openStateToggleIcon _hj-3Iftt__styles__surveyIcons");
            }
            
            ClickIfDisplayed("nonenquiry6941");

            if (dismissAlerts == "Yes")
            {
                try
                {
                    if (shared.driver.FindElement(By.XPath("//*[@*='o-lyc-alerts ']/*[1]/*[contains(@class,'close')]")).Displayed)
                    {
                        shared.driver.FindElement(By.XPath("//*[@*='o-lyc-alerts ']/*[1]/*[contains(@class,'close')]")).Click();
                    }
                    WaitASecond();
                    if (shared.driver.FindElement(By.XPath("//*[@*='o-lyc-alerts ']/*[2]/*[contains(@class,'close')]")).Displayed)
                    {
                        shared.driver.FindElement(By.XPath("//*[@*='o-lyc-alerts ']/*[2]/*[contains(@class,'close')]")).Click();
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("No alerts found");
                }
            }
        }

        public void ScrollTo(string value1)
        {
            string scrollElementIntoMiddle = "var viewPortHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);"
                                           + "var elementTop = arguments[0].getBoundingClientRect().top;"
                                           + "window.scrollBy(0, elementTop-(viewPortHeight/2));";
            ((IJavaScriptExecutor)shared.driver).ExecuteScript(scrollElementIntoMiddle, shared.driver.FindElement(By.XPath(XPath(value1))));
            WaitASecond(2);
        }

        public void AssertPageTitle(string title)
        {
            string pageTitle = shared.driver.Title;
            Console.WriteLine("Assert the page title \"" + pageTitle + "\" matches \"" + pageTitle + "\"");
            Assert.IsTrue(pageTitle.Contains(title), "Page title \"" + pageTitle + "\" does not match \"" + title + "\"");
        }

        public void AssertText(string value1)
        {
            Console.WriteLine("Assert the following text is present on the page: " + value1);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[contains(text(),\"" + value1 + "\")]|//*[contains(., \"" + value1 + "\")]")).Count != 0, "Text not found");
        }

        public void AssertElement(string value1)
        {
            Console.WriteLine("Assert the following element is present on the page: " + value1);
            Assert.IsTrue(shared.driver.FindElements(By.XPath(XPath(value1))).Count != 0, "Element not found");
        }

        public void AssertElementNotDisplayed(string value1)
        {
            Console.WriteLine("Assert the following element is not displayed on the page: " + value1);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[@*=\""+ value1 +"\"]|//*[contains(text(),\"" + value1 + "\")]|//*[contains(@class,\"" + value1 + "\")]")).Count == 0, "Element displayed in error");
        }

        public void AssertElementNotVisible(string value1)
        {
            Console.WriteLine("Assert the following element is not visible on the page: " + value1);
            Assert.IsTrue(shared.driver.FindElement(By.XPath("//*[@*=\"" + value1 + "\"]|//*[contains(text(),\"" + value1 + "\")]|//*[contains(@class,\"" + value1 + "\")]")).Displayed, "Element displayed in error");
        }

        public void Click(string value1)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(XPath(value1))));
            Console.WriteLine("Click \"" + value1 + "\"");
            element.Click();
            WaitASecond();
        }

        public void ClickButton(string value1, string attribute = "button")
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(XPath(value1, attribute))));
            Console.WriteLine("Click the \"" + value1 + "\" button");
            element.Click();
            WaitASecond();
        }

        public void ClickIfDisplayed(string value1)
        {
            try
            {
                if (shared.driver.FindElement(By.XPath(XPath(value1))).Displayed)
                {
                    Console.WriteLine("Click \"" + value1 + "\"");
                    shared.driver.FindElement(By.XPath(XPath(value1))).Click();
                    WaitASecond(1);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(value1 + " not found");
            }
        }

        public void SelectFromDropdown(string option, string dropdown)
        {
            Console.WriteLine("Select option \"" + option + "\" from the \"" + dropdown + "\" dropdown");
            shared.driver.FindElement(By.XPath("//select[@*=\"" + dropdown + "\"]/option[@*=\"" + option + "\"]|//select[@*=\"" + dropdown + "\"]/option[contains(text(),\"" + option + "\")]")).Click();
            WaitASecond();
        }

        public void MouseOver(string value1)
        {
            IWebElement element = shared.driver.FindElement(By.XPath(XPath(value1)));
            Actions action = new Actions(shared.driver);
            action.MoveToElement(element).Perform();
            WaitASecond();
        }

        public void Type(string formField, string text)
        {
            Console.WriteLine("Type \"" + text + "\" into the \"" + formField + "\" field");
            IWebElement element = shared.driver.FindElement(By.XPath(XPath(formField, "input")));
            element.Clear();
            element.SendKeys(text);
        }

        public void TypeIfDisplayed(string formField, string text)
        {
            try
            {
                if (shared.driver.FindElement(By.XPath(XPath(formField, "input"))).Displayed)
                {
                    Console.WriteLine("Type " + text + " into the " + formField + " field");
                    IWebElement element = shared.driver.FindElement(By.XPath(XPath(formField, "input")));
                    element.Clear();
                    element.SendKeys(text);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(formField + " not found");
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
            //Name of directory
            string dir = @"C://Logs//Screenshots//" + DateTime.Now.ToString("yyyy-MM-dd");
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            //Take full webpage screenshot
            VerticalCombineDecorator vcd = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            shared.driver.TakeScreenshot(vcd).ToMagickImage().Write(dir + "//" + title + ".png", ImageMagick.MagickFormat.Png);

            //Take current viewable area screenshot
            //Screenshot image = ((ITakesScreenshot)shared.driver).GetScreenshot();
            //image.SaveAsFile(dir + "//" + title + ".png", ScreenshotImageFormat.Png);
        }
    }
}