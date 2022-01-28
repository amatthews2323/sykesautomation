Feature: Experiments
	Test specific experiments

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

@ActiveExperiments
Scenario: Experiment LetYourCottages_RemoveSectionsFromLYP18292
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18292
	Then the following elements are not dislpayed on the page
		| Example                                |
		| Putting your property in the spotlight |
		| Are you thinking of buying             |
		| Back to Top                            |

@ActiveExperiments
Scenario: Experiment LetYourCottages_EnquiryFormCopyUpdate18283
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18283
	Then the following text is displayed on the page: Complete the form to receive your free information pack

@ActiveExperiments
Scenario: Experiment LetYourCottages_PromoteBedrock18334
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18334
	Then the following elements are dislpayed on the page
         | Element                                      |
         | Looking to get started with holiday letting? |
         | Open content hub                             |

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
Scenario: Experiment LetYourCottages_TrustPilotPromotion18351
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18351
	Then the following element is displayed on the page: Customer reviews powered by Trustpilot

@ActiveExperiments
Scenario: Experiment LetYourCottages_ReferAFriend18136
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18136
	Then the following element is displayed on the page: Refer a friend

@FailedExperiments
Scenario: Experiment LetYourCottages_StaycationGuideDownload18066
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18066
	Then the following text is displayed on the page: Download the Sykes staycation index

@FailedExperiments
Scenario: Experiment LetYourCottages_AlternativeMethodsOfContact18065
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18065
	Then the following elements are dislpayed on the page
         | Element                          |
         | We're here to help               |
         | Get in touch                     |
         | Give us a call                   |
         | Enquire about letting with Sykes |

@FailedExperiments
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

@FailedExperiments
Scenario: Experiment LetYourCottages_RemoveWeAreStillOpen17921
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17921
    Then the following element is not displayed on the page: We are still open as usual

@FailedExperiments
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

@FailedExperiments
Scenario: Experiment LetYourCottages_SingleCTAWithinTheHero17973
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17973
    Then the following element is not displayed on the page: form-heading-container
    And the following elements are dislpayed on the page
         | Element                                                        |
         | Let your property with Sykes and earn up to £125,000 per year* |
         | Get started today                                              |

@FailedExperiments
Scenario: Experiment LetYourCottages_PnoProcess17640
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17640
	Then the following elements are dislpayed on the page
         | Element                |
         | How to list with Sykes |
         | Request for contact    |
         | Self-service           |
         | Start taking bookings  |

@FailedExperiments
Scenario: Experiment LetYourCottages_FullHeightHero17731
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17731
    Then the following element is displayed on the page: o-icon o-icon-down-full-hero

@FailedExperiments
Scenario: Experiment LetYourCottages_RelaxedValidationEnquiry17573
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17573
    And I click submit
    Then the following element is not displayed on the page: Please enter a contact number.

@FailedExperiments
Scenario: Experiment LetYourCottages_ChangeTextForm17977
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17977
	Then the following text is displayed on the page: Complete the form to begin your holiday letting journey

@FailedExperiments
Scenario: Experiment LetYourCottages_FloatingActionButtonDesktopTablet17853
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17853
    And I set the window size to Tablet
	Then the following element is displayed on the page: Floating action button mobile