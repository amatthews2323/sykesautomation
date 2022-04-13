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
    [NUnit.Framework.DescriptionAttribute("OtherPages")]
    public partial class OtherPagesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "OtherPages.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "OtherPages", "\tHoliday Homes for Sale and Manged Services page content and functionality", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The relevent elements are present on the Holiday Homes for Sale page")]
        [NUnit.Framework.CategoryAttribute("HolidayHomesForSale")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        [NUnit.Framework.CategoryAttribute("RegressionSmokeTest")]
        public virtual void TheReleventElementsArePresentOnTheHolidayHomesForSalePage()
        {
            string[] tagsOfScenario = new string[] {
                    "HolidayHomesForSale",
                    "ProductionRegressionSuite",
                    "RegressionSmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevent elements are present on the Holiday Homes for Sale page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("I have navigated to the following page: letyourcottage/holiday-homes-for-sale", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table53.AddRow(new string[] {
                            "Holiday Homes for Sale UK"});
                table53.AddRow(new string[] {
                            "container_sykes_grid"});
                table53.AddRow(new string[] {
                            "View more holiday homes for sale"});
                table53.AddRow(new string[] {
                            "How much could I earn with Sykes?"});
                table53.AddRow(new string[] {
                            "c-alert__icon-wrap"});
                table53.AddRow(new string[] {
                            "Enquire with Sykes today"});
                table53.AddRow(new string[] {
                            "Get started"});
#line 7
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table53, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The enquiry form is displayed on the Holiday Homes for Sale page")]
        [NUnit.Framework.CategoryAttribute("HolidayHomesForSale")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        [NUnit.Framework.CategoryAttribute("EnquiryForm")]
        public virtual void TheEnquiryFormIsDisplayedOnTheHolidayHomesForSalePage()
        {
            string[] tagsOfScenario = new string[] {
                    "HolidayHomesForSale",
                    "ProductionRegressionSuite",
                    "EnquiryForm"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The enquiry form is displayed on the Holiday Homes for Sale page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 18
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
#line 19
 testRunner.Given("I have navigated to the following page: letyourcottage/holiday-homes-for-sale", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
    testRunner.When("I click View property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table54.AddRow(new string[] {
                            "Find your perfect holiday home"});
                table54.AddRow(new string[] {
                            "Select a region"});
#line 21
    testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table54, "Then ");
#line hidden
#line 25
    testRunner.When("I select option All regions from the region dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
    testRunner.And("I click Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table55 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table55.AddRow(new string[] {
                            "hhfs_overlay"});
                table55.AddRow(new string[] {
                            "hhfs_overlay_first_name"});
                table55.AddRow(new string[] {
                            "hhfs_overlay_first_name_validation_error"});
                table55.AddRow(new string[] {
                            "hhfs_overlay_email"});
                table55.AddRow(new string[] {
                            "hhfs_overlay_email_validation_error"});
                table55.AddRow(new string[] {
                            "hhfs_overlay_phone"});
                table55.AddRow(new string[] {
                            "hhfs_overlay_phone_validation_error"});
                table55.AddRow(new string[] {
                            "marketing_email"});
                table55.AddRow(new string[] {
                            "marketing_phone"});
                table55.AddRow(new string[] {
                            "marketing_sms"});
                table55.AddRow(new string[] {
                            "marketing_post"});
                table55.AddRow(new string[] {
                            "By giving us your details you agree that the Sykes Group can contact you with mor" +
                                "e relevant information by email, text and phone."});
                table55.AddRow(new string[] {
                            "/terms/privacypolicy"});
                table55.AddRow(new string[] {
                            "submit"});
#line 27
    testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table55, "Then ");
#line hidden
#line 43
    testRunner.When("I click lyc-cta lyc-cta--green u-full-width js-enquiry-form-button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table56 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table56.AddRow(new string[] {
                            "Please enter a full name."});
                table56.AddRow(new string[] {
                            "Please enter an email address."});
                table56.AddRow(new string[] {
                            "Please enter a contact number."});
#line 44
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table56, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevent elements are present on the Managed Services page")]
        [NUnit.Framework.CategoryAttribute("ManagedServices")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        [NUnit.Framework.CategoryAttribute("RegressionSmokeTest")]
        public virtual void TheReleventElementsArePresentOnTheManagedServicesPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ManagedServices",
                    "ProductionRegressionSuite",
                    "RegressionSmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevent elements are present on the Managed Services page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 51
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
#line 52
 testRunner.Given("I have navigated to the following page: letyourcottage/managed-services", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table57 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table57.AddRow(new string[] {
                            "Holiday home management"});
                table57.AddRow(new string[] {
                            "hero-slideshow"});
                table57.AddRow(new string[] {
                            "form-heading-container"});
                table57.AddRow(new string[] {
                            "Managed services at Sykes"});
                table57.AddRow(new string[] {
                            "What are the benefits"});
                table57.AddRow(new string[] {
                            "Partially managed"});
                table57.AddRow(new string[] {
                            "Fully managed"});
                table57.AddRow(new string[] {
                            "Resource centre"});
                table57.AddRow(new string[] {
                            "Share page"});
#line 53
    testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table57, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
