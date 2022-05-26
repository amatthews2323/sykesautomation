Feature: Holmes
	Holmes experiment tests.

@HolmesExperiments
Scenario: Get all active experiments from Holmes
	Given I am accessing http://holmes.staging.sykes.cloud/experiments
	Then I store the experiment IDs

@HolmesExperiments
Scenario: Get all active experiments in a given session
	Given I have navigated to the following page: letyourcottage
	When I store the active experiment IDs
	Given I am accessing http://holmes.prod.sykes.cloud/experiments
	When I search for the experiment details

@HolmesExperiments
Scenario: Check specific experiments are applied
	Given I have navigated to the following page: letyourcottage
	When I store the active experiment IDs
	Then the following experiements are enabled
		| Example |
		| 4419    |
		| 4396    |
	And I wait 300 seconds

@HolmesExperiments
Scenario: Get experiment conversion precentage 
	Given I am accessing https://holmes.prod.sykes.cloud/experiments
	Then I navigate to the Holmes statistics page and store the conversion percentage
		| Example |
		| 4396    |
		| 4407    |
		| 4442    |
		| 4466    |
		| 4431    |
		| 4470    |
		| 4498    |
		| 4509    |
		| 4516    |
		| 4536    |
		| 4544    |
		| 4560    |
		| 4561    |
		| 4567    |
		| 4572    |

@HolmesExperiments
Scenario: Get experiment status
	Given I am accessing https://holmes.prod.sykes.cloud/experiments
	Then I search for the experient and store the status
		| Example                                                              |
		| LetYourCottages_ReplaceIconsWithimages18585                          |
		| LetYourCottages_InactivityExitModal18457                             |
		| LetYourCottages_DashboardButtonInteraction18675                      |
		| LetYourCottages_LoopingHeroOnDashboardWithMeaningFullImages18671     |
		| LetYourCottages_ToolTipsonLYPHeaders18582                            |
		| LetYourCottages_ClearOptionOnDashboard18697                          |
		| LetYourCottages_BuySellRedesign18920                                 |
		| LetYourCottages_SpeakToSomeoneSectionMobile18682                     |
		| LetYourCottages_ReTestBedrockPromo19009                              |
		| LetYourCottages_InformationCentreCarousel19036                       |
		| LetYourCottages_PartnersInteractiveCarrousel18699                    |
		| LetYourCottages_AddImageToInfoPages19099                             |
		| LetYourCottages_UpdateInfoPageHeaders19095                           |
		| LetYourCottages_AddLYPfloatingactionbuttontoallinformationpages19102 |
		| LetYourCottages_HeroFormTitleChanges19172                            |