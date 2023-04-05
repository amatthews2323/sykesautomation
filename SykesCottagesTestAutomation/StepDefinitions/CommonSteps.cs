using System;
using System.Linq;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace SykesCottagesTestAutomation.BaseClass
{
    [Binding]
    public sealed class CommonSteps : MethodLibrary
    {
        public CommonSteps(SharedDriver context) : base(context)
        {
        }

        [Given(@"I am on the following webpage: (.*)")]
        public void GivenIAmOnTheFollowingWebpage(string domain = "")
        {
            LaunchWebsite(domain);
        }

        [Given(@"I am on the Sykes Homepage")]
        public void GivenIAmOnTheSykesHomepage()
        {
            LaunchWebsite();
        }

        [Given(@"I have navigated to the following page: (.*)")]
        public void GivenIHaveNavigatedToTheFollowingPage(string path = "")
        {
            LaunchWebsite(Hooks.domainOverride, path);
        }

        [Given(@"I have navigated to the following brand: (.*)")]
        public void GivenINavigateToTheFollowingBrand(string brand)
        {
            string domain = ReadFromCSV(fileName: "EnvironmentURLs", columnName: "URL", rowName: "Name", searchTerm: Hooks.environemt + " " + brand);
            LaunchWebsite(domain);
        }

        [Given(@"I have navigated to the following page without dismissing alerts: (.*)")]
        public void GivenIHaveNavigatedToTheFollowingPageWithoutDismissingAlerts(string path = "")
        {
            LaunchWebsite("", path);
        }

        [When(@"I navigate to (.*)")]
        public void WhenINavigateTo(string url = "")
        {
            GoTo(url);
        }

        [When(@"I refresh the page")]
        public void WhenIRefreshThePage()
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
            try
            {
                WaitUntilClickable(value);
            }
            catch
            {
                Console.WriteLine("Element " + value + " not clickable");
            }
            try
            {
                Click(value);
            }
            catch
            {
                Console.WriteLine("Click failed; try with JavaScript...");
                JSClick(value);
            }
        }

        [Then(@"I click (.*)")]
        public void ThenIClick(string value)
        {
            try
            {
                WaitUntilClickable(value);
            }
            catch
            {
                Console.WriteLine("Element " + value + " not clickable");
            }
            try
            {
                Click(value);
            }
            catch
            {
                Console.WriteLine("Click failed; try with JavaScript...");
                JSClick(value);
            }
        }

        [Then(@"I try clicking (.*)")]
        public void ThenITryClicking(string value)
        {
            ClickIfDisplayed(value);
        }

        [When(@"I try clicking (.*)")]
        public void WhenITryClicking(string value)
        {
            ClickIfDisplayed(value);
        }

        [When(@"I select (.*) within the (.*) section")]
        public void WhenISelectWithinTheSection(string element, string section)
        {
            Click(XPathBuilder(section) + XPathBuilder(element));
        }

        [Then(@"I select (.*) within the (.*) section")]
        public void ThenISelectWithinTheSection(string element, string section)
        {
            Click(XPathBuilder(section) + XPathBuilder(element));
        }

        [When(@"I select the Partially Managed Enquire Now button")]
        public void WhenISelectThePartiallyManagedEnquireNowButton()
        {
            ScrollTo("Partially managed");
            Click("Partially managed");
            ScrollTo("//*[text()='Partially managed']//parent::div//following-sibling::div//a");
            Click("//*[text()='Partially managed']//parent::div//following-sibling::div//a");
        }

        [When(@"I select the Fully Managed Enquire Now button")]
        public void WhenISelectTheFullyManagedEnquireNowButton()
        {
            ScrollTo("Fully managed");
            Click("Fully managed");
            ScrollTo("//*[text()='Fully managed']//parent::div//following-sibling::div//a");
            Click("//*[text()='Fully managed']//parent::div//following-sibling::div//a");
        }

        [Then(@"the enquiry form is displayed with the tint applied")]
        public void ThenTheEnquiryFormIsDisplayedWithTheTintApplied()
        {
            WaitUntilExists("//*[@class='o-overlay-tint o-overlay-tint--default' and @style='display: block;']", 5);
            AssertElementDisplayed("//*[@class='o-overlay-tint o-overlay-tint--default' and @style='display: block;']");
        }

        [When(@"I select the (.*) navigation link under (.*)")]
        public void WhenISelectTheNavigationLinkUnder(string headedLink, string headerMenu)
        {
            MouseOver(headerMenu);
            MouseOver(headedLink);
            Click(headedLink);
        }

        [When(@"I hover over (.*)")]
        public void WhenIHoverOver(string element)
        {
            MouseOver(element);
        }

        [Then(@"the following page title is displayed: (.*)")]
        public void ThenTheFollowingPageTitleIsDisplayed(string value)
        {
            WaitUntilExists(value);
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

        [Then(@"the relevant elements are dislpayed")]
        public void ThenTheRelevantElementsAreDislpayedOnThePage(Table table)
        {
            var elements = table.Rows.Select(r => r[0]).ToArray();
            foreach (var element in elements)
            {
                WaitUntilExists(element);
                AssertElementDisplayed(element.ToString());
            }
        }

        [Then(@"the relevant elements are dislpayed within the (.*) section")]
        public void ThenTheRelevantElementsAreDislpayedWithinTheSection(string section, Table table)
        {
            var elements = table.Rows.Select(r => r[0]).ToArray();
            foreach (var element in elements)
            {
                WaitUntilExists(XPathBuilder(section) + XPathBuilder(element.ToString()), 5);
                AssertElementDisplayed(XPathBuilder(section) + XPathBuilder(element.ToString()));
            }
        }

        [Then(@"the relevant elements are not dislpayed")]
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
            WaitUntilExists(value, 5);
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

        [When(@"I select option (.*) from the (.*) dropdown")]
        public void WhenISelectOptionFromTheDropdown(string option, string dropdown)
        {
            SelectFromDropdown(option, dropdown);
        }

        [When(@"I wait (.*) seconds")]
        public void WhenIWaitSeconds(int value)
        {
            WaitASecond(value);
        }

        [Then(@"I wait (.*) seconds")]
        public void ThenIWaitSeconds(int value)
        {
            WaitASecond(value);
        }

        [When(@"I wait up to (.*) seconds for the following to be displayed: (.*)")]
        public void WhenIWaitUpToSecondsForTheFollowingToBeDisplayed(int seconds, string element)
        {
            WaitUntilExists(element, seconds);
        }

        [Then(@"I wait up to (.*) seconds for the following to be displayed: (.*)")]
        public void ThenIWaitUpToSecondsForTheFollowingToBeDisplayed(int seconds, string element)
        {
            WaitUntilVisible(element, seconds);
        }

        [When(@"I wait up to (.*) seconds for the following to be clickable: (.*)")]
        public void WhenIWaitUpToSecondsForTheFollowingToBeClickable(int seconds, string element)
        {
            WaitUntilClickable(element, seconds);
        }

        [Then(@"I wait up to (.*) seconds for the following to be clickable: (.*)")]
        public void ThenIWaitUpToSecondsForTheFollowingToBeClickable(int seconds, string element)
        {
            WaitUntilClickable(element, seconds);
        }

        [When(@"I scroll to the following element: (.*)")]
        public void WhenIScrollToTheFollowingElement(string element)
        {
            ScrollTo(element);
        }

        [Then(@"I scroll to the following element: (.*)")]
        public void ThenIScrollToTheFollowingElement(string element)
        {
            ScrollTo(element);
        }

        [When(@"I switch focus to the new tab")]
        public void WhenISwitchFocusToTheNewTab()
        {
            SwitchFocus();
        }

        [Then(@"I switch focus to the new tab")]
        public void ThenISwitchFocusToTheNewTab()
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
            WaitUntilClickable(field, 5);
            Type(field, text);
        }

        [Then(@"I enter (.*) in the following form field: (.*)")]
        public void ThenIEnterInTheFollowingFormField(string text, string field)
        {
            WaitUntilClickable(field, 5);
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

        [Then(@"I take a screenshot")]
        public void ThenITakeAScreenshot()
        {
            string filename = "Screenshot_" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");
            Screenshot(filename);
        }

        [When(@"I log in with the following credentials")]
        public void WhenILogInWithTheFollowingCredentials(Table table)
        {
            var dictionary = ToDictionary(table);

            if (ElementNotDisplayed(dictionary["Username"]))
            {
                Type("email", dictionary["Username"]);
                Click("submit", "input");
            }
            WaitASecond(2);
            Type("passwd", dictionary["Password"]);
            Click("submit", "input", waitTime: 3);
        }

        [Then(@"I store all headers on the page")]
        public void ThenIStoreAllHeadersOnThePage()
        {
            GetAllHeaders();
        }

        [Then(@"I store the header on the following pages")]
        public void ThenIStoreTheHeaderOnTheFollowingPages(Table table)
        {
            string headers = "Headers:\n";
            var links = table.Rows.Select(r => r[0]).ToArray();

            foreach (var link in links)
            {
                if (link.Contains("http"))
                {
                    GoTo(link);
                }
                else
                {
                    GoTo(url + link);
                }
                string header = GetHeader();
                headers += "\n| " + link + " | " + header + " |";
                //Console.WriteLine("| " + link + " | " + header + " |");
            }
            Console.WriteLine("\n" + headers + "\n");
        }

        [Then(@"I store all links on the page")]
        public void ThenIStoreAllLinksOnThePage()
        {
            GetAllLinks();
        }

        [Then(@"I store all images on the page")]
        public void ThenIStoreAllImagesOnThePage()
        {
            GetAllImages();
        }

        [Then(@"I store the headers and output a test script")]
        public void ThenIStoreTheHeadersAndOutputATestScript()
        {
            BuildHeaderTest();
        }

        [Then(@"I store the links and output a test script")]
        public void ThenIStoreTheLinksAndOutputATestScript()
        {
            BuildLinkTest();
        }

        [Then(@"I store the images and output a test script")]
        public void ThenIStoreTheImagesAndOutputATestScript()
        {
            BuildImageTest();
        }

        [Then(@"the following links load correctly")]
        public void ThenTheFollowingLinksLoadCorrectly(Table table)
        {
            var links = table.Rows.Select(r => r[0]).ToArray();
            foreach (var link in links)
            {
                if (link.Contains("http"))
                {
                    GoTo(link);
                }
                else
                {
                    GoTo(url + link);
                }

                Regex word = new(@".*/(.*)");
                Match m = word.Match(link.ToString());
                Screenshot(m.Groups[1].ToString());
            }
        }
    }
}