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
    [NUnit.Framework.DescriptionAttribute("InformationCentre")]
    public partial class InformationCentreFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "InformationCentre.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "InformationCentre", "\tInformation Centre page content and functionality", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The user can navigate to the Holiday Homes for Sale page")]
        [NUnit.Framework.CategoryAttribute("Navigation")]
        public virtual void TheUserCanNavigateToTheHolidayHomesForSalePage()
        {
            string[] tagsOfScenario = new string[] {
                    "Navigation"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user can navigate to the Holiday Homes for Sale page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.When("I select the Holiday homes for sale navigation link under Let Your Property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.Then("the following page title is displayed: Holiday Homes for Sale UK", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevent elements are present on the Holiday Homes for Sale page")]
        [NUnit.Framework.CategoryAttribute("HolidayHomesForSale")]
        public virtual void TheReleventElementsArePresentOnTheHolidayHomesForSalePage()
        {
            string[] tagsOfScenario = new string[] {
                    "HolidayHomesForSale"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevent elements are present on the Holiday Homes for Sale page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("I have navigated to the following page: letyourcottage/holiday-homes-for-sale", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table18.AddRow(new string[] {
                            "Holiday Homes for Sale UK"});
                table18.AddRow(new string[] {
                            "container_sykes_grid"});
                table18.AddRow(new string[] {
                            "View more holiday homes for sale"});
                table18.AddRow(new string[] {
                            "How much could I earn with Sykes?"});
                table18.AddRow(new string[] {
                            "c-alert__icon-wrap"});
                table18.AddRow(new string[] {
                            "Enquire with Sykes today"});
                table18.AddRow(new string[] {
                            "Get started"});
#line 13
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table18, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The user can navigate to the Information Centre pages")]
        [NUnit.Framework.CategoryAttribute("Navigation")]
        [NUnit.Framework.TestCaseAttribute("Advertising and marketing your holiday let", "Advertising and Marketing Your Holiday Let | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Buying, owner and selling a holiday let", "Buying, Owning & Selling a Holiday Let | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Investment advice for holiday lets", "Investment in Holiday Homes | Holiday Let Business | Sykes", null)]
        [NUnit.Framework.TestCaseAttribute("Legal regulations for holiday lets", "Legal Regulations for Holiday Lets | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Holiday let mortgages", "Mortgages for Holiday Lets | Second Homes | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("How to run your holiday let", "Running Your Holiday Let | Cost & Cleaning | Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("Tax information on holiday lets", "Tax Information for Holiday Homes | Rules & Relief | Sykes", null)]
        public virtual void TheUserCanNavigateToTheInformationCentrePages(string link, string pageTitle, string[] exampleTags)
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The user can navigate to the Information Centre pages", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("I am on the Sykes Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
 testRunner.When("I select the Holiday homes for sale navigation link under Let Your Property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.And(string.Format("I select the {0} navigation link under Information Centre", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.Then(string.Format("the following page title is displayed: {0}", pageTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevent elements are present on the Information Centre pages")]
        [NUnit.Framework.CategoryAttribute("InformationCentre")]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/marketing-your-holiday-let", "Advertising and marketing your holiday let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/buy-own-sell-holiday-lets", "Buying, owning and selling a holiday let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/investment-advice-for-holiday-lets", "Investment advice for holiday lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/legal-regulations-for-holiday-lets", "Legal regulations for holiday lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/holiday-let-mortgages", "Holiday let mortgages", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/how-to-run-your-holiday-let", "How to run your holiday let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/Tax-information-on-holiday-lets", "Tax information on holiday lets", null)]
        public virtual void TheReleventElementsArePresentOnTheInformationCentrePages(string path, string header, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "InformationCentre"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Path", path);
            argumentsOfScenario.Add("Header", header);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevent elements are present on the Information Centre pages", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 40
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
#line 41
 testRunner.Given(string.Format("I have navigated to the following page: {0}", path), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table19.AddRow(new string[] {
                            "form-heading-container"});
                table19.AddRow(new string[] {
                            string.Format("{0}", header)});
                table19.AddRow(new string[] {
                            "Are you thinking of buying?"});
                table19.AddRow(new string[] {
                            "How much could I earn with Sykes?"});
#line 42
 testRunner.Then("the following elements are dislpayed on the page", ((string)(null)), table19, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
