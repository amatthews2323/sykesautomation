using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SykesCottagesTestAutomation.BaseClass
{
    [Binding]
    public sealed class LetYourPropertySteps : CommonSteps
    {
        //private readonly ScenarioContext context;

/*        public LetYourPropertySteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }*/

        public LetYourPropertySteps(SharedDriver context) : base(context)
        {
        }

        [Given(@"I am on the Sykes Homepage")]
        public void GivenIAmOnTheSykesHomepage()
        {
            //System.Threading.Thread.Sleep(2000);

            //Assert page title is correct
            AssertPageTitle("Holiday Cottages To Rent - UK Cottage Holidays");
        }

        [Given(@"I have navigated to the Let Your Property page")]
        public void GivenIHaveNavigatedToTheLetYourPropertyPage()
        {
            Click("Let Your Property");
            
            //Click the Let Your Property button
            //driver.FindElement(By.XPath("//*[contains(text(),'Let Your Property')]")).Click();
            //System.Threading.Thread.Sleep(4000);

            //Get page title
            //string pageTitle = driver.Title;

            //Assert page title is correct
            //Assert.IsTrue(pageTitle.Contains("Holiday Letting Agents For Cottages, Holiday Homes & Property"), pageTitle + " does not match Holiday Letting Agents For Cottages, Holiday Homes & Property");
            AssertPageTitle("Holiday Letting Agents For Cottages, Holiday Homes & Property");
        }


        [When(@"I click the Let your property button")]
        public void IClickTheLetYourPropertyButton()
        {
            //Click the Let Your Property button
            Click("Let Your Property");


            //driver.FindElement(By.XPath("//*[contains(text(),'Let Your Property')]")).Click();
            //System.Threading.Thread.Sleep(4000);
        }

        [Then(@"the relevant page title is diplayed")]
        public void ThenTheRelevantPageTitleIsDiplayed()
        {
            //Get page title
            //string pageTitle = driver.Title;

            //Assert page title is correct

            //Assert.IsTrue(pageTitle.Contains("Holiday Letting Agents For Cottages, Holiday Homes & Property"), pageTitle + " does not match Holiday Letting Agents For Cottages, Holiday Homes & Property");
            AssertPageTitle("Holiday Letting Agents For Cottages, Holiday Homes & Property");
        }

        [Then(@"the enquiry form is displayed")]
        public void ThenTheEnquiryFormIsDisplayed()
        {
            //Assert that the enquiry form is displayed
            Assert.IsTrue(shared.driver.FindElement(By.XPath("//div[@class='c-lyc-form js-enquiry-form']")).Displayed, "Enquiry form not found");
        }

        [Then(@"the Let Your Property page is diplayed")]
        public void ThenTheLetYourPropertyPageIsDisplayed()
        {
            //Get page title
            //string pageTitle = driver.Title;

            //Assert page title is correct
            //Assert.IsTrue(pageTitle.Contains("Holiday Letting Agents For Cottages, Holiday Homes & Property"), pageTitle + " does not match Holiday Letting Agents For Cottages, Holiday Homes & Property");
            AssertPageTitle("Holiday Letting Agents For Cottages, Holiday Homes & Property");
        }
    }
}

