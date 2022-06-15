Feature: Holmes
	Holmes experiment tests.

@HolmesExperiments
Scenario: Get all active experiments from Holmes
	Given I am on the following webpage: http://holmes.staging.sykes.cloud/experiments
	Then I store the experiment IDs

@HolmesExperiments
Scenario: Get all active experiments in a given session
	Given I have navigated to the following page: letyourcottage
	When I store the active experiment IDs
	Given I am on the following webpage: http://holmes.prod.sykes.cloud/experiments
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
	Given I am on the following webpage: https://holmes.prod.sykes.cloud/experiments
	Then I navigate to the Holmes statistics page and store the conversion percentage
		| Example |
		| 4396    |
		| 4516    |
		| 4567    |
		| 4585    |
		| 4586    |
		| 4595    |
		| 4598    |
		| 4602    |
		| 4605    |
		| 4615    |

@HolmesExperiments
Scenario: Get experiment status
	Given I am on the following webpage: https://holmes.prod.sykes.cloud/experiments
	Then I search for the experient and store the status
		| Example                                                              |
		| LetYourCottages_ReplaceIconsWithimages18585                          |
		| LetYourCottages_ReTestBedrockPromo19009                              |
		| LetYourCottages_AddLYPfloatingactionbuttontoallinformationpages19102 |
		| LetYourCottages_RemoveDirectMailSmsFromForm19051                     |
		| LetYourCottages_Livechatfalsedoorlyp11                               |
		| LetYourCottages_FormSmallPrintChange27                               |
		| LetYourCottages_EarningCalculatoronInformationPages19170             |
		| LetYourCottages_CookiePrivacyPolicyLinksinFooterLYP34                |
		| LetYourCottages_InactivityModalInfoPages23                           |
		| LetYourCottages_HeroFormTitleChange24                                |