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
    [NUnit.Framework.DescriptionAttribute("ThinkingOfBuying")]
    public partial class ThinkingOfBuyingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "ThinkingOfBuying.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "ThinkingOfBuying", "\tThinking of Buying content and functionality", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the Thinking of Buying page")]
        [NUnit.Framework.CategoryAttribute("ThinkingOfBuying")]
        [NUnit.Framework.CategoryAttribute("TOBSmokeTest")]
        public void TheRelevantSectionsAreDisplayedOnTheThinkingOfBuyingPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ThinkingOfBuying",
                    "TOBSmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the Thinking of Buying page", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.Given("I have navigated to the following page: letyourcottage/advice", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table116 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table116.AddRow(new string[] {
                            "Holiday Let Information Centre"});
                table116.AddRow(new string[] {
                            "Browse categories"});
                table116.AddRow(new string[] {
                            "Beginner Guides to Buying a Holiday Home"});
                table116.AddRow(new string[] {
                            "Latest Guides and Articles"});
                table116.AddRow(new string[] {
                            "Services and Tools"});
                table116.AddRow(new string[] {
                            "Making a Fresh Start"});
                table116.AddRow(new string[] {
                            "Contact us"});
#line 7
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table116, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the Buying a Holiday Home page")]
        [NUnit.Framework.CategoryAttribute("ThinkingOfBuying")]
        [NUnit.Framework.CategoryAttribute("TOBSmokeTest")]
        public void TheRelevantSectionsAreDisplayedOnTheBuyingAHolidayHomePage()
        {
            string[] tagsOfScenario = new string[] {
                    "ThinkingOfBuying",
                    "TOBSmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the Buying a Holiday Home page", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.Given("I have navigated to the following page: letyourcottage/advice/buying-a-holiday-ho" +
                        "me", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table117 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table117.AddRow(new string[] {
                            "Buying a Holiday Home"});
                table117.AddRow(new string[] {
                            "Where to Buy"});
                table117.AddRow(new string[] {
                            "General"});
                table117.AddRow(new string[] {
                            "Beginner Guides to Buying a Holiday Home"});
                table117.AddRow(new string[] {
                            "Intermediate Guides to Buying a Holiday Home"});
                table117.AddRow(new string[] {
                            "Services and Tools"});
                table117.AddRow(new string[] {
                            "Converting a Listed Chapel Into a Holiday Let"});
                table117.AddRow(new string[] {
                            "Contact us"});
#line 20
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table117, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the Financial Guides page")]
        [NUnit.Framework.CategoryAttribute("ThinkingOfBuying")]
        [NUnit.Framework.CategoryAttribute("TOBSmokeTest")]
        public void TheRelevantSectionsAreDisplayedOnTheFinancialGuidesPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ThinkingOfBuying",
                    "TOBSmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the Financial Guides page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 33
 testRunner.Given("I have navigated to the following page: letyourcottage/advice/financial-guides", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table118 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table118.AddRow(new string[] {
                            "Financial Guides"});
                table118.AddRow(new string[] {
                            "Regulations"});
                table118.AddRow(new string[] {
                            "Mortgages"});
                table118.AddRow(new string[] {
                            "Insurance"});
                table118.AddRow(new string[] {
                            "Taxes"});
                table118.AddRow(new string[] {
                            "Beginner Guides to Financials"});
                table118.AddRow(new string[] {
                            "Intermediate Guides to Financials"});
                table118.AddRow(new string[] {
                            "Advanced Guides to Financials"});
                table118.AddRow(new string[] {
                            "Services and Tools"});
                table118.AddRow(new string[] {
                            "Making an Income"});
                table118.AddRow(new string[] {
                            "Contact us"});
#line 34
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table118, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the Letting a Holiday Home page")]
        [NUnit.Framework.CategoryAttribute("ThinkingOfBuying")]
        [NUnit.Framework.CategoryAttribute("TOBSmokeTest")]
        public void TheRelevantSectionsAreDisplayedOnTheLettingAHolidayHomePage()
        {
            string[] tagsOfScenario = new string[] {
                    "ThinkingOfBuying",
                    "TOBSmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the Letting a Holiday Home page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 50
 testRunner.Given("I have navigated to the following page: letyourcottage/advice/holiday-letting-gui" +
                        "des", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table119 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table119.AddRow(new string[] {
                            "Letting a Holiday Home"});
                table119.AddRow(new string[] {
                            "Holiday Letting"});
                table119.AddRow(new string[] {
                            "Maximising Earnings"});
                table119.AddRow(new string[] {
                            "Running Your Holiday Let"});
                table119.AddRow(new string[] {
                            "Tips and Advice"});
                table119.AddRow(new string[] {
                            "Listing a Holiday Let"});
                table119.AddRow(new string[] {
                            "Beginner Guides to Letting a Holiday Home"});
                table119.AddRow(new string[] {
                            "Intermediate Guides to Letting a Holiday Home"});
                table119.AddRow(new string[] {
                            "Advanced Guides to Letting a Holiday Home"});
                table119.AddRow(new string[] {
                            "Services and Tools"});
                table119.AddRow(new string[] {
                            "Setting up a Holiday Let"});
                table119.AddRow(new string[] {
                            "Contact us"});
#line 51
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table119, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the Managing a Holiday Let page")]
        [NUnit.Framework.CategoryAttribute("ThinkingOfBuying")]
        [NUnit.Framework.CategoryAttribute("TOBSmokeTest")]
        public void TheRelevantSectionsAreDisplayedOnTheManagingAHolidayLetPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ThinkingOfBuying",
                    "TOBSmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the Managing a Holiday Let page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 67
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 68
 testRunner.Given("I have navigated to the following page: letyourcottage/advice/managing-your-holid" +
                        "ay-let", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table120 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table120.AddRow(new string[] {
                            "Managing a Holiday Let"});
                table120.AddRow(new string[] {
                            "Why Sykes?"});
                table120.AddRow(new string[] {
                            "Services and Tools"});
                table120.AddRow(new string[] {
                            "Running Two Holiday Lets"});
                table120.AddRow(new string[] {
                            "Contact us"});
#line 69
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table120, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the Case Studies page")]
        [NUnit.Framework.CategoryAttribute("ThinkingOfBuying")]
        [NUnit.Framework.CategoryAttribute("TOBSmokeTest")]
        public void TheRelevantSectionsAreDisplayedOnTheCaseStudiesPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ThinkingOfBuying",
                    "TOBSmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the Case Studies page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 78
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 79
 testRunner.Given("I have navigated to the following page: letyourcottage/advice/case-studies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table121 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table121.AddRow(new string[] {
                            "Owner Case Studies"});
                table121.AddRow(new string[] {
                            "Services and Tools"});
                table121.AddRow(new string[] {
                            "Contact us"});
#line 80
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table121, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the A Guide to Buying a Holiday Let page")]
        [NUnit.Framework.CategoryAttribute("ThinkingOfBuying")]
        [NUnit.Framework.CategoryAttribute("TOBSmokeTest")]
        public void TheRelevantSectionsAreDisplayedOnTheAGuideToBuyingAHolidayLetPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ThinkingOfBuying",
                    "TOBSmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the A Guide to Buying a Holiday Let page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 87
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 88
 testRunner.Given("I have navigated to the following page: letyourcottage/advice/article/a-guide-to-" +
                        "buying-a-holiday-let", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table122 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table122.AddRow(new string[] {
                            "A Guide to Buying a Holiday Let"});
                table122.AddRow(new string[] {
                            "Let\'s Work Together"});
                table122.AddRow(new string[] {
                            "The key benefits of buying a holiday let"});
                table122.AddRow(new string[] {
                            "A guide to buying your holiday home"});
                table122.AddRow(new string[] {
                            "Where to buy your holiday home"});
                table122.AddRow(new string[] {
                            "Legalities"});
                table122.AddRow(new string[] {
                            "Taxes"});
                table122.AddRow(new string[] {
                            "What are the extra costs when you buy a holiday let?"});
                table122.AddRow(new string[] {
                            "Buying a Holiday Home General Guides"});
                table122.AddRow(new string[] {
                            "Contact us"});
#line 89
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table122, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the Are Holiday Lets a Good Investment pag" +
            "e")]
        [NUnit.Framework.CategoryAttribute("ThinkingOfBuying")]
        [NUnit.Framework.CategoryAttribute("TOBSmokeTest")]
        public void TheRelevantSectionsAreDisplayedOnTheAreHolidayLetsAGoodInvestmentPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ThinkingOfBuying",
                    "TOBSmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the Are Holiday Lets a Good Investment pag" +
                    "e", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 103
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 104
 testRunner.Given("I have navigated to the following page: letyourcottage/advice/article/why-are-hol" +
                        "iday-lets-a-good-investment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table123 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table123.AddRow(new string[] {
                            "Are Holiday Lets a Good Investment?"});
                table123.AddRow(new string[] {
                            "Let\'s Work Together"});
                table123.AddRow(new string[] {
                            "Are holiday lets a good investment?"});
                table123.AddRow(new string[] {
                            "What types of holiday let mortgages are there?"});
                table123.AddRow(new string[] {
                            "What Return on Investment can you get from a holiday let?"});
                table123.AddRow(new string[] {
                            "Best places to buy a holiday home"});
                table123.AddRow(new string[] {
                            "How to maximise your income"});
                table123.AddRow(new string[] {
                            "Ready to get started?"});
                table123.AddRow(new string[] {
                            "Buying a Holiday Home General Guides"});
                table123.AddRow(new string[] {
                            "Contact us"});
#line 105
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table123, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The relevant sections are displayed on the Buying a Holiday Home Abroad vs. in th" +
            "e UK page")]
        [NUnit.Framework.CategoryAttribute("ThinkingOfBuying")]
        [NUnit.Framework.CategoryAttribute("TOBSmokeTest")]
        public void TheRelevantSectionsAreDisplayedOnTheBuyingAHolidayHomeAbroadVs_InTheUKPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ThinkingOfBuying",
                    "TOBSmokeTest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The relevant sections are displayed on the Buying a Holiday Home Abroad vs. in th" +
                    "e UK page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 119
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 120
 testRunner.Given("I have navigated to the following page: letyourcottage/advice/article/buying-a-ho" +
                        "liday-home-abroad-vs-uk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table124 = new TechTalk.SpecFlow.Table(new string[] {
                            "Element"});
                table124.AddRow(new string[] {
                            "Buying a Holiday Home Abroad vs. in the UK"});
                table124.AddRow(new string[] {
                            "Let\'s Work Together"});
                table124.AddRow(new string[] {
                            "Benefits of Holiday Letting in the UK"});
                table124.AddRow(new string[] {
                            "Disadvantages of Holiday Letting in the UK"});
                table124.AddRow(new string[] {
                            "Benefits of Holiday Letting Abroad"});
                table124.AddRow(new string[] {
                            "Disadvantages of Holiday Letting Abroad"});
                table124.AddRow(new string[] {
                            "Where to Buy Guides"});
                table124.AddRow(new string[] {
                            "Contact us"});
#line 121
 testRunner.Then("the relevant elements are dislpayed", ((string)(null)), table124, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
