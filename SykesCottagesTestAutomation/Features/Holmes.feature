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
		| 4586    |
		| 4595    |
		| 4598    |
		| 4602    |
		| 4605    |
		| 4615    |
		| 4623    |
		| 4645    |
		| 4639    |
		| 4638    |
		| 4640    |
		| 4642    |
		| 4641    |
		| 4643    |
		| 4644    |

@HolmesExperiments
Scenario: Get experiment status
	Given I am on the following webpage: https://holmes.prod.sykes.cloud/experiments
	Then I search for the experient and store the status
		| Example                                                                   |
		| LetYourCottages_Livechatfalsedoorlyp11                                    |
		| LetYourCottages_OwnerIncentivePromotion4                                  |
		| LetYourCottages_FormSmallPrintChange27                                    |
		| LetYourCottages_EarningCalculatoronInformationPages19170                  |
		| LetYourCottages_CookiePrivacyPolicyLinksinFooterLYP34                     |
		| LetYourCottages_InactivityModalInfoPages23                                |
		| LetYourCottages_HeroFormTitleChange24                                     |
		| LetYourCottages_OwnerIncentiveRetest33                                    |
		| LetYourCottages_ImagesbeforecontentLYP32                                  |
		| LetYourCottages_GetstartedsectioninsteadofbrochuredownloadLYP31           |
		| LetYourCottages_BespokeheroimagesoninformationpagesinvestmentLYP29        |
		| LetYourCottages_BespokeheroimagesoninformationpagesbuysellLYP29           |
		| LetYourCottages_BespokeheroimagesoninformationpagesmarketingLYP29         |
		| LetYourCottages_BespokeheroimagesoninformationpagesregulationsLYP29       |
		| LetYourCottages_BespokeheroimagesoninformationpagesmortgagesLYP29         |
		| LetYourCottages_BespokeheroimagesoninformationpagesrunyourholidayletLYP29 |
		| LetYourCottages_BespokeheroimagesoninformationpagestaxLYP29               |
