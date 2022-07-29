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
		| 4579    |
		| 4598    |
		| 4615    |
		| 4623    |
		| 4645    |
		| 4648    |
		| 4658    |
		| 4676    |
		| 4683    |
		| 4257    |
		| 4560    |

@HolmesExperiments
Scenario: Get experiment status
	Given I am on the following webpage: https://holmes.prod.sykes.cloud/experiments
	Then I search for the experient and store the status
		| Example                                                              |
		| LetYourCottages_ContentImprovementsonHowtorunholidayletinfopage19169 |
		| LetYourCottages_EarningCalculatoronInformationPages19170             |
		| LetYourCottages_HeroFormTitleChange24                                |
		| LetYourCottages_ImagesbeforecontentLYP32                             |
		| LetYourCottages_GetstartedsectioninsteadofbrochuredownloadLYP31      |
		| LetYourCottages_InformationPageSearchMvpLyp12                        |
		| LetYourCottages_InfopagecontentcollapsedsectionsLYP30                |
		| LetYourCottages_LYPConversionFormFieldOrderLYP53                     |
		| LetYourCottages_OptInRequestaCalltoPhoneLYP15                        |
		| LetYourCottages_RemoveWeAreStillOpen17921                            |
		| LetYourCottages_AddImageToInfoPages19099                             |

@HolmesExperiments
Scenario: Get experiments infomation from Holmes
	Given I am on the following webpage: http://holmes.prod.sykes.cloud/experiments
	When I return the experiment details 4612,4674,4693,4554,4619,4457,4257