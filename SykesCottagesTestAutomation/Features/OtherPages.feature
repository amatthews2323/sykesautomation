Feature: OtherPages
	Holiday Homes for Sale and Manged Services page content and functionality

@ManagedServices @LYPSmokeTest @LYPRegressionSuite
Scenario: The relevent elements are present on the Managed Services page
	Given I have navigated to the following page: letyourcottage/managed-services
    Then the relevant elements are dislpayed
         | Element                   |
         | Holiday home management   |
         | hero-slideshow            |
         | c-lyc-form                |
         | Managed services at Sykes |
         | What are the benefits     |
         | Partially managed         |
         | Fully managed             |
         | Resource centre           |
         | Share page                |

@FAQ @LYPRegressionSuite
Scenario: The relevant links are displayed on the FAQ page
	Given I have navigated to the following page: letyourcottage/holiday-let-owner-information
	Then the relevant elements are dislpayed
	| Element |
	| /letyourcottage/ |
	| /account/login |
	| /letyourcottage/holiday-homes-for-sale/ |
	| /letyourcottage/information/marketing-your-holiday-let/ |
	| /letyourcottage/information/buy-own-sell-holiday-lets/ |
	| /letyourcottage/information/investment-advice-for-holiday-lets/ |
	| /letyourcottage/information/regulations-for-holiday-lets/ |
	| /letyourcottage/information/holiday-let-mortgages/ |
	| /letyourcottage/information/how-to-run-your-holiday-let/ |
	| /letyourcottage/information/tax-information-on-holiday-lets/ |
	| /letyourcottage/In-Your-Area/South-West/ |
	| /letyourcottage/In-Your-Area/South-of-England/ |
	| /letyourcottage/In-Your-Area/Heart-of-England/ |
	| /letyourcottage/In-Your-Area/East-Anglia/ |
	| /letyourcottage/In-Your-Area/Peak-District/ |
	| /letyourcottage/In-Your-Area/North-York-Moors-and-Coast/ |
	| /letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria/ |
	| /letyourcottage/In-Your-Area/Northumberland/ |
	| /letyourcottage/In-Your-Area/Wales/ |
	| /letyourcottage/In-Your-Area/Ireland/ |
	| /letyourcottage/In-Your-Area/Scotland/ |
	| /letyourcottage/#18983-calculator |
	| /letyourcottage/information/buy-own-sell-holiday-lets/ |
	| /letyourcottage/information/investment-advice-for-holiday-lets/ |
	| /letyourcottage/advice/holiday-homes-for-sale/ |
	| /letyourcottage/information/holiday-let-mortgages/ |
	| /letyourcottage/information/tax-information-on-holiday-lets/ |
	| /letyourcottage/marketing-your-holiday-let/#promoting-and-advertising-your-property |
	| /letyourcottage/marketing-your-holiday-let/#marketing-your-property |
	| /letyourcottage/marketing-your-holiday-let/#local-agents |
	| /letyourcottage/information/buy-own-sell-holiday-lets/#best-areas-to-buy |
	| /letyourcottage/information/buy-own-sell-holiday-lets/#leading-online-property-sales |
	| /letyourcottage/information/buy-own-sell-holiday-lets/#thinking-of-buying |
	| /letyourcottage/investment-advice-for-holiday-lets/#starting-a-holiday-letting-business |
	| /letyourcottage/investment-advice-for-holiday-lets/#holiday-rentals-business-model |
	| /letyourcottage/investment-advice-for-holiday-lets/#long-term-lets-vs-holiday-letting |
	| /letyourcottage/regulations-for-holiday-lets/#guidelines-for-planning-permission |
	| /letyourcottage/regulations-for-holiday-lets/#planning-permission-for-holiday lets |
	| /letyourcottage/regulations-for-holiday-lets/#council-building-regulations |
	| /letyourcottage/regulations-for-holiday-lets/#health-and-safety-guidelines |
	| /letyourcottage/regulations-for-holiday-lets/#free-legal-guidance-for-letting |
	| /letyourcottage/holiday-let-mortgages/#mortgage-applications |
	| /letyourcottage/holiday-let-mortgages/#advice-on-buying-a-holiday-let |
	| /letyourcottage/holiday-let-mortgages/#buy-to-let-vs-holiday-let-mortgage |
	| /letyourcottage/holiday-let-mortgages/#offset-the-interest-on-your-mortgage |
	| /letyourcottage/how-to-run-your-holiday-let/#furnishing-my-property |
	| /letyourcottage/how-to-run-your-holiday-let/#booking-dates-for-my-own-use |
	| /letyourcottage/how-to-run-your-holiday-let/#running-my-holiday-let |
	| /letyourcottage/tax-information-on-holiday-lets/#tax-implications |
	| /letyourcottage/tax-information-on-holiday-lets/#Business-rates |
	| /letyourcottage/tax-information-on-holiday-lets/#vat-registration |
	| /letyourcottage/tax-information-on-holiday-lets/#council-tax |
	| /letyourcottage/tax-information-on-holiday-lets/#reducing-tax-amount |
	| mailto:letwithsykes@sykescottages.co.uk |
	| https://showcase.sykescottages.co.uk/winter-22-23.html |
	| /blog/category/cottage-owners/ |
	| /terms/privacypolicy |
	| /terms/cookiepolicy |
	| /press-and-media.html |
	| /letyourcottage/holiday-homes-for-sale/ |
	| https://www.facebook.com/sykescottages.co.uk |
	| https://twitter.com/sykescottages |
	| https://pinterest.com/sykescottages/ |
	| https://instagram.com/sykescottages/ |

@FAQ
Scenario: The FAQ page links work as intended
	Given I am on the following webpage: https://www.sykescottages.co.uk
	Then the following links load correctly
	| Element                                                                                                |
	| /letyourcottage/holiday-let-owner-information/                                                         |
	| /letyourcottage/                                                                                       |
	| /account/login                                                                                         |
	| /letyourcottage/holiday-homes-for-sale/                                                                |
	| /letyourcottage/information/marketing-your-holiday-let/                                                |
	| /letyourcottage/information/buy-own-sell-holiday-lets/                                                 |
	| /letyourcottage/information/investment-advice-for-holiday-lets/                                        |
	| /letyourcottage/information/regulations-for-holiday-lets/                                              |
	| /letyourcottage/information/holiday-let-mortgages/                                                     |
	| /letyourcottage/information/how-to-run-your-holiday-let/                                               |
	| /letyourcottage/information/tax-information-on-holiday-lets/                                           |
	| /letyourcottage/In-Your-Area/South-West/                                                               |
	| /letyourcottage/In-Your-Area/South-of-England/                                                         |
	| /letyourcottage/In-Your-Area/Heart-of-England/                                                         |
	| /letyourcottage/In-Your-Area/East-Anglia/                                                              |
	| /letyourcottage/In-Your-Area/Peak-District/                                                            |
	| /letyourcottage/In-Your-Area/North-York-Moors-and-Coast/                                               |
	| /letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria/                                            |
	| /letyourcottage/In-Your-Area/Northumberland/                                                           |
	| /letyourcottage/In-Your-Area/Wales/                                                                    |
	| /letyourcottage/In-Your-Area/Ireland/                                                                  |
	| /letyourcottage/In-Your-Area/Scotland/                                                                 |
	| /letyourcottage/#18983-calculator                                                                      |
	| /letyourcottage/information/buy-own-sell-holiday-lets/                                                 |
	| /letyourcottage/information/investment-advice-for-holiday-lets/                                        |
	| /letyourcottage/advice/holiday-homes-for-sale/                                                         |
	| /letyourcottage/information/holiday-let-mortgages/                                                     |
	| /letyourcottage/information/tax-information-on-holiday-lets/                                           |
	| /letyourcottage/marketing-your-holiday-let/#promoting-and-advertising-your-property                    |
	| /letyourcottage/marketing-your-holiday-let/#marketing-your-property                                    |
	| /letyourcottage/marketing-your-holiday-let/#local-agents                                               |
	| /letyourcottage/information/buy-own-sell-holiday-lets/#best-areas-to-buy                               |
	| /letyourcottage/information/buy-own-sell-holiday-lets/#leading-online-property-sales                   |
	| /letyourcottage/information/buy-own-sell-holiday-lets/#thinking-of-buying                              |
	| /letyourcottage/investment-advice-for-holiday-lets/#starting-a-holiday-letting-business                |
	| /letyourcottage/investment-advice-for-holiday-lets/#holiday-rentals-business-model                     |
	| /letyourcottage/investment-advice-for-holiday-lets/#long-term-lets-vs-holiday-letting                  |
	| /letyourcottage/regulations-for-holiday-lets/#guidelines-for-planning-permission                       |
	| /letyourcottage/regulations-for-holiday-lets/#planning-permission-for-holiday%20lets                   |
	| /letyourcottage/regulations-for-holiday-lets/#council-building-regulations                             |
	| /letyourcottage/regulations-for-holiday-lets/#health-and-safety-guidelines                             |
	| /letyourcottage/regulations-for-holiday-lets/#free-legal-guidance-for-letting                          |
	| /letyourcottage/holiday-let-mortgages/#mortgage-applications                                           |
	| /letyourcottage/holiday-let-mortgages/#advice-on-buying-a-holiday-let                                  |
	| /letyourcottage/holiday-let-mortgages/#buy-to-let-vs-holiday-let-mortgage                              |
	| /letyourcottage/holiday-let-mortgages/#offset-the-interest-on-your-mortgage                            |
	| /letyourcottage/how-to-run-your-holiday-let/#furnishing-my-property                                    |
	| /letyourcottage/how-to-run-your-holiday-let/#booking-dates-for-my-own-use                              |
	| /letyourcottage/how-to-run-your-holiday-let/#running-my-holiday-let                                    |
	| /letyourcottage/tax-information-on-holiday-lets/#tax-implications                                      |
	| /letyourcottage/tax-information-on-holiday-lets/#Business-rates                                        |
	| /letyourcottage/tax-information-on-holiday-lets/#vat-registration                                      |
	| /letyourcottage/tax-information-on-holiday-lets/#council-tax                                           |
	| /letyourcottage/tax-information-on-holiday-lets/#reducing-tax-amount                                   |
	| https://showcase.sykescottages.co.uk/winter-22-23.html                                                 |
	| /blog/category/cottage-owners/                                                                         |
	| /terms/privacypolicy                                                                                   |
	| /terms/cookiepolicy                                                                                    |
	| /press-and-media.html                                                                                  |
	| /letyourcottage/holiday-homes-for-sale/                                                                |