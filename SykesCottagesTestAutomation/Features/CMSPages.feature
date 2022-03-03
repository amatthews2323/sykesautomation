Feature: CMSPages
	Content Managed page content and functionality

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

@InformationCentre @ProductionRegressionSuite
Scenario: The relevent elements are present on the Information Centre pages
	Given I have navigated to the following page: <Path>
	Then the following elements are dislpayed on the page
    | Element                           |
    | form-heading-container            |
    | <Header>                          |
    | Are you thinking of buying?       |
    | How much could I earn with Sykes? |
	Examples:
	| Path                                              | Header                                     |
	| letyourcottage/marketing-your-holiday-let         | Advertising and marketing your holiday let |
	| letyourcottage/buy-own-sell-holiday-lets          | Buying, owning and selling a holiday let   |
	| letyourcottage/investment-advice-for-holiday-lets | Investment advice for holiday lets         |
	| letyourcottage/legal-regulations-for-holiday-lets | Legal regulations for holiday lets         |
	| letyourcottage/holiday-let-mortgages              | Holiday let mortgages                      |
	| letyourcottage/how-to-run-your-holiday-let        | How to run your holiday let                |
	| letyourcottage/Tax-information-on-holiday-lets    | Tax information on holiday lets            |

@ManagedServices @ProductionRegressionSuite
Scenario: The relevent elements are present on the Managed Services page
	Given I have navigated to the following page: letyourcottage/managed-services
    Then the following elements are dislpayed on the page
         | Element                   |
         | Holiday home management   |
         | hero-slideshow            |
         | form-heading-container    |
         | Managed services at Sykes |
         | What are the benefits     |
         | Partially managed         |
         | Fully managed             |
         | Resource centre           |
         | Share page                |