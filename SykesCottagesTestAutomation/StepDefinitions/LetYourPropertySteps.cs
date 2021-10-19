using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System;
using System.Linq;

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
            LaunchWebsite();
            AssertPageTitle("Holiday Cottages To Rent");
        }

        [Given(@"I have navigated to the (.*) page")]
        public void GivenIHaveNavigatedToThePage(string path = "")
        {
            LaunchWebsite("", path);
            CloseAllPopups();
        }

        [When(@"I click the (.*) link")]
        public void IClickTheLink(string value)
        {
            Click(value);
        }

        [When(@"I click the (.*) navigation link under (.*)")]
        public void WhenIClickTheNavigationLinkUnder(string headedLink, string headerMenu)
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

        [Then(@"the following page title is displayed: (.*)")]
        public void ThenTheFollowingPageTitleIsDisplayed(string value)
        {
            AssertPageTitle(value);
        }

        [Then(@"the following sections are dislpayed")]
        public void ThenTheFollowingSectionsAreDislpayed(Table table)
        {
            var sections = table.Rows.Select(r => r[0]).ToArray();
            foreach (var section in sections)
            {
                ScrollTo(section);
                AssertText(section.ToString());
            }
        }

        [Given(@"I am accessing (.*)")]
        public void GivenIAmAccessing(string domain = "")
        {
            LaunchWebsite(domain);
            CloseAllPopups();
        }

        [Then(@"the following text is displayed on the page: (.*)")]
        public void ThenTheFollowingTextIsDisplayedOnThePage(string text)
        {
            AssertText(text);
        }

        [Then(@"the following element is displayed on the page: (.*)")]
        public void ThenTheFollowingElementIsDisplayedOnThePage(string value)
        {
            AssertElement(value);
        }
    }
}

