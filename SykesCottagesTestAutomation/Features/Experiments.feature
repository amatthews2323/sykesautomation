Feature: Experiments
	Test specific experiments

@ActiveExperiments
Scenario: Experiment LetYourCottages_ContrastAlertsOnLYP18473
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18473
	Then the following element is displayed on the page: c-alert c-alert--standard js-alert is-visible
	And the following elements are not dislpayed on the page
		| Elements                                |
		| o-icon c-alert__icon o-icon--size-large |
		| c-alert__cta cta_tint js-alert-close    |

@ActiveExperiments
Scenario: Experiment LetYourCottages_InformationPageAlerts18281
	Given I have navigated to the following page: letyourcottage/information/marketing-your-holiday-let/?dev_tools=product
	When I apply the following experiment: 18281
	Then the following element is displayed on the page: c-alert c-alert--standard js-alert is-visible

@ActiveExperiments
Scenario: Experiment LetYourCottages_CalculatorInteraction18462
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18462
	Then the following element is displayed on the page: Please select your region
	When I select option South West from the region dropdown
	Then the following element is displayed on the page: homepage_calculator_cta_blue

@ActiveExperiments
Scenario: Experiment LetYourCottages_RemoveAlertMessagesonLYP18458
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18458
	Then the following elements are not dislpayed on the page
		| Element                              |
		| An owner has just completed the form |
		| A new property has just gone live    |

@ActiveExperiments
Scenario: Experiment LetYourCottages_MoveCalculatorControl18349
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18349
	Then the How much could I earn section is displayed at position 4

@ActiveExperiments
Scenario: Experiment LetYourCottages_MoveRegionalTestimonials18277
	Given I have navigated to the following page: letyourcottage/In-Your-Area/South-West/?dev_tools=product
	When I apply the following experiment: 18277
	Then the testimonials_region_pc section is displayed at position 2

@ActiveExperiments
Scenario: Experiment LetYourCottages_RemoveSectionsFromLYP18292
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18292
	Then the following elements are not dislpayed on the page
		| Element                                |
		| Putting your property in the spotlight |
		| Are you thinking of buying             |
		| Back to Top                            |

@ActiveExperiments
Scenario: Experiment LetYourCottages_EnquiryFormCopyUpdate18283
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18283
	Then the following text is displayed on the page: Complete the form to receive your free information pack

@ActiveExperiments
Scenario: Experiment LetYourCottages_TOBAlertModal18279
	Given I have navigated to the following page: letyourcottage/holiday-homes-for-sale/?dev_tools=product
	When I apply the following experiment: 18279
	And I select the alert Get Started button
	And I select the close icon on the form
	Then the following element is displayed on the page: Enquire with Sykes today

@ActiveExperiments
Scenario: Experiment LetYourCottages_RelaxingValidationEnquiry18282
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18282
	When I enter a phone number with spaces and +44
	And I submit the enquiry form
	Then the following element is not displayed on the page: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.

@ActiveExperiments
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

@ActiveExperiments
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

@ActiveExperiments
Scenario: Experiment LetYourCottages_TrustpilotFunctionUpdate18527
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18527
	Then the following element is displayed on the page: Customer reviews powered by Trustpilot
	When I click Customer reviews powered by Trustpilot
	Then the following page title is displayed: Holiday Letting Agents For Cottages, Holiday Homes & Property

@ActiveExperiments
Scenario: Experiment LetYourCottages_ReferAFriend18136
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18136
	Then the following element is displayed on the page: Refer a friend

@DisabledExperiments
Scenario: Experiment LetYourCottages_StaycationGuideDownload18066
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18066
	Then the following text is displayed on the page: Download the Sykes staycation index

@DisabledExperiments
Scenario: Experiment LetYourCottages_AlternativeMethodsOfContact18065
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18065
	Then the following elements are dislpayed on the page
         | Element                          |
         | We're here to help               |
         | Get in touch                     |
         | Give us a call                   |
         | Enquire about letting with Sykes |

@DisabledExperiments
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

@DisabledExperiments
Scenario: Experiment LetYourCottages_RemoveWeAreStillOpen17921
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17921
    Then the following element is not displayed on the page: We are still open as usual

@DisabledExperiments
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

@DisabledExperiments
Scenario: Experiment LetYourCottages_SingleCTAWithinTheHero17973
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17973
    Then the following element is not displayed on the page: form-heading-container
    And the following elements are dislpayed on the page
         | Element                                                        |
         | Let your property with Sykes and earn up to £125,000 per year* |
         | Get started today                                              |

@DisabledExperiments
Scenario: Experiment LetYourCottages_PnoProcess17640
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17640
	Then the following elements are dislpayed on the page
         | Element                |
         | How to list with Sykes |
         | Request for contact    |
         | Self-service           |
         | Start taking bookings  |

@DisabledExperiments
Scenario: Experiment LetYourCottages_FullHeightHero17731
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17731
    Then the following element is displayed on the page: o-icon o-icon-down-full-hero

@DisabledExperiments
Scenario: Experiment LetYourCottages_RelaxedValidationEnquiry17573
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17573
    And I click submit
    Then the following element is not displayed on the page: Please enter a contact number.

@DisabledExperiments
Scenario: Experiment LetYourCottages_ChangeTextForm17977
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17977
	Then the following text is displayed on the page: Complete the form to begin your holiday letting journey

@DisabledExperiments
Scenario: Experiment LetYourCottages_FloatingActionButtonDesktopTablet17853
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17853
    And I set the window size to Tablet
	Then the following element is displayed on the page: Floating action button mobile

@DisabledExperiments
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