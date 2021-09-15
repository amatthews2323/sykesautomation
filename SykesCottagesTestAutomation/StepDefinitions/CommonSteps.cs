using OpenQA.Selenium;
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
        public class SharedDriver
        {
            public IWebDriver driver;
        }

        protected SharedDriver shared;

        public CommonSteps(SharedDriver context)
        {
            shared = context;
        }

        public void AssertPageTitle(string title)
        {
            string pageTitle = shared.driver.Title;
            Assert.IsTrue(pageTitle.Contains(title), "Page title '" + pageTitle + "' does not match '" + title + "'");
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
            IWebElement acceptCookiesButton = shared.driver.FindElement(By.XPath("//*[@*='" + value + "']|//*[contains(text(),'" + value + "')]"));
            try
            {
                if (acceptCookiesButton.Displayed)
                {
                    acceptCookiesButton.Click();
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
