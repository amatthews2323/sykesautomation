Feature: Experiments
	Test specific experiments

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_OwnerIncentivePromotion18529
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18529
	Then the following elements are dislpayed on the page
		 | Element                                                                                                                              |
		 | List your property for a welcome gift of your choice                                                                                 |
		 | Sign your contract by 1st April 2022 and get your property taking bookings by 1st June 2022 to earn a welcome gift of your choice... |
		 | /letyourcottage/information/welcome-gift/                                                                                            |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_DisableEnquiryUntilValidInput18581
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18581
	Then the enquiry form submit button is disabled
	When I enter the following details in the enquiry form
		| Key           | Value                         |
		| Full name     | Test Owner                    |
		| Email address | sykescottagestest@example.org |
		| Phone number  | 07000000000                   |
	And I click form-heading-container
	Then the enquiry form submit button is not disabled

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_TestimonialsCarousel18584
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18584
	Then the Testimonials carousel is displayed on the page
	When I click /images/sykes/letyourcottage/icons/arrow-prev.svg

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_RemoveRequestYourOwnerPackCta18486
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18486
	Then the How Much Could I Earn CTA is not displayed
	And the Holiday Letting Made Easy CTA is not displayed

@ActiveExperiments
Scenario: Experiment LetYourCottages_InactivityExitModal18457
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18457
	Then I wait 305 seconds
	And the following elements are dislpayed on the page
	     | Element                  |
	     | idleform                 |
	     | We're ready when you are |
	     | Open form                |
	When I click Open form
	Then the following elements are dislpayed on the page
	     | Element                                   |
	     | inactive-form_first_name                  |
	     | inactive-form_first_name_validation_error |
	     | inactive-form_email                       |
	     | inactive-form_email_validation_error      |
	     | inactive-form_phone                       |
	     | inactive-form_phone_validation_error      |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_ProgressBar18576
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18576
	Then the following element is displayed on the page: progressbar

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_ManagedServicesBannerOnLYP18552
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18552
	Then the following elements are dislpayed on the page
	     | Element                                                            |
	     | hero-banner managed-services                                       |
	     | We tailor our managed service package to suit your specific needs. |
	     | /letyourcottage/managed-services/                                  |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_ReplaceIconsWithimages18585
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18585
	Then the following elements are dislpayed on the page
         | Element                                                             |
         | /images/let_your_cottage/letting_easy/market-leading.png            |
         | /images/let_your_cottage/letting_easy/payment_in_advance.png        |
         | /images/let_your_cottage/letting_easy/dedicated-account-manager.png |
         | /images/let_your_cottage/letting_easy/helpline-24h.png              |
         | /images/let_your_cottage/letting_easy/full-property-management.png  |
         | /images/let_your_cottage/letting_easy/photography.png               |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_RemoveAlreadyStartedLogin18580
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18580
	Then the following element is not displayed on the page: Already started?

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_ExtendedManagedServicesSectionLinkToTop18639
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18466
	And I apply the following experiment: 18639
	When I scroll to the following element: Partially managed
	And I select the Partially Managed Enquire Now button
	Then the enquiry form is displayed with the tint applied
	When I select the Fully Managed Enquire Now button
	Then the enquiry form is displayed with the tint applied

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_ExtendManagedServicesSection18466
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18466
	When I scroll to the following element: Partially managed
	Then the following elements are dislpayed on the page
         | Element                                                            |
         | What is the difference between partially managed service and fully |
         | Partially managed                                                  |
         | Fully managed                                                      |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_LoopingImageOnHero18461
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18461
	And I navigate to https://www.sykescottages.co.uk/letyourcottage/
	Then the following element is displayed on the page: hero-slideshow

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_CreateTextSupportEnquiry18460
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18460
	Then the following elements are dislpayed on the page
         | Element                          |
         | Please enter your full name      |
         | Please enter your email address  |
         | Please enter your contact number |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_RemoveSecondHeroCopy18494
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18494
	Then the following elements are not dislpayed on the page
		| Elements                                                                                                                            |
		| Let your property with Sykes and earn up to £125,000 per year*                                                                      |
		| As the UK’s leading independent holiday letting agency, we’re committed to getting you the best possible return from your property. |
		| *Based on a 7 bedroom property in the Lake District with bookings between October 2017 to September 2018.                           |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_ContrastAlertsOnLYP18473
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18473
	Then the following element is displayed on the page: c-alert c-alert--standard js-alert is-visible
	And the following elements are not dislpayed on the page
		| Elements                                |
		| o-icon c-alert__icon o-icon--size-large |
		| c-alert__cta cta_tint js-alert-close    |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_CalculatorInteraction18462
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18462
	Then the following element is displayed on the page: Please select your region
	When I select option South West from the region dropdown
	Then the following element is displayed on the page: homepage_calculator_cta_blue

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_RemoveAlertMessagesonLYP18458
	Given I have navigated to the following page without dismissing alerts: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18458
	Then the following elements are not dislpayed on the page
		| Element                              |
		| An owner has just completed the form |
		| A new property has just gone live    |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_MoveRegionalTestimonials18277
	Given I have navigated to the following page: letyourcottage/In-Your-Area/South-West/?dev_tools=product
	When I apply the following experiment: 18277
	Then the testimonials_region_pc section is displayed at position 2

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_SlowHeroTextAndAddInteraction18347
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18347
	Then the following slick dot is highlighted 1
	And I wait 12 seconds
	And the following slick dot is highlighted 2
	And I wait 10 seconds
	And the following slick dot is highlighted 3
	When I click holiday properties already working with Sykes
	Then the following slick dot is highlighted 4

@StoppedExperiments
Scenario: Experiment LetYourCottages_IncludeMultipleImages18474
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18474
	Then the following element is displayed on the page: platform-slider slick-initialized slick-slider

@StoppedExperiments
Scenario: Experiment LetYourCottages_RemoveSectionsFromLYP18292
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18292
	Then the following elements are not dislpayed on the page
		| Element                                |
		| Putting your property in the spotlight |
		| Are you thinking of buying             |
		| Back to Top                            |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ReferAFriend18136
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18136
	Then the following element is displayed on the page: Refer a friend

@StoppedExperiments
Scenario: Experiment LetYourCottages_InformationPageAlerts18281
	Given I have navigated to the following page without dismissing alerts: letyourcottage/information/marketing-your-holiday-let/?dev_tools=product
	When I apply the following experiment: 18281
	Then the following element is displayed on the page: c-alert c-alert--standard js-alert is-visible

@StoppedExperiments
Scenario: Experiment LetYourCottages_TOBAlertModal18279
	Given I have navigated to the following page without dismissing alerts: letyourcottage/holiday-homes-for-sale/?dev_tools=product
	When I apply the following experiment: 18279
	And I select the alert Get Started button
	And I select the close icon on the form
	Then the following element is displayed on the page: Enquire with Sykes today

@StoppedExperiments
Scenario: Experiment LetYourCottages_EnquiryFormCopyUpdate18283
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18283
	Then the following text is displayed on the page: Complete the form to receive your free information pack

@StoppedExperiments
Scenario: Experiment LetYourCottages_StaycationGuideDownload18066
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18066
	Then the following text is displayed on the page: Download the Sykes staycation index

@StoppedExperiments
Scenario: Experiment LetYourCottages_TestimonialRefocus18099
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18099
	Then the following elements are dislpayed on the page
         | Element                                                                             |
         | testimonial-slider                                                                  |
         | Sykes instilled a lot of confidence in us and now I wouldn’t use anybody else       |
         | Sykes have taken the stress out of us taking bookings, they are so professional     |
         | It is great working with Sykes - they are always available and they pay you quickly |
    And the following element is not displayed on the page: What do our owners say?

@StoppedExperiments
Scenario: Experiment LetYourCottages_AlternativeMethodsOfContact18065
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18065
	Then the following elements are dislpayed on the page
         | Element                          |
         | We're here to help               |
         | Get in touch                     |
         | Give us a call                   |
         | Enquire about letting with Sykes |

@StoppedExperiments
Scenario: Experiment LetYourCottages_PartnersInfoGraphic17791
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17791
	Then the following elements are dislpayed on the page
         | Element                    |
         | Expand your reach with our |
         | 700+ partner channels      |
         | airbnb logo                |
         | icelolly logo              |
         | vrbo logo                  |
         | expedia logo               |
         | tripadvisor logo           |

@StoppedExperiments
Scenario: Experiment LetYourCottages_RemoveWeAreStillOpen17921
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17921
    Then the following element is not displayed on the page: We are still open as usual

@StoppedExperiments
Scenario: Experiment LetYourCottages_AddingWebinars17805
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17805
	Then the following elements are dislpayed on the page
         | Element                                       |
         | Let the holiday experts answer your questions |
         | webinar-video                                 |
         | Listing with Sykes                            |
         | Watch more                                    |
         | Thinking of buying a property                 |
         | New to letting                                |

@StoppedExperiments
Scenario: Experiment LetYourCottages_SingleCTAWithinTheHero17973
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17973
    Then the following element is not displayed on the page: form-heading-container
    And the following elements are dislpayed on the page
         | Element                                                        |
         | Let your property with Sykes and earn up to £125,000 per year* |
         | Get started today                                              |

@StoppedExperiments
Scenario: Experiment LetYourCottages_PnoProcess17640
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17640
	Then the following elements are dislpayed on the page
         | Element                |
         | How to list with Sykes |
         | Request for contact    |
         | Self-service           |
         | Start taking bookings  |

@StoppedExperiments
Scenario: Experiment LetYourCottages_FullHeightHero17731
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17731
    Then the following element is displayed on the page: o-icon o-icon-down-full-hero

@StoppedExperiments
Scenario: Experiment LetYourCottages_RelaxedValidationEnquiry17573
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17573
    And I click submit
    Then the following element is not displayed on the page: Please enter a contact number.

@StoppedExperiments
Scenario: Experiment LetYourCottages_ChangeTextForm17977
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17977
	Then the following text is displayed on the page: Complete the form to begin your holiday letting journey

@StoppedExperiments
Scenario: Experiment LetYourCottages_FloatingActionButtonDesktopTablet17853
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17853
    And I set the window size to Tablet
	Then the following element is displayed on the page: Floating action button mobile

@StoppedExperiments
Scenario: Experiment LetYourCottages_AverageMonthlyIncomeProjection17432
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17432
	Then the following text is displayed on the page: Average monthly income

@HolmesExperiments
Scenario: Get all active experiments from Holmes
	Given I am accessing http://holmes.staging.sykes.cloud/experiments
	Then I store the experiment IDs

@HolmesExperiments
Scenario: Get all active experiments in a given session
	Given I have navigated to the following page: letyourcottage
	When I store the active experiment IDs
	Given I am accessing http://holmes.prod.sykes.cloud/experiments
	When I search for the experiment details

@HolmesExperiments
Scenario: Check specific experiments are applied
	Given I have navigated to the following page: letyourcottage
	When I store the active experiment IDs
	Then the following experiements are enabled
		| Example |
		| 4419    |
		| 4396    |
	And I wait 300 seconds