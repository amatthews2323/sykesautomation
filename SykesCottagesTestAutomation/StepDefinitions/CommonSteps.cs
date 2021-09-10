using OpenQA.Selenium;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

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

        public void Click(string text)
        {
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(text(),'" + text + "')]")));
            element.Click();
            System.Threading.Thread.Sleep(2000);
        }

        public void ClickIfDisplayed(string text)
        {
            IWebElement acceptCookiesButton = shared.driver.FindElement(By.XPath("//*[contains(text(),'" + text + "')]"));
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

        public void MouseOver(string text)
        {
            IWebElement element = shared.driver.FindElement(By.XPath("//*[contains(text(),'" + text + "')]"));
            Actions action = new Actions(shared.driver);
            action.MoveToElement(element).Perform();
            System.Threading.Thread.Sleep(2000);
        }
    }
}
