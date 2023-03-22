Feature: LetYourProperty
	Let Your Property page content and functionality

@Navigation @LYPSmokeTest @LYPRegressionSuite
Scenario: The user can navigate to the Let Your Property page
	Given I am on the Sykes Homepage
	When I refresh the page
	And I hover over Let Your Property
	And I click Let Your Property
	Then the following page title is displayed: Holiday Letting Agents For Cottages, Holiday Homes & Property
	And the following text is displayed: Go back to booking a holiday

@LetYourProperty @LYPSmokeTest @LYPRegressionSuite
Scenario: The relevant sections are displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the relevant elements are dislpayed
    | Element                                      |
    | Customer reviews powered by Trustpilot       |
    | Gain exposure through our partners           |
    | What do our owners say?                      |
    | How much could I earn with Sykes?            |
    | Holiday home management with Sykes           |
    | Putting your property in the spotlight       |
    | Holiday letting made easy                    |
    | Information centre                           |
    | Owner Information Pack                       |
    | Looking to get started with holiday letting? |

@HeroForm @LYPRegressionSuite
Scenario: The MultiStep form is displayed correctly
	Given I have navigated to the following page: <Path>
	When I try clicking open-multistep-modal
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
	| In order to receive email communications from our expert team, please provide your email address. |
	| Email address                                                                                     |
	When I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the following text is displayed: Please enter an email address
	When I enter sykescottages.co.uk in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the following text is displayed: 'sykescottages.co.uk' is missing an '@'. Please include an '@' in the email address.
	When I enter testowner@sykescottages in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the following text is displayed: 'testowner@sykescottages' is an incomplete email address. Please include e.g. '.com', '.co.uk', '.net'.
	When I enter testowner@sykescottages.co.uk in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
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
##	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
##	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
##	Then the relevant elements are dislpayed
##	| Element                                                                                                   |
##	| Please ensure the following details are correct                                                           |
##	| Your details will be used by the Sykes group to send you information about our property letting services. |
##	| Submit enquiry                                                                                            |
	Examples:
	| Path                                                          |
	| letyourcottage/                                               |
	| letyourcottage/managed-services/                              |
	| letyourcottage/information/marketing-your-holiday-let         |
	| letyourcottage/information/buy-own-sell-holiday-lets          |
	| letyourcottage/information/investment-advice-for-holiday-lets |
	| letyourcottage/information/regulations-for-holiday-lets       |
	| letyourcottage/information/holiday-let-mortgages              |
	| letyourcottage/information/how-to-run-your-holiday-let        |
	| letyourcottage/information/tax-information-on-holiday-lets    |
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

@HeroForm @FormSubmission
	Scenario: The MultiStep hero form can be submitted
	Given I have navigated to the following page: <Path>
	When I try clicking open-multistep-modal
	Then the relevant elements are dislpayed within the enquiry-multi-step section
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
	| In order to receive email communications from our expert team, please provide your email address. |
	| Email address                                                                                     |
	And I enter testowner@sykescottages.co.uk in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the relevant elements are dislpayed
	| Element                                                                                                                                     |
	| To allow our property experts to contact you by phone (including an initial call regarding your enquiry), please provide your phone number. |
	| Phone number                                                                                                                                |
	When I enter 07123456789 in the following form field: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	And I wait 2 seconds
	And I try clicking //input[@name='region-capture' and @value='thinking']//parent::*
	And I try clicking //*[@*='enquiry-multi-step' and @data-step='4']/button[@*='submit']
	And I try clicking //*[@*='enquiry-multi-step' and @data-step='4']/button[@*='submit']
	Then the relevant elements are dislpayed
	| Element                                                                                                   |
	| Please ensure the following details are correct                                                           |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| Submit enquiry                                                                                            |
	When I wait 2 seconds
	And I try clicking //*[@*='enquiry-multi-step' and @data-step='4']/button[@*='submit']
	And I try clicking //*[@*='enquiry-multi-step' and @data-step='5']/button[@*='submit']
	And I wait up to 10 seconds for the following to be displayed: Thank you for your enquiry
	Then the following page title is displayed: Thank you for your enquiry | Sykes Cottages
	Examples:
	| Path                                                          |
	| letyourcottage                                                |
	| letyourcottage/managed-services                               |
	| letyourcottage/information/marketing-your-holiday-let         |
	| letyourcottage/information/buy-own-sell-holiday-lets          |
	| letyourcottage/information/investment-advice-for-holiday-lets |
	| letyourcottage/information/regulations-for-holiday-lets       |
	| letyourcottage/information/holiday-let-mortgages              |
	| letyourcottage/information/how-to-run-your-holiday-let        |
	| letyourcottage/information/tax-information-on-holiday-lets    |
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

@LetYourProperty @LYPRegressionSuite
Scenario: The transparent header is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following element is displayed: nav_top u-clearfix nav_top_17485

@LetYourProperty @LYPRegressionSuite
Scenario: The floating action button is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	When I scroll to the following element: page-footer container_sykes_grid
	Then the following element is displayed: Back To Top Button
	When I click Back To Top Button
	Then the enquiry form is displayed with the tint applied

@LetYourProperty @LYPRegressionSuite
Scenario: The Managed Services links direct to the LYP form
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I select the Partially Managed Enquire Now button
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

@LetYourProperty
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
	Then the following sections are dislpayed
	| Section                                |
	| Gain exposure through our partners     |
	| How much could I earn                  |
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
	| © 2023 All rights reserved                                 |
	| One City Place, Chester, Cheshire, CH1 3BQ, United Kingdom |
	| Registration No: 4469189                                   |
	| VAT Registration No: 204 9794 88                           |
	| Email us at letwithsykes@sykescottages.co.uk               |
	| Sykes Product Showcase Winter 2022/23                      |
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
	Given I have navigated to the following page: letyourcottage
	Then the alerts are displayed on the page
	And I wait 10 seconds
	Then the alerts are not displayed on the page

@LetYourProperty @LYPRegressionSuite
Scenario: The number of bedrooms is included in the earnings calculator
	Given I have navigated to the following page: letyourcottage
	Then the relevant elements are dislpayed
	| Element                           |
	| How much could I earn with Sykes? |
	| Property information              |
	| Average potential earnings        |

@LetYourProperty @LYPRegressionSuite
Scenario: Performing a search returns the relevant results
	Given I have navigated to the following page: letyourcottage
	Then the relevant elements are dislpayed within the floating-searcher-container section
	| Element                                |
	| Search for holiday letting information |
	| searchTerm                             |
	| Search                                 |
	| Managed services                       |
	| How to run a holiday let               |
	When I try clicking nav_top_link nav_search_container
	And I enter Mortgage in the following form field: searchTerm
	And I click searcher-bar__action
	Then the relevant elements are dislpayed
	| Element                |
	| results for 'Mortgage' |

@LetYourProperty @LYPRegressionSuite
Scenario: The relevant headers are displayed on the page
	Given I have navigated to the following page: letyourcottage
	Then the relevant elements are dislpayed
	| Element                                                        |
	| Let your property with Sykes and earn up to £125,000 per year* |
	| Start your Sykes holiday letting journey today                 |
	| Holiday letting made easy                                      |
	| Information centre                                             |
	| Gain exposure through our partners                             |
	| What do our owners say?                                        |
	| How much could I earn with Sykes?                              |
	| Holiday home management with Sykes                             |
	| Partially managed                                              |
	| Fully managed                                                  |
	| Putting your property in the spotlight                         |
	| Enquire now                                                    |
	| Buying, owning and selling                                     |
	| How to run your holiday let                                    |
	| Tax information and advice                                     |
	| Advertising and marketing                                      |
	| Sykes Cottages                                                 |
	| Quick Links                                                    |
	| Social                                                         |

@LetYourProperty @LYPRegressionSuite
Scenario: The relevant links are displayed on the page
	Given I have navigated to the following page: letyourcottage
	Then the relevant elements are dislpayed
	| Element                                                         |
	| /letyourcottage/                                                |
	| /terms/privacypolicy                                            |
	| /letyourcottage/search?searchTerm=Managed+services              |
	| /letyourcottage/search?searchTerm=How+to+run+a+holiday+let      |
	| /account/login                                                  |
	| https://www.youtube.com/watch?v=x68mFIbCqCg                     |
	| https://www.youtube.com/watch?v=tqjT8KkjgAs                     |
	| https://www.youtube.com/watch?v=Ub391Pv_DA0                     |
	| https://www.youtube.com/watch?v=PM3uFo0QwXs                     |
	| https://www.youtube.com/watch?v=x68mFIbCqCg                     |
	| https://www.youtube.com/watch?v=tqjT8KkjgAs                     |
	| https://www.youtube.com/watch?v=Ub391Pv_DA0                     |
	| https://www.youtube.com/watch?v=PM3uFo0QwXs                     |
	| https://www.youtube.com/watch?v=x68mFIbCqCg                     |
	| https://www.youtube.com/watch?v=tqjT8KkjgAs                     |
	| https://www.youtube.com/watch?v=Ub391Pv_DA0                     |
	| https://www.youtube.com/watch?v=3PBQ5MN4Ko4                     |
	| https://www.youtube.com/watch?v=hEgStYWsKgA                     |
	| https://www.youtube.com/watch?v=ejktTVkAaSw                     |
	| https://www.youtube.com/watch?v=y-LyBJdDSWg                     |
	| https://www.youtube.com/watch?v=adhP_dRJQGM                     |
	| https://www.youtube.com/watch?v=ZaVr02lqZu4                     |
	| https://www.youtube.com/watch?v=eSh0rqAtPc0                     |
	| https://www.youtube.com/watch?v=3PBQ5MN4Ko4                     |
	| https://www.youtube.com/watch?v=hEgStYWsKgA                     |
	| https://www.youtube.com/watch?v=ejktTVkAaSw                     |
	| https://www.youtube.com/watch?v=y-LyBJdDSWg                     |
	| https://www.youtube.com/watch?v=adhP_dRJQGM                     |
	| https://www.youtube.com/watch?v=ZaVr02lqZu4                     |
	| https://www.youtube.com/watch?v=eSh0rqAtPc0                     |
	| https://www.youtube.com/watch?v=3PBQ5MN4Ko4                     |
	| https://www.youtube.com/watch?v=hEgStYWsKgA                     |
	| https://www.youtube.com/watch?v=ejktTVkAaSw                     |
	| /letyourcottage/managed-services                                |
	| /letyourcottage/information/buy-own-sell-holiday-lets/          |
	| /letyourcottage/information/how-to-run-your-holiday-let/        |
	| /letyourcottage/information/tax-information-on-holiday-lets/    |
	| /letyourcottage/information/marketing-your-holiday-let/         |
	| /letyourcottage/information/investment-advice-for-holiday-lets/ |
	| /letyourcottage/information/holiday-let-mortgages/              |
	| /letyourcottage/information/regulations-for-holiday-lets/       |
	| /letyourcottage/download-owner-pack                             |
	| /letyourcottage/advice                                          |
	| mailto:letwithsykes@sykescottages.co.uk                         |
	| https://showcase.sykescottages.co.uk/winter-22-23.html          |
	| /blog/category/cottage-owners/                                  |
	| /terms/privacypolicy                                            |
	| /terms/cookiepolicy                                             |
	| /press-and-media.html                                           |
	| /letyourcottage/holiday-homes-for-sale/                         |
	| https://www.facebook.com/sykescottages.co.uk                    |
	| https://twitter.com/sykescottages                               |
	| https://pinterest.com/sykescottages/                            |
	| https://instagram.com/sykescottages/                            |
	| https://policies.google.com/privacy                             |
	| https://policies.google.com/terms                               |

@LetYourProperty @LYPRegressionSuite
Scenario: The relevant images are displayed on the page
	Given I have navigated to the following page: letyourcottage
	Then the relevant elements are dislpayed
	| Element                                                                                                                                    |
	| /images/icons/icon-user-grey.svg                                                                                                           |
	| /images/icons/icon-mail-grey.svg                                                                                                           |
	| /images/icons/icon-phone-grey.svg                                                                                                          |
	| /images/sykes/sykes-small-logo-white.svg                                                                                                   |
	| /images/sykes/sykes-primary-logo-white.svg                                                                                                 |
	| /images/sykes/sykes-primary-logo.svg                                                                                                       |
	| /images/icons-svg/close_solid.svg                                                                                                          |
	| /images/icons-svg/close_solid.svg                                                                                                          |
	| /images/icons-svg/envelope-solid.svg                                                                                                       |
	| /images/icons-svg/close_solid.svg                                                                                                          |
	| /images/icons-svg/phone-solid.svg                                                                                                          |
	| /images/icons-svg/close_solid.svg                                                                                                          |
	| /images/icons-svg/user-solid.svg                                                                                                           |
	| /images/icons-svg/envelope-solid.svg                                                                                                       |
	| /images/icons-svg/phone-solid.svg                                                                                                          |
	| /images/sykes/letyourcottage/icons/arrow-prev.svg                                                                                          |
	| /images/sykes/letyourcottage/properties/testimonials/Chalmers-Brown.jpg                                                                    |
	| /images/sykes/letyourcottage/properties/testimonials/Hunt.jpg                                                                              |
	| /images/sykes/letyourcottage/properties/testimonials/Martin.jpg                                                                            |
	| /images/sykes/letyourcottage/icons/arrow-next.svg                                                                                          |
	| https://img.youtube.com/vi/x68mFIbCqCg/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/tqjT8KkjgAs/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/Ub391Pv_DA0/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/PM3uFo0QwXs/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/x68mFIbCqCg/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/tqjT8KkjgAs/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/Ub391Pv_DA0/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/PM3uFo0QwXs/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/x68mFIbCqCg/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/tqjT8KkjgAs/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/Ub391Pv_DA0/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/3PBQ5MN4Ko4/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/hEgStYWsKgA/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/ejktTVkAaSw/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/y-LyBJdDSWg/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/adhP_dRJQGM/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/ZaVr02lqZu4/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/eSh0rqAtPc0/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/3PBQ5MN4Ko4/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/hEgStYWsKgA/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/ejktTVkAaSw/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/y-LyBJdDSWg/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/adhP_dRJQGM/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/ZaVr02lqZu4/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/eSh0rqAtPc0/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/3PBQ5MN4Ko4/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/hEgStYWsKgA/maxresdefault.jpg                                                                                   |
	| https://img.youtube.com/vi/ejktTVkAaSw/maxresdefault.jpg                                                                                   |
	| /images/sykes/letyourcottage/icons/arrow-prev.svg                                                                                          |
	| /images/sykes/letyourcottage/managed-services/banner-images/18583/1.png                                                                    |
	| /images/sykes/letyourcottage/managed-services/banner-images/18583/2.png                                                                    |
	| /images/sykes/letyourcottage/managed-services/banner-images/18583/3.png                                                                    |
	| /images/sykes/letyourcottage/managed-services/banner-images/18583/4.png                                                                    |
	| /images/sykes/letyourcottage/managed-services/banner-images/18583/5.png                                                                    |
	| /images/sykes/letyourcottage/icons/arrow-next.svg                                                                                          |
	| /images/icons-svg/navigation/chevron/icon-chevron-down.svg                                                                                 |
	| /images/icons-svg/navigation/chevron/icon-chevron-down.svg                                                                                 |
	| /images/sykes/letyourcottage/icons/arrow-prev.svg                                                                                          |
	| https://property-images-cdn.sykesassets.co.uk/images/property_images/500x375/1094201/sc_1641918857_1094201_26.jpeg?access=3214T3370T840    |
	| https://property-images-cdn.sykesassets.co.uk/images/property_images/500x375/1090686/sc_1642422693_1090686_38.jpeg?access=3214T3370T840    |
	| https://property-images-cdn.sykesassets.co.uk/images/property_images/500x375/1070174/sc_1619444116_1070174_18.jpeg?access=3214T3370T840    |
	| https://property-images-cdn.sykesassets.co.uk/images/property_images/500x375/1090491/sc_1638542947_1090491_50.jpeg?access=3214T3370T840    |
	| https://property-images-cdn.sykesassets.co.uk/images/property_images/500x375/1039764/sc_15917942106716_1039764_67.jpg?access=3214T3370T840 |
	| https://property-images-cdn.sykesassets.co.uk/images/property_images/500x375/1040635/sc_1643110076_1040635_45.jpeg?access=3214T3370T840    |
	| /images/sykes/letyourcottage/icons/arrow-next.svg                                                                                          |
	| /images/let_your_cottage/letting_easy/market-leading.png                                                                                   |
	| /images/let_your_cottage/letting_easy/payment_in_advance.png                                                                               |
	| /images/let_your_cottage/letting_easy/dedicated-account-manager.png                                                                        |
	| /images/let_your_cottage/letting_easy/helpline-24h.png                                                                                     |
	| /images/let_your_cottage/letting_easy/full-property-management.png                                                                         |
	| /images/let_your_cottage/letting_easy/photography.png                                                                                      |
	| /images/sykes/letyourcottage/infopack-18588.jpg                                                                                            |
	| /images/sykes/letyourcottage/thank-you-page/bedrock-18588.png                                                                              |
	| /images/sykes/sykes-primary-logo-white.svg                                                                                                 |
	| /images/icons-svg/social-media-icons/lyc/facebook.svg                                                                                      |
	| /images/icons-svg/social-media-icons/lyc/twitter.svg                                                                                       |
	| /images/icons-svg/social-media-icons/lyc/pinterest.svg                                                                                     |
	| /images/icons-svg/social-media-icons/lyc/instagram.svg                                                                                     |
	| https://cdn.cookielaw.org/logos/static/poweredBy_ot_logo.svg                                                                               |

@LetYourProperty @LYPRegressionSuite
Scenario: The sticky header is displayed on the page
	Given I have navigated to the following page: <Path>
	When I scroll to the following element: page-footer
	Then the following element is displayed: nav_1
	Examples:
	| Path                                    |
	| letyourcottage/                         |
	| letyourcottage/managed-services/        |
	| letyourcottage/In-Your-Area/South-West/ |