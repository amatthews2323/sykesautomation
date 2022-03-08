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
		| 4332    |
		| 4347    |
		| 4355    |
		| 4362    |
		| 4368    |
		| 4373    |
		| 4374    |
		| 4352    |
		| 4379    |
		| 4378    |
		| 4383    |
		| 4387    |
		| 4391    |
		| 4396    |
		| 4398    |
		| 4404    |
		| 4406    |
		| 4407    |
		| 4411    |
		| 4412    |
		| 4419    |
		| 4420    |