﻿Feature: PCToolKit
	PCToolkit content and functionality

@PCToolkit
Scenario: The user can log in to the PC Toolkit
Given I am on the following webpage: https://pctoolkit.staging.sykes.network/login
When I click Log in
And I log in with the following credentials
	| Key      | Value              |
	| Username | name.name@test.com |
	| Password | testing123         |
Then the relevant elements are dislpayed
	| Element          |
	| Diary            |
	| Previous visits  |
	| Upcoming visits  |
	| task-card-header |