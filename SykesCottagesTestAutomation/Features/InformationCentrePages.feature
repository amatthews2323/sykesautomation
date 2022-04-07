Feature: InformationCentrePages
	Information Centre pages content and functionality

@Navigation
Scenario: The user can navigate to the Holiday Homes for Sale page
	Given I am on the Sykes Homepage
	When I select the Holiday homes for sale navigation link under Let Your Property
	Then the following page title is displayed: Holiday Homes for Sale UK

@Navigation
Scenario: The user can navigate to the Information Centre pages
	Given I am on the Sykes Homepage
	When I select the Holiday homes for sale navigation link under Let Your Property
	And I select the <Link> navigation link under Information Centre
	Then the following page title is displayed: <PageTitle>
	Examples:
	| Link                                       | PageTitle                                                     |
	| Advertising and marketing your holiday let | Advertising and Marketing Your Holiday Let \| Sykes Cottages  |
	| Buying, owning and selling a holiday let   | Buying, Owning & Selling a Holiday Let \| Sykes Cottages      |
	| Investment advice for holiday lets         | Investment in Holiday Homes \| Holiday Let Business \| Sykes  |
	| Legal regulations for holiday lets         | Legal Regulations for Holiday Lets \| Sykes Cottages          |
	| Holiday let mortgages                      | Mortgages for Holiday Lets \| Second Homes \| Sykes Cottages  |
	| How to run your holiday let                | Running Your Holiday Let \| Cost & Cleaning \| Sykes Cottages |
	| Tax information on holiday lets            | Tax Information for Holiday Homes \| Rules & Relief \| Sykes  |

@InformationCentre @ProductionRegressionSuite @RegressionSmokeTest
Scenario: The relevent elements are present on the Information Centre pages
	Given I have navigated to the following page: <Path>
	Then the following elements are dislpayed on the page
    | Element                           |
    | form-heading-container            |
    | <Header>                          |
	Examples:
	| Path														    | Header                                     |
	| letyourcottage/information/marketing-your-holiday-let         | Advertising and marketing your holiday let |
	| letyourcottage/information/buy-own-sell-holiday-lets          | Buying, owning and selling a holiday let   |
	| letyourcottage/information/investment-advice-for-holiday-lets | Investment advice for holiday lets         |
	| letyourcottage/information/legal-regulations-for-holiday-lets | Legal regulations for holiday lets         |
	| letyourcottage/information/holiday-let-mortgages              | Holiday let mortgages                      |
	| letyourcottage/information/how-to-run-your-holiday-let        | How to run your holiday let                |
	| letyourcottage/information/Tax-information-on-holiday-lets    | Tax information on holiday lets            |

@InformationCentre @ProductionRegressionSuite @EnquiryForm
Scenario: The enquiry form is displayed on the Information Centre pages
	Given I have navigated to the following page: <Path>
	Then the following elements are dislpayed on the page
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
	Then the following elements are dislpayed on the page
	| Element                        |
	| Please enter a full name.      |
	| Please enter an email address. |
	| Please enter a contact number. |
	When I enter an email address without an @ symbol
	Then the following text is displayed on the page: 'test.com' is missing an '@'. Please include an '@' in the email address.
	When I enter an email address without a valid domain
	Then the following text is displayed on the page: 'test@test' is an incomplete email address. Please include e.g. '.com', '.co.uk', '.net'.
	When I enter a phone number with a non-numerical character
	Then the following text is displayed on the page: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	When I enter a phone number with less than 10 digits
	Then the following text is displayed on the page: Please provide a contact number that is no less than 10 digits long.
	When I enter a phone number with more than 15 digits
	Then the following text is displayed on the page: Please provide a contact number that is no more than 15 digits long.
	When I enter a phone number with spaces and +44
	Then the following element is not displayed on the page: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	Examples:
	| Path                                              |
	| letyourcottage/marketing-your-holiday-let         |
	| letyourcottage/buy-own-sell-holiday-lets          |
	| letyourcottage/investment-advice-for-holiday-lets |
	| letyourcottage/legal-regulations-for-holiday-lets |
	| letyourcottage/holiday-let-mortgages              |
	| letyourcottage/how-to-run-your-holiday-let        |
	| letyourcottage/Tax-information-on-holiday-lets    | 