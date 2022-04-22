Feature: ThinkingOfBuying
	Thinking of Buying page content and functionality

@ThinkingOfBuying
Scenario: The relevant sections are displayed on the Thinking of Buying page
	Given I have navigated to the following page: letyourcottage/advice
	Then the following elements are dislpayed on the page
	| Element                                  |
	| Holiday Let Information Centre           |
	| Browse categories                        |
	| Beginner Guides to Buying a Holiday Home |
	| Latest Guides and Articles               |
	| Services and Tools                       |
	| Making a Fresh Start                     |
	| Contact us                               |