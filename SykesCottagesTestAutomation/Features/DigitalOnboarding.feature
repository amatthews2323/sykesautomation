Feature: DigitalOnboarding
	Owner and Property creation via Digital Onbording
	NOT TO BE RUN AGAINST PRODUCTION

@DigitalOnboarding
Scenario: The user can submit the enquiry form
	Given I have navigated to the following page: letyourcottage
	When I enter the following details on the enquiry form
	| Key           | Value                         |
	| Full name     | Test Owner                    |
	| Email address | sykescottagestest@example.org |
	| Phone number  | 07000000000                   |
	And I submit the enquiry form
	Then I am directed to the Property Letting Dashboard page

@DigitalOnboarding
Scenario: The relevant sections are displayed on the Property Letting Dashboard
	Given I have navigated to the following page: letyourcottage
	When I enter the following details on the enquiry form
	| Key           | Value                         |
	| Full name     | Test Owner                    |
	| Email address | sykescottagestest@example.org |
	| Phone number  | 07000000000                   |
	And I submit the enquiry form
	Then the following elements are dislpayed on the page
	| Element                |
	| Phone Call             |
	| Continue Online        |
	| Pack Download          |
	| Holiday Homes for Sale |

@DigitalOnboarding
Scenario: The user can add a property via the digital onboarding process
	Given I have navigated to the following page: letyourcottage
	When I enter the following details on the enquiry form
	| Key           | Value       |
	| Full name     | Test Owner  |
	| Email address | Random      |
	| Phone number  | 07000000000 |
	And I submit the enquiry form
	When I click Get started online
	Then I can add a property with the following postcode: Random
	And the following page title is displayed: Thank you for your enquiry | Sykes Cottages

@DigitalOnboarding
Scenario: The user can add a property and complete the digital onboarding process
	Given I have navigated to the following page: letyourcottage
	When I enter the following details on the enquiry form
	| Key           | Value       |
	| Full name     | Test Owner  |
	| Email address | Random      |
	| Phone number  | 07000000000 |
	And I submit the enquiry form
	When I select Get Started Online
	Then I can add a property with the following postcode: Random
	And I can create an account using password: Testing123
	And I can register my account via the email
	And I can sign in to my account using the following details
	| Key      | Value      |
	| Username | Random     |
	| Password | Testing123 |
	And I can complete the digital onboarding process using the following deatils
	| Key                | Value  |
	| Number of bedrooms | 2      |
	| Number of guests   | 4      |

@MailCatcher
Scenario: I can click a link within mailcatcher
	Given I am accessing https://mailcatcher.staging.sykes.cloud/
	Then I verify my account

@DigitalOnboarding
Scenario: The user completes digital onboarding
	Given I am accessing https://tech.staging.sykescottages.co.uk/account/login
	Then I can sign in to my account using the following details
	| Key      | Value                       |
	| Username | sykestest169488@example.org |
	| Password | Testing123                  |
	And I can complete the digital onboarding process using the following deatils
	| Key                | Value  |
	| Number of bedrooms | 2      |
	| Number of guests   | 4      |