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
            if (Hooks.Environemt != "Live")
            {
                AssertPageTitle("Holiday Cottages To Rent - UK Holidays | Sykes Cottages");
            }
            else
            {
                AssertPageTitle("Holiday Cottages To Rent - UK Cottage Holidays");
            }
        }

        [Given(@"I have navigated to the Let Your Property page")]
        public void GivenIHaveNavigatedToTheLetYourPropertyPage()
        {
            Click("Let Your Property");
            AssertPageTitle("Holiday Letting Agents For Cottages, Holiday Homes & Property");
        }

        [When(@"I click the Let your property button")]
        public void IClickTheLetYourPropertyButton()
        {
            Click("Let Your Property");
        }

        [Then(@"the enquiry form is displayed")]
        public void ThenTheEnquiryFormIsDisplayed()
        {
            Assert.IsTrue(shared.driver.FindElement(By.XPath("//div[contains(@class,'js-enquiry-form')]")).Displayed, "Enquiry form not found");
        }

        [Then(@"the Let Your Property page is diplayed")]
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
                Click("enquiry-button lyc-cta lyc-cta--blue u-full-width js-enquiry-form-button");
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
    }
}

