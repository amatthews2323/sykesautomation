using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

        [Given(@"I am on the Sykes Homepage")]
        public void GivenIAmOnTheSykesHomepage()
        {
            LaunchWebsite();
            CloseAllPopups();
            SetBrowserSize(Hooks.BrowserSize, Hooks.PageWidth, Hooks.PageHeight);
            AssertPageTitle("Holiday Cottages To Rent");
        }

        [Given(@"I have navigated to the following page: (.*)")]
        public void GivenIHaveNavigatedToTheFollowingPage(string path = "")
        {
            LaunchWebsite("", path);
            CloseAllPopups();
            SetBrowserSize(Hooks.BrowserSize, Hooks.PageWidth, Hooks.PageHeight);
        }

        [When(@"I navigate to (.*)")]
        public void WhenINavigateTo(string url = "")
        {
            shared.driver.Navigate().GoToUrl(url);
        }

        [When(@"I click (.*)")]
        public void IClick(string value)
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

        [When(@"I submit an enquiry with the following details")]
        public void WhenISubmitAnEnquiryWithTheFollowingDetails(Table table)
        {
            var dictionary = ToDictionary(table);
            Type("heroform_first_name", dictionary["Full name"]);
            Type("heroform_email", dictionary["Email address"]);
            Type("heroform_phone", dictionary["Phone number"]);
            shared.driver.FindElement(By.XPath("//form[@*='heroform']/button[@*='submit']")).Click();
        }

        [Given(@"I have submitted an enquiry with the following details")]
        public void GivenIHaveSubmittedAnEnquiryWithTheFollowingDetails(Table table)
        {
            if (Hooks.Environemt != "Live")
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

                shared.driver.FindElement(By.XPath("//form[@*='heroform']/button[@*='submit']")).Click();
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
                AssertElementNotPresent(element.ToString());
            }
        }

        [When(@"I click the (.*) button")]
        public void ThenIClickTheButton(string element)
        {
            Click(element);
        }

        [Given(@"I am accessing (.*)")]
        public void GivenIAmAccessing(string domain = "")
        {
            LaunchWebsite(domain);
            CloseAllPopups();
            SetBrowserSize(Hooks.BrowserSize, Hooks.PageWidth, Hooks.PageHeight);
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
            AssertElementNotPresent(value);
        }

        [When(@"I enter an email address without an @ symbol")]
        public void WhenIEnterAnEmailAddressWithoutAnSymbol()
        {
            Type("email", "test.com");
        }

        [When(@"I enter an email address without a valid domain")]
        public void WhenIEnterAnEmailAddressWithoutAValidDomain()
        {
            Type("email", "test@test");
        }

        [When(@"I enter a phone number with a non-numerical character")]
        public void WhenIEnterAPhoneNumberWithANon_NumericalCharacter()
        {
            Type("phone", "test");
        }

        [When(@"I enter a phone number with less than 10 digits")]
        public void WhenIEnterAPhoneNumberWithLessThanDigits()
        {
            Type("phone", "070000000");
        }

        [When(@"I enter a phone number with more than 15 digits")]
        public void WhenIEnterAPhoneNumberWithMoreThanDigits()
        {
            Type("phone", "0700000000000000");
        }

        [Then(@"I can add a property with the following postcode: (.*)")]
        public void ThenICanCompleteThePropertyCreationProcess(string postcode = "")
        {
            //Step 1
            Click("I have a property I’d like to list", "Yes");
            Click("Next");

            //Step 2
            if (postcode == "Random" | postcode == "")
            {
                postcode = GetPostcode();
            }
            Type("location", postcode);
            Click("Search");
            ClickIfDisplayed("Expand area");
            Click("Select Address");
            WaitASecond();
            Click("Finish");

            /*            //Step 3
                        int bedrooms = int.Parse(dictionary["Number of bedrooms"]);
                        for (int i = 1; i < bedrooms; i++)
                        {
                            ClickButton("+");
                        }
                        WaitASecond();
                        Click("Next");

                        //Step 4
                        int guests = int.Parse(dictionary["Number of guests"]);
                        for (int i = 1; i < guests; i++)
                        {
                            shared.driver.FindElement(By.XPath("//input[@name='ds_guests']/following-sibling::*")).Click();
                        }
                        WaitASecond();
                        Click("Finish");*/
        }

        [Then(@"I can create an account using password: (.*)")]
        public void ThenICanCreateAnAccountUsingPassword(string password)
        {
            Click("Start taking bookings");
            Type("password", password);
            Click("Create my account");
        }

        [Then(@"I can register my account via the email")]
        public void ThenICanRegisterMyAccountViaTheEmail()
        {
            LaunchWebsite("https://mailcatcher.staging.sykes.cloud/");
            Click(emailAddress);

        }

        [Then(@"I can sign in to my account using the following details")]
        public void ThenICanSignInToMyAccountUsingTheFollowingDetails(Table table)
        {
            LaunchWebsite("", "account/login");

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

            Click("submit");
        }

        [Then(@"I can complete the digital onboarding process using the following deatils")]
        public void ThenICanCompleteTheDigitalOnboardingProcessUsingTheFollowingDeatils(Table table)
        {
            
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
        }

        [When(@"I set the window to tablet size")]
        public void GivenISetTheWindowToTabletSize()
        {
            SetBrowserSize("Tablet");
        }
    }
}