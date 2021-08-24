using OpenQA.Selenium;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SykesCottagesTestAutomation
{
    [Binding]
    public class CommonSteps
    {
        //public IWebDriver driver;

        public class SharedDriver
        {
            public IWebDriver driver;
        }

        protected SharedDriver shared;

        public CommonSteps(SharedDriver context)
        {
            this.shared = context;
        }

        public void AssertPageTitle(string title)
        {
            System.Threading.Thread.Sleep(2000);
            string pageTitle = shared.driver.Title;
            Assert.IsTrue(pageTitle.Contains(title), pageTitle + " does not match " + title);
        }

        public void Click(string text)
        {
            IWebElement button = shared.driver.FindElement(By.XPath("//*[contains(text(),'" + text + "')]"));
            button.Click();
            System.Threading.Thread.Sleep(4000);
        }
    }
}
