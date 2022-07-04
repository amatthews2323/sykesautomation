Feature: SisterSites
	Sister sites content and functionality

@SisterSites @LYPSmokeTest @LYPRegressionSuite
Scenario: The Sykes sister sites are displayed correctly
	Given I am on the following webpage: <URL>
	Then the relevant elements are dislpayed
	| Element                                |
	| <Title>                                |
	| nav_logo                               |
	| hero__image                            |
	| form-heading-container                 |
	| Putting your property in the spotlight |
	| Holiday letting made easy              |
	| Request a free owner pack              |
	| Claim My Free Pack                     |
	Examples:
	| URL                                                         | Title                      |
	| https://www.carbisbayholidays.co.uk/letyourcottage/         | Carbis Bay                 |
	| https://www.character-cottages.co.uk/letyourcottage/        | Character Cottages         |
	| https://www.coastandcountry.co.uk/letyourcottage/           | Coast & Country Cottages   |
	| https://www.cornishcottageholidays.co.uk/letyourcottage/    | Cornish Cottage Holidays   |
	| https://www.dream-cottages.co.uk/letyourcottage/            | Dream Cottages             |
	| https://www.heartofthelakes.co.uk/letyourcottage/           | Heart of the Lakes         |
	| https://www.helpfulholidays.co.uk/letyourcottage/           | Helpful Holidays           |
	| https://www.hogansirishcottages.com/letyourcottage/         | Hogans Irish Cottages      |
	| https://www.johnbraycornishholidays.co.uk/letyourcottage/   | John Bray Cornish Holidays |
	| https://www.lakedistrictlodgeholidays.co.uk/letyourcottage/ | Lake District              |
	| https://www.lakescottageholiday.co.uk/letyourcottage/       | Lakes Cottage Holidays     |
	| https://www.lakelovers.co.uk/letyourcottage/                | Lakelovers                 |
	| https://www.manorcottages.co.uk/letyourcottage/             | Manor Cottages             |
	| https://www.menaiholidays.co.uk/letyourcottage/             | Menai Holiday Cottages     |
	| https://www.welsh-cottages.co.uk/letyourcottage/            | Welsh Cottage              |
	| https://www.yorkshirecoastalcottages.com/cottage-owners/    | Yorkshire Coastal          |

@SisterSites @LYPRegressionSuite @EnquiryForm
Scenario: The enquiry form is displayed on the sister sites
	Given I am on the following webpage: <URL>
	Then the relevant elements are dislpayed
	| Element                                                                                                   |
	| form-heading-container                                                                                    |
	| Complete the form to receive your information pack                                                        |
	| heroform_first_name                                                                                       |
	| heroform_first_name_validation_error                                                                      |
	| heroform_email                                                                                            |
	| heroform_email_validation_error                                                                           |
	| heroform_phone                                                                                            |
	| heroform_phone_validation_error                                                                           |
	| /terms/privacypolicy                                                                                      |
	| submit                                                                                                    |
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
	Examples:
	| URL                                                         |
	| https://www.character-cottages.co.uk/letyourcottage/        |
	| https://www.carbisbayholidays.co.uk/letyourcottage/         |
	| https://www.coastandcountry.co.uk/letyourcottage/           |
	| https://www.cornishcottageholidays.co.uk/letyourcottage/    |
	| https://www.dream-cottages.co.uk/letyourcottage/            |
	| https://www.heartofthelakes.co.uk/letyourcottage/           |
	| https://www.helpfulholidays.co.uk/letyourcottage/           |
	| https://www.hogansirishcottages.com/letyourcottage/         |
	| https://www.johnbraycornishholidays.co.uk/letyourcottage/   |
	| https://www.lakedistrictlodgeholidays.co.uk/letyourcottage/ |
	| https://www.lakescottageholiday.co.uk/letyourcottage/       |
	| https://www.lakelovers.co.uk/letyourcottage/                |
	| https://www.manorcottages.co.uk/letyourcottage/             |
	| https://www.menaiholidays.co.uk/letyourcottage/             |
	| https://www.welsh-cottages.co.uk/letyourcottage/            |
	| https://www.yorkshirecoastalcottages.com/cottage-owners/    |