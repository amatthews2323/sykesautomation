Feature: PCToolKit
	PCToolkit content and functionality

@PCToolkit
Scenario: The user can log in to the PC Toolkit
Given I am on the following webpage: https://sykes:1.sykes@pctoolkit.staging.sykes.network/login
When I click Log in
And I log in with the following credentials
	| Key      | Value |
	| Username | gary.smith@sykescottages.co.uk |
	| Password | DesertSea40 |
And I wait 10 seconds
Then the relevant elements are dislpayed
	| Element       |
	| Diary         |
	| Past visits   |
	| Future visits |
	| sign-out      |