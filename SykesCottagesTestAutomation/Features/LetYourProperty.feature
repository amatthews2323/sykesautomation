Feature: LetYourProperty
	Let Your Property page content and functionality

@LetYourProperty
Scenario: The user can navigate to the Let Your Property page
	Given I am on the Sykes Homepage
	When I click the Let Your Property link
	Then the following page title is displayed: Holiday Letting Agents For Cottages, Holiday Homes & Property

@LetYourProperty
Scenario: The enquiry form is displayed on the Let Your Property page
	Given I have navigated to the letyourcottage page
	Then the enquiry form is displayed

@LetYourProperty
Scenario: The relevant sections are displayed on the Let Your Property page
	Given I have navigated to the letyourcottage page
	Then the following sections are dislpayed
	| Section                            |
	| Gain exposure through our partners |
	| What do our owners say             |
	| How much could I earn              |
	| Holiday letting made easy          |
	| Are you thinking of buying         |
	| Request your free                  |

@OwnerCreation
Scenario: The user can submit the enquiry form
	Given I have navigated to the letyourcottage page
	When I enter my details on the enquiry form
	| Key           | Value                         |
	| Full name     | Test Owner                    |
	| Email address | sykescottagestest@example.org |
	| Phone number  | 07000000000                   |
	And I click the submit button
	Then I am directed to the Property Letting Dashboard page

@OwnerCreation
Scenario: The relevant sections are displayed on the Property Letting Dashboard
	Given I have submitted an enquiry with the following details
	| Key           | Value                         |
	| Full name     | Test Owner                    |
	| Email address | sykescottagestest@example.org |
	| Phone number  | 07000000000                   |
	Then the following elements are dislpayed on the page
	| Element                |
	| Phone Call             |
	| Continue Online        |
	| Pack Download          |
	| Holiday Homes for Sale |

@OwnerCreation
Scenario: The user can complete the digital onboarding process
	Given I have submitted an enquiry with the following details
	| Key           | Value                         |
	| Full name     | Test Owner                    |
	| Email address | sykescottagestest@example.org |
	| Phone number  | 07000000000                   |
	When I click the Continue Online button
	Then I can complete the digital online process using the following details
	| Key                | Value   |
	| Postcode           | LA231LJ |
	| Number of bedrooms | 2       |
	| Number of guests   | 4       |
	And the following page title is displayed: Thank you for your enquiry | Sykes Cottages