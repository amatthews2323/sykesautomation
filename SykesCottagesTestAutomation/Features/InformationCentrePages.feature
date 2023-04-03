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

@InformationCentre @LYPSmokeTest @LYPRegressionSuite
Scenario: The relevent elements are present on the Information Centre pages
	Given I have navigated to the following page: <Path>
	When I wait up to 10 seconds for the following to be displayed: Customer reviews powered by Trustpilot
	Then the relevant elements are dislpayed
    | Element                                |
    | <Header>                               |
    | hero__image                            |
    | Customer reviews powered by Trustpilot |
    | How much could I earn with Sykes?      |
	Examples:
	| Path                                                                   | Header                                                         |
	| letyourcottage/information/about-us                                    | About Sykes Holiday Cottages                                   |
	| letyourcottage/information/a-guide-to-buying-a-holiday-let             | A Guide to Buying a Holiday Let                                |
	| letyourcottage/information/are-holiday-homes-a-good-investment         | Why Now is a Good Time to Invest in a Holiday Let              |
	| letyourcottage/information/benefits-short-term-letting                 | Benefits of Short Term Holiday Letting                         |
	| letyourcottage/information/building-holiday-let                        | Building a Holiday Let                                         |
	| letyourcottage/information/buying-a-holiday-home                       | Buying a Holiday Home                                          |
	| letyourcottage/information/buy-own-sell-holiday-lets                   | Buying, owning and selling a holiday let                       |
	| letyourcottage/information/capital-gains-tax                           | Do I have to pay Capital Gains Tax on a Furnished Holiday Let? |
	| letyourcottage/information/cottage-owner                               | Are you a holiday cottage owner?                               |
	| letyourcottage/information/damage-protection-terms                     | Damage Protection Guarantee Terms                              |
	| letyourcottage/information/e-i-l                                       | Do you want to earn more from your holiday let?                |
	| letyourcottage/information/expert-guide-to-advertise-your-holiday-home | Our Expert Guide to Advertising Your Holiday Home              |
	| letyourcottage/information/farm-diversification-holiday-letting        | Farm Diversification and Holiday Letting                       |
	| letyourcottage/information/furnished-holiday-let-tax-guide             | Tax information on holiday lets                                |
	| letyourcottage/information/holiday-chalet-letting-business             | Holiday Chalet Letting Business                                |
	| letyourcottage/information/holiday-cottage-rates                       | What rates of taxes do I need to pay on my holiday cottage?    |
	| letyourcottage/information/holiday-home-cleaning                       |                                                                |
	| letyourcottage/information/holiday-home-finance                        |                                                                |
	| letyourcottage/information/holiday-home-taxes                          |                                                                |
	| letyourcottage/information/holiday-let-agency                          |                                                                |
	| letyourcottage/information/holiday-let-business-success                |                                                                |
	| letyourcottage/information/holiday-let-investment                      |                                                                |
	| letyourcottage/information/holiday-let-marketing                       |                                                                |
	| letyourcottage/information/holiday-let-mortgage-information            |                                                                |
	| letyourcottage/information/holiday-let-mortgages                       | Holiday let mortgages                                          |
	| letyourcottage/information/holiday-let-mortgages-a-complete-guide      |                                                                |
	| letyourcottage/information/holiday-letting-getting-started             |                                                                |
	| letyourcottage/information/holiday-letting-information                 |                                                                |
	| letyourcottage/information/holiday-letting-rules                       |                                                                |
	| letyourcottage/information/holiday-management-services                 |                                                                |
	| letyourcottage/information/how-to-run-your-holiday-let                 | How to run your holiday let                                    |
	| letyourcottage/information/investment-advice-for-holiday-lets          | Investment advice for holiday lets                             |
	| letyourcottage/information/leading-holiday-let-agency                  |                                                                |
	| letyourcottage/information/legal-regulations-for-holiday-lets          | Legal regulations for holiday lets                             |
	| letyourcottage/information/letting-a-log-cabin                         |                                                                |
	| letyourcottage/information/make-the-switch                             |                                                                |
	| letyourcottage/information/marketing-your-holiday-let                  | Advertising and Marketing                                      |
	| letyourcottage/information/n-t-l                                       |                                                                |
	| letyourcottage/information/regulations-for-holiday-lets                |                                                                |
	| letyourcottage/information/renting-out-your-property                   |                                                                |
	| letyourcottage/information/run-holiday-let-as-business                 |                                                                |
	| letyourcottage/information/running-your-holiday-let                    |                                                                |
	| letyourcottage/information/shepherd-huts-for-holiday-lets              |                                                                |
	| letyourcottage/information/Stamp-Duty-On-Holiday-Lets                  |                                                                |
	| letyourcottage/information/Tax-information-on-holiday-lets             | Tax information on holiday lets                                |
	| letyourcottage/information/t-o-b                                       |                                                                |
	| letyourcottage/information/video-test-let-agency                       |                                                                |
	| letyourcottage/information/welcome-gift                                |                                                                |
	| letyourcottage/information/welcome-gift-terms                          |                                                                |