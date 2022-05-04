Feature: LandingPages
	Landing pages content and functionality

@LandingPages @RegressionSmokeTest
Scenario: The Landing pages are displayed correctly
	Given I have navigated to the following page: <Path>
	Then the following elements are dislpayed
	| Element                                   |
	| <Title>                                   |
	| form-heading-container                    |
	| Reading time                              |
	| Download your free owner information pack |
	Examples:
	| Path                                                                | Title                                                                     |
	| letyourcottage/information/run-holiday-let-as-business              | How to Run a Holiday Let as a Business                                    |
	| letyourcottage/information/leading-holiday-let-agency               | Why You Should Let Your Property With The Leading Holiday Lettings Agency |
	| letyourcottage/information/holiday-management-services              | How Sykes Can Manage Your Holiday Home                                    |

@LandingPages @ProductionRegressionSuite
Scenario: The enquiry form is displayed on the Landing pages
	Given I have navigated to the following page: <Path>
	Then the following elements are dislpayed
	| Element                                                                                                                                                        |
	| form-heading-container                                                                                                                                         |
	| Complete the form to receive your information pack                                                                                                             |
	| heroform_first_name                                                                                                                                            |
	| heroform_first_name_validation_error                                                                                                                           |
	| heroform_email                                                                                                                                                 |
	| heroform_email_validation_error                                                                                                                                |
	| heroform_phone                                                                                                                                                 |
	| heroform_phone_validation_error                                                                                                                                |
	| marketing_email                                                                                                                                                |
	| marketing_phone                                                                                                                                                |
	| marketing_sms                                                                                                                                                  |
	| marketing_post                                                                                                                                                 |
	| Your details will be stored and used to send you information about our property letting services. You can opt out or unsubscribe at any time by contacting us. |
	| /terms/privacypolicy                                                                                                                                           |
	| submit                                                                                                                                                         |
	When I click form-heading-container
	And I click heroform_first_name
	And I click form-heading-container
	Then the following elements are dislpayed
	| Element                        |
	| Please enter a full name.      |
	| Please enter an email address. |
	| Please enter a contact number. |
	When I enter an email address without an @ symbol
	And I click form-heading-container
	Then the following text is displayed: 'test.com' is missing an '@'. Please include an '@' in the email address.
	When I enter an email address without a valid domain
	And I click form-heading-container
	Then the following text is displayed: 'test@test' is an incomplete email address. Please include e.g. '.com', '.co.uk', '.net'.
	When I enter a phone number with a non-numerical character
	And I click form-heading-container
	Then the following text is displayed: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	When I enter a phone number with less than 10 digits
	And I click form-heading-container
	Then the following text is displayed: Please provide a contact number that is no less than 10 digits long.
	When I enter a phone number with more than 15 digits
	And I click form-heading-container
	Then the following text is displayed: Please provide a contact number that is no more than 15 digits long.
	When I enter a phone number with spaces and +44
	And I click form-heading-container
	Then the following element is not displayed: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	Examples:
	| Path                                                   |
	| letyourcottage/information/run-holiday-let-as-business |
	| letyourcottage/information/leading-holiday-let-agency  |
	| letyourcottage/information/holiday-management-services |