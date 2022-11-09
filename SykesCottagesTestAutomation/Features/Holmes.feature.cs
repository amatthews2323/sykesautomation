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
    [NUnit.Framework.DescriptionAttribute("Holmes")]
    public partial class HolmesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Holmes.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Holmes", "\tHolmes experiment tests.", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("Get all active experiments from Holmes")]
        [NUnit.Framework.CategoryAttribute("HolmesExperiments")]
        public void GetAllActiveExperimentsFromHolmes()
        {
            string[] tagsOfScenario = new string[] {
                    "HolmesExperiments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all active experiments from Holmes", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.Given("I am on the following webpage: http://holmes.staging.sykes.cloud/experiments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.Then("I store the experiment IDs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get all active experiments in a given session")]
        [NUnit.Framework.CategoryAttribute("HolmesExperiments")]
        public void GetAllActiveExperimentsInAGivenSession()
        {
            string[] tagsOfScenario = new string[] {
                    "HolmesExperiments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all active experiments in a given session", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 11
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 12
 testRunner.When("I store the active experiment IDs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Given("I am on the following webpage: http://holmes.prod.sykes.cloud/experiments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 14
 testRunner.When("I search for the experiment details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check specific experiments are applied")]
        [NUnit.Framework.CategoryAttribute("HolmesExperiments")]
        public void CheckSpecificExperimentsAreApplied()
        {
            string[] tagsOfScenario = new string[] {
                    "HolmesExperiments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check specific experiments are applied", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 19
 testRunner.When("I store the active experiment IDs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table74 = new TechTalk.SpecFlow.Table(new string[] {
                            "Example"});
                table74.AddRow(new string[] {
                            "4419"});
                table74.AddRow(new string[] {
                            "4396"});
#line 20
 testRunner.Then("the following experiements are enabled", ((string)(null)), table74, "Then ");
#line hidden
#line 24
 testRunner.And("I wait 300 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get experiment conversion precentage")]
        [NUnit.Framework.CategoryAttribute("HolmesExperiments")]
        public void GetExperimentConversionPrecentage()
        {
            string[] tagsOfScenario = new string[] {
                    "HolmesExperiments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get experiment conversion precentage", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.Given("I am on the following webpage: https://holmes.prod.sykes.cloud/experiments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table75 = new TechTalk.SpecFlow.Table(new string[] {
                            "Example"});
                table75.AddRow(new string[] {
                            "4645"});
                table75.AddRow(new string[] {
                            "4648"});
                table75.AddRow(new string[] {
                            "4658"});
                table75.AddRow(new string[] {
                            "4683"});
                table75.AddRow(new string[] {
                            "4257"});
                table75.AddRow(new string[] {
                            "4560"});
                table75.AddRow(new string[] {
                            "4736"});
                table75.AddRow(new string[] {
                            "4739"});
                table75.AddRow(new string[] {
                            "4744"});
#line 29
 testRunner.Then("I navigate to the Holmes statistics page and store the conversion percentage", ((string)(null)), table75, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get experiment status")]
        [NUnit.Framework.CategoryAttribute("HolmesExperiments")]
        public void GetExperimentStatus()
        {
            string[] tagsOfScenario = new string[] {
                    "HolmesExperiments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get experiment status", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 43
 testRunner.Given("I am on the following webpage: https://holmes.prod.sykes.cloud/experiments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table76 = new TechTalk.SpecFlow.Table(new string[] {
                            "Example"});
                table76.AddRow(new string[] {
                            "LetYourCottages_PossibleInsurancePolicyimplementationLYP82"});
                table76.AddRow(new string[] {
                            "LetYourCottages_MakeLYPNumberClickableOnMobileHomepage19693"});
                table76.AddRow(new string[] {
                            "LetYourCottages_SpeakToSomeoneSectionAllPlatforms19766"});
                table76.AddRow(new string[] {
                            "LetYourCottages_DownloadPackSection144"});
                table76.AddRow(new string[] {
                            "LetYourCottages_ImprovehomepagesectionsfortabletLYP81"});
                table76.AddRow(new string[] {
                            "LetYourCottages_RemoveOwnerPack19968"});
                table76.AddRow(new string[] {
                            "LetYourCottages_RemovalOfNonHeroForms171"});
                table76.AddRow(new string[] {
                            "LetYourCottages_HeroContentandFormTitleChangeLYP178"});
                table76.AddRow(new string[] {
                            "LetYourCottages_CreateExperimenttoHideFreebadgeLYP177"});
                table76.AddRow(new string[] {
                            "LetYourCottages_LYPTestPositionofCalculatorLYP182"});
                table76.AddRow(new string[] {
                            "LetYourCottages_PartnersMarketingSection152"});
                table76.AddRow(new string[] {
                            "LetYourCottages_LYPHeroImageChangetoConveyOwnerSpaceLYP185"});
                table76.AddRow(new string[] {
                            "LetYourCottages_SykesLYPLogo186"});
                table76.AddRow(new string[] {
                            "LetYourCottages_LinkbackforconsumertrafficLYP192"});
                table76.AddRow(new string[] {
                            "LetYourCottages_LYPTestPositionofCalculatorLYP182"});
                table76.AddRow(new string[] {
                            "LetYourCottages_LYPDirectBookHolidayTraffictoConsumerLYP203"});
#line 44
 testRunner.Then("I search for the experient and store the status", ((string)(null)), table76, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get experiments infomation from Holmes")]
        [NUnit.Framework.CategoryAttribute("HolmesExperiments")]
        public void GetExperimentsInfomationFromHolmes()
        {
            string[] tagsOfScenario = new string[] {
                    "HolmesExperiments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get experiments infomation from Holmes", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 64
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 65
 testRunner.Given("I am on the following webpage: http://holmes.prod.sykes.cloud/experiments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 66
 testRunner.When("I return the experiment details 4557,3960,4045,4717,4765,4774,4758,4708,4730,4790" +
                        ",4733,4762,4457,4648", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
