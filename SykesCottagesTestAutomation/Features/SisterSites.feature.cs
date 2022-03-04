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
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "SisterSites.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "SisterSites", "\tSister sites content and functionality", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The Sykes sister sites are displayed correctly")]
        [NUnit.Framework.CategoryAttribute("SisterSites")]
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
        public virtual void TheSykesSisterSitesAreDisplayedCorrectly(string uRL, string title, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SisterSites",
                    "ProductionRegressionSuite"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("URL", uRL);
            argumentsOfScenario.Add("Title", title);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Sykes sister sites are displayed correctly", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given(string.Format("I am accessing {0}", uRL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table41.AddRow(new string[] {
                            string.Format("{0}", title)});
                table41.AddRow(new string[] {
                            "form-heading-container"});
                table41.AddRow(new string[] {
                            "partner"});
                table41.AddRow(new string[] {
                            "Holiday letting made easy"});
                table41.AddRow(new string[] {
                            "Request a free owner pack"});
#line 7
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table41, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The enquiry form is displayed on the sister sites")]
        [NUnit.Framework.CategoryAttribute("SisterSites")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
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
        public virtual void TheEnquiryFormIsDisplayedOnTheSisterSites(string uRL, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SisterSites",
                    "ProductionRegressionSuite"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("URL", uRL);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The enquiry form is displayed on the sister sites", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 34
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
#line 35
 testRunner.Given(string.Format("I am accessing {0}", uRL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table42.AddRow(new string[] {
                            "form-heading-container"});
                table42.AddRow(new string[] {
                            "Complete the form to receive your information pack"});
                table42.AddRow(new string[] {
                            "heroform_first_name"});
                table42.AddRow(new string[] {
                            "heroform_first_name_validation_error"});
                table42.AddRow(new string[] {
                            "heroform_email"});
                table42.AddRow(new string[] {
                            "heroform_email_validation_error"});
                table42.AddRow(new string[] {
                            "heroform_phone"});
                table42.AddRow(new string[] {
                            "heroform_phone_validation_error"});
                table42.AddRow(new string[] {
                            "marketing_email"});
                table42.AddRow(new string[] {
                            "marketing_phone"});
                table42.AddRow(new string[] {
                            "marketing_sms"});
                table42.AddRow(new string[] {
                            "marketing_post"});
                table42.AddRow(new string[] {
                            "Your details will be stored and used to send you information about our property l" +
                                "etting services. You can opt out or unsubscribe at any time by contacting us."});
                table42.AddRow(new string[] {
                            "/terms/privacypolicy"});
                table42.AddRow(new string[] {
                            "submit"});
#line 36
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table42, "Then ");
#line hidden
#line 53
 testRunner.When("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.And("I click heroform_first_name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table43 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table43.AddRow(new string[] {
                            "Please enter a full name."});
                table43.AddRow(new string[] {
                            "Please enter an email address."});
                table43.AddRow(new string[] {
                            "Please enter a contact number."});
#line 56
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table43, "Then ");
#line hidden
#line 61
 testRunner.When("I enter an email address without an @ symbol", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.Then("the following text is displayed on the page: \'test.com\' is missing an \'@\'. Please" +
                        " include an \'@\' in the email address.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 64
 testRunner.When("I enter an email address without a valid domain", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 65
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.Then("the following text is displayed on the page: \'test@test\' is an incomplete email a" +
                        "ddress. Please include e.g. \'.com\', \'.co.uk\', \'.net\'.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.When("I enter a phone number with a non-numerical character", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.Then("the following text is displayed on the page: Please enter a valid contact number " +
                        "that does not include letters, spaces, special characters and contains no less t" +
                        "han 10 digits.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.When("I enter a phone number with less than 10 digits", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.Then("the following text is displayed on the page: Please provide a contact number that" +
                        " is no less than 10 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
 testRunner.When("I enter a phone number with more than 15 digits", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 74
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.Then("the following text is displayed on the page: Please provide a contact number that" +
                        " is no more than 15 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 76
 testRunner.When("I enter a phone number with spaces and +44", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.Then("the following element is not displayed on the page: Please enter a valid contact " +
                        "number that does not include letters, spaces, special characters and contains no" +
                        " less than 10 digits.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
