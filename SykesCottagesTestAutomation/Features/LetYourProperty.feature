Feature: LetYourProperty
	Let Your Property page content and functionality

@Navigation @SmokeTest
Scenario: The user can navigate to the Let Your Property page
	Given I am on the Sykes Homepage
	When I click Let Your Property
	Then the following page title is displayed: Holiday Letting Agents For Cottages, Holiday Homes & Property

@LetYourProperty @SmokeTest
Scenario: The relevant sections are displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following elements are dislpayed
    | Element                                |
    | Customer reviews powered by Trustpilot |
    | Gain exposure through our partners     |
    | What do our owners say                 |
    | How much could I earn                  |
    | We are still open as usual             |
    | Holiday home management with Sykes     |
    | Putting your property in the spotlight |
    | Holiday letting made easy              |
    | Information centre                     |
    | Free Owner Information Pack            |

@LetYourProperty @RegressionSuite @EnquiryForm
Scenario: The enquiry form is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following elements are dislpayed
	| Element                                                                                           |
	| form-heading-container                                                                            |
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

@LetYourProperty @RegressionSuite @EnquiryForm
Scenario: The modal enquiry form is displayed correctly
	Given I have navigated to the following page: letyourcottage
	When I scroll to the following element: Start your listing today
	And I click Start your listing today
	Then I wait 2 seconds
	Then the following elements are dislpayed
	| Element                                                                |
	| o-overlay__content o-overlay__content--reset js-overlay-content        |
	| list_property_first_name                                               |
	| list_property_email                                                    |
	| list_property_phone                                                    |
	| list_property_first_name_validation_error                              |
	| list_property_email_validation_error                                   |
	| list_property_phone_validation_error                                   |
	When I select the form overlay submit button
	Then the following elements are dislpayed
	| Element                        |
	| Please enter a full name.      |
	| Please enter an email address. |
	| Please enter a contact number. |
	When I enter test.com in the following form field: list_property_email
	And I click o-overlay__content o-overlay__content--reset js-overlay-content
	Then the following text is displayed: 'test.com' is missing an '@'. Please include an '@' in the email address.
	When I enter test@test in the following form field: list_property_email
	And I click o-overlay__content o-overlay__content--reset js-overlay-content
	Then the following text is displayed: 'test@test' is an incomplete email address. Please include e.g. '.com', '.co.uk', '.net'.
	When I enter test in the following form field: list_property_phone
	And I click o-overlay__content o-overlay__content--reset js-overlay-content
	Then the following text is displayed: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	When I enter 070000000 in the following form field: list_property_phone
	And I click o-overlay__content o-overlay__content--reset js-overlay-content
	Then the following text is displayed: Please provide a contact number that is no less than 10 digits long.
	When I enter 0700000000000000 in the following form field: list_property_phone
	And I click o-overlay__content o-overlay__content--reset js-overlay-content
	Then the following text is displayed: Please provide a contact number that is no more than 15 digits long.
	When I enter +44 7000 000 000 in the following form field: list_property_phone
	And I click o-overlay__content o-overlay__content--reset js-overlay-content
	Then the following element is not displayed: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	Then the following element is not displayed: Already started?

@LetYourProperty @RegressionSuite @EnquiryForm
Scenario: The Information Centre carousel enquiry form is displayed correctly
	Given I have navigated to the following page: letyourcottage
	When I click Click enquire now and complete the form to receive your free information pack.
	Then I wait 2 seconds
	Then the following elements are dislpayed
	| Element                                                                |
	| o-overlay__content o-overlay__content--reset js-overlay-content        |
	| list_property_first_name                                               |
	| list_property_email                                                    |
	| list_property_phone                                                    |
	| list_property_first_name_validation_error                              |
	| list_property_email_validation_error                                   |
	| list_property_phone_validation_error                                   |

@LetYourProperty @RegressionSuite
Scenario: The transparent header is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following element is displayed: nav_top u-clearfix nav_top_17485

@LetYourProperty
Scenario: The floating action button is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	When I scroll to the following element: page-footer container_sykes_grid
	Then the following element is displayed: Back To Top Button
	When I click Back To Top Button
	And I wait 5 seconds
	Then the enquiry form is displayed with the tint applied

@LetYourProperty @RegressionSuite
Scenario: The Income Projection is displayed upon interaction
	Given I have navigated to the following page: letyourcottage
	Then the following element is displayed: Please select your region
	When I select option South West from the region dropdown
	Then the following element is displayed: homepage_calculator_cta_blue

@LetYourProperty @RegressionSuite
Scenario: The Managed Services links direct to the LYP form
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I scroll to the following element: Partially managed
	And I select the Partially Managed Enquire Now button
	Then the enquiry form is displayed with the tint applied
	When I select the Fully Managed Enquire Now button
	Then the enquiry form is displayed with the tint applied

@LetYourProperty @RegressionSuite
Scenario: The page sections are displayed in the correct order
	Given I have navigated to the following page: letyourcottage
	Then the page sections are displayed in the relevant positions
	| Key                                    | Position |
	| navigation                             | 1        |
	| Gain exposure through our partners     | 2        |
	| What do our owners say                 | 3        |
	| How much could I earn                  | 4        |
	| We are still open as usual             | 5        |
	| Holiday home management with Sykes     | 6        |
	| Putting your property in the spotlight | 7        |
	| Holiday letting made easy              | 8        |
	| Information centre                     | 9        |
	| Free Owner Information Pack            | 10       |

@MobileApp @SmokeTest
Scenario: The relevant sections are displayed on the Mobile App homepage
	Given I have navigated to the following page: letyourcottage/?app_view=true
	When I set the window size to Mobile
	Then the following sections are dislpayed
	| Section                                |
	| Gain exposure through our partners     |
	| What do our owners say                 |
	| How much could I earn                  |
	| We are still open as usual             |
	| Holiday home management with Sykes     |
	| Putting your property in the spotlight |
	| Holiday letting made easy              |
	| Information centre                     |
	| Free Owner Information Pack            |
	And the following elements are not dislpayed
	| Element                 |
	| contact-to-book mobile  |
	| navbar-toggle collapsed |

@LetYourProperty
Scenario: The Information Carousel is displayed on the page
	Given I have navigated to the following page: letyourcottage
	Then the following elements are dislpayed
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

@LetYourProperty @RegressionSuite
Scenario: The footer content is displayed correctly
	Given I have navigated to the following page: letyourcottage
	When I scroll to the following element: page-footer
	Then the following elements are dislpayed within the footer section
	| Element                                                    |
	| Sykes Cottages                                             |
	| © 2022 All rights reserved                                 |
	| One City Place, Chester, Cheshire, CH1 3BQ, United Kingdom |
	| Registration No: 4469189                                   |
	| VAT Registration No: 204 9794 88                           |
	| Email us at letwithsykes@sykescottages.co.uk               |
	| Sykes Product Showcase 2022                                |
	| Read our blog                                              |
	| Privacy Policy                                             |
	| Press and media                                            |
	| Holiday homes for sale                                     |
	| Facebook                                                   |
	| Twitter                                                    |
	| Pinterest                                                  |
	| Instagram                                                  |