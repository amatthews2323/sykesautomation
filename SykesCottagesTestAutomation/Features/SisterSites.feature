﻿Feature: SisterSites
	Sister sites content and functionality

@SisterSites @ProductionRegressionSuite
Scenario: The Sykes sister sites are displayed correctly
	Given I am accessing <URL>
	Then the following elements are dislpayed on the page
	| Element                   |
	| <Title>                   |
	| form-heading-container    |
	| partner                   |
	| Holiday letting made easy |
	| Request a free owner pack |
	Examples:
	| URL                                                         | Title                      |
	| https://www.character-cottages.co.uk/letyourcottage/        | Character Cottages         |
	| https://www.carbisbayholidays.co.uk/letyourcottage/         | Carbis Bay                 |
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

@SisterSites @ProductionRegressionSuite
Scenario: The enquiry form is displayed on the sister sites
	Given I am accessing <URL>
	Then the following elements are dislpayed on the page
	| Element                                                                     |
	| form-heading-container                                                      |
	| Complete the form to receive your information pack                          |
	| heroform_first_name                                                         |
	| heroform_first_name_validation_error                                        |
	| heroform_email                                                              |
	| heroform_email_validation_error                                             |
	| heroform_phone                                                              |
	| heroform_phone_validation_error                                             |
	| marketing_email                                                             |
	| marketing_phone                                                             |
	| marketing_sms                                                               |
	| marketing_post                                                              |
	| To stop this, just ask or click the opt out link when we are next in touch. |
	| /terms/privacypolicy                                                        |
	| submit                                                                      |
#	When I select the alert Get Started button
#	Then the following elements are dislpayed on the page
#	| Element                        |
#	| Please enter a full name.      |
#	| Please enter an email address. |
#	| Please enter a contact number. |
	When I enter an email address without an @ symbol
	And I select the alert Get Started button 
	Then the following text is displayed on the page: 'test.com' is missing an '@'. Please include an '@' in the email address.
	When I enter an email address without a valid domain
	And I select the alert Get Started button 
	Then the following text is displayed on the page: 'test@test' is an incomplete email address. Please include e.g. '.com', '.co.uk', '.net'.
	When I enter a phone number with a non-numerical character
	And I select the alert Get Started button 
	Then the following text is displayed on the page: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	When I enter a phone number with less than 10 digits
	And I select the alert Get Started button 
	Then the following text is displayed on the page: Please provide a contact number that is no less than 10 digits long.
	When I enter a phone number with more than 15 digits
	And I select the alert Get Started button 
	Then the following text is displayed on the page: Please provide a contact number that is no more than 15 digits long.
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