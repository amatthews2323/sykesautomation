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
        [NUnit.Framework.DescriptionAttribute("The Sister Brands are displayed correctly")]
        [NUnit.Framework.CategoryAttribute("SisterBrands")]
        [NUnit.Framework.CategoryAttribute("LYPRegressionSuite")]
        [NUnit.Framework.TestCaseAttribute("Best Escapes", null)]
        [NUnit.Framework.TestCaseAttribute("Best of Suffolk", null)]
        [NUnit.Framework.TestCaseAttribute("Carbis Bay Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Character Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Coast & Country Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Coast & Country Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Cornish Cottage Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Dream Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Heart of the Lakes", null)]
        [NUnit.Framework.TestCaseAttribute("Helpful Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Hogans Irish Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("John Bray Cornish Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Lake District Lodge Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Lakelovers", null)]
        [NUnit.Framework.TestCaseAttribute("Lakes Cottage Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Large Holiday Houses", null)]
        [NUnit.Framework.TestCaseAttribute("Lyme Bay Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Manor Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Menai Holiday Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Northumbria Coast & Country Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Yorkshire Coastal", null)]
        public void TheSisterBrandsAreDisplayedCorrectly(string brand, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SisterBrands",
                    "LYPRegressionSuite"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Brand", brand);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Sister Brands are displayed correctly", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.Given(string.Format("I have navigated to the following brand: {0}", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table103 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table103.AddRow(new string[] {
                            "first_name"});
                table103.AddRow(new string[] {
                            "last_name"});
                table103.AddRow(new string[] {
                            "Your details will be used by the Sykes group to send you information about our pr" +
                                "operty letting services."});
                table103.AddRow(new string[] {
                            "/terms/privacypolicy"});
#line 7
 testRunner.Then("the relevant elements are dislpayed within the enquiry-multi-step section", ((string)(null)), table103, "Then ");
#line hidden
#line 13
 testRunner.When("I click //*[@*=\'enquiry-multi-step\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table104 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table104.AddRow(new string[] {
                            "Please enter your first name"});
                table104.AddRow(new string[] {
                            "Please enter your surname"});
#line 14
 testRunner.Then("the relevant elements are dislpayed within the enquiry-multi-step section", ((string)(null)), table104, "Then ");
#line hidden
#line 18
 testRunner.When("I enter Test in the following form field: //*[@*=\'enquiry-multi-step\']//input[@*=" +
                        "\'first_name\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.And("I enter Owner in the following form field: //*[@*=\'enquiry-multi-step\']//input[@*" +
                        "=\'last_name\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("I click //*[@*=\'enquiry-multi-step\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table105 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table105.AddRow(new string[] {
                            "In order to receive email communications from our expert team, please provide you" +
                                "r email address."});
                table105.AddRow(new string[] {
                            "Email address"});
#line 21
 testRunner.Then("the relevant elements are dislpayed within the enquiry-multi-step section", ((string)(null)), table105, "Then ");
#line hidden
#line 25
 testRunner.When("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'2\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("the following text is displayed: Please enter an email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.When("I enter sykescottages.co.uk in the following form field: //*[@*=\'enquiry-multi-st" +
                        "ep\' and @data-step=\'2\']//input[@*=\'email\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.And("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'2\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then("the following text is displayed: \'sykescottages.co.uk\' is missing an \'@\'. Please " +
                        "include an \'@\' in the email address.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.When("I enter testowner@sykescottages in the following form field: //*[@*=\'enquiry-mult" +
                        "i-step\' and @data-step=\'2\']//input[@*=\'email\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.And("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'2\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.Then("the following text is displayed: \'testowner@sykescottages\' is an incomplete email" +
                        " address. Please include e.g. \'.com\', \'.co.uk\', \'.net\'.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.When("I enter testowner@sykescottages.co.uk in the following form field: //*[@*=\'enquir" +
                        "y-multi-step\' and @data-step=\'2\']//input[@*=\'email\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.And("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'2\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'2\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table106 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table106.AddRow(new string[] {
                            "To allow our property experts to contact you by phone (including an initial call " +
                                "regarding your enquiry), please provide your phone number."});
                table106.AddRow(new string[] {
                            "Phone number"});
#line 36
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table106, "Then ");
#line hidden
#line 40
 testRunner.And("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'3\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.Then("the following text is displayed: Please enter a contact number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
 testRunner.When("I enter 070000000 in the following form field: //*[@*=\'enquiry-multi-step\' and @d" +
                        "ata-step=\'3\']//input[@*=\'phone\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.And("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'3\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.Then("the following text is displayed: Please provide a contact number that is no less " +
                        "than 10 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.When("I enter 0700000000000000 in the following form field: //*[@*=\'enquiry-multi-step\'" +
                        " and @data-step=\'3\']//input[@*=\'phone\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.And("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'3\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.Then("the following text is displayed: Please provide a contact number that is no more " +
                        "than 15 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.When("I enter +44 7000 000 000 in the following form field: //*[@*=\'enquiry-multi-step\'" +
                        " and @data-step=\'3\']//input[@*=\'phone\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.And("I click //*[@*=\'enquiry-form-step3\']//*[@*=\'Close modal\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Sister Brand MultiStep form can be submitted")]
        [NUnit.Framework.CategoryAttribute("SisterBrands")]
        [NUnit.Framework.CategoryAttribute("FormSubmission")]
        [NUnit.Framework.TestCaseAttribute("Best Escapes", null)]
        [NUnit.Framework.TestCaseAttribute("Best of Suffolk", null)]
        [NUnit.Framework.TestCaseAttribute("Carbis Bay Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Character Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Coast & Country Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Coast & Country Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Cornish Cottage Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Dream Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Heart of the Lakes", null)]
        [NUnit.Framework.TestCaseAttribute("Helpful Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Hogans Irish Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("John Bray Cornish Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Lake District Lodge Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Lakelovers", null)]
        [NUnit.Framework.TestCaseAttribute("Lakes Cottage Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Large Holiday Houses", null)]
        [NUnit.Framework.TestCaseAttribute("Lyme Bay Holidays", null)]
        [NUnit.Framework.TestCaseAttribute("Manor Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Menai Holiday Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Northumbria Coast & Country Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Yorkshire Coastal", null)]
        public void TheSisterBrandMultiStepFormCanBeSubmitted(string brand, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SisterBrands",
                    "FormSubmission"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Brand", brand);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Sister Brand MultiStep form can be submitted", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 82
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 83
 testRunner.Given(string.Format("I have navigated to the following brand: {0}", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 84
 testRunner.Then("the following text is displayed: Start your  holiday letting journey today", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table107 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table107.AddRow(new string[] {
                            "first_name"});
                table107.AddRow(new string[] {
                            "last_name"});
                table107.AddRow(new string[] {
                            "Your details will be used by the Sykes group to send you information about our pr" +
                                "operty letting services."});
                table107.AddRow(new string[] {
                            "/terms/privacypolicy"});
#line 85
 testRunner.And("the relevant elements are dislpayed within the enquiry-multi-step section", ((string)(null)), table107, "And ");
#line hidden
#line 91
 testRunner.When("I enter Test in the following form field: //*[@*=\'enquiry-multi-step\']//input[@*=" +
                        "\'first_name\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.And("I enter Owner in the following form field: //*[@*=\'enquiry-multi-step\']//input[@*" +
                        "=\'last_name\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.And("I click //*[@*=\'enquiry-multi-step\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table108 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table108.AddRow(new string[] {
                            "In order to receive email communications from our expert team, please provide you" +
                                "r email address."});
                table108.AddRow(new string[] {
                            "Email address"});
#line 94
 testRunner.Then("the relevant elements are dislpayed within the enquiry-multi-step section", ((string)(null)), table108, "Then ");
#line hidden
#line 98
 testRunner.When("I enter testowner@sykescottages.co.uk in the following form field: //*[@*=\'enquir" +
                        "y-multi-step\' and @data-step=\'2\']//input[@*=\'email\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 99
 testRunner.And("I wait 2 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
 testRunner.And("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'2\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
 testRunner.And("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'2\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table109 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table109.AddRow(new string[] {
                            "To allow our property experts to contact you by phone (including an initial call " +
                                "regarding your enquiry), please provide your phone number."});
                table109.AddRow(new string[] {
                            "Phone number"});
#line 102
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table109, "Then ");
#line hidden
#line 106
 testRunner.And("I wait 2 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.When("I enter 03555999555 in the following form field: //*[@*=\'enquiry-multi-step\' and " +
                        "@data-step=\'3\']//input[@*=\'phone\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 108
 testRunner.And("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'3\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.And("I click //*[@*=\'enquiry-multi-step\' and @data-step=\'3\']/button[@*=\'submit\']", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 110
 testRunner.And("I wait 2 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.And("I try clicking //input[@name=\'region-capture\' and @value=\'thinking\']//parent::*", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 112
 testRunner.And("I try clicking //*[@*=\'enquiry-multi-step\' and @data-step=\'4\']/button[@*=\'submit\'" +
                        "]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.And("I try clicking //*[@*=\'enquiry-multi-step\' and @data-step=\'4\']/button[@*=\'submit\'" +
                        "]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table110 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table110.AddRow(new string[] {
                            "Please ensure the following details are correct"});
                table110.AddRow(new string[] {
                            "Your details will be used by the Sykes group to send you information about our pr" +
                                "operty letting services."});
                table110.AddRow(new string[] {
                            "Submit enquiry"});
#line 114
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table110, "Then ");
#line hidden
#line 119
 testRunner.When("I wait 2 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 120
 testRunner.And("I try clicking //*[@*=\'enquiry-multi-step\' and @data-step=\'4\']/button[@*=\'submit\'" +
                        "]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 121
 testRunner.And("I try clicking //*[@*=\'enquiry-multi-step\' and @data-step=\'5\']/button[@*=\'submit\'" +
                        "]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 122
 testRunner.And("I wait up to 10 seconds for the following to be displayed: Thank you for your enq" +
                        "uiry", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 123
 testRunner.Then("the following page title is displayed: Thank you for your enquiry | Sykes Cottage" +
                        "s", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
