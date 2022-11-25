Feature: LetYourProperty
	Let Your Property page content and functionality

@Navigation @LYPSmokeTest @LYPRegressionSuite
Scenario: The user can navigate to the Let Your Property page
	Given I am on the Sykes Homepage
	When I hover over Let Your Property
	And I click Let Your Property
	Then the following page title is displayed: Holiday Letting Agents For Cottages, Holiday Homes & Property

@LetYourProperty @LYPSmokeTest @LYPRegressionSuite
Scenario: The relevant sections are displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the relevant elements are dislpayed
    | Element                                      |
    | Customer reviews powered by Trustpilot       |
    | Gain exposure through our partners           |
    | How much could I earn                        |
    | Information centre                           |
    | Looking to get started with holiday letting? |

@HeroForm @LYPRegressionSuite
Scenario: The MultiStep form is displayed correctly
	Given I have navigated to the following page: <Path>
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
	| Path                                                          |
	| letyourcottage/                                               |
	| letyourcottage/managed-services/                              |
	| letyourcottage/In-Your-Area/South-West                        |
	| letyourcottage/In-Your-Area/South-of-England                  |
	| letyourcottage/In-Your-Area/Heart-of-England                  |
	| letyourcottage/In-Your-Area/East-Anglia                       |
	| letyourcottage/In-Your-Area/Peak-District                     |
	| letyourcottage/In-Your-Area/North-York-Moors-and-Coast        |
	| letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria     |
	| letyourcottage/In-Your-Area/Northumberland                    |
	| letyourcottage/In-Your-Area/Wales                             |
	| letyourcottage/In-Your-Area/Ireland                           |
	| letyourcottage/In-Your-Area/Scotland                          |
	| letyourcottage/information/marketing-your-holiday-let         |
	| letyourcottage/information/buy-own-sell-holiday-lets          |
	| letyourcottage/information/investment-advice-for-holiday-lets |
	| letyourcottage/information/legal-regulations-for-holiday-lets |
	| letyourcottage/information/holiday-let-mortgages              |
	| letyourcottage/information/how-to-run-your-holiday-let        |
	| letyourcottage/information/Tax-information-on-holiday-lets    |
	| letyourcottage/information/run-holiday-let-as-business        |
	| letyourcottage/information/leading-holiday-let-agency         |
	| letyourcottage/information/holiday-management-services        |

Scenario: The hero form is displayed correctly
	Given I have navigated to the following page: <Path>
	Then the relevant elements are dislpayed
	| Element                              |
	| form-heading-container               |
	| heroform_first_name                  |
	| heroform_first_name_validation_error |
	| heroform_email                       |
	| heroform_email_validation_error      |
	| heroform_phone                       |
	| heroform_phone_validation_error      |
	| Get started                          |
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
	When I enter Test Owner in the following form field: heroform_first_name
	And I enter test@test.com in the following form field: heroform_email
	And I enter 07000000000 in the following form field: heroform_phone
	And I select Get Started
	Then the relevant elements are dislpayed
	| Element                                                                                                   |
	| Your enquiry                                                                                              |
	| Please ensure the following details are correct                                                           |
	| How would you like the Sykes Group to keep in touch?                                                      |
	| marketing_phone                                                                                           |
	| marketing_email                                                                                           |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| You can opt out or unsubscribe at any time by contacting us or using an unsubscribe link.                 |
	| /terms/privacypolicy                                                                                      |
	| Complete enquiry                                                                                          |
	And the relevant elements are not dislpayed
	| Element        |
	| marketing_sms  |
	| marketing_post |
	Examples:
	| Path                                                          |
	| letyourcottage/managed-services/                              |
	| letyourcottage/In-Your-Area/South-West                        |
	| letyourcottage/In-Your-Area/South-of-England                  |
	| letyourcottage/In-Your-Area/Heart-of-England                  |
	| letyourcottage/In-Your-Area/East-Anglia                       |
	| letyourcottage/In-Your-Area/Peak-District                     |
	| letyourcottage/In-Your-Area/North-York-Moors-and-Coast        |
	| letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria     |
	| letyourcottage/In-Your-Area/Northumberland                    |
	| letyourcottage/In-Your-Area/Wales                             |
	| letyourcottage/In-Your-Area/Ireland                           |
	| letyourcottage/In-Your-Area/Scotland                          |
	| letyourcottage/information/marketing-your-holiday-let         |
	| letyourcottage/information/buy-own-sell-holiday-lets          |
	| letyourcottage/information/investment-advice-for-holiday-lets |
	| letyourcottage/information/legal-regulations-for-holiday-lets |
	| letyourcottage/information/holiday-let-mortgages              |
	| letyourcottage/information/how-to-run-your-holiday-let        |
	| letyourcottage/information/Tax-information-on-holiday-lets    |
	| letyourcottage/information/run-holiday-let-as-business        |
	| letyourcottage/information/leading-holiday-let-agency         |
	| letyourcottage/information/holiday-management-services        |

Scenario: The hero form can be submitted
	Given I have navigated to the following page: <Path>
	When I enter Test Owner in the following form field: heroform_first_name
	And I enter test@test.com in the following form field: heroform_email
	And I enter 07000000000 in the following form field: heroform_phone
	And I select Get Started
	And I click Complete enquiry
	And I wait 5 seconds
	Then the following page title is displayed: Thank you for your enquiry | Sykes Cottages
	And the relevant elements are dislpayed
	| Element                                        |
	| Hi, we’re ready when you are                   |
	| Ask one of our property experts to call you    |
	| Ask us to call you                             |
	| Start your Sykes letting journey online        |
	| Continue Online                                |
	Examples:
	| Path                                                          |
	| letyourcottage/managed-services/                              |
	| letyourcottage/In-Your-Area/South-West                        |
	| letyourcottage/In-Your-Area/South-of-England                  |
	| letyourcottage/In-Your-Area/Heart-of-England                  |
	| letyourcottage/In-Your-Area/East-Anglia                       |
	| letyourcottage/In-Your-Area/Peak-District                     |
	| letyourcottage/In-Your-Area/North-York-Moors-and-Coast        |
	| letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria     |
	| letyourcottage/In-Your-Area/Northumberland                    |
	| letyourcottage/In-Your-Area/Wales                             |
	| letyourcottage/In-Your-Area/Ireland                           |
	| letyourcottage/In-Your-Area/Scotland                          |
	| letyourcottage/information/marketing-your-holiday-let         |
	| letyourcottage/information/buy-own-sell-holiday-lets          |
	| letyourcottage/information/investment-advice-for-holiday-lets |
	| letyourcottage/information/legal-regulations-for-holiday-lets |
	| letyourcottage/information/holiday-let-mortgages              |
	| letyourcottage/information/how-to-run-your-holiday-let        |
	| letyourcottage/information/Tax-information-on-holiday-lets    |
	| letyourcottage/information/run-holiday-let-as-business        |
	| letyourcottage/information/leading-holiday-let-agency         |
	| letyourcottage/information/holiday-management-services        |

@HeroForm @FormSubmission
	Scenario: The MultiStep hero form can be submitted
	Given I have navigated to the following page: <Path>
	Then the following text is displayed: Start your Sykes holiday letting journey today
	And the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                                   |
	| first_name                                                                                                |
	| last_name                                                                                                 |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| /terms/privacypolicy                                                                                      |
	When I enter Test in the following form field: //*[@*='enquiry-multi-step']//input[@*='first_name']
	And I enter Owner in the following form field: //*[@*='enquiry-multi-step']//input[@*='last_name']
	And I click //*[@*='enquiry-multi-step']/button[@*='submit']
	And I wait 2 seconds
	Then the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                           |
	| In order to receive email communciations from our expert team, please provide your email address. |
	| Email address                                                                                     |
	When I enter test@test.com in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I wait 2 seconds
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	And I wait 2 seconds
	Then the relevant elements are dislpayed
	| Element                                                                                                                                     |
	| To allow our property experts to contact you by phone (including an initial call regarding your enquiry), please provide your phone number. |
	| Phone number                                                                                                                                |
	When I enter 070000000000 in the following form field: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
	And I wait 2 seconds
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	And I wait 2 seconds
	Then the relevant elements are dislpayed
	| Element                                                                                                   |
	| Please ensure the following details are correct                                                           |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| Submit enquiry                                                                                            |
	When I click //*[@*='enquiry-multi-step' and @data-step='4']/button[@*='submit']
	And I wait 4 seconds
	Then the following page title is displayed: Thank you for your enquiry | Sykes Cottages
	Examples:
	| Path                                                          |
	| letyourcottage                                                |
	| letyourcottage/managed-services                               |
	| letyourcottage/In-Your-Area/South-West                        |
	| letyourcottage/In-Your-Area/South-of-England                  |
	| letyourcottage/In-Your-Area/Heart-of-England                  |
	| letyourcottage/In-Your-Area/East-Anglia                       |
	| letyourcottage/In-Your-Area/Peak-District                     |
	| letyourcottage/In-Your-Area/North-York-Moors-and-Coast        |
	| letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria     |
	| letyourcottage/In-Your-Area/Northumberland                    |
	| letyourcottage/In-Your-Area/Wales                             |
	| letyourcottage/In-Your-Area/Ireland                           |
	| letyourcottage/In-Your-Area/Scotland                          |
	| letyourcottage/information/marketing-your-holiday-let         |
	| letyourcottage/information/buy-own-sell-holiday-lets          |
	| letyourcottage/information/investment-advice-for-holiday-lets |
	| letyourcottage/information/legal-regulations-for-holiday-lets |
	| letyourcottage/information/holiday-let-mortgages              |
	| letyourcottage/information/how-to-run-your-holiday-let        |
	| letyourcottage/information/Tax-information-on-holiday-lets    |
	| letyourcottage/information/run-holiday-let-as-business        |
	| letyourcottage/information/leading-holiday-let-agency         |
	| letyourcottage/information/holiday-management-services        |

@LetYourProperty @LYPRegressionSuite
Scenario: The transparent header is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following element is displayed: nav_top u-clearfix nav_top_17485

@LetYourProperty
Scenario: The floating action button is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	When I scroll to the following element: page-footer container_sykes_grid
	And I wait 2 seconds
	Then the following element is displayed: Back To Top Button
	When I click Back To Top Button
	And I wait 3 seconds
	Then the enquiry form is displayed with the tint applied


Scenario: The Income Projection is displayed upon interaction
	Given I have navigated to the following page: letyourcottage
	When I select option Northumberland from the region dropdown
	Then the following element is displayed: homepage_calculator_cta_blue

@LetYourProperty @LYPRegressionSuite
Scenario: The Managed Services links direct to the LYP form
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I scroll to the following element: Partially managed
	And I select the Partially Managed Enquire Now button
	Then the enquiry form is displayed with the tint applied
	When I select the Fully Managed Enquire Now button
	Then the enquiry form is displayed with the tint applied

@LetYourProperty @LYPRegressionSuite
Scenario: The Holiday Letting Made Easy images are displayed
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	Then the relevant elements are dislpayed
    | Element                                                             |
    | /images/let_your_cottage/letting_easy/market-leading.png            |
    | /images/let_your_cottage/letting_easy/payment_in_advance.png        |
    | /images/let_your_cottage/letting_easy/dedicated-account-manager.png |
    | /images/let_your_cottage/letting_easy/helpline-24h.png              |
    | /images/let_your_cottage/letting_easy/full-property-management.png  |
    | /images/let_your_cottage/letting_easy/photography.png               |

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

@MobileApp @LYPSmokeTest @LYPRegressionSuite
Scenario: The relevant sections are displayed on the Mobile App homepage
	Given I have navigated to the following page: letyourcottage/?app_view=true
	When I set the window size to Mobile
	Then the following sections are dislpayed
	| Section                                |
	| Gain exposure through our partners     |
	| How much could I earn                  |
	| Holiday letting made easy              |
	| Information centre                     |
	And the relevant elements are not dislpayed
	| Element                 |
	| contact-to-book mobile  |
	| navbar-toggle collapsed |

@LetYourProperty @LYPRegressionSuite
Scenario: The Information Carousel is displayed on the page
	Given I have navigated to the following page: letyourcottage
	Then the relevant elements are dislpayed
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

@LetYourProperty @LYPRegressionSuite
Scenario: The image navigation buttons are displayed on the page
	Given I have navigated to the following page: letyourcottage
	Then the relevant elements are dislpayed
	| Element        |
	| arrow-prev.svg |
	| arrow-next.svg |
	| slick-dots     |

@LetYourProperty @LYPRegressionSuite
Scenario: The footer content is displayed correctly
	Given I have navigated to the following page: letyourcottage
	When I scroll to the following element: page-footer
	Then the relevant elements are dislpayed within the page-footer section
	| Element                                                    |
	| Sykes Cottages                                             |
	| © 2022 All rights reserved                                 |
	| One City Place, Chester, Cheshire, CH1 3BQ, United Kingdom |
	| Registration No: 4469189                                   |
	| VAT Registration No: 204 9794 88                           |
	| Email us at letwithsykes@sykescottages.co.uk               |
	| Sykes Product Showcase 2022                                |
	| Read our blog                                              |
	| /terms/privacypolicy                                       |
	| Privacy Policy                                             |
	| /terms/cookiepolicy                                        |
	| Cookie Policy                                              |
	| Manage cookie preferences									 |
	| Press and media                                            |
	| Holiday homes for sale                                     |
	| Facebook                                                   |
	| Twitter                                                    |
	| Pinterest                                                  |
	| Instagram                                                  |

@LetYourProperty @LYPRegressionSuite
Scenario: The alerts disapear after an amount of time
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	Then the alerts are displayed on the page
	And I wait 10 seconds
	Then the alerts are not displayed on the page

@LetYourProperty @LYPRegressionSuite
Scenario: The number of bedrooms is included in the earnings calculator
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	Then the relevant elements are dislpayed
	| Element                           |
	| How much could I earn with Sykes? |
	| Property location                 |
	| Property information              |
	| Average potential earnings        |
	| Enquire today to get started      |