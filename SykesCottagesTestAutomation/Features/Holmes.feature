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
Scenario: Get experiments conversion precentage 
	Given I am accessing http://holmes.staging.sykes.cloud/experiments
	Then I navigate to the Holmes statistics page and store the conversion percentage
		| Example |
		| 4355    |
		| 4368    |
		| 4373    |
		| 4378    |
		| 4379    |
		| 4387    |
		| 4396    |
		| 4407    |
		| 4406    |
		| 4411    |
		| 4419    |
		| 4420    |
		| 4430    |
		| 4438    |
		| 4437    |
		| 4442    |
		| 4443    |
		| 4446    |
		| 4450    |
		| 4454    |
		| 4453    |
		| 4458    |
		| 4421    |
		| 4463    |
		| 4466    |
		| 4431    |
		| 4469    |
		| 4472    |
		| 4470    |

@HolmesExperiments
Scenario: Get experiments status
	Given I am accessing http://holmes.staging.sykes.cloud/experiments
	Then I search for the experient and store the status
		| Example                                                          |
		| LetYourCottages_RemoveAlertMessagesonLYP18458                    |
		| LetYourCottages_ContrastAlertsOnLYP18473                         |
		| LetYourCottages_RemoveSecondHeroCopy18494                        |
		| LetYourCottages_LoopingImageOnHero18461                          |
		| LetYourCottages_ManagedServicesBannerOnLYP18552                  |
		| LetYourCottages_RemoveAlreadyStartedLogin18580                   |
		| LetYourCottages_ReplaceIconsWithimages18585                      |
		| LetYourCottages_InactivityExitModal18457                         |
		| LetYourCottages_TestimonialsCarousel18584                        |
		| LetYourCottages_SectionImageNavigation18583                      |
		| LetYourCottages_MakeIconsInteractive18586                        |
		| LetYourCottages_CollapseSectionsOnLypPage18587                   |
		| LetYourCottages_ChangeLegacyFavicon18431                         |
		| LetYourCottages_BurguerMenuTablet18658                           |
		| LetYourCottages_QAOwnerCaseStudies18625                          |
		| LetYourCottages_DashboardButtonInteraction18675                  |
		| LetYourCottages_PartnersIntoHero18491                            |
		| LetYourCottages_VisualTimeronAlerts18791                         |
		| LetYourCottages_HeroImagesBasedOnHeadingForLoop18704             |
		| LetYourCottages_TriggerVisitRequest18459                         |
		| LetYourCottages_InformationCentreLyc18455                        |
		| LetYourCottages_AddTrustpilotontotheInformationPages18486        |
		| LetYourCottages_LYPPhoneNumberSection18569                       |
		| LetYourCottages_EnquiryFormAtFooter18813                         |
		| LetYourCottages_LoopingHeroOnDashboardWithMeaningFullImages18671 |
		| LetYourCottages_ToolTipsonLYPHeaders18582                        |
		| LetYourCottages_ProgressBarUpdatetoWhite18869                    |
		| LetYourCottages_UpdatepartnersSectionforMobile18816              |
		| LetYourCottages_ClearOptionOnDashboard18697                      |