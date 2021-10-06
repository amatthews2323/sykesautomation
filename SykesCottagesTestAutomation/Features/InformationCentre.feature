Feature: InformationCentre
	Information Centre page content and functionality

@InformationCentre
Scenario: The user can navigate to the Information Centre pages
	Given I am on the Sykes Homepage
	When I click the 'Holiday homes for sale' navigation link under 'Let Your Property'
	And I click the '<Link>' navigation link under 'Information Centre'
	Then the '<PageTitle>' page is displayed
	Examples:
	| Link                                       | PageTitle                                           |
	| Advertising and marketing your holiday let | Advertising and Marketing Your Holiday Let          |
	| Buying, owning and selling a holiday let   | Buying, Owning & Selling a Holiday Let              |
	| Investment advice for holiday lets         | Investment in Holiday Homes \| Holiday Let Business |
	| Legal regulations for holiday lets         | Legal Regulations for Holiday Lets                  |
	| Holiday let mortgages                      | Mortgages for Holiday Lets \| Second Homes          |
	| How to run your holiday let                | Running Your Holiday Let \| Cost & Cleaning         |
	| Tax information on holiday lets            | Tax Information for Holiday Homes \| Rules & Relief |