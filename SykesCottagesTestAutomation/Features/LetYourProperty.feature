Feature: LetYourProperty
	Let Your Property page content and functionality

@Navigation
Scenario: The user can navigate to the Let Your Property page
	Given I am on the Sykes Homepage
	When I click Let Your Property
	Then the following page title is displayed: Holiday Letting Agents For Cottages, Holiday Homes & Property

@LetYourProperty @ProductionRegressionSuite
Scenario: The enquiry form is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following element is displayed on the page: form-heading-container

@LetYourProperty @ProductionRegressionSuite
Scenario: The transparent header is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following element is displayed on the page: nav_top u-clearfix nav_top_17485

@LetYourProperty @ProductionRegressionSuite
Scenario: The floating action button is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	When I scroll to the following element: page-footer container_sykes_grid
	Then the following element is displayed on the page: Back To Top Button

@LetYourProperty @ProductionRegressionSuite
Scenario: The relevant validation is in place on the enquiry form
	Given I have navigated to the following page: letyourcottage
	When I submit the enquiry form
	Then the following elements are dislpayed on the page
	| Element                        |
	| Please enter a full name.      |
	| Please enter an email address. |
	| Please enter a contact number. |
	When I enter an email address without an @ symbol
	And I submit the enquiry form
	Then the following text is displayed on the page: 'test.com' is missing an '@'. Please include an '@' in the email address.
	When I enter an email address without a valid domain
	And I submit the enquiry form
	Then the following text is displayed on the page: 'test@test' is an incomplete email address. Please include e.g. '.com', '.co.uk', '.net'.
	When I enter a phone number with a non-numerical character
	And I submit the enquiry form
	Then the following text is displayed on the page: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	When I enter a phone number with less than 10 digits
	And I submit the enquiry form
	Then the following text is displayed on the page: Please provide a contact number that is no less than 10 digits long.
	When I enter a phone number with more than 15 digits
	And I submit the enquiry form
	Then the following text is displayed on the page: Please provide a contact number that is no more than 15 digits long.

@LetYourProperty @ProductionRegressionSuite
Scenario: The relevant sections are displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following sections are dislpayed
	| Section                                      |
	| Gain exposure through our partners           |
	| What do our owners say                       |
	| How much could I earn                        |
	| We are still open as usual                   |
	| Holiday home management with Sykes           |
	| Putting your property in the spotlight       |
	| Holiday letting made easy                    |
	| Request your free owner information pack     |
	| Looking to get started with holiday letting? |

#@LetYourProperty @ProductionRegressionSuite
Scenario: The page sections are displayed is the correct order
	Given I have navigated to the following page: letyourcottage
	Then the <Section> section is displayed at position <Position>
	Examples:
	| Section                                                | Position |
	| Gain exposure through our partners                     | 3        |
	| What do our owners say?                                | 4        |
	| How can Sykes elevate your holiday letting experience? | 5        |
	| How much could I earn                                  | 6        |
	| Holiday home management with Sykes                     | 7        |
	| Putting your property in the spotlight                 | 8        |
	| Holiday letting made easy                              | 9        |
	| Are you thinking of buying                             | 10       |
	| Request your free owner information pack               | 11       |

@ThinkingOfBuying @ProductionRegressionSuite
Scenario: The Thinking of Buying Guide section is displayed on the Let Your Property page
	Given I have navigated to the following page: letyourcottage
	Then the following elements are dislpayed on the page
         | Element                                      |
         | Looking to get started with holiday letting? |
         | Explore guides & resources                   |
	When I click /letyourcottage/advice
	Then the following page title is displayed: Buying a Holiday Let Information Centre | Sykes Holiday Cottages

@MobileApp @ProductionRegressionSuite
Scenario: The relevant sections are displayed on the Mobile App homepage
	Given I have navigated to the following page: letyourcottage/?app_view=true
	When I set the window size to Mobile
	Then the following sections are dislpayed
	| Section                                      |
	| Gain exposure through our partners           |
	| What do our owners say                       |
	| How much could I earn                        |
	| We are still open as usual                   |
	| Holiday home management with Sykes           |
	| Putting your property in the spotlight       |
	| Holiday letting made easy                    |
	| Request your free owner information pack	   |
	| Looking to get started with holiday letting? |
	And the following elements are not dislpayed on the page
	| Element                          |
	| contact-to-book mobile           |
	| navbar-toggle collapsed          |