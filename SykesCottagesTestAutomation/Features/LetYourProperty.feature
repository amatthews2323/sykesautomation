Feature: LetYourProperty
	Let Your Property page content and functionality

@LetYourProperty
Scenario: Assert that the user can navigate to the Let Your Property page
	Given I am on the Sykes Homepage
	When I click the Let your property button
	Then the Let Your Property page is diplayed

@LetYourProperty
Scenario: Assert that the Let Your Property page loads
	Given I have navigated to the Let Your Property page
	Then the Let Your Property page is diplayed

@LetYourProperty @EnquiryForm
Scenario: Assert that the enquiry form is displayed
	Given I have navigated to the Let Your Property page
	Then the enquiry form is displayed