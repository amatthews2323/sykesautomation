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
    | Download your Free Owner Information Pack    |
    | Download owner pack                          |
    | We’ve got your property covered              |
    | leading UK holiday home insurer              |
    | 40% of our customers                         |

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
	When I enter Dupe in the following form field: //*[@*='enquiry-multi-step']//input[@*='first_name']
	And I enter Test002 in the following form field: //*[@*='enquiry-multi-step']//input[@*='last_name']
	And I click //*[@*='enquiry-multi-step']/button[@*='submit']
	Then the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                           |
	| In order to receive email communciations from our expert team, please provide your email address. |
	| Email address                                                                                     |
	When I enter dupetest002@gmail.com in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the relevant elements are dislpayed
	| Element                                                                                                                                     |
	| To allow our property experts to contact you by phone (including an initial call regarding your enquiry), please provide your phone number. |
	| Phone number                                                                                                                                |
	When I enter 06444666555 in the following form field: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
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
	Then the relevant elements are dislpayed within the searcher-section section
	| Element                                |
	| Search for holiday letting information |
	| searchTerm                             |
	| Search                                 |
	| Managed services                       |
	| Investment advice                      |
	| How to run a holiday let               |
	When I enter Mortgage in the following form field: searchTerm
	And I click searcher-bar__action
	Then the relevant elements are dislpayed
	| Element                                           |
	| 12 results for 'Mortgage'                         |
	| back-container                                    |
	| A complete guide to holiday let mortgages         |
	| Holiday let mortgages                             |
	| Running your holiday let                          |
	| Why now is a good time to invest in a holiday let |

@LetYourProperty @LYPRegressionSuite
Scenario: The relevant headers are displayed on the page
	Given I have navigated to the following page: letyourcottage
	Then the relevant elements are dislpayed
	| Element                                                        |
	| Let your property with Sykes and earn up to £125,000 per year* |
	| Start your Sykes holiday letting journey today                 |
	| Search for holiday letting information                         |
	| Holiday letting made easy                                      |
	| Information centre                                             |
	| Gain exposure through our partners                             |
	| What do our owners say?                                        |
	| How much could I earn with Sykes?                              |
	| We are still open as usual                                     |
	| Holiday home management with Sykes                             |
	| Partially managed                                              |
	| Fully managed                                                  |
	| Putting your property in the spotlight                         |
	| Enquire now                                                    |
	| Buying, owning and selling                                     |
	| How to run your holiday let                                    |
	| Tax information and advice                                     |
	| We’ve got your property covered                                |
	| Download your Free Owner Information Pack                      |
	| Looking to get started with holiday letting?                   |
	| Video visits                                                   |
	| Unaccompanied visits                                           |
	| Contact-free photoshoots                                       |
	| List your property online                                      |
	| Dedicated Account Manager                                      |
	| Large network of cleaning suppliers                            |
	| Can't find the service you are looking for?                    |
	| Sykes Cottages                                                 |
	| Quick Links                                                    |
	| Social                                                         |

@LetYourProperty @LYPRegressionSuite
Scenario: The relevant links are displayed on the page
	Given I have navigated to the following page: letyourcottage
	Then the relevant elements are dislpayed
	| Element                                                                     |
	| /letyourcottage/                                                            |
	| /css/fonts/glyphicons-halflings-regular.woff2                               |
	| /css/sykes/letyourcottage/app.d095d542c83cd993e55b77dc2b84f6d0.css          |
	| /css/sykes/letyourcottage/app_enhanced.e4469a9a3dcf3c3e998f1c8d4c05586f.css |
	| /account/login                                                              |
	| /terms/privacypolicy                                                        |
	| /letyourcottage/search?searchTerm=Managed+services                          |
	| /letyourcottage/search?searchTerm=Investment+advice                         |
	| /letyourcottage/search?searchTerm=How+to+run+a+holiday+let                  |
	| /letyourcottage/managed-services                                            |
	| /letyourcottage/information/buy-own-sell-holiday-lets/                      |
	| /letyourcottage/information/how-to-run-your-holiday-let/                    |
	| /letyourcottage/information/tax-information-on-holiday-lets/                |
	| /letyourcottage/information/marketing-your-holiday-let/                     |
	| /letyourcottage/information/investment-advice-for-holiday-lets/             |
	| /letyourcottage/information/holiday-let-mortgages/                          |
	| /letyourcottage/information/regulations-for-holiday-lets/                   |
	| /letyourcottage/download-owner-pack                                         |
	| /letyourcottage/advice                                                      |
	| tel:01244617832                                                             |
	| mailto:letwithsykes@sykescottages.co.uk                                     |
	| https://showcase.sykescottages.co.uk/                                       |
	| /blog/category/cottage-owners/                                              |
	| /terms/privacypolicy                                                        |
	| /terms/cookiepolicy                                                         |
	| /press-and-media.html                                                       |
	| /letyourcottage/holiday-homes-for-sale/                                     |
	| https://www.facebook.com/sykescottages.co.uk                                |
	| https://twitter.com/sykescottages                                           |
	| https://pinterest.com/sykescottages/                                        |
	| https://instagram.com/sykescottages/                                        |
	| https://policies.google.com/privacy                                         |
	| https://policies.google.com/terms                                           |
	| /terms/cookiepolicy                                                         |

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
	| /images/sykes/letyourcottage/icons/arrow-prev.svg                                                                                          |
	| /images/sykes/letyourcottage/managed-services/banner-images/18583/1.png                                                                    |
	| /images/sykes/letyourcottage/managed-services/banner-images/18583/2.png                                                                    |
	| /images/sykes/letyourcottage/managed-services/banner-images/18583/3.png                                                                    |
	| /images/sykes/letyourcottage/managed-services/banner-images/18583/4.png                                                                    |
	| /images/sykes/letyourcottage/managed-services/banner-images/18583/5.png                                                                    |
	| /images/sykes/letyourcottage/icons/arrow-next.svg                                                                                          |
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
	| /images/sykes/sykes-primary-logo-white.svg                                                                                                 |
	| /images/icons-svg/social-media-icons/lyc/facebook.svg                                                                                      |
	| /images/icons-svg/social-media-icons/lyc/twitter.svg                                                                                       |
	| /images/icons-svg/social-media-icons/lyc/pinterest.svg                                                                                     |
	| /images/icons-svg/social-media-icons/lyc/instagram.svg                                                                                     |
	| https://cdn.cookielaw.org/logos/static/poweredBy_ot_logo.svg                                                                               |