Feature: RegionPages
	Region Centre page content and functionality

@RegionPages
Scenario: The Regional pages are displayed correctly
	Given I have navigated to the <Path> page
	Then the following text is displayed on the page: <Region>
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