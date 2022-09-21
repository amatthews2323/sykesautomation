﻿Feature: Holmes
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
		| 4645    |
		| 4648    |
		| 4658    |
		| 4683    |
		| 4257    |
		| 4560    |
		| 4736    |
		| 4739    |
		| 4744    |

@HolmesExperiments
Scenario: Get experiment status
	Given I am on the following webpage: https://holmes.prod.sykes.cloud/experiments
	Then I search for the experient and store the status
	| Example                                                           |
	| LetYourCottages_GetstartedsectioninsteadofbrochuredownloadLYP31   |
	| LetYourCottages_InformationPageSearchMvpLyp12                     |
	| LetYourCottages_InfopagecontentcollapsedsectionsLYP30             |
	| LetYourCottages_PossibleInsurancePolicyimplementationLYP82        |
	| LetYourCottages_MakeLYPNumberClickableOnMobileHomepage19693       |
	| LetYourCottages_HomepageOwnerStoriesSectionLYP123                 |
	| LetYourCottages_RequestACallForm55                                |
	| LetYourCottages_AddContactUsToHomeScreenWhenCallCentreClosed19700 |
	| LetYourCottages_AddIconAndChangeColourOfPhoneNumber19694          |
	| LetYourCottages_SpeakToSomeoneSectionAllPlatforms19766            |
	| LetYourCottages_BedrockMortgageLetterSectiononHomepageLYP37       |
	| LetYourCottages_CaptureIfPnoHasAProperty19842                     |
	| LetYourCottages_TestRequestaCallForminHeroLYP166                  |
	| LetYourCottages_DownloadPackSection144                            |
	| LetYourCottages_AddRemoteValidationToTheEnquiryForm19834          |
	| LetYourCottages_ImprovehomepagesectionsfortabletLYP81             |

@HolmesExperiments
Scenario: Get experiments infomation from Holmes
	Given I am on the following webpage: http://holmes.prod.sykes.cloud/experiments
	When I return the experiment details 4557,3960,4045,4717,4765,4774,4758,4708,4730,4790,4733,4762,4457,4648