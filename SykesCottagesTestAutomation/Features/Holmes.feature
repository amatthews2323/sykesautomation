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
Scenario: Get conversion precentage for all started experiments
	Given I am accessing http://holmes.staging.sykes.cloud/experiments
	Then I navigate to the Holmes statistics page and store the conversion percentage
		| Example |
		| 4355    |
		| 4368    |
		| 4374    |
		| 4352    |
		| 4373    |
		| 4378    |
		| 4379    |
		| 4374    |
		| 4387    |
		| 4391    |
		| 4396    |
		| 4404    |
		| 4407    |
		| 4406    |
		| 4411    |
		| 4419    |
		| 4420    |
		| 4438    |
		| 4437    |
		| 4444    |
		| 4443    |
		| 4446    |
		| 4454    |
		| 4453    |