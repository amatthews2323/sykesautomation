using CsvHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using TechTalk.SpecFlow;
using WDSE.ScreenshotMaker;
using WDSE.Decorators;
using WDSE;
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

        public void SelectBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers");
                    //var options = new ChromeOptions();
                    //options.AddArguments("load-extension=/Users/gary.smith/AppData/Local/Google/Chrome/User Data/Default/Extensions/bmhfelbhbkeoldaiphchjibggnoodpcj/0.1.6_0"); //Option for adding extesions to Chrome
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
                    shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers");
                    break;
            }
        }

        public void LaunchWebsite(string domain = "", string path = "")
        {
            //Check for domain override, if none found, use the one specified in the Hooks class
            if (domain == "")
            {
                domain = ReadFromCSV(fileName: "EnvironmentURLs", columnName: "URL", rowName: "Name", searchTerm: Hooks.Environemt); //Get the URL based on the Hooks.Environemt value
            }

            SelectBrowser(Hooks.Browser); //Set the driver and browser
            shared.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Hooks.TimeOut); //Set the timeout duration

            try
            {
                GoTo(domain + path); //Launch website
            }
            catch (Exception)
            {
                Console.WriteLine("Website did not finish loading after " + Hooks.TimeOut + " seconds. Cancel page load and continue...");
                shared.driver.FindElement(By.TagName("body")).SendKeys("Keys.ESCAPE");
            }

            //Check for experiments
            if (Hooks.Experiments != "")
            {
                WaitASecond(2);
                //If Dev Tools not found, launch website with Dev Tools activated
                if (shared.driver.FindElements(By.XPath("//a[text()='Dev Tools']")).Count == 0)
                {
                    //Console.WriteLine("Dev Tools not found");
                    shared.driver.Navigate().GoToUrl(domain + path + "/?dev_tools=product");
                }
                ApplyExperiment(Hooks.Experiments);
            }
        }

        public void SetBrowserSize(string viewpoint = "", int width = 768, int height = 1024)
        {
            if (viewpoint.Contains("Max") | viewpoint.Contains("max"))
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

        public void ApplyExperiment(string experimentIds)
        {
            Click("Dev Tools");
            var array = experimentIds.Split(",");
            for (int i = 0; i < array.Length; i++)
            {
                string Experiment = array[i].ToString().Trim();
                Type("experiment-search", Experiment);
                WaitASecond();
                Click("//li[contains(@data-name,\"" + Experiment + "\")]");
            }
            try
            {
                Console.WriteLine("Reload the page");
                Refresh();
            }
            catch (Exception)
            {
                shared.driver.FindElement(By.TagName("body")).SendKeys("Keys.ESCAPE");
            }
            WaitASecond();
            SetBrowserSize(Hooks.BrowserSize, Hooks.PageWidth, Hooks.PageHeight);
        }

        public void CloseAllPopups(string acceptCookies = "Yes", string dismissAlerts = "Yes")
        {

            if (Hooks.AcceptCookies.Contains("Y"))
            {
                if (acceptCookies.Contains("Y"))
                {
                    WaitASecond(2);
                    ClickIfDisplayed("Accept All Cookies", waitTime: 1);
                }
            }
            else
            {
                Console.WriteLine("Cookies popup dismissed. Set AcceptCookies to 'Yes' in Hooks class to dismiss popups.");
            }

            if (Hooks.DismissPopups.Contains("Y"))
            {
                //Collapse survey
                if (shared.driver.FindElements(By.XPath("//*[@*='_hj-1tTKm__styles__surveyContainer _hj-2UlJh__styles__positionRight _hj-3BmV5__styles__openingAnimation']")).Count != 0)
                {
                    ClickIfDisplayed("_hj-102w7__styles__openStateToggleIcon _hj-3Iftt__styles__surveyIcons");
                }

                //Dismiss form tint
                ClickIfDisplayed("nonenquiry6941");

                //Dismiss alerts (unless overridden to test an experiment)
                if (dismissAlerts == "Yes")
                {
                    try
                    {
                        if (shared.driver.FindElement(By.XPath("//*[@*='o-lyc-alerts ']/*[1]/*[contains(@class,'close')]")).Displayed)
                        {
                            Click("//*[@*='o-lyc-alerts ']/*[1]/*[contains(@class,'close')]");
                        }
                        WaitASecond();
                        if (shared.driver.FindElement(By.XPath("//*[@*='o-lyc-alerts ']/*[2]/*[contains(@class,'close')]")).Displayed)
                        {
                            Click("//*[@*='o-lyc-alerts ']/*[2]/*[contains(@class,'close')]");
                        }
                    }

                    catch (Exception)
                    {
                        Console.WriteLine("No alerts found");
                    }
                }
            }
            else
            {
                Console.WriteLine("Popups not dismissed. Set DismissAllPopups to 'Yes' in Hooks class to dismiss popups.");
            }
        }

        public string ReadFromCSV(string fileName, string columnName, string rowName, string searchTerm)
        {
            string csvValue = "";
            DataTable dataTable = null;
            using var reader = new StreamReader(@fileName + ".csv");
            using var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture);
            using (var dr = new CsvDataReader(csv))
            {
                dataTable = new DataTable();
                dataTable.Load(dr);
            }
            DataRow[] rows = dataTable.Select(rowName + " = '" + searchTerm + "'");
            foreach (DataRow row in rows)
            {
                Console.WriteLine("CSV value is: " + row[columnName]);
                csvValue = row[columnName].ToString();
            }
            return csvValue;
        }

        public string XPath(string value, string element = "*")
        {
            if (value.Contains("//") & !value.Contains("http"))
            {
                return value;
            }
            else
            {
                return "//" + element + "[@*=\"" + value + "\"]|//" + element + "[contains(text(),\"" + value + "\")]|//" + element + "[contains(@class,\"" + value + "\")]|//" + element + "[contains(@id,\"" + value + "\")]";
            }
        }

        public void GoTo(string url)
        {
            Console.WriteLine("Launch website: " + url);
            shared.driver.Navigate().GoToUrl(url);
        }

        public void SwitchFocus()
        {
            shared.driver.SwitchTo().Window(shared.driver.WindowHandles[1]);
            WaitASecond(2);
        }

        public void Refresh()
        {
            shared.driver.Navigate().Refresh();
        }

        public void WaitASecond(int seconds = 1)
        {
            int value = seconds * 1000;
            System.Threading.Thread.Sleep(value);
        }

        public void WaitUntilExists(string value)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(XPath(value))));
        }

        public void WaitUntilVisible(string value)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(XPath(value))));
        }

        public void WaitUntilClickable(string value)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(XPath(value))));
        }

        public void ScrollTo(string value)
        {
            string scrollElementIntoMiddle = "var viewPortHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);"
                                           + "var elementTop = arguments[0].getBoundingClientRect().top;"
                                           + "window.scrollBy(0, elementTop-(viewPortHeight/2));";
            ((IJavaScriptExecutor)shared.driver).ExecuteScript(scrollElementIntoMiddle, shared.driver.FindElement(By.XPath(XPath(value))));
            WaitASecond(2);
        }

        public void AssertPageTitle(string title)
        {
            string pageTitle = shared.driver.Title;
            Console.WriteLine("Assert the page title \"" + pageTitle + "\" matches \"" + pageTitle + "\"");
            Assert.IsTrue(pageTitle.Contains(title), "Page title \"" + pageTitle + "\" does not match \"" + title + "\"");
        }

        public void AssertTextDisplayed(string value)
        {
            Console.WriteLine("Assert the following text is present on the page: " + value);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[contains(text(),\"" + value + "\")]|//*[contains(., \"" + value + "\")]")).Count != 0, "Text not found");
        }

        public bool ElementDisplayed(string value)
        {
            return shared.driver.FindElement(By.XPath(XPath(value))).Displayed;
        }

        public void AssertElementDisplayed(string value)
        {
            Console.WriteLine("Assert the following element is present on the page: " + value);
            Assert.IsTrue(shared.driver.FindElements(By.XPath(XPath(value))).Count != 0, value + " not found");
        }

        public void AssertElementNotDisplayed(string value)
        {
            Console.WriteLine("Assert the following element is not displayed on the page: " + value);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[@*=\""+ value +"\"]|//*[contains(text(),\"" + value + "\")]|//*[contains(@class,\"" + value + "\")]")).Count == 0, "Element displayed in error");
        }

        public void AssertElementNotVisible(string value)
        {
            Console.WriteLine("Assert the following element is not visible on the page: " + value);
            Assert.IsTrue(shared.driver.FindElement(By.XPath("//*[@*=\"" + value + "\"]|//*[contains(text(),\"" + value + "\")]|//*[contains(@class,\"" + value + "\")]")).Displayed, "Element displayed in error");
        }

        public void Click(string value, string attribute = "*", int waitTime = 0)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(XPath(value, attribute))));
            Console.WriteLine("Click \"" + value + "\"");
            element.Click();
            if (waitTime != 0)
            {
                WaitASecond(waitTime);
            }
        }

        public void JSClick(string value, string attribute = "*", int waitTime = 0)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)shared.driver;
            jsExecutor.ExecuteScript("arguments[0].click()", shared.driver.FindElement(By.XPath(XPath(value, attribute))));
            if (waitTime != 0)
            {
                WaitASecond(waitTime);
            }
        }

        public void ClickIfDisplayed(string value, string attribute = "*", int waitTime = 0)
        {
            try
            {
                if (shared.driver.FindElement(By.XPath(XPath(value, attribute))).Displayed)
                {
                    Console.WriteLine("Click \"" + value + "\"");
                    shared.driver.FindElement(By.XPath(XPath(value, attribute))).Click();
                    if (waitTime != 0)
                    {
                        WaitASecond(waitTime);
                    }
                }
                else
                {
                    Console.WriteLine(value + " not found");
                }
            }
            catch (Exception)
            {
                Console.WriteLine(value + " click failed");
            }
        }

        public void SelectFromDropdown(string option, string dropdown)
        {
            Console.WriteLine("Select option \"" + option + "\" from the \"" + dropdown + "\" dropdown");
            shared.driver.FindElement(By.XPath("//select[@*=\"" + dropdown + "\"]/option[@*=\"" + option + "\"]|//select[@*=\"" + dropdown + "\"]/option[contains(text(),\"" + option + "\")]")).Click();
            WaitASecond();
        }

        public void MouseOver(string value)
        {
            IWebElement element = shared.driver.FindElement(By.XPath(XPath(value)));
            Actions action = new Actions(shared.driver);
            action.MoveToElement(element).Perform();
            WaitASecond();
        }

        public void Type(string formField, string text, string attribute = "input", int waitTime = 0)
        {
            Console.WriteLine("Type \"" + text + "\" into the \"" + formField + "\" field");
            IWebElement element = shared.driver.FindElement(By.XPath(XPath(formField, attribute)));
            element.Clear();
            element.SendKeys(text);
            if (waitTime != 0)
            {
                WaitASecond(waitTime);
            }
        }

        public void JSType(string formField, string text, int waitTime = 0)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)shared.driver;
            jsExecutor.ExecuteScript("document.getElementById('" + formField + "').value='" + text + "'");
            if (waitTime != 0)
            {
                WaitASecond(waitTime);
            }
        }

        public void TypeIfDisplayed(string formField, string text, string attribute = "*", int waitTime = 0)
        {
            try
            {
                if (shared.driver.FindElement(By.XPath(XPath(formField, "input"))).Displayed)
                {
                    Console.WriteLine("Type " + text + " into the " + formField + " field");
                    IWebElement element = shared.driver.FindElement(By.XPath(XPath(formField, attribute)));
                    element.Clear();
                    element.SendKeys(text);
                    if (waitTime != 0)
                    {
                        WaitASecond(waitTime);
                    }
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

        public string GetAttribrute(string value, string attribute = "class")
        {
            return shared.driver.FindElement(By.XPath(value)).GetAttribute(attribute);
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

        public void Screenshot(string fileName = "screenshot")
        {
            //Name of directory
            string dir = @"C://Logs//" + DateTime.Now.ToString("yyyy-MM-dd") + "//Screenshots";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            //Take full webpage screenshot
            VerticalCombineDecorator vcd = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            shared.driver.TakeScreenshot(vcd).ToMagickImage().Write(dir + "//" + fileName + ".png", ImageMagick.MagickFormat.Png);

            //Take current viewable area screenshot
            //Screenshot image = ((ITakesScreenshot)shared.driver).GetScreenshot();
            //image.SaveAsFile(dir + "//" + title + ".png", ScreenshotImageFormat.Png);
        }
    }
}