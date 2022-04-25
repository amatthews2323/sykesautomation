Feature: LetYourProperty
	Let Your Property page content and functionality

@Navigation
Scenario: The user can navigate to the Let Your Property page
	Given I am on the Sykes Homepage
	When I click Let Your Property
	Then the following page title is displayed: Holiday Letting Agents For Cottages, Holiday Homes & Property

@LetYourProperty @ProductionRegressionSuite @EnquiryForm
Scenario: The enquiry form is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following elements are dislpayed on the page
	| Element                                                                                           |
	| form-heading-container                                                                            |
#   | Complete the form to receive your information pack												|
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
	Then the following element is not displayed on the page: Already started?

@LetYourProperty @ProductionRegressionSuite
Scenario: The transparent header is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following element is displayed on the page: nav_top u-clearfix nav_top_17485

@LetYourProperty
Scenario: The floating action button is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	When I scroll to the following element: page-footer container_sykes_grid
	Then the following element is displayed on the page: Back To Top Button

@LetYourProperty @ProductionRegressionSuite
Scenario: The relevant elements are displayed within the footer
	Given I have navigated to the following page: letyourcottage
	When I scroll to the following element: page-footer
	Then the following elements are dislpayed on the page
    | Element                                                    |
    | /images/sykes/sykes-primary-logo-white.svg                 |
    | © 2022 All rights reserved                                 |
    | One City Place, Chester, Cheshire, CH1 3BQ, United Kingdom |
    | Registration No: 4469189                                   |
    | VAT Registration No: 204 9794 88                           |
    | Email us at letwithsykes@sykescottages.co.uk               |
    | Sykes Product Showcase 2022                                |
    | /blog/category/cottage-owners/                             |
    | /terms/privacypolicy                                       |
    | /press-and-media.html                                      |
    | /letyourcottage/holiday-homes-for-sale/                    |
    | https://www.facebook.com/sykescottages.co.uk               |
    | https://twitter.com/sykescottages                          |
    | https://pinterest.com/sykescottages/                       |
    | https://instagram.com/sykescottages/                       |

@LetYourProperty @ProductionRegressionSuite
Scenario: The Income Projection is displayed upon interaction
	Given I have navigated to the following page: letyourcottage
	Then the following element is displayed on the page: Please select your region
	When I select option South West from the region dropdown
	Then the following element is displayed on the page: homepage_calculator_cta_blue

@LetYourProperty @ProductionRegressionSuite
Scenario: The Managed Services links direct to the LYP form
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18466
	And I close the pop-ups
	And I scroll to the following element: Partially managed
	And I select the Partially Managed Enquire Now button
	Then the enquiry form is displayed with the tint applied
	When I select the Fully Managed Enquire Now button
	Then the enquiry form is displayed with the tint applied

@LetYourProperty @RegressionSmokeTest
Scenario: The relevant sections are displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following elements are dislpayed on the page
    | Element                                      |
    | Customer reviews powered by Trustpilot       |
    | Gain exposure through our partners           |
    | What do our owners say                       |
    | How much could I earn                        |
    | We are still open as usual                   |
    | Holiday home management with Sykes           |
    | Putting your property in the spotlight       |
    | Holiday letting made easy                    |
    | Free Owner Information Pack                  |
    | Looking to get started with holiday letting? |

#@LetYourProperty @ProductionRegressionSuite
Scenario: The page sections are displayed is the correct order
	Given I have navigated to the following page: letyourcottage
	Then the <Section> section is displayed at position <Position>
	Examples:
	| Section                                                | Position |
	| Gain exposure through our partners                     | 3        |
	| What do our owners say?                                | 4        |
	| How can Sykes elevate your holiday letting experience? | 5        |
	| How much could I earn                                  | 6        |
	| Holiday home management with Sykes                     | 7        |
	| Putting your property in the spotlight                 | 8        |
	| Holiday letting made easy                              | 9        |
	| Are you thinking of buying                             | 10       |
	| Request your free owner information pack               | 11       |

@MobileApp @RegressionSmokeTest
Scenario: The relevant sections are displayed on the Mobile App homepage
	Given I have navigated to the following page: letyourcottage/?app_view=true
	When I set the window size to Mobile
	Then the following sections are dislpayed
	| Section                                      |
    | Gain exposure through our partners           |
    | What do our owners say                       |
    | How much could I earn                        |
    | We are still open as usual                   |
    | Holiday home management with Sykes           |
    | Putting your property in the spotlight       |
    | Holiday letting made easy                    |
    | Free Owner Information Pack                  |
    | Looking to get started with holiday letting? |
	And the following elements are not dislpayed on the page
	| Element                          |
	| contact-to-book mobile           |
	| navbar-toggle collapsed          |

@LetYourProperty @ProductionRegressionSuite
Scenario: The Information Carousel is displayed on the page
	Given I have navigated to the following page: letyourcottage
	Then the following elements are dislpayed on the page
		 | Element                     |
		 | Information centre          |
		 | Enquire now                 |
		 | Buying, owning and selling  |
		 | How to run your holiday let |
		 | Tax information and advice  |
		 | Advertising and marketing   |
		 | Investment advice           |
		 | Holiday let mortgages       |
		 | Legal regulations           |