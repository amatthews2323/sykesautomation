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
    [NUnit.Framework.DescriptionAttribute("DigitalOnboarding")]
    public partial class DigitalOnboardingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "DigitalOnboarding.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "DigitalOnboarding", "\tOwner and Property creation via Digital Onbording\r\n\tNOT TO BE RUN AGAINST PRODUC" +
                    "TION", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("The user can submit the enquiry form")]
        [NUnit.Framework.CategoryAttribute("DigitalOnboarding")]
        public void TheUserCanSubmitTheEnquiryForm()
        {
            string[] tagsOfScenario = new string[] {
                    "DigitalOnboarding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user can submit the enquiry form", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table1.AddRow(new string[] {
                            "Full name",
                            "Test Owner"});
                table1.AddRow(new string[] {
                            "Email address",
                            "sykescottagestest@example.org"});
                table1.AddRow(new string[] {
                            "Phone number",
                            "07000000000"});
#line 8
 testRunner.When("I enter the following details on the enquiry form", ((string)(null)), table1, "When ");
#line hidden
#line 13
 testRunner.And("I submit the enquiry form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.Then("I am directed to the Property Letting Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the Property Letting Dashboard")]
        [NUnit.Framework.CategoryAttribute("DigitalOnboarding")]
        public void TheRelevantSectionsAreDisplayedOnThePropertyLettingDashboard()
        {
            string[] tagsOfScenario = new string[] {
                    "DigitalOnboarding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the Property Letting Dashboard", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 18
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table2.AddRow(new string[] {
                            "Full name",
                            "Test Owner"});
                table2.AddRow(new string[] {
                            "Email address",
                            "sykestest@example.org"});
                table2.AddRow(new string[] {
                            "Phone number",
                            "07000000000"});
#line 19
 testRunner.When("I enter the following details on the enquiry form", ((string)(null)), table2, "When ");
#line hidden
#line 24
 testRunner.And("I submit the enquiry form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table3.AddRow(new string[] {
                            "Phone Call"});
                table3.AddRow(new string[] {
                            "Continue Online"});
                table3.AddRow(new string[] {
                            "Pack Download"});
                table3.AddRow(new string[] {
                            "Holiday Homes for Sale"});
#line 25
 testRunner.Then("the following elements are dislpayed", ((string)(null)), table3, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user can add a property via the digital onboarding process")]
        [NUnit.Framework.CategoryAttribute("DigitalOnboarding")]
        public void TheUserCanAddAPropertyViaTheDigitalOnboardingProcess()
        {
            string[] tagsOfScenario = new string[] {
                    "DigitalOnboarding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user can add a property via the digital onboarding process", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 34
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table4.AddRow(new string[] {
                            "Full name",
                            "Test Owner"});
                table4.AddRow(new string[] {
                            "Email address",
                            "Random"});
                table4.AddRow(new string[] {
                            "Phone number",
                            "07000000000"});
#line 35
 testRunner.When("I enter the following details on the enquiry form", ((string)(null)), table4, "When ");
#line hidden
#line 40
 testRunner.And("I submit the enquiry form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.When("I click Get started online", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.Then("I can add a property with the following postcode: Random", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.And("the following page title is displayed: Thank you for your enquiry | Sykes Cottage" +
                        "s", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user can add a property and complete the digital onboarding process")]
        [NUnit.Framework.CategoryAttribute("DigitalOnboarding")]
        public void TheUserCanAddAPropertyAndCompleteTheDigitalOnboardingProcess()
        {
            string[] tagsOfScenario = new string[] {
                    "DigitalOnboarding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user can add a property and complete the digital onboarding process", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 47
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table5.AddRow(new string[] {
                            "Full name",
                            "Auto Bot"});
                table5.AddRow(new string[] {
                            "Email address",
                            "Random"});
                table5.AddRow(new string[] {
                            "Phone number",
                            "07000000000"});
#line 48
 testRunner.When("I enter the following details on the enquiry form", ((string)(null)), table5, "When ");
#line hidden
#line 53
 testRunner.And("I submit the enquiry form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.When("I select Get Started Online", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("I can add a property with the following postcode: CH1 2NW", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.And("I can create an account using password: Testing123", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("I can register my account via the email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table6.AddRow(new string[] {
                            "Username",
                            "Random"});
                table6.AddRow(new string[] {
                            "Password",
                            "Testing123"});
#line 58
 testRunner.And("I can sign in to my account using the following details", ((string)(null)), table6, "And ");
#line hidden
#line 62
 testRunner.And("I can complete Additional Property Details Step 1 - Property Location", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table7.AddRow(new string[] {
                            "Number of bedrooms",
                            "2"});
                table7.AddRow(new string[] {
                            "Number of guests",
                            "4"});
#line 63
 testRunner.And("I can complete Additional Property Details Step 2 - Guests and bedrooms", ((string)(null)), table7, "And ");
#line hidden
#line 67
 testRunner.And("I can complete Additional Property Details Step 3 - Photos of your property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("I can complete Additional Property Details Step 4 - About your property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("I can complete Additional Property Details Step 5 - Key Collection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And("I can complete Additional Property Details Step 6 - Booking details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("I can complete Additional Property Details Step 7 - Upcoming bookings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("I can complete Personal Details Step 1 - Personal details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("I can complete Personal Details Step 2 - Your bank details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.And("I can complete Personal Details Step 3 - File uploads", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.And("I can complete Personal Details Step 4 - Select commission tier", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And("I can complete Personal Details Step 5 - Property Pricing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And("I can sign the contract and complete digital onboarding", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.And("the following text is displayed: Welcome to the Sykes Family!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user completes digital onboarding")]
        [NUnit.Framework.CategoryAttribute("DigitalOnboarding")]
        public void TheUserCompletesDigitalOnboarding()
        {
            string[] tagsOfScenario = new string[] {
                    "DigitalOnboarding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user completes digital onboarding", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 81
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 82
 testRunner.Given("I am on the following webpage: https://tech.staging.sykescottages.co.uk/account/l" +
                        "ogin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table8.AddRow(new string[] {
                            "Username",
                            "sykestest855343@example.org"});
                table8.AddRow(new string[] {
                            "Password",
                            "Testing123"});
#line 83
 testRunner.Then("I can sign in to my account using the following details", ((string)(null)), table8, "Then ");
#line hidden
#line 87
 testRunner.And("I can complete Personal Details Step 5 - Property Pricing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And("I can sign the contract and complete digital onboarding", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.And("the following text is displayed: Welcome to the Sykes Family!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
