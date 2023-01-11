Feature: OtherPages
	Holiday Homes for Sale and Manged Services page content and functionality

@HolidayHomesForSale @LYPSmokeTest @LYPRegressionSuite
Scenario: The relevent elements are present on the Holiday Homes for Sale page
	Given I have navigated to the following page: letyourcottage/holiday-homes-for-sale
    Then the following page title is displayed: Holiday Homes for Sale UK | Holiday Let Business for Sale

@ManagedServices @LYPSmokeTest @LYPRegressionSuite
Scenario: The relevent elements are present on the Managed Services page
	Given I have navigated to the following page: letyourcottage/managed-services
    Then the relevant elements are dislpayed
         | Element                   |
         | Holiday home management   |
         | hero-slideshow            |
         | c-lyc-form                |
         | Managed services at Sykes |
         | What are the benefits     |
         | Partially managed         |
         | Fully managed             |
         | Resource centre           |
         | Share page                |