﻿using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SykesCottagesTestAutomation.BaseClass
{
    [Binding]
    public sealed class LetYourPropertySteps : CommonSteps
    {
        public LetYourPropertySteps(SharedDriver context) : base(context)
        {
        }

        private string activeExperiments;
        public string emailAddress;
        public string postcode;

        [Given(@"I am on the Sykes Homepage")]
        public void GivenIAmOnTheSykesHomepage()
        {
            LaunchWebsite();
            SetBrowserSize(Hooks.BrowserSize, Hooks.PageWidth, Hooks.PageHeight);
            CloseAllPopups();
            AssertPageTitle("Holiday Cottages To Rent");
        }

        [Given(@"I have navigated to the following page: (.*)")]
        public void GivenIHaveNavigatedToTheFollowingPage(string path = "")
        {
            LaunchWebsite("", path);
            SetBrowserSize(Hooks.BrowserSize, Hooks.PageWidth, Hooks.PageHeight);
            CloseAllPopups(acceptCookies: "Yes", dismissAlerts: "Yes");
        }

        [Given(@"I have navigated to the following page without dismissing alerts: (.*)")]
        public void GivenIHaveNavigatedToTheFollowingPageWithoutDismissingAlerts(string path = "")
        {
            LaunchWebsite("", path);
            CloseAllPopups(acceptCookies: "Yes", dismissAlerts: "No");
            SetBrowserSize(Hooks.BrowserSize, Hooks.PageWidth, Hooks.PageHeight);
        }

        [When(@"I navigate to (.*)")]
        public void WhenINavigateTo(string url = "")
        {
            shared.driver.Navigate().GoToUrl(url);
        }

        [When(@"I close the pop-ups")]
        public void WhenICloseThePop_Ups()
        {
            CloseAllPopups();
        }

        [When(@"I click (.*)")]
        public void IClick(string value)
        {
            Click(value);
        }

        [When(@"I select the alert Get Started button")]
        public void WhenISelectTheAlertGetStartedButton()
        {
            shared.driver.FindElement(By.XPath("//div[contains(@class,'c-alert--blue')]//a[contains(text(),'Get started')]|//button[contains(@class,'enquiry-button')]")).Click();
            WaitASecond();
        }

        [When(@"I select the Partially Managed Enquire Now button")]
        public void WhenISelectThePartiallyManagedEnquireNowButton()
        {
            shared.driver.FindElement(By.XPath("//*[text()='Partially managed']//parent::div//following-sibling::div//a")).Click();
            WaitASecond(5);
        }

        [When(@"I select the Fully Managed Enquire Now button")]
        public void WhenISelectTheFullyManagedEnquireNowButton()
        {
            shared.driver.FindElement(By.XPath("//*[text()='Fully managed']//parent::div//following-sibling::div//a")).Click();
            WaitASecond(5);
        }

        [Then(@"the enquiry form is displayed with the tint applied")]
        public void ThenTheEnquiryFormIsDisplayedWithTheTintApplied()
        {
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[@class='o-overlay-tint o-overlay-tint--default' and @style='display: block;']")).Count == 1, "Tint not displayed");
        }

        [Then(@"the Testimonials carousel is displayed on the page")]
        public void ThenTheTestimonialsCarouselIsDisplayedOnThePage()
        {
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[text()='What do our owners say?']/parent::div/div[contains(@class,'carousel-slider')]")).Count == 1, "Testimonials carousel not displayed");
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[text()='What do our owners say?']/parent::div//img[contains(@src,'arrow-prev.svg')]")).Count == 1, "Testimonials previous arrow not displayed");
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[text()='What do our owners say?']/parent::div//img[contains(@src,'arrow-next.svg')]")).Count == 1, "Testimonials next arrow not displayed");
        }

        [Then(@"the enquiry form submit button is disabled")]
        public void ThenTheEnquiryFormSubmitButtonIsDisabled()
        {
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//form[@*='heroform']/button[@type='submit' and @disabled='']")).Count == 1, "Disabled submit button not found");
        }

        [Then(@"the enquiry form submit button is not disabled")]
        public void ThenTheEnquiryFormSubmitButtonIsNotDisabled()
        {
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//form[@*='heroform']/button[@type='submit' and @disabled='']")).Count == 0, "Submit button disabled in error");
        }

        [When(@"I select the close icon on the form")]
        public void WhenISelectTheCloseIconOnTheForm()
        {
            shared.driver.FindElement(By.XPath("//div[@class='o-overlay__content']/button[@title='Close form']")).Click();
            WaitASecond();
        }

        [When(@"I select the (.*) navigation link under (.*)")]
        public void WhenISelectTheNavigationLinkUnder(string headedLink, string headerMenu)
        {
            MouseOver(headerMenu);
            MouseOver(headedLink);
            Click(headedLink);
        }

        [When(@"I submit an enquiry with the following details")]
        public void WhenISubmitAnEnquiryWithTheFollowingDetails(Table table)
        {
            var dictionary = ToDictionary(table);
            Type("heroform_first_name", dictionary["Full name"]);
            Type("heroform_email", dictionary["Email address"]);
            Type("heroform_phone", dictionary["Phone number"]);
            shared.driver.FindElement(By.XPath("//form[@*='heroform']/button[@*='submit']")).Click();
        }

        [When(@"I enter the following details on the enquiry form")]
        public void WhenIEnterTheFollowingDetailsOnTheEnquiryForm(Table table)
        {
            var dictionary = ToDictionary(table);
            Type("heroform_first_name", dictionary["Full name"]);

            if (dictionary["Email address"] == "Random")
            {
                Random r = new Random();
                emailAddress = "sykestest" + r.Next(100000, 999999).ToString() + "@example.org";
                Type("heroform_email", emailAddress);
            }
            else
            {
                Type("heroform_email", dictionary["Email address"]);
            }

            Type("heroform_phone", dictionary["Phone number"]);
            Click("form-heading-container");
            WaitASecond(2);
        }

        [When(@"I enter the following details in the enquiry form")]
        public void WhenIEnterTheFollowingDetailsInTheEnquiryForm(Table table)
        {
            LaunchWebsite("", "letyourcottage");
            CloseAllPopups();
            SetBrowserSize(Hooks.BrowserSize, Hooks.PageWidth, Hooks.PageHeight);

            var dictionary = ToDictionary(table);
            Type("heroform_first_name", dictionary["Full name"]);

            if (dictionary["Email address"] == "Random")
            {
                Random r = new Random();
                emailAddress = "sykestest" + r.Next(100000, 999999).ToString() + "@example.org";
                Type("heroform_email", emailAddress);
            }
            else
            {
                Type("heroform_email", dictionary["Email address"]);
            }
            Type("heroform_phone", dictionary["Phone number"]);
        }

        [When(@"I submit the enquiry form")]
        public void WhenISubmitTheEnquiryForm()
        {
            if (Hooks.Environemt != "Live")
            {
                var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//form[@*='heroform']/button[@*='submit']")));
                Console.WriteLine("Click the Get Started button");
                element.Click();
                WaitASecond(4);
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
                AssertText(section.ToString());
            }
        }

        [Then(@"the following elements are dislpayed on the page")]
        public void ThenTheFollowingElementsAreDislpayedOnThePage(Table table)
        {
            var elements = table.Rows.Select(r => r[0]).ToArray();
            foreach (var element in elements)
            {
                AssertElement(element.ToString());
            }
        }

        [Then(@"the following elements are not dislpayed on the page")]
        public void ThenTheFollowingElementsAreNotDislpayedOnThePage(Table table)
        {
            var elements = table.Rows.Select(r => r[0]).ToArray();
            foreach (var element in elements)
            {
                AssertElementNotDisplayed(element.ToString());
            }
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

        [Then(@"the following element is not displayed on the page: (.*)")]
        public void ThenTheFollowingElementIsNotDisplayedOnThePage(string value)
        {
            AssertElementNotDisplayed(value);
        }

        [Then(@"the following element is not visible: (.*)")]
        public void ThenTheFollowingElementIsNotVisible(string value)
        {
            AssertElementNotVisible(value);
        }

        [Then(@"the How Much Could I Earn CTA is not displayed")]
        public void ThenTheHowMuchCouldIEarnCTAIsNotDisplayed()
        {
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//div[@*='how-much-could-i-earn']/a[@*='homepage_calculator_cta_blue']")).Count == 0, "How Much Could I Earn CTA displayed in error");
        }

        [Then(@"the Holiday Letting Made Easy CTA is not displayed")]
        public void ThenTheHolidayLettingMadeEasyCTAIsNotDisplayed()
        {
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[text()='Holiday letting made easy']/parent::div//a[@*='homepage_letting_made_easy_cta_blue']")).Count == 0, "Holiday Letting Made Easy CTA displayed in error");
        }

        [When(@"I click the (.*) button")]
        public void ThenIClickTheButton(string element)
        {
            Click(element);
        }

        [When(@"I select option (.*) from the (.*) dropdown")]
        public void WhenISelectOptionFromTheDropdown(string option, string dropdown)
        {
            SelectFromDropdown(option, dropdown);
        }

        [Given(@"I view the Thinking of Buying section")]
        public void GivenIViewTheThinkingOfBuyingSection()
        {
            ClickIfDisplayed("/images/sykes/letyourcottage/collapseicons/money.svg");
        }


        [Then(@"the following slick dot is highlighted (.*)")]
        public void ThenTheFollowingSlickDotIsHighlighted(int value)
        {
            Console.WriteLine("Assert the relevant slick dot is highlighted");
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//ul[@class='slick-dots']/li[" + value + "]//self::*[@class='slick-active']")).Count != 0, "Element not found");
        }

        [Then(@"I wait (.*) seconds")]
        public void ThenIWaitSeconds(int value)
        {
            WaitASecond(value);
        }

        [Given(@"I am accessing (.*)")]
        public void GivenIAmAccessing(string domain = "")
        {
            LaunchWebsite(domain);
            CloseAllPopups();
            SetBrowserSize(Hooks.BrowserSize, Hooks.PageWidth, Hooks.PageHeight);
        }

        [When(@"I scroll to the following element: (.*)")]
        public void WhenIScrollToTheFollowingElement(string element)
        {
            ScrollTo(element);
        }

        [When(@"I switch focus to the new tab")]
        public void WhenISwitchFocusToTheNewTab()
        {
            SwitchFocus();
        }

        [Then(@"the alerts are displayed on the page")]
        public void ThenTheAlertsAreDisplayedOnThePage()
        {
            try
            {
                if (shared.driver.FindElement(By.XPath("//*[@class='c-alert c-alert--standard js-alert  is-visible']")).Displayed)
                {
                    Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[@class='c-alert c-alert--standard js-alert  is-visible']")).Count != 0, "Alert displayed on the page");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No alerts displayed");
            }
        }

        [Then(@"the alerts are not displayed on the page")]
        public void ThenTheAlertsAreNotDisplayedOnThePage()
        {
            try
            {
                if (shared.driver.FindElement(By.XPath("//*[@class='c-alert c-alert--standard js-alert  is-visible']")).Displayed)
                {
                    Assert.IsTrue(shared.driver.FindElements(By.XPath("//*[@class='c-alert c-alert--standard js-alert  is-visible' and @style='display: none;']")).Count != 0, "Alert displayed on the page");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No alerts displayed");
            }
        }

        [When(@"I enter (.*) in the following form field: (.*)")]
        public void WhenIEnterInTheFollowingFormField(string text, string field)
        {
            Type(field, text);
        }

        [Then(@"the (.*) section is displayed at position (.*)")]
        public void ThenTheSectionIsDisplayedAtPosition(string section, int position)
        {
            Console.WriteLine("Assert the " + section + "section is displayed at position " + position);
            Assert.IsTrue(shared.driver.FindElements(By.XPath("//section[" + position + " and contains(@id,'" + section + "')]|//section[" + position + "]//*[contains(@id,'" + section + "')]|//section[" + position + "]//*[contains(text(),'" + section + "')]")).Count != 0, "Text not found");
        }

        [When(@"I enter an email address without an @ symbol")]
        public void WhenIEnterAnEmailAddressWithoutAnSymbol()
        {
            Type("heroform_email", "test.com");
            Click("form-heading-container");
        }

        [When(@"I enter an email address without a valid domain")]
        public void WhenIEnterAnEmailAddressWithoutAValidDomain()
        {
            Type("heroform_email", "test@test");
            Click("form-heading-container");
        }

        [When(@"I enter a phone number with a non-numerical character")]
        public void WhenIEnterAPhoneNumberWithANon_NumericalCharacter()
        {
            Type("heroform_phone", "test");
            Click("form-heading-container");
        }

        [When(@"I enter a phone number with less than 10 digits")]
        public void WhenIEnterAPhoneNumberWithLessThanDigits()
        {
            Type("heroform_phone", "070000000");
            Click("form-heading-container");
        }

        [When(@"I enter a phone number with more than 15 digits")]
        public void WhenIEnterAPhoneNumberWithMoreThanDigits()
        {
            Type("heroform_phone", "0700000000000000");
            Click("form-heading-container");
        }

        [When(@"I enter a phone number with spaces and \+(.*)")]
        public void WhenIEnterAPhoneNumberWithSpacesAnd(int p0)
        {
            Type("heroform_phone", "+44 7000 000 000");
            Click("form-heading-container");
        }

        [Then(@"I can add a property with the following postcode: (.*)")]
        public void ThenICanCompleteThePropertyCreationProcess(string _postcode = "Random")
        {
            //Step 1
            Click("I have a property I’d like to list");
            Click("Next");
            WaitASecond();

            //Step 2
            if (_postcode == "Random")
            {
                _postcode = GetPostcode();
            }
            postcode = _postcode;
            Type("location", postcode);
            Click("Search");
            ClickIfDisplayed("Expand area");
            Click("Select Address");
            WaitASecond();
            Click("Finish");
            WaitASecond();
        }

        [When(@"I select Get Started Online")]
        public void WhenISelectGetStartedOnline()
        {
            ClickIfDisplayed("Get started online");
            ClickIfDisplayed("thankyoulycgetstartedonline");
        }

        [Then(@"I can create an account using password: (.*)")]
        public void ThenICanCreateAnAccountUsingPassword(string password)
        {
            WaitASecond(2);
            shared.driver.FindElement(By.XPath("//button/span[contains(text(),'Start taking bookings')]")).Click();
            WaitASecond(2);
            Type("digital-onboarding-password", password);
            Click("Create my account");
        }

        [Then(@"I can register my account via the email")]
        public void ThenICanRegisterMyAccountViaTheEmail()
        {
            shared.driver.Navigate().GoToUrl("https://mailcatcher.staging.sykes.cloud/");
            Click(emailAddress);
            WaitASecond();
            string emailPath = shared.driver.FindElement(By.XPath("//dd[text()='<" + emailAddress + ">']/ancestor::article/iframe")).GetAttribute("src");
            shared.driver.Navigate().GoToUrl(emailPath); 
            SetBrowserSize("Max");
            Click("Verify your account");
        }

        [Then(@"I can sign in to my account using the following details")]
        public void ThenICanSignInToMyAccountUsingTheFollowingDetails(Table table)
        {
            var dictionary = ToDictionary(table);
            if (dictionary["Username"] == "Random")
            {
                Type("email", emailAddress);
            }
            else
            {
                Type("email", dictionary["Username"]);
            }
            Type("password", dictionary["Password"]);

            ClickAttribute("submit", "input");
        }

        [Then(@"I can complete Additional Property Details Step 1 - Property Location")]
        public void ThenICanCompleteStep1OfAddingAdditionalPropertyDetails()
        {
            Screenshot("DO - Additional Property Details - Step 1 - Property Location");
            AssertText("Property Location");

            JSType("digital-onboarding-directions-to-property", "Automated test");
            JSClick("Directions to your property");
            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(3);
        }

        [Then(@"I can complete Additional Property Details Step 2 - Guests and bedrooms")]
        public void ThenICanCompleteStep2OfAddingAdditionalPropertyDetails(Table table)
        {
            Screenshot("DO - Additional Property Details - Step 2 - Guests and bedrooms");
            AssertText("How many guests can your property sleep?");

            var dictionary = ToDictionary(table);
            int guests = int.Parse(dictionary["Number of guests"]);
            for (int i = 1; i < guests; i++)
            {
                JSClick("//input[@name='ds_guests']/following-sibling::*");
            }
            int bedrooms = int.Parse(dictionary["Number of bedrooms"]);
            for (int i = 1; i < bedrooms; i++)
            {
                JSClick("//input[@name='ds_bedroom_count']/following-sibling::*");
            }
            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(3);
        }

        [Then(@"I can complete Additional Property Details Step 3 - Photos of your property")]
        public void ThenICanCompleteStep3OfAddingAdditionalPropertyDetails()
        {
            Screenshot("DO - Additional Property Details - Step 3 - Photos of your property");
            AssertText("Photos of your property");

            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(2);
            shared.driver.FindElement(By.XPath("//textarea[@id='upload-images-reason']")).SendKeys("Automated test");
            WaitASecond();
            JSClick("//button/span[contains(text(),'Continue')]");
            WaitASecond(5);
        }

        [Then(@"I can complete Additional Property Details Step 4 - About your property")]
        public void ThenICanCompleteStep4OfAddingAdditionalPropertyDetails()
        {
            Screenshot("DO - Additional Property Details - Step 4 - About your property");
            AssertText("About your property");

            Type("digital-onboarding-property-address", "Test");
            WaitASecond();
            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(5);
        }

        [Then(@"I can complete Additional Property Details Step 5 - Key Collection")]
        public void ThenICanCompleteStep5OfAddingAdditionalPropertyDetails()
        {
            Screenshot("DO - Additional Property Details - Step 5 - Key Collection");
            AssertText("Key Collection");

            JSClick("//span[text()='Other']");
            WaitASecond(1);
            shared.driver.FindElement(By.XPath("//textarea[@id='key-collection-alt-instructions']")).SendKeys("Test");
            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(3);
        }

        [Then(@"I can complete Additional Property Details Step 6 - Booking details")]
        public void ThenICanCompleteStep6OfAddingAdditionalPropertyDetails()
        {
            Screenshot("DO - Additional Property Details - Step 6 - Booking details");
            AssertText("Booking details");

            JSType("digital-signup-booking-start-date-hidden-input", DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"));
            WaitASecond();
            JSClick("//span[text()='Friday']");
            JSClick("//span[@class='c-selection-button__label' and text()='Yes']");
            WaitASecond();
            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(3);
        }

        [Then(@"I can complete Additional Property Details Step 7 - Upcoming bookings")]
        public void ThenICanCompleteStep7OfAddingAdditionalPropertyDetails()
        {
            Screenshot("DO - Additional Property Details - Step 7 - Upcoming bookings");
            AssertText("Upcoming bookings");

            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(3);
        }

        [Then(@"I can complete Personal Details Step 1 - Personal details")]
        public void ThenICanCompleteStep1OfAddingPersonalDetails()
        {
            Screenshot("DO - Personal Details - Step 1 - Personal details");
            AssertText("Personal details");

            shared.driver.FindElement(By.XPath("//input[@id='digital-onboarding-owner-postcode']")).SendKeys(postcode);
            WaitASecond(2);
            JSClick("//div[@aria-expanded='true']//button/span[contains(text(),'Search')]");
            WaitASecond();
            JSClick("//button[@aria-label='Select Address']");
            WaitASecond(2);
            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(3);
        }

        [Then(@"I can complete Personal Details Step 2 - Your bank details")]
        public void ThenICanCompleteStep2OfAddingPersonalDetails()
        {
            Screenshot("DO - Personal Details - Step 2 - Your bank details");
            AssertText("Your bank details");

            shared.driver.FindElement(By.XPath("//input[@id='digital-onboarding-account-name']")).SendKeys("Test");
            shared.driver.FindElement(By.XPath("//input[@id='digital-onboarding-account-number']")).SendKeys("01010101");
            shared.driver.FindElement(By.XPath("//input[@id='digital-onboarding-sort-code']")).SendKeys("010101");
            WaitASecond();
            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(3);
        }

        [Then(@"I can complete Personal Details Step 3 - File uploads")]
        public void ThenICanCompleteStep3OfAddingPersonalDetails()
        {
            Screenshot("DO - Personal Details - Step 3 - File uploads");
            AssertText("File uploads");

            JSClick("//*[@*='digital-onboarding-gas-certificate-no']");
            JSClick("//*[@*='digital-onboarding-liability-certificate-no']");
            JSClick("//*[@*='digital-onboarding-fire-certificate-no']");
            JSClick("//*[@*='digital-onboarding-waterSupply-certificate-no']");
            WaitASecond();
            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(3);
        }

        [Then(@"I can complete Personal Details Step 4 - Select commission tier")]
        public void ThenICanCompleteStep4OfAddingPersonalDetails()
        {
            Screenshot("DO - Personal Details - Step 4 - Select commission tier");
            AssertText("Select commission tier");

            JSClick("//*[@*='commission-full']");
            WaitASecond();
            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(3);
        }

        [Then(@"I can complete Personal Details - Step 5 - Property Pricing")]
        public void ThenICanCompleteStep5OfAddingPersonalDetails()
        {
            Screenshot("DO - Personal Details - Step 5 - Property Pricing");
            AssertText("Property Pricing");

            WaitASecond(59);
            JSClick("//button/span[contains(text(),'Next')]");
            WaitASecond(3);
        }

        [Then(@"I can sign the contract and complete digital onboarding")]
        public void ThenICanSignTheContractAndCompleteDigitalOnboarding()
        {
            Screenshot("DO - Contract Signing");
            AssertText("Your online agreement");

            JSClick("//*[@*='do_contract_sole_owner']");
            JSClick("//span[text()='I accept the terms and conditions']");
            WaitASecond(2);
            shared.driver.FindElement(By.XPath("//input[@id='do_contract_signature']")).SendKeys("Automated Test");
            WaitASecond(2);
            JSClick("//button/span[contains(text(),'Submit Contract')]");
            WaitASecond(5);
        }

        [Then(@"I store the experiment IDs")]
        public void ThenIStoreTheExperimentIDs()
        {
            WaitASecond(5);
            ScrollTo("currentPage");
            int a = 1;
            while (a < 15)
            {
                IList<IWebElement> elementTexts = shared.driver.FindElements(By.XPath("//a[contains(text(),'KEP-')]"));
                string[] elementIDs = new string[elementTexts.Count];
                int i = 0;
                foreach (IWebElement element in elementTexts)
                {
                    elementIDs[i++] = Regex.Replace(element.Text, "[^0-9]", "");
                }
                Console.WriteLine("{0}", string.Join(",", elementIDs));
                try
                {
                    if (shared.driver.FindElement(By.XPath("//li[@class='ng-scope']/a[text()='Next']")).Displayed)
                    {
                        shared.driver.FindElement(By.XPath("//li[@class='ng-scope']/a[text()='Next']")).Click();
                        WaitASecond(1);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Next button not found");
                }
                a++;
            }
        }

        [When(@"I store the active experiment IDs")]
        public void WhenIStoreTheActiveExperimentIDs()
        {
            activeExperiments = GetJavaScriptText("experimental_experiments");
        }

        [When(@"I search for the experiment details")]
        public void WhenISearchForTheExperimentDetails()
        {
            WaitASecond(2);
            Console.WriteLine("Experiment details:");
            var array = activeExperiments.Split(",");
            for (int i = 0; i < array.Length; i++)
            {
                string id = array[i].ToString().Trim();
                Type("text_search", id);
                WaitASecond();
                string experimentId = shared.driver.FindElement(By.XPath("//a[@class='ng-binding']")).Text;
                string experimentName = shared.driver.FindElement(By.XPath("//p[@class='name ng-binding']")).Text;
                Console.WriteLine(experimentId + " " + experimentName);
            }
        }

        [When(@"I apply the following experiment: (.*)")]
        public void WhenIApplyTheFollowingExperiment(string experimentId)
        {
            ApplyExperiment(experimentId);
            Click("movePanel");
        }

        [Then(@"the following experiements are enabled")]
        public void ThenTheFollowingExperiementsAreEnabled(Table table)
        {
            var experiments = table.Rows.Select(r => r[0]).ToArray();
            foreach (var experiment in experiments)
            {
                Assert.IsTrue(activeExperiments.Contains(experiment), "Experiment " + experiment + " not found");
            }
        }

        [Then(@"I navigate to the Holmes statistics page and store the conversion percentage")]
        public void ThenINavigateToTheHolmesStatisticsPageAndStoreTheConversionPercentage(Table table)
        {
            string conversion = "";

            var experiments = table.Rows.Select(r => r[0]).ToArray();
            foreach (var experiment in experiments)
            {
                try
                {
                    shared.driver.Navigate().GoToUrl("https://holmes.prod.sykes.cloud/experiments/google-analytics/" + experiment + "?conversiontype=owner_enquiry");
                    var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//tr[contains(@ng-show,'keyFigures.conversion')]//strong")));
                    conversion += "\n" + shared.driver.FindElement(By.XPath("//tr[contains(@ng-show,'keyFigures.conversion')]//strong")).Text;
                }
                catch (Exception)
                {
                    conversion += "\n Holmes error";
                }
            }
            Console.WriteLine("Conversion values: " + conversion);
        }

        [Then(@"I search for the experient and store the status")]
        public void ThenISearchForTheExperientAndStoreTheStatus(Table table)
        {
            string status = "";

            var experiments = table.Rows.Select(r => r[0]).ToArray();
            foreach (var experiment in experiments)
            {
                Type("text_search", experiment);
                var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//tbody[@*='experiment in filteredExperiments']/tr/td[4]")));
                string _status = shared.driver.FindElement(By.XPath("//tbody[@*='experiment in filteredExperiments']/tr/td[4]")).Text.Trim();
                status += "\n" + _status.Replace("Active", "Started").Replace("Off", "Stopped");
            }
            Console.WriteLine("Experiment statuses: " + status);
        }

        [When(@"I set the window size to (.*)")]
        public void GivenISetTheWindowSizeTo(string windowSize)
        {
            SetBrowserSize(windowSize);
            shared.driver.Navigate().Refresh();
            CloseAllPopups();
        }
    }
}