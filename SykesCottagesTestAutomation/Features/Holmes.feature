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
		| 4368    |
		| 4373    |
		| 4379    |
		| 4396    |
		| 4406    |
		| 4407    |
		| 4411    |
		| 4430    |
		| 4442    |
		| 4446    |
		| 4450    |
		| 4466    |
		| 4431    |
		| 4470    |
		| 4477    |
		| 4476    |
		| 4475    |
		| 4493    |

@HolmesExperiments
Scenario: Get experiments status
	Given I am accessing https://holmes.prod.sykes.cloud/experiments
	Then I search for the experient and store the status
		| Example                                                          |
		| LetYourCottages_ContrastAlertsOnLYP18473                         |
		| LetYourCottages_RemoveSecondHeroCopy18494                        |
		| LetYourCottages_ManagedServicesBannerOnLYP18552                  |
		| LetYourCottages_ReplaceIconsWithimages18585                      |
		| LetYourCottages_TestimonialsCarousel18584                        |
		| LetYourCottages_InactivityExitModal18457                         |
		| LetYourCottages_SectionImageNavigation18583                      |
		| LetYourCottages_ChangeLegacyFavicon18431                         |
		| LetYourCottages_DashboardButtonInteraction18675                  |
		| LetYourCottages_VisualTimeronAlerts18791                         |
		| LetYourCottages_HeroImagesBasedOnHeadingForLoop18704             |
		| LetYourCottages_LoopingHeroOnDashboardWithMeaningFullImages18671 |
		| LetYourCottages_ToolTipsonLYPHeaders18582                        |
		| LetYourCottages_ClearOptionOnDashboard18697                      |
		| LetYourCottages_DashboardInfoCarousel18696                       |
		| LetYourCottages_HeroOnMobile18815                                |
		| LetYourCottages_MobileFriendlyHolidayLetting18846                |
		| LetYourCottages_RevisitManagedServicesBanner18906                |