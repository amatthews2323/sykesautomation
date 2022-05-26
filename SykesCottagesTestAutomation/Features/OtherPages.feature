﻿Feature: OtherPages
	Holiday Homes for Sale and Manged Services page content and functionality

@HolidayHomesForSale @SmokeTest
Scenario: The relevent elements are present on the Holiday Homes for Sale page
	Given I have navigated to the following page: letyourcottage/holiday-homes-for-sale
	Then the following elements are dislpayed
         | Element                           |
         | Holiday Homes for Sale UK         |
         | container_sykes_grid              |
         | View more holiday homes for sale  |
         | How much could I earn with Sykes? |
         | c-alert__icon-wrap                |
         | Enquire with Sykes today          |
         | Get started                       |

@HolidayHomesForSale @RegressionSuite @EnquiryForm
Scenario: The enquiry form is displayed on the Holiday Homes for Sale page
	Given I have navigated to the following page: letyourcottage/holiday-homes-for-sale
    When I click View property
    Then the following elements are dislpayed
         | Element                        |
         | Find your perfect holiday home |
         | Select a region                |
    When I select option All regions from the region dropdown
    And I click Next
    Then the following elements are dislpayed
         | Element                                                                                           |
         | hhfs_overlay                                                                                      |
         | hhfs_overlay_first_name                                                                           |
         | hhfs_overlay_first_name_validation_error                                                          |
         | hhfs_overlay_email                                                                                |
         | hhfs_overlay_email_validation_error                                                               |
         | hhfs_overlay_phone                                                                                |
         | hhfs_overlay_phone_validation_error                                                               |
         | Your details will be stored and used to send you information about our property letting services. |
         | /terms/privacypolicy                                                                              |
         | submit                                                                                            |

@ManagedServices @SmokeTest
Scenario: The relevent elements are present on the Managed Services page
	Given I have navigated to the following page: letyourcottage/managed-services
    Then the following elements are dislpayed
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