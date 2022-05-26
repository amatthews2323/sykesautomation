using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace SykesCottagesTestAutomation.BaseClass
{
    [Binding]
    public sealed class LetYourPropertySteps : CommonSteps
    {
        public LetYourPropertySteps(SharedDriver context) : base(context)
        {
        }

        public string CSVValue;

        [Given(@"I am on the Sykes Homepage")]
        public void GivenIAmOnTheSykesHomepage()
        {
            LaunchWebsite();
            SetBrowserSize(Hooks.browserSize, Hooks.pageWidth, Hooks.pageHeight);
            ClosePopups();
            AssertPageTitle("Holiday Cottages To Rent");
        }

        [Given(@"I have navigated to the following page: (.*)")]
        public void GivenIHaveNavigatedToTheFollowingPage(string path = "")
        {
            LaunchWebsite("", path);
            SetBrowserSize(Hooks.browserSize, Hooks.pageWidth, Hooks.pageHeight);
            ClosePopups(_acceptCookies: true, _dismissAlerts: true);
        }

        [Given(@"I have navigated to the following page without dismissing alerts: (.*)")]
        public void GivenIHaveNavigatedToTheFollowingPageWithoutDismissingAlerts(string path = "")
        {
            LaunchWebsite("", path);
            ClosePopups(_acceptCookies: true, _dismissAlerts: false);
            SetBrowserSize(Hooks.browserSize, Hooks.pageWidth, Hooks.pageHeight);
        }

        [When(@"I navigate to (.*)")]
        public void WhenINavigateTo(string url = "")
        {
            GoTo(url);
        }

        [When(@"I close the pop-ups")]
        public void WhenICloseThePop_Ups()
        {
            ClosePopups();
        }

        [Then(@"I read the csv file (.*), colunm (.*), row (.*), search term (.*)")]
        public void ThenIReadTheCsvFileColunmRowSearchTerm(string fileName, string columnName, string rowName, string searchTerm)
        {
            CSVValue = ReadFromCSV(fileName, columnName, rowName, searchTerm);
        }

        [When(@"I click (.*)")]
        public void WhenIClick(string value)
        {
            Click(value);
        }

        [Then(@"I click (.*)")]
        public void ThenIClick(string value)
        {
            Click(value);
        }

        [When(@"I select the alert Get Started button")]
        public void WhenISelectTheAlertGetStartedButton()
        {
            Click("//div[contains(@class,'c-alert--blue')]//a[contains(text(),'Get started')]|//button[contains(@class,'enquiry-button')]", waitTime: 1);
        }

        [When(@"I select the Partially Managed Enquire Now button")]
        public void WhenISelectThePartiallyManagedEnquireNowButton()
        {
            Click("Partially managed");
            Click("//*[text()='Partially managed']//parent::div//following-sibling::div//a", waitTime: 5);
        }

        [When(@"I select the Fully Managed Enquire Now button")]
        public void WhenISelectTheFullyManagedEnquireNowButton()
        {
            Click("Fully managed");
            Click("//*[text()='Fully managed']//parent::div//following-sibling::div//a", waitTime: 5);
        }

        [Then(@"the enquiry form is displayed with the tint applied")]
        public void ThenTheEnquiryFormIsDisplayedWithTheTintApplied()
        {
            AssertElementDisplayed("//*[@class='o-overlay-tint o-overlay-tint--default' and @style='display: block;']");
        }

        [Then(@"the Testimonials carousel is displayed on the page")]
        public void ThenTheTestimonialsCarouselIsDisplayedOnThePage()
        {
            AssertElementDisplayed("//*[text()='What do our owners say?']/parent::div/div[contains(@class,'carousel-slider')]");
            AssertElementDisplayed("//*[text()='What do our owners say?']/parent::div//img[contains(@src,'arrow-prev.svg')]");
            AssertElementDisplayed("//*[text()='What do our owners say?']/parent::div//img[contains(@src,'arrow-next.svg')]");
        }

        [Then(@"the enquiry form submit button is disabled")]
        public void ThenTheEnquiryFormSubmitButtonIsDisabled()
        {
            AssertElementDisplayed("//form[@*='heroform']/button[@type='submit' and @disabled='']");
        }

        [Then(@"the enquiry form submit button is not disabled")]
        public void ThenTheEnquiryFormSubmitButtonIsNotDisabled()
        {
            AssertElementNotDisplayed("//form[@*='heroform']/button[@type='submit' and @disabled='']");
        }

        [When(@"I select the close icon on the form")]
        public void WhenISelectTheCloseIconOnTheForm()
        {
            Click("//div[@class='o-overlay__content']/button[@title='Close form']", waitTime: 1);
        }

        [When(@"I select the (.*) navigation link under (.*)")]
        public void WhenISelectTheNavigationLinkUnder(string headedLink, string headerMenu)
        {
            MouseOver(headerMenu);
            MouseOver(headedLink);
            Click(headedLink);
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
                AssertTextDisplayed(section.ToString());
            }
        }

        [Then(@"the following elements are dislpayed")]
        public void ThenTheFollowingElementsAreDislpayedOnThePage(Table table)
        {
            var elements = table.Rows.Select(r => r[0]).ToArray();
            foreach (var element in elements)
            {
                AssertElementDisplayed(element.ToString());
            }
        }

        [Then(@"the following elements are dislpayed within the (.*) section")]
        public void ThenTheFollowingElementsAreDislpayedWithinTheSection(string section, Table table)
        {
            var elements = table.Rows.Select(r => r[0]).ToArray();
            foreach (var element in elements)
            {
                AssertElementDisplayed(element.ToString(), section);
            }
        }


        [Then(@"the following elements are not dislpayed")]
        public void ThenTheFollowingElementsAreNotDislpayed(Table table)
        {
            var elements = table.Rows.Select(r => r[0]).ToArray();
            foreach (var element in elements)
            {
                AssertElementNotDisplayed(element.ToString());
            }
        }

        [Then(@"the following elements are not visible")]
        public void ThenTheFollowingElementsAreNotVisible(Table table)
        {
            var elements = table.Rows.Select(r => r[0]).ToArray();
            foreach (var element in elements)
            {
                AssertElementNotVisible(element.ToString());
            }
        }

        [Then(@"the following text is displayed: (.*)")]
        public void ThenTheFollowingTextIsDisplayed(string text)
        {
            AssertTextDisplayed(text);
        }

        [Then(@"the following element is displayed: (.*)")]
        public void ThenTheFollowingElementIsDisplayed(string value)
        {
            AssertElementDisplayed(value);
        }

        [Then(@"the following element is not displayed: (.*)")]
        public void ThenTheFollowingElementIsNotDisplayed(string value)
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
            AssertElementDisplayed("//div[@*='how-much-could-i-earn']/a[@*='homepage_calculator_cta_blue']");
        }

        [Then(@"the Holiday Letting Made Easy CTA is not displayed")]
        public void ThenTheHolidayLettingMadeEasyCTAIsNotDisplayed()
        {
            AssertElementNotDisplayed("//*[text()='Holiday letting made easy']/parent::div//a[@*='homepage_letting_made_easy_cta_blue']");
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

        [Then(@"the following slick dot is highlighted (.*)")]
        public void ThenTheFollowingSlickDotIsHighlighted(int value)
        {
            AssertElementDisplayed("//ul[@class='slick-dots']/li[" + value + "]//self::*[@class='slick-active']");
        }

        [Then(@"I wait (.*) seconds")]
        public void ThenIWaitSeconds(int value)
        {
            WaitASecond(value);
        }

        [When(@"I wait (.*) seconds")]
        public void WhenIWaitSeconds(int value)
        {
            WaitASecond(value);
        }

        [Given(@"I am accessing (.*)")]
        public void GivenIAmAccessing(string domain = "")
        {
            LaunchWebsite(domain);
            ClosePopups();
            SetBrowserSize(Hooks.browserSize, Hooks.pageWidth, Hooks.pageHeight);
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
                if (ElementDisplayed("//*[@class='c-alert c-alert--standard js-alert  is-visible']"))
                {
                    AssertElementDisplayed("//*[@class='c-alert c-alert--standard js-alert  is-visible']");
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
                if (ElementDisplayed("//*[@class='c-alert c-alert--standard js-alert  is-visible' and @style='display: none;']"))
                {
                    AssertElementDisplayed("//*[@class='c-alert c-alert--standard js-alert  is-visible' and @style='display: none;']");
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

        [Then(@"the page sections are displayed in the relevant positions")]
        public void ThenThePageSectionsAreDisplayedInTheRelevantPositions(Table table)
        {
            var dictionary = ToDictionary(table);
            var sections = table.Rows.Select(r => r[0]).ToArray();
            foreach (var section in sections)
            {
                Console.WriteLine("Section: " + section);
                Console.WriteLine("Position: " + dictionary[section]);
                AssertElementDisplayed("//section[" + dictionary[section] + " and contains(@id,'" + section + "')]|//section[" + dictionary[section] + "]//*[contains(@id,'" + section + "')]|//section[" + dictionary[section] + "]//*[contains(text(),'" + section + "')]|//section[" + dictionary[section] + " and contains(@class,'" + section + "')]|//section[" + dictionary[section] + "]//*[contains(@class,'" + section + "')]");
            }
        }

        [When(@"I select the form overlay submit button")]
        public void WhenISelectTheFormOverlaySubmitButton()
        {
            Click("//div[@id='js-overlay-list-property']//form[@*='list_property']/button[@type='submit']", waitTime: 2);
        }

        [When(@"I set the window size to (.*)")]
        public void GivenISetTheWindowSizeTo(string windowSize)
        {
            SetBrowserSize(windowSize);
            Refresh();
            ClosePopups();
        }
    }
}