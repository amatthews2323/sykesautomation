Feature: SisterSites
	Sister sites content and functionality

@SisterBrands @LYPRegressionSuite
Scenario: The Sister Brands are displayed correctly
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
	| Brand                  |
	| Hogans Irish Cottages  |
	| Lakes Cottage Holidays |
	| Large Holiday Houses   |
	| Lyme Bay Holidays      |

@SisterBrands @LYPRegressionSuite
Scenario: The Sister Brands are displayed correctly part two
	Given I have navigated to the following brand: <Brand>
	Then the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                                   |
	| first_name                                                                                                |
	| last_name                                                                                                 |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| /terms/privacypolicy                                                                                      |
	When I click //*[@*='enquiry-multi-step']/button[@*='submit']
	Then the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                      |
	| Please enter your first name |
	| Please enter your surname    |	
	When I enter Test in the following form field: //*[@*='enquiry-multi-step']//input[@*='first_name']
	And I enter Owner in the following form field: //*[@*='enquiry-multi-step']//input[@*='last_name']
	And I click //*[@*='enquiry-multi-step']/button[@*='submit']
	Then the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                           |
	| In order to receive email communciations from our expert team, please provide your email address. |
	| Email address                                                                                     |
	When I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the following text is displayed: Please enter an email address
	When I enter test.com in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the following text is displayed: 'test.com' is missing an '@'. Please include an '@' in the email address.
	When I enter test@test in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the following text is displayed: 'test@test' is an incomplete email address. Please include e.g. '.com', '.co.uk', '.net'.
	When I enter test@test.com in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the relevant elements are dislpayed
	| Element                                                                                                                                     |
	| To allow our property experts to contact you by phone (including an initial call regarding your enquiry), please provide your phone number. |
	| Phone number                                                                                                                                |
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	Then the following text is displayed: Please enter a contact number
	When I enter 070000000 in the following form field: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	Then the following text is displayed: Please provide a contact number that is no less than 10 digits long.
	When I enter 0700000000000000 in the following form field: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	Then the following text is displayed: Please provide a contact number that is no more than 15 digits long.
	When I enter +44 7000 000 000 in the following form field: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	Then the relevant elements are dislpayed
	| Element                                                                                                   |
	| Please ensure the following details are correct                                                           |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| Submit enquiry                                                                                            |
	Examples:
	| Brand                      |
	| Carbis Bay                 |
	| Character Cottages		 |
	| Coast & Country Cottages   |
	| Coast & Country Holidays   |
	| Cornish Cottage Holidays   |
	| Dream Cottages             |
	| Heart of the Lakes         |
	| Helpful Holidays           |
	| John Bray Cornish Holidays |
	| Lake District              |
	| Lakelovers                 |
	| Manor Cottages             |
	| Menai Holiday Cottages     |
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
	| Brand                  |
	| Hogans Irish Cottages  |
	| Lakes Cottage Holidays |
	| Large Holiday Houses   |
	| Lyme Bay Holidays      |

@SisterBrands @FormSubmission
Scenario: The Sister Brand MultiStep form can be submitted
	Given I have navigated to the following brand: <Brand>
	Then the following text is displayed: Start your  holiday letting journey today
	And the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                                   |
	| first_name                                                                                                |
	| last_name                                                                                                 |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| /terms/privacypolicy                                                                                      |
	When I enter Test in the following form field: //*[@*='enquiry-multi-step']//input[@*='first_name']
	And I enter Owner in the following form field: //*[@*='enquiry-multi-step']//input[@*='last_name']
	And I click //*[@*='enquiry-multi-step']/button[@*='submit']
	Then the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                           |
	| In order to receive email communciations from our expert team, please provide your email address. |
	| Email address                                                                                     |
	When I enter test@test.com in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the relevant elements are dislpayed
	| Element                                                                                                                                     |
	| To allow our property experts to contact you by phone (including an initial call regarding your enquiry), please provide your phone number. |
	| Phone number                                                                                                                                |
	When I enter 07000000000 in the following form field: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	Then the relevant elements are dislpayed
	| Element                                                                                                   |
	| Please ensure the following details are correct                                                           |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| Submit enquiry                                                                                            |
	When I click //*[@*='enquiry-multi-step' and @data-step='4']/button[@*='submit']
	And I wait up to 10 seconds for the following to be displayed: Thank you for your enquiry
	Then the following page title is displayed: Thank you for your enquiry | Sykes Cottages
	Examples:
	| Brand                      |
	| Carbis Bay                 |
	| Character Cottages		 |
	| Coast & Country Cottages   |
	| Coast & Country Holidays   |
	| Cornish Cottage Holidays   |
	| Dream Cottages             |
	| Heart of the Lakes         |
	| Helpful Holidays           |
	| John Bray Cornish Holidays |
	| Lake District              |
	| Lakelovers                 |
	| Manor Cottages             |
	| Menai Holiday Cottages     |
	| Yorkshire Coastal          |