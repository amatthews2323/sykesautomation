Feature: LandingPages
	Landing pages content and functionality

@LandingPages @SmokeTest
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

@LandingPages @RegressionSuite @EnquiryForm
Scenario: The enquiry form is displayed on the Landing pages
	Given I have navigated to the following page: <Path>
	Then the following elements are dislpayed
	| Element                                                                                           |
	| form-heading-container                                                                            |
	| Complete the form to receive your information pack                                                |
	| heroform_first_name                                                                               |
	| heroform_first_name_validation_error                                                              |
	| heroform_email                                                                                    |
	| heroform_email_validation_error                                                                   |
	| heroform_phone                                                                                    |
	| heroform_phone_validation_error                                                                   |
	| Your details will be stored and used to send you information about our property letting services. |
	| /terms/privacypolicy                                                                              |
	| submit                                                                                            |
	When I click form-heading-container
	And I click heroform_first_name
	And I click form-heading-container
	Then the following text is displayed: Please enter a full name.
	When I click heroform_email
	And I click form-heading-container
	Then the following text is displayed: Please enter an email address.
	When I click heroform_phone
	And I click form-heading-container
	Then the following text is displayed: Please enter a contact number.
	When I enter test.com in the following form field: heroform_email
	And I click form-heading-container
	Then the following text is displayed: 'test.com' is missing an '@'. Please include an '@' in the email address.
	When I enter test@test in the following form field: heroform_email
	And I click form-heading-container
	Then the following text is displayed: 'test@test' is an incomplete email address. Please include e.g. '.com', '.co.uk', '.net'.
	When I enter test in the following form field: heroform_phone
	And I click form-heading-container
	Then the following text is displayed: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	When I enter 070000000 in the following form field: heroform_phone
	And I click form-heading-container
	Then the following text is displayed: Please provide a contact number that is no less than 10 digits long.
	When I enter 0700000000000000 in the following form field: heroform_phone
	And I click form-heading-container
	Then the following text is displayed: Please provide a contact number that is no more than 15 digits long.
	When I enter +44 7000 000 000 in the following form field: heroform_phone
	And I click form-heading-container
	Then the following element is not displayed: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	Then the following element is not displayed: Already started?
	Examples:
	| Path                                                   |
	| letyourcottage/information/run-holiday-let-as-business |
	| letyourcottage/information/leading-holiday-let-agency  |
	| letyourcottage/information/holiday-management-services |