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
    [NUnit.Framework.DescriptionAttribute("LetYourProperty")]
    public partial class LetYourPropertyFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "LetYourProperty.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "LetYourProperty", "\tLet Your Property page content and functionality", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The user can navigate to the Let Your Property page")]
        [NUnit.Framework.CategoryAttribute("Navigation")]
        public virtual void TheUserCanNavigateToTheLetYourPropertyPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Navigation"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user can navigate to the Let Your Property page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("I am on the Sykes Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.When("I click Let Your Property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.Then("the following page title is displayed: Holiday Letting Agents For Cottages, Holid" +
                        "ay Homes & Property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The enquiry form is displayed on the Let Your Property page")]
        [NUnit.Framework.CategoryAttribute("LetYourProperty")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        public virtual void TheEnquiryFormIsDisplayedOnTheLetYourPropertyPage()
        {
            string[] tagsOfScenario = new string[] {
                    "LetYourProperty",
                    "ProductionRegressionSuite"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The enquiry form is displayed on the Let Your Property page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 11
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
#line 12
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
 testRunner.Then("the following element is displayed on the page: form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The transparent header is displayed on the Let Your Property page")]
        [NUnit.Framework.CategoryAttribute("LetYourProperty")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        public virtual void TheTransparentHeaderIsDisplayedOnTheLetYourPropertyPage()
        {
            string[] tagsOfScenario = new string[] {
                    "LetYourProperty",
                    "ProductionRegressionSuite"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The transparent header is displayed on the Let Your Property page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 16
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
#line 17
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 18
 testRunner.Then("the following element is displayed on the page: nav_top u-clearfix nav_top_17485", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The floating action button is displayed on the Let Your Property page")]
        [NUnit.Framework.CategoryAttribute("LetYourProperty")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        public virtual void TheFloatingActionButtonIsDisplayedOnTheLetYourPropertyPage()
        {
            string[] tagsOfScenario = new string[] {
                    "LetYourProperty",
                    "ProductionRegressionSuite"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The floating action button is displayed on the Let Your Property page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 21
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
#line 22
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 testRunner.When("I scroll to the following element: page-footer container_sykes_grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then("the following element is displayed on the page: Back To Top Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant validation is in place on the enquiry form")]
        [NUnit.Framework.CategoryAttribute("LetYourProperty")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        public virtual void TheRelevantValidationIsInPlaceOnTheEnquiryForm()
        {
            string[] tagsOfScenario = new string[] {
                    "LetYourProperty",
                    "ProductionRegressionSuite"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant validation is in place on the enquiry form", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 27
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
#line 28
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 29
 testRunner.When("I submit the enquiry form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table25.AddRow(new string[] {
                            "Please enter a full name."});
                table25.AddRow(new string[] {
                            "Please enter an email address."});
                table25.AddRow(new string[] {
                            "Please enter a contact number."});
#line 30
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table25, "Then ");
#line hidden
#line 35
 testRunner.When("I enter an email address without an @ symbol", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.And("I submit the enquiry form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.Then("the following text is displayed on the page: \'test.com\' is missing an \'@\'. Please" +
                        " include an \'@\' in the email address.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.When("I enter an email address without a valid domain", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.And("I submit the enquiry form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.Then("the following text is displayed on the page: \'test@test\' is an incomplete email a" +
                        "ddress. Please include e.g. \'.com\', \'.co.uk\', \'.net\'.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.When("I enter a phone number with a non-numerical character", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.And("I submit the enquiry form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.Then("the following text is displayed on the page: Please enter a valid contact number " +
                        "that does not include letters, spaces, special characters and contains no less t" +
                        "han 10 digits.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.When("I enter a phone number with less than 10 digits", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.And("I submit the enquiry form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.Then("the following text is displayed on the page: Please provide a contact number that" +
                        " is no less than 10 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.When("I enter a phone number with more than 15 digits", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.And("I submit the enquiry form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.Then("the following text is displayed on the page: Please provide a contact number that" +
                        " is no more than 15 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the Let Your Property page")]
        [NUnit.Framework.CategoryAttribute("LetYourProperty")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        public virtual void TheRelevantSectionsAreDisplayedOnTheLetYourPropertyPage()
        {
            string[] tagsOfScenario = new string[] {
                    "LetYourProperty",
                    "ProductionRegressionSuite"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the Let Your Property page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 52
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
#line 53
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "Section"});
                table26.AddRow(new string[] {
                            "Gain exposure through our partners"});
                table26.AddRow(new string[] {
                            "What do our owners say"});
                table26.AddRow(new string[] {
                            "How much could I earn"});
                table26.AddRow(new string[] {
                            "We are still open as usual"});
                table26.AddRow(new string[] {
                            "Holiday home management with Sykes"});
                table26.AddRow(new string[] {
                            "Putting your property in the spotlight"});
                table26.AddRow(new string[] {
                            "Holiday letting made easy"});
                table26.AddRow(new string[] {
                            "Request your free owner information pack"});
                table26.AddRow(new string[] {
                            "Looking to get started with holiday letting?"});
#line 54
 testRunner.Then("the following sections are dislpayed", ((string)(null)), table26, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The page sections are displayed is the correct order")]
        [NUnit.Framework.TestCaseAttribute("Gain exposure through our partners", "3", null)]
        [NUnit.Framework.TestCaseAttribute("What do our owners say?", "4", null)]
        [NUnit.Framework.TestCaseAttribute("How can Sykes elevate your holiday letting experience?", "5", null)]
        [NUnit.Framework.TestCaseAttribute("How much could I earn", "6", null)]
        [NUnit.Framework.TestCaseAttribute("Holiday home management with Sykes", "7", null)]
        [NUnit.Framework.TestCaseAttribute("Putting your property in the spotlight", "8", null)]
        [NUnit.Framework.TestCaseAttribute("Holiday letting made easy", "9", null)]
        [NUnit.Framework.TestCaseAttribute("Are you thinking of buying", "10", null)]
        [NUnit.Framework.TestCaseAttribute("Request your free owner information pack", "11", null)]
        public virtual void ThePageSectionsAreDisplayedIsTheCorrectOrder(string section, string position, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Section", section);
            argumentsOfScenario.Add("Position", position);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The page sections are displayed is the correct order", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 67
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
#line 68
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 69
 testRunner.Then(string.Format("the {0} section is displayed at position {1}", section, position), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Thinking of Buying Guide section is displayed on the Let Your Property page")]
        [NUnit.Framework.CategoryAttribute("ThinkingOfBuying")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        public virtual void TheThinkingOfBuyingGuideSectionIsDisplayedOnTheLetYourPropertyPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ThinkingOfBuying",
                    "ProductionRegressionSuite"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Thinking of Buying Guide section is displayed on the Let Your Property page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 83
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
#line 84
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table27.AddRow(new string[] {
                            "Looking to get started with holiday letting?"});
                table27.AddRow(new string[] {
                            "Explore guides & resources"});
#line 85
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table27, "Then ");
#line hidden
#line 89
 testRunner.When("I click /letyourcottage/advice", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.Then("the following page title is displayed: Buying a Holiday Let Information Centre | " +
                        "Sykes Holiday Cottages", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the Mobile App homepage")]
        [NUnit.Framework.CategoryAttribute("MobileApp")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        public virtual void TheRelevantSectionsAreDisplayedOnTheMobileAppHomepage()
        {
            string[] tagsOfScenario = new string[] {
                    "MobileApp",
                    "ProductionRegressionSuite"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the Mobile App homepage", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 93
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
#line 94
 testRunner.Given("I have navigated to the following page: letyourcottage/?app_view=true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 95
 testRunner.When("I set the window size to Mobile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "Section"});
                table28.AddRow(new string[] {
                            "Gain exposure through our partners"});
                table28.AddRow(new string[] {
                            "What do our owners say"});
                table28.AddRow(new string[] {
                            "How much could I earn"});
                table28.AddRow(new string[] {
                            "We are still open as usual"});
                table28.AddRow(new string[] {
                            "Holiday home management with Sykes"});
                table28.AddRow(new string[] {
                            "Putting your property in the spotlight"});
                table28.AddRow(new string[] {
                            "Holiday letting made easy"});
                table28.AddRow(new string[] {
                            "Request your free owner information pack"});
                table28.AddRow(new string[] {
                            "Looking to get started with holiday letting?"});
#line 96
 testRunner.Then("the following sections are dislpayed", ((string)(null)), table28, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table29.AddRow(new string[] {
                            "contact-to-book mobile"});
                table29.AddRow(new string[] {
                            "navbar-toggle collapsed"});
#line 107
 testRunner.And("the following elements are not dislpayed on the page", ((string)(null)), table29, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
