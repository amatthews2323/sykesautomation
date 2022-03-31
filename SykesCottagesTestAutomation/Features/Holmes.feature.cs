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
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Holmes.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Holmes", "\tHolmes experiment tests.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Get all active experiments from Holmes")]
        [NUnit.Framework.CategoryAttribute("HolmesExperiments")]
        public virtual void GetAllActiveExperimentsFromHolmes()
        {
            string[] tagsOfScenario = new string[] {
                    "HolmesExperiments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all active experiments from Holmes", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
        public virtual void GetAllActiveExperimentsInAGivenSession()
        {
            string[] tagsOfScenario = new string[] {
                    "HolmesExperiments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all active experiments in a given session", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 10
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
        public virtual void CheckSpecificExperimentsAreApplied()
        {
            string[] tagsOfScenario = new string[] {
                    "HolmesExperiments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check specific experiments are applied", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 17
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
#line 18
 testRunner.Given("I have navigated to the following page: letyourcottage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 19
 testRunner.When("I store the active experiment IDs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                            "Example"});
                table38.AddRow(new string[] {
                            "4419"});
                table38.AddRow(new string[] {
                            "4396"});
#line 20
 testRunner.Then("the following experiements are enabled", ((string)(null)), table38, "Then ");
#line hidden
#line 24
 testRunner.And("I wait 300 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get experiments conversion precentage")]
        [NUnit.Framework.CategoryAttribute("HolmesExperiments")]
        public virtual void GetExperimentsConversionPrecentage()
        {
            string[] tagsOfScenario = new string[] {
                    "HolmesExperiments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get experiments conversion precentage", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 27
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
#line 28
 testRunner.Given("I am accessing http://holmes.staging.sykes.cloud/experiments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                            "Example"});
                table39.AddRow(new string[] {
                            "4368"});
                table39.AddRow(new string[] {
                            "4373"});
                table39.AddRow(new string[] {
                            "4379"});
                table39.AddRow(new string[] {
                            "4387"});
                table39.AddRow(new string[] {
                            "4396"});
                table39.AddRow(new string[] {
                            "4406"});
                table39.AddRow(new string[] {
                            "4407"});
                table39.AddRow(new string[] {
                            "4411"});
                table39.AddRow(new string[] {
                            "4419"});
                table39.AddRow(new string[] {
                            "4420"});
                table39.AddRow(new string[] {
                            "4430"});
                table39.AddRow(new string[] {
                            "4437"});
                table39.AddRow(new string[] {
                            "4441"});
                table39.AddRow(new string[] {
                            "4438"});
                table39.AddRow(new string[] {
                            "4442"});
                table39.AddRow(new string[] {
                            "4446"});
                table39.AddRow(new string[] {
                            "4450"});
                table39.AddRow(new string[] {
                            "4454"});
                table39.AddRow(new string[] {
                            "4453"});
                table39.AddRow(new string[] {
                            "4458"});
                table39.AddRow(new string[] {
                            "4463"});
                table39.AddRow(new string[] {
                            "4466"});
                table39.AddRow(new string[] {
                            "4431"});
                table39.AddRow(new string[] {
                            "4470"});
                table39.AddRow(new string[] {
                            "4474"});
                table39.AddRow(new string[] {
                            "4477"});
                table39.AddRow(new string[] {
                            "4476"});
                table39.AddRow(new string[] {
                            "4475"});
                table39.AddRow(new string[] {
                            "4479"});
                table39.AddRow(new string[] {
                            "4480"});
                table39.AddRow(new string[] {
                            "4483"});
                table39.AddRow(new string[] {
                            "4482"});
#line 29
 testRunner.Then("I navigate to the Holmes statistics page and store the conversion percentage", ((string)(null)), table39, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get experiments status")]
        [NUnit.Framework.CategoryAttribute("HolmesExperiments")]
        public virtual void GetExperimentsStatus()
        {
            string[] tagsOfScenario = new string[] {
                    "HolmesExperiments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get experiments status", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 65
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
#line 66
 testRunner.Given("I am accessing http://holmes.staging.sykes.cloud/experiments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                            "Example"});
                table40.AddRow(new string[] {
                            "LetYourCottages_ContrastAlertsOnLYP18473"});
                table40.AddRow(new string[] {
                            "LetYourCottages_RemoveSecondHeroCopy18494"});
                table40.AddRow(new string[] {
                            "LetYourCottages_ManagedServicesBannerOnLYP18552"});
                table40.AddRow(new string[] {
                            "LetYourCottages_RemoveAlreadyStartedLogin18580"});
                table40.AddRow(new string[] {
                            "LetYourCottages_ReplaceIconsWithimages18585"});
                table40.AddRow(new string[] {
                            "LetYourCottages_TestimonialsCarousel18584"});
                table40.AddRow(new string[] {
                            "LetYourCottages_InactivityExitModal18457"});
                table40.AddRow(new string[] {
                            "LetYourCottages_SectionImageNavigation18583"});
                table40.AddRow(new string[] {
                            "LetYourCottages_MakeIconsInteractive18586"});
                table40.AddRow(new string[] {
                            "LetYourCottages_CollapseSectionsOnLypPage18587"});
                table40.AddRow(new string[] {
                            "LetYourCottages_ChangeLegacyFavicon18431"});
                table40.AddRow(new string[] {
                            "LetYourCottages_QAOwnerCaseStudies18625"});
                table40.AddRow(new string[] {
                            "LetYourCottages_AddDownArrowInHero18579"});
                table40.AddRow(new string[] {
                            "LetYourCottages_BurguerMenuTablet18658"});
                table40.AddRow(new string[] {
                            "LetYourCottages_DashboardButtonInteraction18675"});
                table40.AddRow(new string[] {
                            "LetYourCottages_VisualTimeronAlerts18791"});
                table40.AddRow(new string[] {
                            "LetYourCottages_HeroImagesBasedOnHeadingForLoop18704"});
                table40.AddRow(new string[] {
                            "LetYourCottages_TriggerVisitRequest18459"});
                table40.AddRow(new string[] {
                            "LetYourCottages_InformationCentreLyc18455"});
                table40.AddRow(new string[] {
                            "LetYourCottages_AddTrustpilotontotheInformationPages18486"});
                table40.AddRow(new string[] {
                            "LetYourCottages_EnquiryFormAtFooter18813"});
                table40.AddRow(new string[] {
                            "LetYourCottages_LoopingHeroOnDashboardWithMeaningFullImages18671"});
                table40.AddRow(new string[] {
                            "LetYourCottages_ToolTipsonLYPHeaders18582"});
                table40.AddRow(new string[] {
                            "LetYourCottages_ClearOptionOnDashboard18697"});
                table40.AddRow(new string[] {
                            "LetYourCottages_IntroducingSisterBrands18705"});
                table40.AddRow(new string[] {
                            "LetYourCottages_DashboardInfoCarousel18696"});
                table40.AddRow(new string[] {
                            "LetYourCottages_HeroOnMobile18815"});
                table40.AddRow(new string[] {
                            "LetYourCottages_MobileFriendlyHolidayLetting18846"});
                table40.AddRow(new string[] {
                            "LetYourCottages_StickyFooter18680"});
                table40.AddRow(new string[] {
                            "LetYourCottages_MobileAppFooter18700"});
                table40.AddRow(new string[] {
                            "LetYourCottages_ProductShowCasePromotion18893"});
                table40.AddRow(new string[] {
                            "LetYourCottages_ProductShowCasePromotionLinkFooter18893"});
                table40.AddRow(new string[] {
                            "LetYourCottages_Sharepage18683"});
#line 67
 testRunner.Then("I search for the experient and store the status", ((string)(null)), table40, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
