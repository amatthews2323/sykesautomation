Feature: LetYourProperty
	Let Your Property page content and functionality

@LetYourProperty
Scenario: The user can navigate to the Let Your Property page
	Given I am on the Sykes Homepage
	When I click the Let Your Property link
	Then the following page title is displayed: Holiday Letting Agents For Cottages, Holiday Homes & Property

@LetYourProperty
Scenario: The enquiry form is displayed
	Given I have navigated to the letyourcottage page
	Then the enquiry form is displayed

@LetYourProperty
Scenario: The relevant page sections are displayed
	Given I have navigated to the letyourcottage page
	Then the following sections are dislpayed
	| Section                            |
	| Gain exposure through our partners |
	| What do our owners say             |
	| How much could I earn              |
	| Holiday letting made easy          |
	| Are you thinking of buying         |
	| Request your free                  |

@LetYourProperty
Scenario: The user can submit their details
	Given I have navigated to the letyourcottage page
	When I enter my details on the enquiry form
	| Key           | Value                         |
	| Full name     | Test Owner                    |
	| Email address | sykescottagestest@example.org |
	| Phone number  | 07000000000                   |
	And I click the Get Started button
	Then I am directed to the Property Letting Dashboard page