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
 testRunner.Given("I am accessing http://holmes.staging.sykes.cloud/experiments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
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
 testRunner.Given("I am accessing http://holmes.prod.sykes.cloud/experiments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
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
                TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                            "Example"});
                table45.AddRow(new string[] {
                            "4419"});
                table45.AddRow(new string[] {
                            "4396"});
#line 20
 testRunner.Then("the following experiements are enabled", ((string)(null)), table45, "Then ");
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
 testRunner.Given("I am accessing https://holmes.prod.sykes.cloud/experiments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table46 = new TechTalk.SpecFlow.Table(new string[] {
                            "Example"});
                table46.AddRow(new string[] {
                            "4396"});
                table46.AddRow(new string[] {
                            "4407"});
                table46.AddRow(new string[] {
                            "4442"});
                table46.AddRow(new string[] {
                            "4466"});
                table46.AddRow(new string[] {
                            "4431"});
                table46.AddRow(new string[] {
                            "4470"});
                table46.AddRow(new string[] {
                            "4498"});
                table46.AddRow(new string[] {
                            "4509"});
                table46.AddRow(new string[] {
                            "4516"});
                table46.AddRow(new string[] {
                            "4536"});
                table46.AddRow(new string[] {
                            "4537"});
                table46.AddRow(new string[] {
                            "4544"});
                table46.AddRow(new string[] {
                            "4547"});
                table46.AddRow(new string[] {
                            "4560"});
                table46.AddRow(new string[] {
                            "4561"});
                table46.AddRow(new string[] {
                            "4567"});
                table46.AddRow(new string[] {
                            "4569"});
                table46.AddRow(new string[] {
                            "4572"});
#line 29
 testRunner.Then("I navigate to the Holmes statistics page and store the conversion percentage", ((string)(null)), table46, "Then ");
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
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 52
 testRunner.Given("I am accessing https://holmes.prod.sykes.cloud/experiments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table47 = new TechTalk.SpecFlow.Table(new string[] {
                            "Example"});
                table47.AddRow(new string[] {
                            "LetYourCottages_ReplaceIconsWithimages18585"});
                table47.AddRow(new string[] {
                            "LetYourCottages_InactivityExitModal18457"});
                table47.AddRow(new string[] {
                            "LetYourCottages_DashboardButtonInteraction18675"});
                table47.AddRow(new string[] {
                            "LetYourCottages_LoopingHeroOnDashboardWithMeaningFullImages18671"});
                table47.AddRow(new string[] {
                            "LetYourCottages_ToolTipsonLYPHeaders18582"});
                table47.AddRow(new string[] {
                            "LetYourCottages_ClearOptionOnDashboard18697"});
                table47.AddRow(new string[] {
                            "LetYourCottages_BuySellRedesign18920"});
                table47.AddRow(new string[] {
                            "LetYourCottages_SpeakToSomeoneSectionMobile18682"});
                table47.AddRow(new string[] {
                            "LetYourCottages_ReTestBedrockPromo19009"});
                table47.AddRow(new string[] {
                            "LetYourCottages_InformationCentreCarousel19036"});
                table47.AddRow(new string[] {
                            "LetYourCottages_ApplyNewDesignToInfoPages19055"});
                table47.AddRow(new string[] {
                            "LetYourCottages_PartnersInteractiveCarrousel18699"});
                table47.AddRow(new string[] {
                            "LetYourCottages_RedirectTobToDigitalOnboarding19109"});
                table47.AddRow(new string[] {
                            "LetYourCottages_AddImageToInfoPages19099"});
                table47.AddRow(new string[] {
                            "LetYourCottages_UpdateInfoPageHeaders19095"});
                table47.AddRow(new string[] {
                            "LetYourCottages_AddLYPfloatingactionbuttontoallinformationpages19102"});
                table47.AddRow(new string[] {
                            "LetYourCottages_InformationPageSidebarTruncation19171"});
                table47.AddRow(new string[] {
                            "LetYourCottages_HeroFormTitleChanges19172"});
#line 53
 testRunner.Then("I search for the experient and store the status", ((string)(null)), table47, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
