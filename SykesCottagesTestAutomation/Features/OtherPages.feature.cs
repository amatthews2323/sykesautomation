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
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "OtherPages.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "OtherPages", "\tHoliday Homes for Sale and Manged Services page content and functionality", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("The relevent elements are present on the Holiday Homes for Sale page")]
        [NUnit.Framework.CategoryAttribute("HolidayHomesForSale")]
        [NUnit.Framework.CategoryAttribute("SmokeTest")]
        public void TheReleventElementsArePresentOnTheHolidayHomesForSalePage()
        {
            string[] tagsOfScenario = new string[] {
                    "HolidayHomesForSale",
                    "SmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevent elements are present on the Holiday Homes for Sale page", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.Given("I have navigated to the following page: letyourcottage/holiday-homes-for-sale", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table64 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table64.AddRow(new string[] {
                            "Holiday Homes for Sale UK"});
                table64.AddRow(new string[] {
                            "container_sykes_grid"});
                table64.AddRow(new string[] {
                            "View more holiday homes for sale"});
                table64.AddRow(new string[] {
                            "How much could I earn with Sykes?"});
                table64.AddRow(new string[] {
                            "c-alert__icon-wrap"});
                table64.AddRow(new string[] {
                            "Enquire with Sykes today"});
                table64.AddRow(new string[] {
                            "Get started"});
#line 7
 testRunner.Then("the following elements are dislpayed", ((string)(null)), table64, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The enquiry form is displayed on the Holiday Homes for Sale page")]
        [NUnit.Framework.CategoryAttribute("HolidayHomesForSale")]
        [NUnit.Framework.CategoryAttribute("RegressionSuite")]
        [NUnit.Framework.CategoryAttribute("EnquiryForm")]
        public void TheEnquiryFormIsDisplayedOnTheHolidayHomesForSalePage()
        {
            string[] tagsOfScenario = new string[] {
                    "HolidayHomesForSale",
                    "RegressionSuite",
                    "EnquiryForm"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The enquiry form is displayed on the Holiday Homes for Sale page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
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
                TechTalk.SpecFlow.Table table65 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table65.AddRow(new string[] {
                            "Find your perfect holiday home"});
                table65.AddRow(new string[] {
                            "Select a region"});
#line 21
    testRunner.Then("the following elements are dislpayed", ((string)(null)), table65, "Then ");
#line hidden
#line 25
    testRunner.When("I select option All regions from the region dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
    testRunner.And("I click Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table66 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table66.AddRow(new string[] {
                            "hhfs_overlay"});
                table66.AddRow(new string[] {
                            "hhfs_overlay_first_name"});
                table66.AddRow(new string[] {
                            "hhfs_overlay_first_name_validation_error"});
                table66.AddRow(new string[] {
                            "hhfs_overlay_email"});
                table66.AddRow(new string[] {
                            "hhfs_overlay_email_validation_error"});
                table66.AddRow(new string[] {
                            "hhfs_overlay_phone"});
                table66.AddRow(new string[] {
                            "hhfs_overlay_phone_validation_error"});
                table66.AddRow(new string[] {
                            "Your details will be stored and used to send you information about our property l" +
                                "etting services."});
                table66.AddRow(new string[] {
                            "/terms/privacypolicy"});
                table66.AddRow(new string[] {
                            "submit"});
#line 27
    testRunner.Then("the following elements are dislpayed", ((string)(null)), table66, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevent elements are present on the Managed Services page")]
        [NUnit.Framework.CategoryAttribute("ManagedServices")]
        [NUnit.Framework.CategoryAttribute("SmokeTest")]
        public void TheReleventElementsArePresentOnTheManagedServicesPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ManagedServices",
                    "SmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevent elements are present on the Managed Services page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 41
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 42
 testRunner.Given("I have navigated to the following page: letyourcottage/managed-services", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table67 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table67.AddRow(new string[] {
                            "Holiday home management"});
                table67.AddRow(new string[] {
                            "hero-slideshow"});
                table67.AddRow(new string[] {
                            "form-heading-container"});
                table67.AddRow(new string[] {
                            "Managed services at Sykes"});
                table67.AddRow(new string[] {
                            "What are the benefits"});
                table67.AddRow(new string[] {
                            "Partially managed"});
                table67.AddRow(new string[] {
                            "Fully managed"});
                table67.AddRow(new string[] {
                            "Resource centre"});
                table67.AddRow(new string[] {
                            "Share page"});
#line 43
    testRunner.Then("the following elements are dislpayed", ((string)(null)), table67, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
