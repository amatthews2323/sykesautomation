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
	When I wait 3 seconds
	Then the relevant elements are dislpayed
    | Element                                |
    | form-heading-container                 |
    | <Header>                               |
    | hero__image                            |
    | Customer reviews powered by Trustpilot |
    | How much could I earn with Sykes?      |
    | Estimated earnings                     |
	When I scroll to the following element: page-footer
	Then the following element is displayed: floatingactionbutton
	Examples:
	| Path                                                          | Header                                   |
	| letyourcottage/information/marketing-your-holiday-let         | Advertising and Marketing                |
	| letyourcottage/information/buy-own-sell-holiday-lets          | Buying, owning and selling a holiday let |
	| letyourcottage/information/investment-advice-for-holiday-lets | Investment advice for holiday lets       |
	| letyourcottage/information/legal-regulations-for-holiday-lets | Legal regulations for holiday lets	   |
	| letyourcottage/information/holiday-let-mortgages              | Holiday let mortgages                    |
	| letyourcottage/information/how-to-run-your-holiday-let        | How to run your holiday let              |
	| letyourcottage/information/Tax-information-on-holiday-lets    | Tax information on holiday lets          |