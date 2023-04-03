Feature: TestBuilder
	Tests to help with writing more tests

@TestBuilder
Scenario: Get all headers on the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/letyourcottage
	Then I store all headers on the page

@TestBuilder
Scenario: Get all links on the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/letyourcottage/search/?searchTerm=th
	Then I store all links on the page

@TestBuilder
Scenario: Get all images on the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/letyourcottage
	Then I store all images on the page

@TestBuilder
Scenario: Get the header of the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/
	Then I store the header on the following pages
	| WebPage                                                                |
	| letyourcottage/information/about-us                                    |
	| letyourcottage/information/a-guide-to-buying-a-holiday-let             |
	| letyourcottage/information/are-holiday-homes-a-good-investment         |
	| letyourcottage/information/benefits-short-term-letting                 |
	| letyourcottage/information/building-holiday-let                        |
	| letyourcottage/information/buying-a-holiday-home                       |
	| letyourcottage/information/buy-own-sell-holiday-lets                   |
	| letyourcottage/information/capital-gains-tax                           |
	| letyourcottage/information/cottage-owner                               |
	| letyourcottage/information/damage-protection-terms                     |
	| letyourcottage/information/e-i-l                                       |
	| letyourcottage/information/expert-guide-to-advertise-your-holiday-home |
	| letyourcottage/information/farm-diversification-holiday-letting        |
	| letyourcottage/information/furnished-holiday-let-tax-guide             |
	| letyourcottage/information/holiday-chalet-letting-business             |
	| letyourcottage/information/holiday-cottage-rates                       |
	| letyourcottage/information/holiday-home-cleaning                       |
	| letyourcottage/information/holiday-home-finance                        |
	| letyourcottage/information/holiday-home-taxes                          |
	| letyourcottage/information/holiday-let-agency                          |
	| letyourcottage/information/holiday-let-business-success                |
	| letyourcottage/information/holiday-let-investment                      |
	| letyourcottage/information/holiday-let-marketing                       |
	| letyourcottage/information/holiday-let-mortgage-information            |
	| letyourcottage/information/holiday-let-mortgages                       |
	| letyourcottage/information/holiday-let-mortgages-a-complete-guide      |
	| letyourcottage/information/holiday-letting-getting-started             |
	| letyourcottage/information/holiday-letting-information                 |
	| letyourcottage/information/holiday-letting-rules                       |
	| letyourcottage/information/holiday-management-services                 |
	| letyourcottage/information/how-to-run-your-holiday-let                 |
	| letyourcottage/information/investment-advice-for-holiday-lets          |
	| letyourcottage/information/leading-holiday-let-agency                  |
	| letyourcottage/information/legal-regulations-for-holiday-lets          |
	| letyourcottage/information/letting-a-log-cabin                         |
	| letyourcottage/information/make-the-switch                             |
	| letyourcottage/information/marketing-your-holiday-let                  |
	| letyourcottage/information/n-t-l                                       |
	| letyourcottage/information/regulations-for-holiday-lets                |
	| letyourcottage/information/renting-out-your-property                   |
	| letyourcottage/information/run-holiday-let-as-business                 |
	| letyourcottage/information/running-your-holiday-let                    |
	| letyourcottage/information/shepherd-huts-for-holiday-lets              |
	| letyourcottage/information/Stamp-Duty-On-Holiday-Lets                  |
	| letyourcottage/information/Tax-information-on-holiday-lets             |
	| letyourcottage/information/t-o-b                                       |
	| letyourcottage/information/video-test-let-agency                       |
	| letyourcottage/information/welcome-gift                                |
	| letyourcottage/information/welcome-gift-terms                          |

@TestBuilder
Scenario: Build a test that checks all headers on the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/letyourcottage
	Then I store the headers and output a test script

@TestBuilder
Scenario: Build a test that checks all links on the page
	Given I am on the following webpage: https://sykes:1.sykes@lyp238dedicatedfaqpa.dev.sykescottages.co.uk/letyourcottage/holiday-let-owner-information/
	Then I store the links and output a test script

@TestBuilder
Scenario: Build a test that checks all images on the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/letyourcottage
	Then I store the images and output a test script