﻿Feature: LetYourProperty
	Let Your Property page content and functionality

@LetYourProperty
Scenario: The user can navigate to the Let Your Property page
	Given I am on the Sykes Homepage
	When I click the Let your property button
	Then the Let Your Property page is diplayed

@LetYourProperty
Scenario: The Let Your Property page loads
	Given I have navigated to the Let Your Property page
	Then the Let Your Property page is diplayed

@LetYourProperty
Scenario: The enquiry form is displayed
	Given I have navigated to the Let Your Property page
	Then the enquiry form is displayed

@LetYourProperty
Scenario: The user can submit their details
	Given I have navigated to the Let Your Property page
	When I enter my details on the enquiry form
	| Key           | Value                         |
	| Full name     | Test Owner                    |
	| Email address | sykescottagestest@example.org |
	| Phone number  | 07000000000                   |
	And I click the Get Started button
	Then I am directed to the Property Letting Dashboard page