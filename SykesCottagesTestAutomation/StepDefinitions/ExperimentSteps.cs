using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace SykesCottagesTestAutomation.BaseClass
{
    [Binding]
    public sealed class ExperimentSteps : MethodLibrary
    {
        public ExperimentSteps(SharedDriver context) : base(context)
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
                        Click("//li[@class='ng-scope']/a[text()='Next']", waitTime: 1);
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
            activeExperiments = GetJavaScriptText("control_experiments") + "," + GetJavaScriptText("experimental_experiments");
        }

        [When(@"I search for the experiment details")]
        public void WhenISearchForTheExperimentDetails()
        {
            string experimentList = "\nActive experiments:\n";
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
                experimentList += "\n" + id + " " + experimentId + " " + experimentName; 
            }
            Console.WriteLine(experimentList + "\n");
        }

        [When(@"I return the experiment details (.*)")]
        public void WhenIReturnTheExperimentDetails(string experiments)
        {
            WaitASecond(2);
            Console.WriteLine("Experiment details:");
            var array = experiments.Split(",");
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

        [Given(@"the following experiment is active: (.*)")]
        public void GivenTheFollowingExperimentIsActiveLetYourCottages_InfoPageInvestmentAdviceLYP(string experiment)
        {
            LaunchWebsite("https://holmes.prod.sykes.cloud/experiments/");
            Type("text_search", experiment);
            var wait = new WebDriverWait(shared.driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//tbody[@*='experiment in filteredExperiments']/tr/td[4]")));
            string experimentStatus = shared.driver.FindElement(By.XPath("//tbody[@*='experiment in filteredExperiments']/tr/td[4]")).Text.Trim();
            StringAssert.Contains(experimentStatus, "Active", "\nExperiment " + experiment + " not active\n");
            Console.WriteLine("\nExperiment " + experiment + " active.\n");
            shared.driver.Quit();
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
                Assert.IsTrue(experimentalExperiments.Contains(experiment), "Experiment " + experiment + " not found");
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
                    GoTo("https://holmes.prod.sykes.cloud/experiments/google-analytics/" + experiment + "?conversiontype=owner_enquiry");
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

        [Then(@"experiment LetYourCottages_LinkbackforconsumertrafficLYP192 is applied")]
        public void ThenExperimentLetYourCottages_LinkbackforconsumertrafficLYP192IsApplied()
        {
            if (experimentalExperiments.Contains("4912"))
            {
                Console.WriteLine("\nExperiment LetYourCottages_LinkbackforconsumertrafficLYP192 (4912) enabled.\n");
                Click("Book a holiday");
                MouseOver("Let Your Property");
                Click("Let Your Property");
                AssertElementDisplayed("Go back to booking a holiday");
            }
            else
            {
                if (controlExperiments.Contains("4912"))
                {
                    Console.WriteLine("\nExperiment LetYourCottages_LinkbackforconsumertrafficLYP192 (4912) not enabled this session.\n");
                }
                else
                {
                    Console.WriteLine("\nExperiment LetYourCottages_LinkbackforconsumertrafficLYP192 (4912) not found.\n");
                }
            }
        }

        [Then(@"experiment LetYourCottages_RemovereadingtimefrominformationpageheroLYP216 is applied")]
        public void ThenExperimentLetYourCottages_RemovereadingtimefrominformationpageheroLYP216IsApplied()
        {
            string experimentName = "LetYourCottages_RemovereadingtimefrominformationpageheroLYP216";
            string experimentId = "4931";

            if (experimentalExperiments.Contains(experimentId))
            {
                Console.WriteLine("\nExperiment " + experimentName + " (" + experimentId + ") enabled.\n");
                LaunchWebsite(Hooks.domainOverride, "/letyourcottage/information/marketing-your-holiday-let/");
                AssertElementNotDisplayed("Reading time");
            }
            else
            {
                if (controlExperiments.Contains(experimentId))
                {
                    Console.WriteLine("\nExperiment " + experimentName + " (" + experimentId + ") not enabled this session.\n");
                }
                else
                {
                    Console.WriteLine("\nExperiment " + experimentName + " (" + experimentId + ") not found.\n");
                }
            }
        }

        [Then(@"experiment LetYourCottages_LYPStickyHeader202 is applied")]
        public void ThenExperimentLetYourCottages_LYPStickyHeader202IsApplied()
        {
            string experimentName = "LetYourCottages_LYPStickyHeader202";
            string experimentId = "4933";

            if (experimentalExperiments.Contains(experimentId))
            {
                Console.WriteLine("\nExperiment " + experimentName + " (" + experimentId + ") enabled.\n");
                ScrollTo("Holiday letting made easy");
                AssertElementDisplayed("lyc-header");
                Console.WriteLine("\nExperiment " + experimentName + " (" + experimentId + ") present and working as expected.\n");
            }
            else
            {
                if (controlExperiments.Contains(experimentId))
                {
                    Console.WriteLine("\nExperiment " + experimentName + " (" + experimentId + ") not enabled this session.\n");
                }
                else
                {
                    Console.WriteLine("\nExperiment " + experimentName + " (" + experimentId + ") not found.\n");
                }
            }
        }

        [Then(@"experiment LetYourCottages_InfoPageInvestmentAdviceLYP223 is applied")]
        public void ThenExperimentLetYourCottages_InfoPageInvestmentAdviceLYP223IsApplied()
        {
            string experimentName = "LetYourCottages_InfoPageInvestmentAdviceLYP223";
            string experimentId = "4948";

            if (experimentalExperiments.Contains(experimentId))
            {
                Console.WriteLine("\nExperiment " + experimentName + " (" + experimentId + ") enabled.\n");
                LaunchWebsite(Hooks.domainOverride, "/letyourcottage/information/investment-advice-for-holiday-lets/");
                AssertElementDisplayed("What is the business model behind holiday home rentals?");
                AssertElementDisplayed("We’ll work with you to make sure your property is perfectly priced");
                AssertElementDisplayed("F.A.Q");
                AssertElementDisplayed("What's a better investment – long-term lets or holiday lets?");
                AssertElementDisplayed("Should I start a B&B or holiday let business? What's the difference and can I change from one to the other?");
                AssertElementDisplayed("How do I calculate ROI on a holiday rental property?");
                AssertElementDisplayed("How do I work out yield on a rental property?");
            }
            else
            {
                if (controlExperiments.Contains(experimentId))
                {
                    Console.WriteLine("\nExperiment " + experimentName + " (" + experimentId + ") not enabled this session.\n");
                }
                else
                {
                    Console.WriteLine("\nExperiment " + experimentName + " (" + experimentId + ") not found.\n");
                }
            }
        }
    }
}
