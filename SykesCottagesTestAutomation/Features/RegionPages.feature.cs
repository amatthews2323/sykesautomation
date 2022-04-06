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
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "RegionPages.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "RegionPages", "\tRegion pages content and functionality", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The Regional pages are displayed correctly")]
        [NUnit.Framework.CategoryAttribute("RegionPages")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        [NUnit.Framework.CategoryAttribute("RegressionSmokeTest")]
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
        public virtual void TheRegionalPagesAreDisplayedCorrectly(string path, string region, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegionPages",
                    "ProductionRegressionSuite",
                    "RegressionSmokeTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Path", path);
            argumentsOfScenario.Add("Region", region);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Regional pages are displayed correctly", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given(string.Format("I have navigated to the following page: {0}", path), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.Then(string.Format("the following text is displayed on the page: {0}", region), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 8
 testRunner.And("the following element is displayed on the page: form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The enquiry form is displayed on the Regional pages")]
        [NUnit.Framework.CategoryAttribute("RegionPages")]
        [NUnit.Framework.CategoryAttribute("ProductionRegressionSuite")]
        [NUnit.Framework.CategoryAttribute("EnquiryForm")]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/South-West", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/South-of-England", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Heart-of-England", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/East-Anglia", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Peak-District", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/North-York-Moors-and-Coast", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Northumberland", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Wales", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Ireland", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/In-Your-Area/Scotland", null)]
        public virtual void TheEnquiryFormIsDisplayedOnTheRegionalPages(string path, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegionPages",
                    "ProductionRegressionSuite",
                    "EnquiryForm"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Path", path);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The enquiry form is displayed on the Regional pages", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 24
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
#line 25
 testRunner.Given(string.Format("I have navigated to the following page: {0}", path), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table60 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table60.AddRow(new string[] {
                            "form-heading-container"});
                table60.AddRow(new string[] {
                            "Complete the form to receive your information pack"});
                table60.AddRow(new string[] {
                            "heroform_first_name"});
                table60.AddRow(new string[] {
                            "heroform_first_name_validation_error"});
                table60.AddRow(new string[] {
                            "heroform_email"});
                table60.AddRow(new string[] {
                            "heroform_email_validation_error"});
                table60.AddRow(new string[] {
                            "heroform_phone"});
                table60.AddRow(new string[] {
                            "heroform_phone_validation_error"});
                table60.AddRow(new string[] {
                            "marketing_email"});
                table60.AddRow(new string[] {
                            "marketing_phone"});
                table60.AddRow(new string[] {
                            "marketing_sms"});
                table60.AddRow(new string[] {
                            "marketing_post"});
                table60.AddRow(new string[] {
                            "Your details will be stored and used to send you information about our property l" +
                                "etting services. You can opt out or unsubscribe at any time by contacting us."});
                table60.AddRow(new string[] {
                            "/terms/privacypolicy"});
                table60.AddRow(new string[] {
                            "submit"});
#line 26
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table60, "Then ");
#line hidden
#line 43
 testRunner.When("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.And("I click heroform_first_name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table61 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table61.AddRow(new string[] {
                            "Please enter a full name."});
                table61.AddRow(new string[] {
                            "Please enter an email address."});
                table61.AddRow(new string[] {
                            "Please enter a contact number."});
#line 46
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table61, "Then ");
#line hidden
#line 51
 testRunner.When("I enter an email address without an @ symbol", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.Then("the following text is displayed on the page: \'test.com\' is missing an \'@\'. Please" +
                        " include an \'@\' in the email address.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.When("I enter an email address without a valid domain", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.Then("the following text is displayed on the page: \'test@test\' is an incomplete email a" +
                        "ddress. Please include e.g. \'.com\', \'.co.uk\', \'.net\'.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.When("I enter a phone number with a non-numerical character", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.Then("the following text is displayed on the page: Please enter a valid contact number " +
                        "that does not include letters, spaces, special characters and contains no less t" +
                        "han 10 digits.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.When("I enter a phone number with less than 10 digits", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.Then("the following text is displayed on the page: Please provide a contact number that" +
                        " is no less than 10 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.When("I enter a phone number with more than 15 digits", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.Then("the following text is displayed on the page: Please provide a contact number that" +
                        " is no more than 15 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.When("I enter a phone number with spaces and +44", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.Then("the following element is not displayed on the page: Please enter a valid contact " +
                        "number that does not include letters, spaces, special characters and contains no" +
                        " less than 10 digits.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
        public virtual void TheUserCanNavigateToTheRegionPages(string link, string pageTitle, string[] exampleTags)
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user can navigate to the Region pages", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 84
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
#line 85
 testRunner.Given("I am on the Sykes Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 86
 testRunner.When("I select the Holiday homes for sale navigation link under Let Your Property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.And(string.Format("I select the {0} navigation link under Your Location", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.Then(string.Format("the following page title is displayed: {0}", pageTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
