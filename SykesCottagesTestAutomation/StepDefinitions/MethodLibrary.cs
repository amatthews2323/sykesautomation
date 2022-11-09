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
using System.Text.RegularExpressions;
using System.Linq;

namespace SykesCottagesTestAutomation
{
    [Binding]
    public class MethodLibrary
    {
        public class SharedDriver
        {
            public IWebDriver driver;
        }

        protected SharedDriver shared;

        public MethodLibrary(SharedDriver context)
        {
            shared = context;
        }

        public static string url;
        public static string controlExperiments;
        public static string experimentalExperiments;
        public static string CSVValue;
        public static string Headers;

        public void SelectBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    shared.driver = new ChromeDriver(chromeDriverDirectory: @"Drivers", new ChromeOptions { Proxy = null });
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
                domain = ReadFromCSV(fileName: "EnvironmentURLs", columnName: "URL", rowName: "Name", searchTerm: Hooks.environemt); //Get the URL based on the Hooks.Environemt value
            }
            url = domain + path;

            SelectBrowser(Hooks.browser); //Set the driver and browser
            shared.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Hooks.timeOut); //Set the timeout duration

            try
            {
                GoTo(url); //Launch website
                WaitASecond();
            }
            catch (Exception)
            {
                Console.WriteLine("Website did not finish loading after " + Hooks.timeOut + " seconds. Cancel page load and continue...");
                shared.driver.FindElement(By.TagName("body")).SendKeys("Keys.ESCAPE");
            }

            AssertElementNotDisplayed("503 Service Temporarily Unavailable");
            AssertElementNotDisplayed("An error has occurred");
            AssertElementNotDisplayed("Service Unavailable");
            AssertElementNotDisplayed("504 Gateway Time-out");

            try
            {
                controlExperiments = GetJavaScriptText("control_experiments");
                experimentalExperiments = GetJavaScriptText("experimental_experiments");
                Console.WriteLine("Control experiments: " + controlExperiments + "\nExperimental experiments: " + experimentalExperiments);
            }
            catch
            {
                Console.WriteLine("No enabled experiments found");
            }

            if (Hooks.acceptCookies == true)
            {
                ClickIfDisplayed("Accept all", waitTime: 2);
            }
            else
            {
                ClickIfDisplayed("Reject all", waitTime: 2);
            }

            //Dismiss Book a Holiday pop-up if displayed
            ClickIfDisplayed("dismiss-direct-book-holiday-overlay");

            //Check for experiments
            if (Hooks.experiments != "")
            {
                //If Dev Tools not found, launch website with Dev Tools activated
                if (shared.driver.FindElements(By.XPath("//a[text()='Dev Tools']")).Count == 0)
                {
                    GoTo(url + "/?dev_tools=product");
                }
                ApplyExperiment(Hooks.experiments);
            }
        }

        public void SetBrowserSize(string viewpoint = "", int width = 768, int height = 1024)
        {
            if (viewpoint.Contains("Max") | viewpoint.Contains("max") | viewpoint.Contains("Full") | viewpoint.Contains("full"))
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
            if (shared.driver.FindElements(By.XPath("//a[text()='Dev Tools']")).Count == 0)
            {
                GoTo(url + "/?dev_tools=product");
            }
            JSClick("Dev Tools");
            var array = experimentIds.Split(",");
            for (int i = 0; i < array.Length; i++)
            {
                string Experiment = array[i].ToString().Trim();
                Type("experiment-search", Experiment);
                Click("//li[contains(@data-name,\"" + Experiment + "\")]");
            }
            JSClick("//a[@class='dev-panel-toggle' and text()='Close']");
            Refresh();
        }

        public void ClosePopups(bool _acceptCookies = true, bool _dismissAlerts = true)
        {
            if (Hooks.acceptCookies == true)
            {
                if (_acceptCookies == true)
                {
                    WaitASecond();
                    ClickIfDisplayed("Accept all cookies");
                }
            }
            else
            {
                Console.WriteLine("Cookies popup not dismissed. Set AcceptCookies to 'Yes' in Hooks class to dismiss popups.");
            }

            if (Hooks.dismissPopups == true)
            {
                //Collapse survey
                if (shared.driver.FindElements(By.XPath("//*[@*='_hj-1tTKm__styles__surveyContainer _hj-2UlJh__styles__positionRight _hj-3BmV5__styles__openingAnimation']")).Count != 0)
                {
                    ClickIfDisplayed("_hj-102w7__styles__openStateToggleIcon _hj-3Iftt__styles__surveyIcons");
                }

                //Dismiss form tint
                ClickIfDisplayed("nonenquiry6941");

                //Dismiss alerts (unless overridden to test an experiment)
                if (_dismissAlerts == true)
                {
                    //WaitASecond();
                    ClickIfDisplayed("//*[@*='o-lyc-alerts ']/*[1]/*[contains(@class,'close')]", waitTime: 2);
                    ClickIfDisplayed("//*[@*='o-lyc-alerts ']/*[2]/*[contains(@class,'close')]");
                    ClickIfDisplayed("close c-alert__close js-alert-close");
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
            //If "value" parameter is already an XPath, return the origninal string; else return an XPath containing the "value" parameter
            if (value.Contains("//") & !value.Contains("http"))
            {
                return value;
            }
            else
            {
                //Console.WriteLine("Lookup xPath: " + "//" + element + "[@*=\"" + value + "\" or contains(@class,\"" + value + "\") or contains(@id,\"" + value + "\") or contains(@style,\"" + value + "\") or contains(text(),\"" + value + "\")]");
                return "//" + element + "[@*=\"" + value + "\" or contains(@class,\"" + value + "\") or contains(@id,\"" + value + "\") or contains(@style,\"" + value + "\") or contains(text(),\"" + value + "\")]";
            }
        }

        public void GoTo(string webpage)
        {
            Console.WriteLine("Launch website: " + webpage);
            shared.driver.Navigate().GoToUrl(webpage);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//body")).Count != 0, "Webpage did not load");
        }

        public void SwitchFocus()
        {
            shared.driver.SwitchTo().Window(shared.driver.WindowHandles[1]);
            WaitASecond(2);
        }

        public void Refresh()
        {
            try
            {
                Console.WriteLine("Reload the page");
                //shared.driver.Navigate().Refresh();
                GoTo(url);
            }
            catch (Exception)
            {
                Console.WriteLine("Website did not finish loading after " + Hooks.timeOut + " seconds. Cancel page load and continue...");
                shared.driver.FindElement(By.TagName("body")).SendKeys("Keys.ESCAPE");
            }
            SetBrowserSize(Hooks.browserSize, Hooks.pageWidth, Hooks.pageHeight);
        }

        public void GetPageHeaders()
        {
            //Headers = shared.driver.FindElement(By.XPath("/html/body//*[self::h1 or self::h2 or self::h3]/text()")).Text;

            string input = @"<div class='main - body'>
                     <h2> 1.1 Heading </h2>     
                     <h3> 1.1.1 Subheading </h3>        
                     <p> Lorem ipsum </ p >           
                     <h3> 1.1.2 Another Subheading</h3>              
                     <p> Lorem ipsum </p>     
                     <h2> 2.1 Heading </h2>
                     <h3> 2.1.1 Subheading </h3>
                     <p> Lorem ipsum </p>
                     <h4> 2.1.1.1 SubSubHeading </h4>
                 </div> ";

            string pattern = @"<h[1-6][^>]*?>(?<TagText>.*?)</h[1-6]>";

            MatchCollection matches = Regex.Matches(input, pattern);

            var heading_matches = matches.Cast<Match>().Select(x => x.Groups["TagText"].Value);


            Console.WriteLine("Page headers: " + Headers);
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

        public bool ElementDisplayed(string value, string element = "*")
        {
            return shared.driver.FindElements(By.XPath(XPath(value, element))).Count != 0;
        }

        public void AssertPageTitle(string title)
        {
            string pageTitle = shared.driver.Title;
            Console.WriteLine("Assert the page title \"" + pageTitle + "\" matches \"" + pageTitle + "\"");
            Assert.IsTrue(pageTitle.Contains(title), "Page title \"" + pageTitle + "\" does not match \"" + title + "\"");
        }

        public void AssertTextDisplayed(string value)
        {
            Console.WriteLine("Assert the following text is displayed: " + value);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[contains(text(),\"" + value + "\")]|//*[contains(., \"" + value + "\")]")).Count != 0, "Text \"" + value + "\" not found");
        }

        public void AssertElementDisplayed(string value, string element = "*")
        {
            Console.WriteLine("Assert the following element is displayed: " + value);
            Assert.IsTrue(shared.driver.FindElements(By.XPath(XPath(value, element))).Count != 0, "\"" + value + "\" not found");
        }

        public void AssertElementNotDisplayed(string value, string element = "*")
        {
            Console.WriteLine("Assert the following element is not displayed: " + value);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//" + element + "[@*=\""+ value +"\"]|//*[contains(text(),\"" + value + "\")]|//" + element + "[contains(@class,\"" + value + "\")]")).Count == 0, "\"" + value + "\" displayed in error");
        }

        public void AssertElementVisible(string value, string element = "*")
        {
            Console.WriteLine("Assert the following element is visible: " + value);
            Assert.IsTrue(shared.driver.FindElement(By.XPath(XPath(value, element))).Displayed, "\"" + value + "\" not visible");
        }

        public void AssertElementNotVisible(string value, string element = "*")
        {
            Console.WriteLine("Assert the following element is not visible: " + value);
            Assert.IsTrue(shared.driver.FindElement(By.XPath("//" + element + "[@*=\"" + value + "\"]|//*[contains(text(),\"" + value + "\")]|//" + element + "[contains(@class,\"" + value + "\")]")).Displayed, "\"" + value + "\" displayed in error");
        }

        public void Click(string value, string element = "*", int waitTime = 0)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            var _element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(XPath(value, element))));
            Console.WriteLine("Click: \"" + value + "\"");
            _element.Click();
            if (waitTime != 0)
            {
                WaitASecond(waitTime);
            }
        }

        public void JSClick(string value, string element = "*", int waitTime = 0)
        {
            Console.WriteLine("Click: \"" + value + "\"");
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)shared.driver;
            jsExecutor.ExecuteScript("arguments[0].click()", shared.driver.FindElement(By.XPath(XPath(value, element))));
            if (waitTime != 0)
            {
                WaitASecond(waitTime);
            }
        }

        public void ClickIfDisplayed(string value, string element = "*", int waitTime = 0)
        {
            try
            {
                if (ElementDisplayed(value, element))
                {
                    Console.WriteLine("Click \"" + value + "\"");
                    shared.driver.FindElement(By.XPath(XPath(value, element))).Click();
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

        public void MouseOver(string value, string element = "*")
        {
            IWebElement _element = shared.driver.FindElement(By.XPath(XPath(value, element)));
            Actions action = new Actions(shared.driver);
            action.MoveToElement(_element).Perform();
            WaitASecond();
        }

        public void Type(string formField, string text, string element = "input", int waitTime = 0)
        {
            Console.WriteLine("Type \"" + text + "\" into the \"" + formField + "\" field");
            IWebElement _element = shared.driver.FindElement(By.XPath(XPath(formField, element)));
            _element.Clear();
            _element.SendKeys(text);
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

        public void TypeIfDisplayed(string formField, string text, string element = "*", int waitTime = 0)
        {
            try
            {
                if (shared.driver.FindElement(By.XPath(XPath(formField, "input"))).Displayed)
                {
                    Console.WriteLine("Type " + text + " into the " + formField + " field");
                    IWebElement _element = shared.driver.FindElement(By.XPath(XPath(formField, element)));
                    _element.Clear();
                    _element.SendKeys(text);
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
            return jsText;
        }

        public string GetAttribrute(string value, string element = "class")
        {
            return shared.driver.FindElement(By.XPath(value)).GetAttribute(element);
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

        public void GetAllHeaders()
        {
            WaitASecond(5);
            for (int h = 1; h < 5; h++)
            {
                Console.WriteLine("\nH"+ h +" tags:");
                int numberOfH1Tags = shared.driver.FindElements(By.XPath("//h" + h)).Count;
                for (int i = 1; i < numberOfH1Tags; i++)
                {
                    string header = shared.driver.FindElement(By.XPath("(//h" + h + ")[" + i + "]")).Text;
                    if (header != "")
                    {
                        Console.WriteLine("| " + header + " |");
                    }
                }
            }
            Console.WriteLine("\n");
        }

        public void GetAllLinks()
        {
            WaitASecond(3);
            Console.WriteLine("\nLinks:");
            int numberOfLinks = shared.driver.FindElements(By.XPath("//*[@href]")).Count;
            for (int i = 1; i < numberOfLinks; i++)
            {
                string link = shared.driver.FindElement(By.XPath("(//*[@href])[" + i + "]")).GetAttribute("href");
                if (link != "")
                {
                    Console.WriteLine("| " + link + " |");
                }
            }
            Console.WriteLine("\n");
        }

        public void GetAllImages()
        {
            WaitASecond(3);
            Console.WriteLine("\nImages:");
            int numberOfLinks = shared.driver.FindElements(By.XPath("//img[@src]")).Count;
            for (int i = 1; i < numberOfLinks; i++)
            {
                string image = shared.driver.FindElement(By.XPath("(//img[@src])[" + i + "]")).GetAttribute("src");
                if (image != "")
                {
                    Console.WriteLine("| " + image + " |");
                }
            }
            Console.WriteLine("\n");
        }

        public void BuildHeaderTest()
        {
            Console.WriteLine("Copy the following into a feature file:\n");
            Console.WriteLine("Given I am on the following webpage: " + url);
            Console.WriteLine("Then the relevant elements are dislpayed");
            Console.WriteLine("| Element |");
            WaitASecond(5);
            for (int h = 1; h < 5; h++)
            {
                int numberOfH1Tags = shared.driver.FindElements(By.XPath("//h" + h)).Count;
                for (int i = 1; i < numberOfH1Tags; i++)
                {
                    string header = shared.driver.FindElement(By.XPath("(//h" + h + ")[" + i + "]")).Text;
                    if (header != "")
                    {
                        Console.WriteLine("| " + header + " |");
                    }
                }
            }
            Console.WriteLine("\n");
        }

        public void BuildLinkTest()
        {
            Console.WriteLine("Copy the following into a feature file:\n");
            Console.WriteLine("Given I am on the following webpage: " + url);
            Console.WriteLine("Then the relevant elements are dislpayed");
            Console.WriteLine("| Element |");
            WaitASecond(3);
            int numberOfLinks = shared.driver.FindElements(By.XPath("//*[@href]")).Count;
            for (int i = 1; i < numberOfLinks; i++)
            {
                string link = shared.driver.FindElement(By.XPath("(//*[@href])[" + i + "]")).GetAttribute("href");
                if (link != "")
                {
                    Console.WriteLine("| " + link + " |");
                }
            }
            Console.WriteLine("\n");
        }

        public void BuildImageTest()
        {
            Console.WriteLine("Copy the following into a feature file:\n");
            Console.WriteLine("Given I am on the following webpage: " + url);
            Console.WriteLine("Then the relevant elements are dislpayed");
            Console.WriteLine("| Element |");
            WaitASecond(3);
            int numberOfLinks = shared.driver.FindElements(By.XPath("//img[@src]")).Count;
            for (int i = 1; i < numberOfLinks; i++)
            {
                string image = shared.driver.FindElement(By.XPath("(//img[@src])[" + i + "]")).GetAttribute("src");
                if (image != "")
                {
                    Console.WriteLine("| " + image + " |");
                }
            }
            Console.WriteLine("\n");
        }

        public void Screenshot(string fileName = "screenshot", string type = "full webpage")
        {
            //Name of directory
            string dir = @Hooks.reportDir + "//" + DateTime.Now.ToString("yyyy-MM-dd") + "//" + Hooks.reportName + "_" + Hooks.environemt + "_" + Hooks.browser;
            if (Hooks.browserSize != "")
            {
                dir += "_" + Hooks.browserSize;
            }
            dir += "//Screenshots";

            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (type == "full webpage")
            {
                //Take screenshot of entire webpage
                VerticalCombineDecorator vcd = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
                shared.driver.TakeScreenshot(vcd).ToMagickImage().Write(dir + "//" + fileName + ".png", ImageMagick.MagickFormat.Png);
            }
            else
            {
                //Take screenshot of viewable area
                Screenshot image = ((ITakesScreenshot)shared.driver).GetScreenshot();
                image.SaveAsFile(dir + "//" + fileName + ".png", ScreenshotImageFormat.Png);
            }
        }
    }
}

//using WebDriverManager.DriverConfigs.Impl;
//var options = new ChromeOptions();
//options.AddArguments("load-extension=/Users/gary.smith/AppData/Local/Google/Chrome/User Data/Default/Extensions/bmhfelbhbkeoldaiphchjibggnoodpcj/0.1.6_0"); //Option for adding extesions to Chrome
//new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); //For launching Chrome via a build pipeline