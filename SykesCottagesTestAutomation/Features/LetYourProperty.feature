Feature: LetYourProperty
	Let Your Property page content and functionality

@LetYourProperty
Scenario: The user can navigate to the Let Your Property page
	Given I am on the Sykes Homepage
	When I click the 'Let Your Property' link
	Then the Let Your Property page is displayed

@LetYourProperty
Scenario: The enquiry form is displayed
	Given I have navigated to the 'letyourcottage' page
	Then the enquiry form is displayed

@LetYourProperty
Scenario: The relevant page sections are displayed
	Given I have navigated to the 'letyourcottage' page
	Then the following sections are dislpayed
	| Section                                  |
	| Gain exposure through our partners       |
	| How much could I earn letting with Sykes |
	| What do our owners say                   |
	| Holiday letting made easy                |
	| Request your free owner information pack |
	| Are you thinking of buying               |

@LetYourProperty @Enquiry
Scenario: The user can submit their details
	Given I have navigated to the 'letyourcottage' page
	When I enter my details on the enquiry form
	| Key           | Value                         |
	| Full name     | Test Owner                    |
	| Email address | sykescottagestest@example.org |
	| Phone number  | 07000000000                   |
	And I click the Get Started button
	Then I am directed to the Property Letting Dashboard page

@LetYourProperty @Subdomains
Scenario: The Sykes sub-domains are displayed correctly
	Given I am accessing <Subdomain>
	Then the following text is displayed on the page: <Title>
	And the enquiry form is displayed
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