Feature: Subdomains
	Let Your Property subdomain content and functionality

@Subdomains
Scenario: The Sykes sub-domains are displayed correctly
	Given I am accessing <Subdomain>
	Then the following elements are dislpayed on the page
	| Element                   |
	| <Title>                   |
	| form-heading-container    |
	| partner                   |
	| Holiday letting made easy |
	| Request a free owner pack |
	Examples:
	| Subdomain                                                   | Title                    |
	| https://www.carbisbayholidays.co.uk/letyourcottage/         | Carbis Bay               |
	| https://www.coastandcountry.co.uk/letyourcottage/           | Coast & Country Cottages |
	| https://www.cornishcottageholidays.co.uk/letyourcottage/    | Cornish Cottage Holidays |
	| https://www.dream-cottages.co.uk/letyourcottage/            | Dream Cottages           |
	| https://www.heartofthelakes.co.uk/letyourcottage/           | Heart of the Lakes       |
	| https://www.helpfulholidays.co.uk/letyourcottage/           | Helpful Holidays         |
	| https://www.hogansirishcottages.com/letyourcottage/         | Hogans Irish Cottages    |
	| https://www.lakedistrictlodgeholidays.co.uk/letyourcottage/ | Lake District            |
	| https://www.lakescottageholiday.co.uk/letyourcottage/       | Lakes Cottage Holidays   |
	| https://www.lakelovers.co.uk/letyourcottage/                | Lakelovers               |
	| https://www.manorcottages.co.uk/letyourcottage/             | Manor Cottages           |
	| https://www.menaiholidays.co.uk/letyourcottage/             | Menai Holiday Cottages   |
	| https://www.welsh-cottages.co.uk/letyourcottage/            | Welsh Cottage            |
	| https://www.yorkshirecoastalcottages.com/cottage-owners/    | Yorkshire Coastal        |