Feature: LandingPages
	Landing pages content and functionality

@LandingPages @LYPSmokeTest @LYPRegressionSuite
Scenario: The Landing pages are displayed correctly
	Given I have navigated to the following page: <Path>
	Then the relevant elements are dislpayed
	| Element                                   |
	| <Title>                                   |
	| c-lyc-form                                |
	| Back To Top                               |
	Examples:
	| Path                                                                | Title                                                                     |
	| letyourcottage/information/run-holiday-let-as-business              | How to Run a Holiday Let as a Business                                    |
	| letyourcottage/information/leading-holiday-let-agency               | Why You Should Let Your Property With The Leading Holiday Lettings Agency |
	| letyourcottage/information/holiday-management-services              | How Sykes Can Manage Your Holiday Home                                    |