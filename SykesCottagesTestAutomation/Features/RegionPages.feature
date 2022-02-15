Feature: RegionPages
	Region pages content and functionality

@RegionPages @ProductionRegressionSuite
Scenario: The Regional pages are displayed correctly
	Given I have navigated to the following page: <Path>
	Then the following text is displayed on the page: <Region>
	And the following element is displayed on the page: form-heading-container
	Examples:
	| Path                                                      | Region                     |
	| letyourcottage/In-Your-Area/South-West                    | South West                 |
	| letyourcottage/In-Your-Area/South-of-England              | South of England           |
	| letyourcottage/In-Your-Area/Heart-of-England              | Heart of England           |
	| letyourcottage/In-Your-Area/East-Anglia                   | East Anglia                |
	| letyourcottage/In-Your-Area/Peak-District                 | Peak District              |
	| letyourcottage/In-Your-Area/North-York-Moors-and-Coast    | North York Moors and Coast |
	| letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria | Lake District and Cumbria  |
	| letyourcottage/In-Your-Area/Northumberland                | Northumberland             |
	| letyourcottage/In-Your-Area/Wales                         | Wales                      |
	| letyourcottage/In-Your-Area/Ireland                       | Ireland                    |
	| letyourcottage/In-Your-Area/Scotland                      | Scotland                   |

@Navigation
Scenario: The user can navigate to the Region pages
	Given I am on the Sykes Homepage
	When I select the Holiday homes for sale navigation link under Let Your Property
	And I select the <Link> navigation link under Your Location
	Then the following page title is displayed: <PageTitle>
	Examples:
	| Link                       | PageTitle                                                         |
	| South West                 | South West Holiday Letting Agents \| Sykes Cottages               |
	| South of England           | South of England Holiday Letting Agents \| Sykes Cottages         |
	| Heart of England           | Heart of England Holiday Letting Agents \| Sykes Cottages         |
	| East Anglia                | Norfolk and Suffolk Holiday Letting Agents \| Sykes Cottages      |
	| Peak District              | Peak District Holiday Letting Agents \| Sykes Cottages            |
	| North York Moors and Coast | Yorkshire Moors & Coast Holiday Letting Agents \| Sykes           |
	| Lake District and Cumbria  | Lake District & Cumbria Holiday Letting Agents \| Sykes           |
	| Northumberland             | Northumberland Holiday Letting Agents \| Sykes Cottages           |
	| Wales                      | Wales Holiday Letting Agents \| Welsh Holiday Lets \| Sykes       |
	| Ireland                    | Ireland Holiday Letting Agents \| Irish Holiday Lets \| Sykes     |
	| Scotland                   | Scotland Holiday Letting Agents \| Scottish Holiday Lets \| Sykes |