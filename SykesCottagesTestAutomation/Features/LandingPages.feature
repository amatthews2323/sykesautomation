Feature: LandingPages
	Landing pages content and functionality

@LandingPages
Scenario: The Landing pages are displayed correctly
	Given I have navigated to the following page: <Path>
	Then the following text is displayed on the page: <Title>
	And the following elements are dislpayed on the page
	| Element                                   |
	| form-heading-container                    |
	| Reading time                              |
	| Download your free owner information pack |
	Examples:
	| Path                                                                | Title                                                                     |
	| letyourcottage/information/run-holiday-let-as-business              | How to Run a Holiday Let as a Business                                    |
	| letyourcottage/information/leading-holiday-let-agency               | Why You Should Let Your Property With The Leading Holiday Lettings Agency |
	| letyourcottage/information/holiday-management-services              | How Sykes Can Manage Your Holiday Home                                    |
	| letyourcottage/information/why-become-a-sykes-holiday-cottage-owner | Why You Should Become a Sykes Holiday Cottage Owner                       |
