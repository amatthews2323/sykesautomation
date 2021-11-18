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

        [Given(@"I am on the Sykes Homepage")]
        public void GivenIAmOnTheSykesHomepage()
        {
            LaunchWebsite();
            AssertPageTitle("Holiday Cottages To Rent");
        }

        [Given(@"I have navigated to the following page: (.*)")]
        public void GivenIHaveNavigatedToTheFollowingPage(string path = "")
        {
            LaunchWebsite("", path);
            CloseAllPopups();
        }

        [When(@"I navigate to (.*)")]
        public void WhenINavigateTo(string url = "")
        {
            shared.driver.Navigate().GoToUrl(url);
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
            TypeIfDisplayed("form_phone", dictionary["Phone number"]);
        }

        [Given(@"I have submitted an enquiry with the following details")]
        public void GivenIHaveSubmittedAnEnquiryWithTheFollowingDetails(Table table)
        {
            if (Hooks.Environemt != "Live")
            {
                LaunchWebsite("", "letyourcottage");
                CloseAllPopups();

                var dictionary = ToDictionary(table);
                Type("form_first_name", dictionary["Full name"]);
                Type("form_email", dictionary["Email address"]);
                TypeIfDisplayed("form_phone", dictionary["Phone number"]);

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

        [Then(@"I can complete the property creation process")]
        public void ThenICanCompleteThePropertyCreationProcess(Table table)
        {
            var dictionary = ToDictionary(table);
            string postcode = dictionary["Postcode"];
            if (postcode == "Random" | postcode == "")
            {
                postcode = GetPostcode();
            }
            Click("Next");

            //Step 1
            Click("I have a property I’d like to list", "Yes");
            Click("Next");

            //Step 2
            Type("location", postcode);
            Click("Search");
            ClickIfDisplayed("Expand area");
            Click("Select Address");
            WaitASecond();
            Click("Next");

            //Step 3
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
            Click("Finish");
        }

        [Then(@"I store the experiment IDs")]
        public void ThenIStoreTheExperimentIDs()
        {
            WaitASecond(5);
            ScrollTo("currentPage");
            int a = 1;
            while (a < 15)
            {
                IList<IWebElement> elementTexts = shared.driver.FindElements(By.XPath("//a[contains(text(),'KEP-')]|//a[contains(text(),'TES-')]|//a[contains(text(),'SDA-')]"));
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
            SetWindowSize(768, 1024);
        }
    }
}

