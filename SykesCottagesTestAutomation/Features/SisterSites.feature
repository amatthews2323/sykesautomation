Feature: SisterSites
	Sister sites content and functionality

@SisterBrands @LYPRegressionSuite
Scenario: The Sykes sister brands are displayed correctly
	Given I have navigated to the following brand: <Brand>
	Then the relevant elements are dislpayed
	| Element                                                                                                   |
	| <Brand>                                                                                                   |
	| form-heading-container                                                                                    |
	| Complete the form to receive your information pack                                                        |
	| heroform_first_name                                                                                       |
	| heroform_first_name_validation_error                                                                      |
	| heroform_email                                                                                            |
	| heroform_email_validation_error                                                                           |
	| heroform_phone                                                                                            |
	| heroform_phone_validation_error                                                                           |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| You can opt out or unsubscribe at any time by contacting us or using an unsubscribe link.                 |
	| /terms/privacypolicy                                                                                      |
	| Get started                                                                                               |
	When I click form-heading-container
	And I click heroform_first_name
	And I click form-heading-container
	Then the following text is displayed: Please enter a full name
	When I click heroform_email
	And I click form-heading-container
	Then the following text is displayed: Please enter an email address
	When I click heroform_phone
	And I click form-heading-container
	Then the following text is displayed: Please enter a contact number
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
	Examples:
	| Brand                      |
	| Carbis Bay                 |
	| Character Cottages         |
	| Coast & Country Cottages   |
	| Cornish Cottage Holidays   |
	| Dream Cottages             |
	| Heart of the Lakes         |
	| Helpful Holidays           |
	| Hogans Irish Cottages      |
	| John Bray Cornish Holidays |
	| Lake District              |
	| Lakes Cottage Holidays     |
	| Lakelovers                 |
	| Large Holiday Houses       |
	| Lyme Bay Holidays          |
	| Manor Cottages             |
	| Menai Holiday Cottages     |
	| Welsh Cottage Holidays     |
	| Yorkshire Coastal          |

@SisterBrands @FormSubmission
Scenario: The Sister Brand hero form can be submitted
	Given I have navigated to the following brand: <Brand>
	When I enter Test Owner in the following form field: heroform_first_name
	And I enter test@test.com in the following form field: heroform_email
	And I enter 07000000000 in the following form field: heroform_phone
	And I click form-heading-container
	And I select Get Started
	Then the following page title is displayed: Thank you for your enquiry | Sykes Cottages
	Examples:
	| Brand                      |
	| Carbis Bay                 |
	| Character Cottages         |
	| Coast & Country Cottages   |
	| Cornish Cottage Holidays   |
	| Dream Cottages             |
	| Heart of the Lakes         |
	| Helpful Holidays           |
	| Hogans Irish Cottages      |
	| John Bray Cornish Holidays |
	| Lake District              |
	| Lakes Cottage Holidays     |
	| Lakelovers                 |
	| Large Holiday Houses       |
	| Lyme Bay Holidays          |
	| Manor Cottages             |
	| Menai Holiday Cottages     |
	| Welsh Cottage Holidays     |
	| Yorkshire Coastal          |