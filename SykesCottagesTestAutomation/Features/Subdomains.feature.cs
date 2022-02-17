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
    [NUnit.Framework.DescriptionAttribute("Subdomains")]
    public partial class SubdomainsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Subdomains.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Subdomains", "\tLet Your Property subdomain content and functionality", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Sykes sub-domains are displayed correctly")]
        [NUnit.Framework.CategoryAttribute("Subdomains")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        [NUnit.Framework.TestCaseAttribute("https://www.character-cottages.co.uk/letyourcottage/", "Character Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.carbisbayholidays.co.uk/letyourcottage/", "Carbis Bay", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.coastandcountry.co.uk/letyourcottage/", "Coast & Country Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.cornishcottageholidays.co.uk/letyourcottage/", "Cornish Cottage Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.dream-cottages.co.uk/letyourcottage/", "Dream Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.heartofthelakes.co.uk/letyourcottage/", "Heart of the Lakes", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.helpfulholidays.co.uk/letyourcottage/", "Helpful Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.hogansirishcottages.com/letyourcottage/", "Hogans Irish Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.johnbraycornishholidays.co.uk/letyourcottage/", "John Bray Cornish Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.lakedistrictlodgeholidays.co.uk/letyourcottage/", "Lake District", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.lakescottageholiday.co.uk/letyourcottage/", "Lakes Cottage Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.lakelovers.co.uk/letyourcottage/", "Lakelovers", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.manorcottages.co.uk/letyourcottage/", "Manor Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.menaiholidays.co.uk/letyourcottage/", "Menai Holiday Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.welsh-cottages.co.uk/letyourcottage/", "Welsh Cottage", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.yorkshirecoastalcottages.com/cottage-owners/", "Yorkshire Coastal", null)]
        public virtual void TheSykesSub_DomainsAreDisplayedCorrectly(string subdomain, string title, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Subdomains",
                    "ProductionRegressionSuite"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Subdomain", subdomain);
            argumentsOfScenario.Add("Title", title);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Sykes sub-domains are displayed correctly", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given(string.Format("I am accessing {0}", subdomain), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table28.AddRow(new string[] {
                            string.Format("{0}", title)});
                table28.AddRow(new string[] {
                            "form-heading-container"});
                table28.AddRow(new string[] {
                            "partner"});
                table28.AddRow(new string[] {
                            "Holiday letting made easy"});
                table28.AddRow(new string[] {
                            "Request a free owner pack"});
#line 7
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table28, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
