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
using System.Diagnostics;

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
        public static string activeExperiments;
        public static string CSVValue;
        public static string Headers;

        public void SelectBrowser(string browser)
        {
            //Kill any existing WebDriver processes
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }

            Process[] edgeDriverProcesses = Process.GetProcessesByName("msedgedriver");
            foreach (var edgeDriverProcess in edgeDriverProcesses)
            {
                edgeDriverProcess.Kill();
            }

            Process[] firefoxDriverProcesses = Process.GetProcessesByName("geckodriver");
            foreach (var firefoxDriverProcess in firefoxDriverProcesses)
            {
                firefoxDriverProcess.Kill();
            }

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

            //If ephemeral environment, add the branch name to the URL
            if (domain.Contains("ephemeral"))
            {
                domain = Regex.Replace(domain, "ephemeralName", Hooks.ephemeralEnvironmentName);
            }

            url = domain + path; //Build the URL
            SelectBrowser(Hooks.browser); //Set the driver and browser
            shared.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Hooks.timeOut); //Set the timeout duration

            //Launch website - if it takes too long to load, hit Escape and continue
            try
            {
                GoTo(url);
                WaitASecond();
            }
            catch (Exception)
            {
                Console.WriteLine("Website did not finish loading after " + Hooks.timeOut + " seconds. Cancel page load and continue...");
                shared.driver.FindElement(By.TagName("body")).SendKeys("Keys.ESCAPE");
            }

            //Check for system errors
            Assert.IsTrue(shared.driver.FindElements(By.XPath(XPath("503 Service Temporarily Unavailable"))).Count == 0, "ERROR MESSAGE: 503 Service Temporarily Unavailable");
            Assert.IsTrue(shared.driver.FindElements(By.XPath(XPath("An error has occurred"))).Count == 0, "ERROR MESSAGE: An error has occurred");
            Assert.IsTrue(shared.driver.FindElements(By.XPath(XPath("Service Unavailable"))).Count == 0, "ERROR MESSAGE: Service Unavailable");
            Assert.IsTrue(shared.driver.FindElements(By.XPath(XPath("504 Gateway Time-out"))).Count == 0, "ERROR MESSAGE: 504 Gateway Time-out");

            //Write active experiments to console
            try
            {
                controlExperiments = GetJavaScriptText("control_experiments");
                experimentalExperiments = GetJavaScriptText("experimental_experiments");
                Console.WriteLine("On experiments: " + experimentalExperiments + "\nOff experiments: " + controlExperiments);
            }
            catch {}

            ClosePopups(); //Dismiss any pop-ups or alerts

            //Check for experiments and apply them
            if (Hooks.experiments != "")
            {
                //If Dev Tools not found, launch website with Dev Tools activated
                if (shared.driver.FindElements(By.XPath("//a[text()='Dev Tools']")).Count == 0)
                {
                    GoTo(url + "/?dev_tools=product");
                }
                ApplyExperiment(Hooks.experiments);
            }

            SetBrowserSize(); //Set the browser width and height
            Console.WriteLine("");
        }

        public void SetBrowserSize()
        {
            if (Hooks.browserSize.Contains("Max") | Hooks.browserSize.Contains("max") | Hooks.browserSize.Contains("Full") | Hooks.browserSize.Contains("full"))
            {
                Console.WriteLine("Set browser size to maximum");
                shared.driver.Manage().Window.Maximize(); //Maximise
            }
            if (Hooks.browserSize.Contains("Desktop") | Hooks.browserSize.Contains("desktop"))
            {
                Console.WriteLine("Set browser size to desktop");
                shared.driver.Manage().Window.Size = new Size(1460, 640); //Laptop screen dimentions
            }
            if (Hooks.browserSize.Contains("Tablet") | Hooks.browserSize.Contains("tablet"))
            {
                Console.WriteLine("Set browser size to tablet");
                shared.driver.Manage().Window.Size = new Size(820, 1180); //iPad Air dimensions
            }
            if (Hooks.browserSize.Contains("Mobile") | Hooks.browserSize.Contains("mobile"))
            {
                Console.WriteLine("Set browser size to mobile");
                shared.driver.Manage().Window.Size = new Size(375, 812); //iPhone X dimensions
            }
            if (Hooks.browserSize.Contains("Custom") | Hooks.browserSize.Contains("custom"))
            {
                Console.WriteLine("Set browser size to " + Hooks.pageWidth + " by " + Hooks.pageHeight);
                shared.driver.Manage().Window.Size = new Size(Hooks.pageWidth, Hooks.pageHeight);
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

        public void ClosePopups()
        {
            //Accept, reject or ignore the cookie banner
            if (Hooks.cookieBanner == "Accept")
            {
                ClickIfDisplayed("Accept all", waitTime: 2);
            }
            if (Hooks.cookieBanner == "Reject")
            {
                ClickIfDisplayed("Reject all", waitTime: 2);
            }

            //Dismiss overlay tint
            if (shared.driver.FindElements(By.XPath("overlay-tint")).Count != 0)
            {
                ClickIfDisplayed("overlay-tint");
            }

            //Dismiss alerts and pop-ups
            if (Hooks.dismissPopups == true)
            {
                //Collapse survey
                if (shared.driver.FindElements(By.XPath("//*[@*='_hj-1tTKm__styles__surveyContainer _hj-2UlJh__styles__positionRight _hj-3BmV5__styles__openingAnimation']")).Count != 0)
                {
                    ClickIfDisplayed("_hj-102w7__styles__openStateToggleIcon _hj-3Iftt__styles__surveyIcons");
                }

                //Dismiss alerts
                if (shared.driver.FindElements(By.XPath("//*[@*='o-lyc-alerts ']/*[1]/*[contains(@class,'close')]")).Count != 0)
                {
                    ClickIfDisplayed("//*[@*='o-lyc-alerts ']/*[1]/*[contains(@class,'close')]", waitTime: 2);
                    ClickIfDisplayed("//*[@*='o-lyc-alerts ']/*[2]/*[contains(@class,'close')]");
                    ClickIfDisplayed("close c-alert__close js-alert-close");
                }
                else
                {
                    Console.WriteLine("No alerts found");
                }
            }
            else
            {
                Console.WriteLine("Popups not dismissed. Set DismissAllPopups to 'Yes' in Hooks class to dismiss popups.");
            }
        }

        public static string ReadFromCSV(string fileName, string columnName, string rowName, string searchTerm)
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
                //Console.WriteLine("CSV value is: " + row[columnName]);
                csvValue = row[columnName].ToString();
            }
            return csvValue;
        }

        public static string XPath(string value, string element = "*")
        {
            //If "value" parameter is already an XPath, return the origninal string; else return an XPath containing the "value" parameter
            if (value.Contains("//") & !value.Contains("http"))
            {
                return value;
            }
            else
            {
                return "//" + element + "[@*=\"" + value + "\" or contains(@class,\"" + value + "\") or contains(@id,\"" + value + "\") or contains(@style,\"" + value + "\") or contains(@href,\"" + value + "\") or contains(@src,\"" + value + "\") or contains(text(),\"" + value + "\")]";
            }
        }

        public void GoTo(string webpage)
        {
            try
            {
                Console.WriteLine("Launch website: " + webpage);
                shared.driver.Navigate().GoToUrl(webpage);
            }
            catch
            {
                Console.WriteLine("Webpage failed to load: " + webpage);
            }
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
                GoTo(url);
            }
            catch (Exception)
            {
                Console.WriteLine("Website did not finish loading after " + Hooks.timeOut + " seconds. Cancel page load and continue...");
                shared.driver.FindElement(By.TagName("body")).SendKeys("Keys.ESCAPE");
            }
            SetBrowserSize();
        }

        public static void GetPageHeaders()
        {
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

        public static void WaitASecond(int seconds = 1)
        {
            int value = seconds * 1000;
            System.Threading.Thread.Sleep(value);
        }

        public void WaitUntilExists(string value, int seconds = 10)
        {
            try
            {
                var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, seconds));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(XPath(value))));
            }
            catch (Exception)
            {
                Console.WriteLine(value + " not found after " + seconds + " seconds");
            }
        }

        public void WaitUntilVisible(string value, int seconds = 10)
        {
            try
            {
                var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, seconds));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(XPath(value))));
            }
            catch (Exception)
            {
                Console.WriteLine(value + " not visible after " + seconds + " seconds");
            }
        }

        public void WaitUntilClickable(string value, int seconds = 10)
        {
            try
            {
                var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, seconds));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(XPath(value))));
            }
            catch (Exception)
            {
                Console.WriteLine(value + " not clickable after " + seconds + " seconds");
            }
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

        public bool ElementNotDisplayed(string value, string element = "*")
        {
            return shared.driver.FindElements(By.XPath(XPath(value, element))).Count == 0;
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
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//" + element + "[@*=\""+ value +"\"]|//*[contains(text(),\"" + value + "\")]|//" + element + "[contains(@class,\"" + value + "\")]")).Count == 0, "\"" + value + "\" displayed");
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
            Console.WriteLine(" JS click: \"" + value + "\"");
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

        public static string GetPostcode()
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
            Console.WriteLine("Scenario: The relevant headers are displayed on the page");
            Console.WriteLine("\tGiven I am on the following webpage: " + url);
            Console.WriteLine("\tThen the relevant elements are dislpayed");
            Console.WriteLine("\t| Element |");
            WaitASecond(5);
            for (int h = 1; h < 5; h++)
            {
                int numberOfH1Tags = shared.driver.FindElements(By.XPath("//h" + h)).Count;
                for (int i = 1; i < numberOfH1Tags; i++)
                {
                    string header = shared.driver.FindElement(By.XPath("(//h" + h + ")[" + i + "]")).Text;
                    if (header != "")
                    {
                        Console.WriteLine("\t| " + header + " |");
                    }
                }
            }
            Console.WriteLine("\n");
        }

        public void BuildLinkTest()
        {
            Console.WriteLine("Copy the following into a feature file:\n");
            Console.WriteLine("Scenario: The relevant links are displayed on the page");
            Console.WriteLine("\tGiven I am on the following webpage: " + url);
            Console.WriteLine("\tThen the relevant elements are dislpayed");
            Console.WriteLine("\t| Element |");
            WaitASecond(3);
            int numberOfLinks = shared.driver.FindElements(By.XPath("//*[@href]")).Count;
            for (int i = 1; i < numberOfLinks; i++)
            {
                string link = shared.driver.FindElement(By.XPath("(//*[@href])[" + i + "]")).GetAttribute("href");
                link = Regex.Replace(link, "https://www.sykescottages.co.uk", "");
                link = Regex.Replace(link, "https://lyp238dedicatedfaqpa.dev.sykescottages.co.uk", "");
                link = Regex.Replace(link, "https://sykes:1.sykes@lyp238dedicatedfaqpa.dev.sykescottages.co.uk", "");
                link = Regex.Replace(link, "%20", " ");
                
                if (link != "" & link != "/" & link != "#" & !link.Contains("#body") & !link.Contains("/css"))
                {
                    Console.WriteLine("\t| " + link + " |");
                }
            }
            Console.WriteLine("\n");
        }

        public void BuildImageTest()
        {
            Console.WriteLine("Copy the following into a feature file:\n");
            Console.WriteLine("Scenario: The relevant images are displayed on the page");
            Console.WriteLine("\tGiven I am on the following webpage: " + url);
            Console.WriteLine("\tThen the relevant elements are dislpayed");
            Console.WriteLine("\t| Element |");
            WaitASecond(3);
            int numberOfImages = shared.driver.FindElements(By.XPath("//img[@src]")).Count;
            for (int i = 1; i < numberOfImages; i++)
            {
                string image = shared.driver.FindElement(By.XPath("(//img[@src])[" + i + "]")).GetAttribute("src");
                image = Regex.Replace(image, "https://www.sykescottages.co.uk", "");
                if (image != "")
                {
                    Console.WriteLine("\t| " + image + " |");
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


//Add Staging authentication cookie
//shared.driver.Manage().Cookies.AddCookie(new Cookie("internally_authenticated", "F1s4LtCgeouXQD0h1dlAEnmm9jcSS56nSIADaR0h%2FVDY2kmLMgiN4ZsaYldMyXBuGAFUHjaWS87NYZ43vaoDDzy7Di6UA%2FvTSo0Ejv%2FTMAHDf6MUzk7KKbg2zlXHmMqWAPWCxRDawTlXo%2B0qXvewU3%2BGATSa8sZmuJNo5YX9X9EElSHuWCc%3D"));
//shared.driver.Manage().Cookies.AddCookie(new Cookie("_hjSessionUser_2309408", "eyJpZCI6IjRjYzE3YTdlLTU4ZTYtNTViZS04ZDFiLWZiZGJlOTI3MzAyMCIsImNyZWF0ZWQiOjE2NzA5NDE0MTEzMTUsImV4aXN0aW5nIjp0cnVlfQ=="));


//using WebDriverManager.DriverConfigs.Impl;
//var options = new ChromeOptions();
//options.AddArguments("load-extension=/Users/gary.smith/AppData/Local/Google/Chrome/User Data/Default/Extensions/bmhfelbhbkeoldaiphchjibggnoodpcj/0.1.6_0"); //Option for adding extesions to Chrome
//new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); //For launching Chrome via a build pipeline