Feature: InformationCentre
	Information Centre page content and functionality

@InformationCentre
Scenario: The user can navigate to the "Advertising and marketing your holiday let" page
	Given I am on the Sykes Homepage
	When I click the 'Holiday homes for sale' header link under 'Let Your Property'
	And I click the 'Advertising and marketing your holiday let' header link under 'Information Centre'
	Then the 'Advertising and Marketing Your Holiday Let' page is displayed

@InformationCentre
Scenario: The user can navigate to the "Buying, owning and selling a holiday let" page
	Given I am on the Sykes Homepage
	When I click the 'Holiday homes for sale' header link under 'Let Your Property'
	And I click the 'Buying, owning and selling a holiday let' header link under 'Information Centre'
	Then the 'Buying, Owning & Selling a Holiday Let' page is displayed

@InformationCentre
Scenario: The user can navigate to the "Investment advice for holiday lets" page
	Given I am on the Sykes Homepage
	When I click the 'Holiday homes for sale' header link under 'Let Your Property'
	And I click the 'Investment advice for holiday lets' header link under 'Information Centre'
	Then the 'Investment in Holiday Homes | Holiday Let Business' page is displayed

@InformationCentre
Scenario: The user can navigate to the "Legal regulations for holiday lets" page
	Given I am on the Sykes Homepage
	When I click the 'Holiday homes for sale' header link under 'Let Your Property'
	And I click the 'Legal regulations for holiday lets' header link under 'Information Centre'
	Then the 'Legal Regulations for Holiday Lets' page is displayed

@InformationCentre
Scenario: The user can navigate to the "Holiday let mortgages" page
	Given I am on the Sykes Homepage
	When I click the 'Holiday homes for sale' header link under 'Let Your Property'
	And I click the 'Holiday let mortgages' header link under 'Information Centre'
	Then the 'Mortgages for Holiday Lets | Second Homes' page is displayed

@InformationCentre
Scenario: The user can navigate to the "How to run your holiday let" page
	Given I am on the Sykes Homepage
	When I click the 'Holiday homes for sale' header link under 'Let Your Property'
	And I click the 'How to run your holiday let' header link under 'Information Centre'
	Then the 'Running Your Holiday Let | Cost & Cleaning' page is displayed

@InformationCentre
Scenario: The user can navigate to the "Tax information on holiday lets" page
	Given I am on the Sykes Homepage
	When I click the 'Holiday homes for sale' header link under 'Let Your Property'
	And I click the 'Tax information on holiday lets' header link under 'Information Centre'
	Then the 'Tax Information for Holiday Homes | Rules & Relief' page is displayed