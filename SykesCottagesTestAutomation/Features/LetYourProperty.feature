Feature: LetYourProperty
	Let Your Property page content and functionality

@Experiment
Scenario: The user can access the specified experiment
	Given I have navigated to the Let Your Property Dev Tools page
	When I click the 'Dev Tools' link
	And I select the following experiments '17282'
	##Then the experiment is applied

@LetYourProperty
Scenario: The user can navigate to the Let Your Property page
	Given I am on the Sykes Homepage
	When I click the 'Let Your Property' link
	Then the Let Your Property page is displayed

@LetYourProperty
Scenario: The enquiry form is displayed
	Given I have navigated to the Let Your Property page
	Then the enquiry form is displayed

@LetYourProperty
Scenario: The user can submit their details
	Given I have navigated to the Let Your Property page
	When I enter my details on the enquiry form
	| Key           | Value                         |
	| Full name     | Test Owner                    |
	| Email address | sykescottagestest@example.org |
	| Phone number  | 07000000000                   |
	And I click the Get Started button
	Then I am directed to the Property Letting Dashboard page