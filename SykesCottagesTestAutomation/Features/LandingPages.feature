Feature: LandingPages
	Landing pages content and functionality

@LandingPages @ProductionRegressionSuite
Scenario: The Landing pages are displayed correctly
	Given I have navigated to the following page: <Path>
	Then the following elements are dislpayed on the page
	| Element                                   |
	| <Title>                                   |
	| form-heading-container                    |
	| Reading time                              |
	| Download your free owner information pack |
	Examples:
	| Path                                                                | Title                                                                     |
	| letyourcottage/information/run-holiday-let-as-business              | How to Run a Holiday Let as a Business                                    |
	| letyourcottage/information/leading-holiday-let-agency               | Why You Should Let Your Property With The Leading Holiday Lettings Agency |
	| letyourcottage/information/holiday-management-services              | How Sykes Can Manage Your Holiday Home                                    |
