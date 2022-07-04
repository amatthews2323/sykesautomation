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
    [NUnit.Framework.DescriptionAttribute("InformationCentrePages")]
    public partial class InformationCentrePagesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "InformationCentrePages.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "InformationCentrePages", "\tInformation Centre pages content and functionality", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("The user can navigate to the Holiday Homes for Sale page")]
        [NUnit.Framework.CategoryAttribute("Navigation")]
        public void TheUserCanNavigateToTheHolidayHomesForSalePage()
        {
            string[] tagsOfScenario = new string[] {
                    "Navigation"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user can navigate to the Holiday Homes for Sale page", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.Given("I am on the Sykes Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.When("I select the Holiday homes for sale navigation link under Let Your Property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.Then("the following page title is displayed: Holiday Homes for Sale UK", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user can navigate to the Information Centre pages")]
        [NUnit.Framework.CategoryAttribute("Navigation")]
        [NUnit.Framework.TestCaseAttribute("Advertising and marketing your holiday let", "Advertising and Marketing Your Holiday Let | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Buying, owning and selling a holiday let", "Buying, Owning & Selling a Holiday Let | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Investment advice for holiday lets", "Investment in Holiday Homes | Holiday Let Business | Sykes", null)]
        [NUnit.Framework.TestCaseAttribute("Legal regulations for holiday lets", "Legal Regulations for Holiday Lets | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Holiday let mortgages", "Mortgages for Holiday Lets | Second Homes | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("How to run your holiday let", "Running Your Holiday Let | Cost & Cleaning | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Tax information on holiday lets", "Tax Information for Holiday Homes | Rules & Relief | Sykes", null)]
        public void TheUserCanNavigateToTheInformationCentrePages(string link, string pageTitle, string[] exampleTags)
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user can navigate to the Information Centre pages", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 12
 testRunner.Given("I am on the Sykes Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
 testRunner.When("I select the Holiday homes for sale navigation link under Let Your Property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.And(string.Format("I select the {0} navigation link under Information Centre", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.Then(string.Format("the following page title is displayed: {0}", pageTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevent elements are present on the Information Centre pages")]
        [NUnit.Framework.CategoryAttribute("InformationCentre")]
        [NUnit.Framework.CategoryAttribute("LYPSmokeTest")]
        [NUnit.Framework.CategoryAttribute("LYPRegressionSuite")]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/marketing-your-holiday-let", "Advertising and Marketing", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/buy-own-sell-holiday-lets", "Buying, owning and selling a holiday let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/investment-advice-for-holiday-lets", "Investment advice for holiday lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/legal-regulations-for-holiday-lets", "Legal regulations for holiday lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-let-mortgages", "Holiday let mortgages", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/how-to-run-your-holiday-let", "How to run your holiday let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/Tax-information-on-holiday-lets", "Tax information on holiday lets", null)]
        public void TheReleventElementsArePresentOnTheInformationCentrePages(string path, string header, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "InformationCentre",
                    "LYPSmokeTest",
                    "LYPRegressionSuite"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Path", path);
            argumentsOfScenario.Add("Header", header);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevent elements are present on the Information Centre pages", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 27
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 28
 testRunner.Given(string.Format("I have navigated to the following page: {0}", path), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 29
 testRunner.When("I wait 3 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table63 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table63.AddRow(new string[] {
                            "form-heading-container"});
                table63.AddRow(new string[] {
                            string.Format("{0}", header)});
                table63.AddRow(new string[] {
                            "hero__image"});
                table63.AddRow(new string[] {
                            "Customer reviews powered by Trustpilot"});
#line 30
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table63, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The enquiry form is displayed on the Information Centre pages")]
        [NUnit.Framework.CategoryAttribute("InformationCentre")]
        [NUnit.Framework.CategoryAttribute("LYPRegressionSuite")]
        [NUnit.Framework.CategoryAttribute("EnquiryForm")]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/marketing-your-holiday-let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/buy-own-sell-holiday-lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/investment-advice-for-holiday-lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/legal-regulations-for-holiday-lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/holiday-let-mortgages", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/how-to-run-your-holiday-let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/Tax-information-on-holiday-lets", null)]
        public void TheEnquiryFormIsDisplayedOnTheInformationCentrePages(string path, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "InformationCentre",
                    "LYPRegressionSuite",
                    "EnquiryForm"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Path", path);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The enquiry form is displayed on the Information Centre pages", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 48
 testRunner.Given(string.Format("I have navigated to the following page: {0}", path), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table64 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table64.AddRow(new string[] {
                            "form-heading-container"});
                table64.AddRow(new string[] {
                            "heroform_first_name"});
                table64.AddRow(new string[] {
                            "heroform_first_name_validation_error"});
                table64.AddRow(new string[] {
                            "heroform_email"});
                table64.AddRow(new string[] {
                            "heroform_email_validation_error"});
                table64.AddRow(new string[] {
                            "heroform_phone"});
                table64.AddRow(new string[] {
                            "heroform_phone_validation_error"});
                table64.AddRow(new string[] {
                            "/terms/privacypolicy"});
                table64.AddRow(new string[] {
                            "submit"});
#line 49
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table64, "Then ");
#line hidden
#line 60
 testRunner.When("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.And("I click heroform_first_name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And("I wait 2 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.Then("the following text is displayed: Please enter a full name.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.When("I click heroform_email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.Then("the following text is displayed: Please enter an email address.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.When("I click heroform_phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.Then("the following text is displayed: Please enter a contact number.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.When("I enter test.com in the following form field: heroform_email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.Then("the following text is displayed: \'test.com\' is missing an \'@\'. Please include an " +
                        "\'@\' in the email address.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.When("I enter test@test in the following form field: heroform_email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.Then("the following text is displayed: \'test@test\' is an incomplete email address. Plea" +
                        "se include e.g. \'.com\', \'.co.uk\', \'.net\'.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
 testRunner.When("I enter test in the following form field: heroform_phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.Then("the following text is displayed: Please enter a valid contact number that does no" +
                        "t include letters, spaces, special characters and contains no less than 10 digit" +
                        "s.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 80
 testRunner.When("I enter 070000000 in the following form field: heroform_phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
 testRunner.Then("the following text is displayed: Please provide a contact number that is no less " +
                        "than 10 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.When("I enter 0700000000000000 in the following form field: heroform_phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.Then("the following text is displayed: Please provide a contact number that is no more " +
                        "than 15 digits long.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 86
 testRunner.When("I enter +44 7000 000 000 in the following form field: heroform_phone", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.And("I click form-heading-container", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.Then("the following element is not displayed: Please enter a valid contact number that " +
                        "does not include letters, spaces, special characters and contains no less than 1" +
                        "0 digits.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.Then("the following element is not displayed: Already started?", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
