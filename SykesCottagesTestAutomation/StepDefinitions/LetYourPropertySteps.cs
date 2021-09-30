using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System;

namespace SykesCottagesTestAutomation.BaseClass
{
    [Binding]
    public sealed class LetYourPropertySteps : CommonSteps
    {
        public LetYourPropertySteps(SharedDriver context) : base(context)
        {
        }

        [Given(@"I am on the Sykes Homepage")]
        public void GivenIAmOnTheSykesHomepage()
        {
            AssertPageTitle("Holiday Cottages To Rent - UK Holidays");
        }

        [Given(@"I have navigated to the Let Your Property page")]
        public void GivenIHaveNavigatedToTheLetYourPropertyPage()
        {
            Click("Let Your Property");
            AssertPageTitle("Holiday Letting Agents For Cottages, Holiday Homes & Property");
        }

        [When(@"I click the '(.*)' link")]
        public void IClickTheLink(string value)
        {
            Click(value);
        }

        [When(@"I click the '(.*)' header link under '(.*)'")]
        public void WhenIClickTheHeaderLinkUnder(string headedLink, string headerMenu)
        {
            MouseOver(headerMenu);
            MouseOver(headedLink);
            Click(headedLink);
        }

        [Then(@"the enquiry form is displayed")]
        public void ThenTheEnquiryFormIsDisplayed()
        {
            Assert.IsTrue(shared.driver.FindElement(By.XPath("//div[contains(@class,'js-enquiry-form')]")).Displayed, "Enquiry form not found");
        }

        [Then(@"the Let Your Property page is displayed")]
        public void ThenTheLetYourPropertyPageIsDisplayed()
        {
            AssertPageTitle("Holiday Letting Agents For Cottages, Holiday Homes & Property");
        }

        [When(@"I enter my details on the enquiry form")]
        public void WhenIEnterMyDetailsOnTheEnquiryForm(Table table)
        {
            var dictionary = ToDictionary(table);

            Type("form_first_name", dictionary["Full name"]);
            Type("form_email", dictionary["Email address"]);
            Type("form_phone", dictionary["Phone number"]);
        }

        [When(@"I click the Get Started button")]
        public void WhenIClickTheGetStartedButton()
        {
            if (Hooks.Environemt != "Live")
            {
                Click("submit");
            }
            else
            {
                Console.WriteLine("Step skipped on Live environment");
            }
        }

        [Then(@"I am directed to the Property Letting Dashboard page")]
        public void ThenIAmDirectedToThePropertyLettingDashboardPage()
        {
            if (Hooks.Environemt != "Live")
            {
                AssertPageTitle("Thank you for your enquiry | Sykes Cottages");
            }
            else
            {
                Console.WriteLine("Step skipped on Live environment");
            }
        }

        [Then(@"the '(.*)' page is displayed")]
        public void ThenPageIsDisplayed(string value)
        {
            AssertPageTitle(value);
        }

        [Given(@"I have navigated to the Let Your Property Dev Tools page")]
        public void GivenIHaveNavigatedToTheLetYourPropertyDevToolsPage()
        {
            shared.driver.Navigate().GoToUrl(Hooks.baseUrl + "/letyourcottage/?dev_tools=product");
        }

        [When(@"I select the following experiments '(.*)'")]
        public void WhenISelectTheFollowingExperiments(string experimentId)
        {
            Type("experiment-search", experimentId);
            System.Threading.Thread.Sleep(2000);
            shared.driver.FindElement(By.XPath("//li[contains(@data-name'" + experimentId + "')]")).Click();
            System.Threading.Thread.Sleep(2000);
        }
    }
}

