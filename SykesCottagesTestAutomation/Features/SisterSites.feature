﻿Feature: SisterSites
	Sister sites content and functionality

@SisterBrands @LYPRegressionSuite
Scenario: The Sister Brands are displayed correctly
	Given I have navigated to the following brand: <Brand>
	Then the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                                   |
	| first_name                                                                                                |
	| last_name                                                                                                 |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| /terms/privacypolicy                                                                                      |
	When I click //*[@*='enquiry-multi-step']/button[@*='submit']
	Then the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                      |
	| Please enter your first name |
	| Please enter your surname    |	
	When I enter Test in the following form field: //*[@*='enquiry-multi-step']//input[@*='first_name']
	And I enter Owner in the following form field: //*[@*='enquiry-multi-step']//input[@*='last_name']
	#And I wait 1 seconds
	And I click //*[@*='enquiry-multi-step']/button[@*='submit']
	Then the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                           |
	| In order to receive email communications from our expert team, please provide your email address. |
	| Email address                                                                                     |
	#When I wait 1 seconds
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the following text is displayed: Please enter an email address
	When I enter sykescottages.co.uk in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	#And I wait 1 seconds
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the following text is displayed: 'sykescottages.co.uk' is missing an '@'. Please include an '@' in the email address.
	When I enter testowner@sykescottages in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	#And I wait 1 seconds
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the following text is displayed: 'testowner@sykescottages' is an incomplete email address. Please include e.g. '.com', '.co.uk', '.net'.
	When I enter testowner@sykescottages.co.uk in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	#And I wait 3 seconds
	And I try clicking //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	And I try clicking //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the relevant elements are dislpayed
	| Element                                                                                                                                             |
	| To allow our holiday letting advisors to contact you by phone (including an initial call regarding your enquiry), please provide your phone number. |
	| Phone number                                                                                                                                        |
	#When I wait 1 seconds
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	Then the following text is displayed: Please enter a contact number
	When I enter 070000000 in the following form field: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
	#And I wait 1 seconds
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	Then the following text is displayed: Please provide a contact number that is no less than 10 digits long.
	When I enter 0700000000000000 in the following form field: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
	#And I wait 1 seconds
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	Then the following text is displayed: Please provide a contact number that is no more than 15 digits long.
	When I enter +44 7000 000 000 in the following form field: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
	And I click //*[@*='enquiry-form-step3']//*[@*='Close modal']
##	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
##	Then the relevant elements are dislpayed
##	| Element                                                                                                   |
##	| Please ensure the following details are correct                                                           |
##	| Your details will be used by the Sykes group to send you information about our property letting services. |
##	| Submit enquiry                                                                                            |
##	And I click //*[@*='enquiry-form-step4']/*[@*='close-modal']
	Examples:
	| Brand                                |
	| Best Escapes                         |
	| Best of Suffolk                      |
	| Carbis Bay Holidays                  |
	| Character Cottages                   |
	| Coast & Country Cottages             |
	| Coast & Country Holidays             |
	| Cornish Cottage Holidays             |
	| Dream Cottages                       |
	| Heart of the Lakes                   |
	| Helpful Holidays                     |
	| Hogans Irish Cottages                |
	| John Bray Cornish Holidays           |
	| Lake District Lodge Holidays         |
	| Lakelovers                           |
	| Lakes Cottage Holidays               |
	| Large Holiday Houses                 |
	| Lyme Bay Holidays                    |
	| Manor Cottages                       |
	| Menai Holiday Cottages               |
	| Northumbria Coast & Country Cottages |
	| Yorkshire Coastal                    |

@SisterBrands @FormSubmission
Scenario: The Sister Brand MultiStep form can be submitted
	Given I have navigated to the following brand: <Brand>
	And I am not on the Live environment
	Then the following text is displayed: Start your  holiday letting journey today
	And the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                                   |
	| first_name                                                                                                |
	| last_name                                                                                                 |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| /terms/privacypolicy                                                                                      |
	When I enter Region in the following form field: //*[@*='enquiry-multi-step']//input[@*='first_name']
	And I enter BrandTest001 in the following form field: //*[@*='enquiry-multi-step']//input[@*='last_name']
	And I click //*[@*='enquiry-multi-step']/button[@*='submit']
	Then the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                           |
	| In order to receive email communications from our expert team, please provide your email address. |
	| Email address                                                                                     |
	When I wait up to 2 seconds for the following to be displayed: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I enter regionbrandtest001@sykescottages.co.uk in the following form field: //*[@*='enquiry-multi-step' and @data-step='2']//input[@*='email']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	And I click //*[@*='enquiry-multi-step' and @data-step='2']/button[@*='submit']
	Then the relevant elements are dislpayed
	| Element                                                                                                                                             |
	| To allow our holiday letting advisors to contact you by phone (including an initial call regarding your enquiry), please provide your phone number. |
	| Phone number                                                                                                                                        |
	When I wait up to 3 seconds for the following to be displayed: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
	And I enter 06484548454 in the following form field: //*[@*='enquiry-multi-step' and @data-step='3']//input[@*='phone']
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	And I click //*[@*='enquiry-multi-step' and @data-step='3']/button[@*='submit']
	Then the relevant elements are dislpayed
	| Element                                                                                                   |
	| Please ensure the following details are correct                                                           |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| Submit enquiry                                                                                            |
	When I wait up to 2 seconds for the following to be displayed: //*[@*='enquiry-multi-step' and @data-step='5']/button[@*='submit']
	And I try clicking No, but I'm thinking of buying
	And I click //*[@*='enquiry-multi-step' and @data-step='5']/button[@*='submit']
	And I click //*[@*='enquiry-multi-step' and @data-step='5']/button[@*='submit']
	And I wait up to 5 seconds for the following to be displayed: Thank you for your enquiry
	Then the following page title is displayed: Thank you for your enquiry | Sykes Cottages
	Examples:
	| Brand                                |
	| Best Escapes                         |
	| Best of Suffolk                      |
	| Carbis Bay Holidays                  |
	| Character Cottages                   |
	| Coast & Country Cottages             |
	| Coast & Country Holidays             |
	| Cornish Cottage Holidays             |
	| Dream Cottages                       |
	| Heart of the Lakes                   |
	| Helpful Holidays                     |
	| Hogans Irish Cottages                |
	| John Bray Cornish Holidays           |
	| Lake District Lodge Holidays		   |
	| Lakelovers                           |
	| Lakes Cottage Holidays               |
	| Large Holiday Houses                 |
	| Lyme Bay Holidays                    |
	| Manor Cottages                       |
	| Menai Holiday Cottages               |
	| Northumbria Coast & Country Cottages |
	| Yorkshire Coastal                    |