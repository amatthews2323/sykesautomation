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
	| Key           | Value                 |
	| Full name     | Test Owner            |
	| Email address | sykestest@example.org |
	| Phone number  | 07000000000           |
	And I submit the enquiry form
	Then the relevant elements are dislpayed
	| Element                |
	| Phone Call             |
	| Continue Online        |
	| Pack Download          |
	| Holiday Homes for Sale |

@DigitalOnboarding
Scenario: The user can add a property via the digital onboarding process
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_VersionCOfMarketingPrefs25
	And I enter the following details on the enquiry form
	| Key           | Value       |
	| Full name     | Test Owner  |
	| Email address | Random      |
	| Phone number  | 07000000000 |
	And I click enquiry-button lyc-cta u-full-width js-enquiry-form-button-25 lyc-cta--blue u-cursor-pointer
	And I click Complete enquiry
	And I click thankyoulycgetstartedonline
	Then I can add a property with the following postcode: Random
	And the following page title is displayed: Thank you for your enquiry | Sykes Cottages

@DigitalOnboarding
Scenario: The user can add a property and complete the digital onboarding process
	Given I have navigated to the following page: letyourcottage
	When I apply the following experiment: LetYourCottages_VersionCOfMarketingPrefs25
	And I enter the following details on the enquiry form
	| Key           | Value       |
	| Full name     | Test Owner  |
	| Email address | Random      |
	| Phone number  | 07000000000 |
	And I click enquiry-button lyc-cta u-full-width js-enquiry-form-button-25 lyc-cta--blue u-cursor-pointer
	And I click Complete enquiry
	And I click thankyoulycgetstartedonline
	Then I can add a property with the following postcode: Random
	And I can create an account using password: Testing123
	And I can register my account via the email
	And I can sign in to my account using the following details
	| Key      | Value      |
	| Username | Random     |
	| Password | Testing123 |
	And I can complete Additional Property Details Step 1 - Property Location
	And I can complete Additional Property Details Step 2 - Guests and bedrooms
	| Key                | Value  |
	| Number of bedrooms | 2      |
	| Number of guests   | 4      |
	And I can complete Additional Property Details Step 3 - Photos of your property
	And I can complete Additional Property Details Step 4 - About your property
	And I can complete Additional Property Details Step 5 - Key Collection
	And I can complete Additional Property Details Step 6 - Booking details
	And I can complete Additional Property Details Step 7 - Upcoming bookings
	And I can complete Personal Details Step 1 - Personal details
	And I can complete Personal Details Step 2 - Your bank details
	And I can complete Personal Details Step 3 - File uploads
	And I can complete Personal Details Step 4 - Select commission tier
	And I can complete Personal Details Step 5 - Property Pricing
	And I can sign the contract and complete digital onboarding
	And the following text is displayed: Welcome to the Sykes Family!

@DigitalOnboarding
Scenario: The user completes digital onboarding
	Given I am on the following webpage: https://tech.staging.sykescottages.co.uk/account/login
	Then I can sign in to my account using the following details
	| Key      | Value                       |
	| Username | sykestest855343@example.org |
	| Password | Testing123                  |
	And I can complete Personal Details Step 5 - Property Pricing
	And I can sign the contract and complete digital onboarding
	And the following text is displayed: Welcome to the Sykes Family!