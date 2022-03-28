Feature: OtherPages
	Holiday Homes for Sale and Manged Services page content and functionality

@HolidayHomesForSale @ProductionRegressionSuite @RegressionSmokeTest
Scenario: The relevent elements are present on the Holiday Homes for Sale page
	Given I have navigated to the following page: letyourcottage/holiday-homes-for-sale
	Then the following elements are dislpayed on the page
         | Element                           |
         | Holiday Homes for Sale UK         |
         | container_sykes_grid              |
         | View more holiday homes for sale  |
         | How much could I earn with Sykes? |
         | c-alert__icon-wrap                |
         | Enquire with Sykes today          |
         | Get started                       |

@ManagedServices @ProductionRegressionSuite @RegressionSmokeTest
Scenario: The relevent elements are present on the Managed Services page
	Given I have navigated to the following page: letyourcottage/managed-services
    Then the following elements are dislpayed on the page
         | Element                   |
         | Holiday home management   |
         | hero-slideshow            |
         | form-heading-container    |
         | Managed services at Sykes |
         | What are the benefits     |
         | Partially managed         |
         | Fully managed             |
         | Resource centre           |
         | Share page                |