Feature: RegionPages
	Region pages content and functionality

@RegionPages @SmokeTest
Scenario: The Regional pages are displayed correctly
	Given I have navigated to the following page: <Path>
	Then the following text is displayed: <Region>
	And the following element is displayed: form-heading-container
	Examples:
	| Path                                                      | Region                     |
	| letyourcottage/In-Your-Area/South-West                    | South West                 |
	| letyourcottage/In-Your-Area/South-of-England              | South of England           |
	| letyourcottage/In-Your-Area/Heart-of-England              | Heart of England           |
	| letyourcottage/In-Your-Area/East-Anglia                   | East Anglia                |
	| letyourcottage/In-Your-Area/Peak-District                 | Peak District              |
	| letyourcottage/In-Your-Area/North-York-Moors-and-Coast    | North York Moors and Coast |
	| letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria | Lake District and Cumbria  |
	| letyourcottage/In-Your-Area/Northumberland                | Northumberland             |
	| letyourcottage/In-Your-Area/Wales                         | Wales                      |
	| letyourcottage/In-Your-Area/Ireland                       | Ireland                    |
	| letyourcottage/In-Your-Area/Scotland                      | Scotland                   |

@RegionPages @RegressionSuite @EnquiryForm
Scenario: The enquiry form is displayed on the Regional pages
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
	| marketing_email                                                                                   |
	| marketing_phone                                                                                   |
	| marketing_sms                                                                                     |
	| marketing_post                                                                                    |
	| Your details will be stored and used to send you information about our property letting services. |
	| /terms/privacypolicy                                                                              |
	| submit                                                                                            |
	When I click enquiry-button lyc-cta u-full-width js-enquiry-form-button lyc-cta--blue
	Then the following elements are dislpayed
	| Element                        |
	| Please enter a full name.      |
	| Please enter an email address. |
	| Please enter a contact number. |
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
	| Path                                                      |
	| letyourcottage/In-Your-Area/South-West                    |
	| letyourcottage/In-Your-Area/South-of-England              |
	| letyourcottage/In-Your-Area/Heart-of-England              |
	| letyourcottage/In-Your-Area/East-Anglia                   |
	| letyourcottage/In-Your-Area/Peak-District                 |
	| letyourcottage/In-Your-Area/North-York-Moors-and-Coast    |
	| letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria |
	| letyourcottage/In-Your-Area/Northumberland                |
	| letyourcottage/In-Your-Area/Wales                         |
	| letyourcottage/In-Your-Area/Ireland                       |
	| letyourcottage/In-Your-Area/Scotland                      |

@Navigation
Scenario: The user can navigate to the Region pages
	Given I am on the Sykes Homepage
	When I select the Holiday homes for sale navigation link under Let Your Property
	And I select the <Link> navigation link under Your Location
	Then the following page title is displayed: <PageTitle>
	Examples:
	| Link                       | PageTitle                                                         |
	| South West                 | South West Holiday Letting Agents \| Sykes Cottages               |
	| South of England           | South of England Holiday Letting Agents \| Sykes Cottages         |
	| Heart of England           | Heart of England Holiday Letting Agents \| Sykes Cottages         |
	| East Anglia                | Norfolk and Suffolk Holiday Letting Agents \| Sykes Cottages      |
	| Peak District              | Peak District Holiday Letting Agents \| Sykes Cottages            |
	| North York Moors and Coast | Yorkshire Moors & Coast Holiday Letting Agents \| Sykes           |
	| Lake District and Cumbria  | Lake District & Cumbria Holiday Letting Agents \| Sykes           |
	| Northumberland             | Northumberland Holiday Letting Agents \| Sykes Cottages           |
	| Wales                      | Wales Holiday Letting Agents \| Welsh Holiday Lets \| Sykes       |
	| Ireland                    | Ireland Holiday Letting Agents \| Irish Holiday Lets \| Sykes     |
	| Scotland                   | Scotland Holiday Letting Agents \| Scottish Holiday Lets \| Sykes |