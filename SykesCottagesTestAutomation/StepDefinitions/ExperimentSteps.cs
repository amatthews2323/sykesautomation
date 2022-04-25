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
    public sealed class ExperimentSteps : CommonSteps
    {
        public ExperimentSteps(SharedDriver context) : base(context)
        {
        }

        private string activeExperiments;

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
    }
}
