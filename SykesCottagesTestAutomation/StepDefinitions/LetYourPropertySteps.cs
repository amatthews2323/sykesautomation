using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

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
            AssertPageTitle("Holiday Cottages To Rent - UK Cottage Holidays");
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
    }
}

