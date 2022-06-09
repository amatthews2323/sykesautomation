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
    [NUnit.Framework.DescriptionAttribute("SisterSites")]
    public partial class SisterSitesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "SisterSites.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "SisterSites", "\tSister sites content and functionality", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("The Sykes sister sites are displayed correctly")]
        [NUnit.Framework.CategoryAttribute("SisterSites")]
        [NUnit.Framework.CategoryAttribute("LYPSmokeTest")]
        [NUnit.Framework.TestCaseAttribute("https://www.carbisbayholidays.co.uk/letyourcottage/", "Carbis Bay", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.character-cottages.co.uk/letyourcottage/", "Character Cottages", null)]
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
        public void TheSykesSisterSitesAreDisplayedCorrectly(string uRL, string title, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SisterSites",
                    "LYPSmokeTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("URL", uRL);
            argumentsOfScenario.Add("Title", title);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Sykes sister sites are displayed correctly", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.Given(string.Format("I am on the following webpage: {0}", uRL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table74 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table74.AddRow(new string[] {
                            string.Format("{0}", title)});
                table74.AddRow(new string[] {
                            "nav_logo"});
                table74.AddRow(new string[] {
                            "hero__image"});
                table74.AddRow(new string[] {
                            "form-heading-container"});
                table74.AddRow(new string[] {
                            "Putting your property in the spotlight"});
                table74.AddRow(new string[] {
                            "Holiday letting made easy"});
                table74.AddRow(new string[] {
                            "Request a free owner pack"});
                table74.AddRow(new string[] {
                            "Claim My Free Pack"});
#line 7
 testRunner.Then("the following elements are dislpayed", ((string)(null)), table74, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The enquiry form is displayed on the sister sites")]
        [NUnit.Framework.CategoryAttribute("SisterSites")]
        [NUnit.Framework.CategoryAttribute("LYPRegressionSuite")]
        [NUnit.Framework.CategoryAttribute("EnquiryForm")]
        [NUnit.Framework.TestCaseAttribute("https://www.character-cottages.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.carbisbayholidays.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.coastandcountry.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.cornishcottageholidays.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.dream-cottages.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.heartofthelakes.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.helpfulholidays.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.hogansirishcottages.com/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.johnbraycornishholidays.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.lakedistrictlodgeholidays.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.lakescottageholiday.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.lakelovers.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.manorcottages.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.menaiholidays.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.welsh-cottages.co.uk/letyourcottage/", null)]
        [NUnit.Framework.TestCaseAttribute("https://www.yorkshirecoastalcottages.com/cottage-owners/", null)]
        public void TheEnquiryFormIsDisplayedOnTheSisterSites(string uRL, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SisterSites",
                    "LYPRegressionSuite",
                    "EnquiryForm"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("URL", uRL);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The enquiry form is displayed on the sister sites", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 38
 testRunner.Given(string.Format("I am on the following webpage: {0}", uRL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table75 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table75.AddRow(new string[] {
                            "form-heading-container"});
                table75.AddRow(new string[] {
                            "Complete the form to receive your information pack"});
                table75.AddRow(new string[] {
                            "heroform_first_name"});
                table75.AddRow(new string[] {
                            "heroform_first_name_validation_error"});
                table75.AddRow(new string[] {
                            "heroform_email"});
                table75.AddRow(new string[] {
                            "heroform_email_validation_error"});
                table75.AddRow(new string[] {
                            "heroform_phone"});
                table75.AddRow(new string[] {
                            "heroform_phone_validation_error"});
                table75.AddRow(new string[] {
                            "/terms/privacypolicy"});
                table75.AddRow(new string[] {
                            "submit"});
#line 39
 testRunner.Then("the following elements are dislpayed", ((string)(null)), table75, "Then ");
#line hidden
#line 51
 testRunner.When("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.And("I click heroform_first_name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.Then("the following text is displayed: Please enter a full name.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
 testRunner.When("I click heroform_email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.Then("the following text is displayed: Please enter an email address.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.When("I click heroform_phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.Then("the following text is displayed: Please enter a contact number.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.When("I enter test.com in the following form field: heroform_email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.Then("the following text is displayed: \'test.com\' is missing an \'@\'. Please include an " +
                        "\'@\' in the email address.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 64
 testRunner.When("I enter test@test in the following form field: heroform_email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 65
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.Then("the following text is displayed: \'test@test\' is an incomplete email address. Plea" +
                        "se include e.g. \'.com\', \'.co.uk\', \'.net\'.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.When("I enter test in the following form field: heroform_phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.Then("the following text is displayed: Please enter a valid contact number that does no" +
                        "t include letters, spaces, special characters and contains no less than 10 digit" +
                        "s.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.When("I enter 070000000 in the following form field: heroform_phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.Then("the following text is displayed: Please provide a contact number that is no less " +
                        "than 10 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
 testRunner.When("I enter 0700000000000000 in the following form field: heroform_phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.Then("the following text is displayed: Please provide a contact number that is no more " +
                        "than 15 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
