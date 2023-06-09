﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SykesCottagesTestAutomation.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("RegionPages")]
    public partial class RegionPagesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "RegionPages.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "RegionPages", "\tRegion pages content and functionality", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Regional pages are displayed correctly")]
        [NUnit.Framework.CategoryAttribute("RegionPages")]
        [NUnit.Framework.CategoryAttribute("LYPSmokeTest")]
        [NUnit.Framework.CategoryAttribute("LYPRegressionSuite")]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/South-West", "South West", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/South-of-England", "South of England", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Heart-of-England", "Heart of England", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/East-Anglia", "East Anglia", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Peak-District", "Peak District", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/North-York-Moors-and-Coast", "North York Moors and Coast", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria", "Lake District and Cumbria", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Northumberland", "Northumberland", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Wales", "Wales", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Ireland", "Ireland", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Scotland", "Scotland", null)]
        public void TheRegionalPagesAreDisplayedCorrectly(string path, string region, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegionPages",
                    "LYPSmokeTest",
                    "LYPRegressionSuite"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Path", path);
            argumentsOfScenario.Add("Region", region);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Regional pages are displayed correctly", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given(string.Format("I have navigated to the following page: {0}", path), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.Then(string.Format("the following text is displayed: {0}", region), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table101 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table101.AddRow(new string[] {
                            "c-lyc-form"});
                table101.AddRow(new string[] {
                            "trustpilot-widget"});
                table101.AddRow(new string[] {
                            "Local Holiday Letting Expertise"});
                table101.AddRow(new string[] {
                            "Holiday letting made easy"});
                table101.AddRow(new string[] {
                            "Here\'s why our local experts love their job"});
                table101.AddRow(new string[] {
                            "Back To Top"});
#line 8
 testRunner.And("the relevant elements are dislpayed", ((string)(null)), table101, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user can navigate to the Region pages")]
        [NUnit.Framework.CategoryAttribute("Navigation")]
        [NUnit.Framework.TestCaseAttribute("South West", "South West Holiday Letting Agents | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("South of England", "South of England Holiday Letting Agents | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Heart of England", "Heart of England Holiday Letting Agents | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("East Anglia", "Norfolk and Suffolk Holiday Letting Agents | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Peak District", "Peak District Holiday Letting Agents | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("North York Moors and Coast", "Yorkshire Moors & Coast Holiday Letting Agents | Sykes", null)]
        [NUnit.Framework.TestCaseAttribute("Lake District and Cumbria", "Lake District & Cumbria Holiday Letting Agents | Sykes", null)]
        [NUnit.Framework.TestCaseAttribute("Northumberland", "Northumberland Holiday Letting Agents | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Wales", "Wales Holiday Letting Agents | Welsh Holiday Lets | Sykes", null)]
        [NUnit.Framework.TestCaseAttribute("Ireland", "Ireland Holiday Letting Agents | Irish Holiday Lets | Sykes", null)]
        [NUnit.Framework.TestCaseAttribute("Scotland", "Scotland Holiday Letting Agents | Scottish Holiday Lets | Sykes", null)]
        public void TheUserCanNavigateToTheRegionPages(string link, string pageTitle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Navigation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Link", link);
            argumentsOfScenario.Add("PageTitle", pageTitle);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user can navigate to the Region pages", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 31
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 32
 testRunner.Given("I am on the Sykes Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 33
 testRunner.When("I select the Holiday homes for sale navigation link under Let Your Property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.And(string.Format("I select the {0} navigation link under Your Location", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.Then(string.Format("the following page title is displayed: {0}", pageTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The potential earnings is displayed on the Regional pages")]
        [NUnit.Framework.CategoryAttribute("RegionPages")]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/South-West", "Based on 2 beds, sleeps 4, Cornwall", "Based on 2 beds, sleeps 4, Devon", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/South-of-England", "Based on 2 beds, sleeps 4, Kent Coast", "Based on 2 beds, sleeps 4, Isle of Wight", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Heart-of-England", "Based on 2 beds, sleeps 4, Shropshire & Herefordshire", "Based on 2 beds, sleeps 4, Worcestershire, Warwickshire, Wiltshire & Gloucestersh" +
            "ire", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/East-Anglia", "Based on 2 beds, sleeps 4, Norfolk and Suffolk", "Based on 2 beds, sleeps 4, Lincolnshire and Rutland", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Peak-District", "Based on 2 beds, sleeps 4, Peak District", "Based on 3 beds, sleeps 6, Peak District", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/North-York-Moors-and-Coast", "Based on 2 beds, sleeps 4, North York Moors & Coast", "Based on 3 beds, sleeps 6, North York Moors & Coast", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria", "Based on 2 beds, sleeps 4, Cumbria & The Lake District", "Based on 3 beds, sleeps 6, Cumbria & The Lake District", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Northumberland", "Based on 2 beds, sleeps 4, Northumberland", "Based on 3 beds, sleeps 6, Northumberland", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Wales", "Based on 2 beds, sleeps 4, North Wales", "Based on 2 beds, sleeps 4, South Wales", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Ireland", "Based on 2 beds, sleeps 4, Northern Ireland", "Based on 3 beds, sleeps 6, Northern Ireland", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Scotland", "Based on 2 beds, sleeps 4, Perthshire & Fife", "Based on 2 beds, sleeps 4, The Highlands", null)]
        public void ThePotentialEarningsIsDisplayedOnTheRegionalPages(string path, string region1, string region2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegionPages"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Path", path);
            argumentsOfScenario.Add("Region 1", region1);
            argumentsOfScenario.Add("Region 2", region2);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The potential earnings is displayed on the Regional pages", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 52
 testRunner.Given(string.Format("I have navigated to the following page: {0}", path), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 53
 testRunner.When("I apply the following experiment: LetYourCottages_CalcInHeroOnRegionalPages262", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table102 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table102.AddRow(new string[] {
                            "Your potential earnings"});
                table102.AddRow(new string[] {
                            "Find out more"});
#line 54
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table102, "Then ");
#line hidden
#line 58
 testRunner.And(string.Format("the following text is displayed: {0}", region1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And(string.Format("the following text is displayed: {0}", region2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.Then("I take a screenshot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
