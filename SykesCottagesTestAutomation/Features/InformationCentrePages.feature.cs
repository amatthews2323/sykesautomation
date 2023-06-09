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
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/about-us", "About Sykes Holiday Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/a-guide-to-buying-a-holiday-let", "A Guide to Buying a Holiday Let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/are-holiday-homes-a-good-investment", "Why Now is a Good Time to Invest in a Holiday Let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/benefits-short-term-letting", "Benefits of Short Term Holiday Letting", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/building-holiday-let", "Building a Holiday Let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/buying-a-holiday-home", "Buying a Holiday Home", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/buy-own-sell-holiday-lets", "Buying, owning and selling a holiday let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/capital-gains-tax", "Do I have to pay Capital Gains Tax on a Furnished Holiday Let?", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/cottage-owner", "Are you a holiday cottage owner?", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/damage-protection-terms", "Damage Protection Guarantee Terms", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/e-i-l", "Do you want to earn more from your holiday let?", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/expert-guide-to-advertise-your-holiday-home", "Our Expert Guide to Advertising Your Holiday Home", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/farm-diversification-holiday-letting", "Farm Diversification and Holiday Letting", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/furnished-holiday-let-tax-guide", "Tax information on holiday lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-chalet-letting-business", "Holiday Chalet Letting Business", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-cottage-rates", "What rates of taxes do I need to pay on my holiday cottage?", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-home-cleaning", "Cleaning your holiday home - what are the options?", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-home-finance", "Holiday Let Finance", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-home-taxes", "Holiday home tax - what are the rules?", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-let-agency", "How to Choose the Best Holiday Let Agency", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-let-business-success", "Running a Successful Holiday Let Business", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-let-investment", "Are Holiday Homes a Good Investment?", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-let-marketing", "Marketing Your Holiday Let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-let-mortgage-information", "Holiday Let Mortgages", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-let-mortgages", "Holiday let mortgages", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-let-mortgages-a-complete-guide", "A Complete Guide to Holiday Let Mortgages", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-letting-getting-started", "Holiday Letting: Getting Started", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-letting-information", "Holiday Letting: The Pros & Cons", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-letting-rules", "Holiday letting - what are the rules and regulations for a furnished holiday let?" +
            "", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/holiday-management-services", "How Sykes Can Manage Your Holiday Home", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/how-to-run-your-holiday-let", "How to run your holiday let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/investment-advice-for-holiday-lets", "Investment advice for holiday lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/leading-holiday-let-agency", "Why You Should Let Your Property With The Leading Holiday Lettings Agency", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/legal-regulations-for-holiday-lets", "Holiday Let Rules and Regulations - The Legal Requirements", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/letting-a-log-cabin", "Letting Out A Log Cabin", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/make-the-switch", "Make the Switch to Sykes - it\'s easier than you think...", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/marketing-your-holiday-let", "Advertising and Marketing", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/n-t-l", "Are you new to the holiday home market and looking to let out your property?", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/regulations-for-holiday-lets", "Legal regulations for holiday lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/renting-out-your-property", "Let Sykes help you with everything you need to rent out your property", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/run-holiday-let-as-business", "How to Run a Holiday Let as a Business", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/running-your-holiday-let", "Running your Holiday Let", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/shepherd-huts-for-holiday-lets", "Holiday Letting With Shepherd huts", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/Stamp-Duty-On-Holiday-Lets", "Stamp Duty On Holiday Lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/Tax-information-on-holiday-lets", "Tax information on holiday lets", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/t-o-b", "Are you thinking of buying a holiday let?", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/video-test-let-agency", "How to Choose the Best Holiday Let Agency", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/welcome-gift", "Earn a welcome cashback offer when you list your property with Sykes Cottages", null)]
        [NUnit.Framework.TestCaseAttribute("letyourcottage/information/welcome-gift-terms", "Welcome Gift Offer 2023 - Terms and Conditions", null)]
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
 testRunner.When("I wait up to 10 seconds for the following to be displayed: Customer reviews power" +
                        "ed by Trustpilot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table71 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table71.AddRow(new string[] {
                            string.Format("{0}", header)});
                table71.AddRow(new string[] {
                            "hero__image"});
                table71.AddRow(new string[] {
                            "Customer reviews powered by Trustpilot"});
                table71.AddRow(new string[] {
                            "How much could I earn with Sykes?"});
#line 30
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table71, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Information Centre pages load as intended")]
        [NUnit.Framework.CategoryAttribute("InformationCentre")]
        public void TheInformationCentrePagesLoadAsIntended()
        {
            string[] tagsOfScenario = new string[] {
                    "InformationCentre"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Information Centre pages load as intended", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 89
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 90
 testRunner.Given("I am on the following webpage: https://www.sykescottages.co.uk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table72 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/about-us"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/a-guide-to-buying-a-holiday-let"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/are-holiday-homes-a-good-investment"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/benefits-short-term-letting"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/building-holiday-let"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/buying-a-holiday-home"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/buy-own-sell-holiday-lets"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/capital-gains-tax"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/cottage-owner"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/damage-protection-terms"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/e-i-l"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/expert-guide-to-advertise-your-holiday-home"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/farm-diversification-holiday-letting"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/furnished-holiday-let-tax-guide"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-chalet-letting-business"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-cottage-rates"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-home-cleaning"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-home-finance"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-home-taxes"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-let-agency"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-let-business-success"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-let-investment"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-let-marketing"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-let-mortgage-information"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-let-mortgages"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-let-mortgages-a-complete-guide"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-letting-getting-started"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-letting-information"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-letting-rules"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/holiday-management-services"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/how-to-run-your-holiday-let"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/investment-advice-for-holiday-lets"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/leading-holiday-let-agency"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/legal-regulations-for-holiday-lets"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/letting-a-log-cabin"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/make-the-switch"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/marketing-your-holiday-let"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/n-t-l"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/regulations-for-holiday-lets"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/renting-out-your-property"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/run-holiday-let-as-business"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/running-your-holiday-let"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/shepherd-huts-for-holiday-lets"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/Stamp-Duty-On-Holiday-Lets"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/Tax-information-on-holiday-lets"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/t-o-b"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/video-test-let-agency"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/welcome-gift"});
                table72.AddRow(new string[] {
                            "letyourcottage/information/welcome-gift-terms"});
#line 91
 testRunner.Then("the following links load correctly", ((string)(null)), table72, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
