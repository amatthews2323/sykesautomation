Feature: Experiments
	Test specific experiments

@ActiveExperiments @ThinkingOfBuying @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_ReTestBedrockPromo19009
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ReTestBedrockPromo19009
	And I scroll to the following element: Looking to get started with holiday letting?
	Then the following elements are dislpayed on the page
         | Element                                      |
         | Looking to get started with holiday letting? |
         | Explore guides & resources                   |
	When I click Explore guides & resources
	And I switch focus to the new tab
	Then the following page title is displayed: Holiday Let Information Centre | Sykes Holiday Cottages

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_ProductShowCasePromotion18893
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ProductShowCasePromotion18893
	Then the following elements are dislpayed on the page
		 | Element                           |
		 | Sykes Product Showcase 2022       |
		 | Sykes Cottages Showcase promotion |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_EnquiryFormPhoneSubCopy18889
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_EnquiryFormPhoneSubCopy18889
	Then the following text is displayed on the page: Get started to access free holiday letting advice
	When I enter the following details on the enquiry form
	| Key           | Value                         |
	| Full name     | Test Owner                    |
	| Email address | sykescottagestest@example.org |
	| Phone number  | 07000000000                   |
	And I click form-heading-container
	And I click o-checkbox__input js-marketing-preferences-phone
	Then I wait 2 seconds
	Then the following text is displayed on the page: If you would like a call from our property experts regarding this enquiry, please leave the phone option selected below.

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_HeroImagesBasedOnHeadingForLoop18704
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_HeroImagesBasedOnHeadingForLoop18704
	Then the following element is displayed on the page: hero-slideshow

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_ManagedServicesBannerOnLYP18552
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ManagedServicesBannerOnLYP18552
	Then the following element is displayed on the page: We tailor our managed service package to suit your specific needs.

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_SectionImageNavigation18583
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_SectionImageNavigation18583
		Then the following elements are dislpayed on the page
		 | Element        |
		 | arrow-prev.svg |
		 | arrow-next.svg |
		 | slick-dots     |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_VisualTimeronAlerts18791
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18791
	Then the alerts are displayed on the page
	And I wait 10 seconds
	Then the alerts are not displayed on the page

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_ToolTipsonLYPHeaders18582
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18582
	And I close the pop-ups
	Then the following elements are dislpayed on the page
		 | Element                                                                                                         |
		 | LYPtooltip                                                                                                      |
		 | We have over 9000 owners  listing with Sykes, and 17,902 properties.                                            |
		 | Average potential earnings are based on the average annual earnings a property within that region might expect. |
		 | We can tailor our services to fit your needs. Find out how by using the button below.                           |
		 | Access our expert knowledge on listing and managing holiday lets.                                               |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_TestimonialsCarousel18584
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18584
	And I close the pop-ups
	Then the Testimonials carousel is displayed on the page
	When I click /images/sykes/letyourcottage/icons/arrow-prev.svg

@ActiveExperiments
Scenario: Experiment LetYourCottages_InactivityExitModal18457
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18457
	And I close the pop-ups
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
Scenario: Experiment LetYourCottages_ReplaceIconsWithimages18585
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18585
	And I close the pop-ups
	Then the following elements are dislpayed on the page
         | Element                                                             |
         | /images/let_your_cottage/letting_easy/market-leading.png            |
         | /images/let_your_cottage/letting_easy/payment_in_advance.png        |
         | /images/let_your_cottage/letting_easy/dedicated-account-manager.png |
         | /images/let_your_cottage/letting_easy/helpline-24h.png              |
         | /images/let_your_cottage/letting_easy/full-property-management.png  |
         | /images/let_your_cottage/letting_easy/photography.png               |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_CreateTextSupportEnquiry18460
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18460
	And I close the pop-ups
	Then the following elements are dislpayed on the page
         | Element                          |
         | Please enter your full name      |
         | Please enter your email address  |
         | Please enter your contact number |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_RemoveSecondHeroCopy18494
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18494
	And I close the pop-ups
	Then the following elements are not dislpayed on the page
		| Elements                                                                                                                            |
		| Let your property with Sykes and earn up to £125,000 per year*                                                                      |
		| As the UK’s leading independent holiday letting agency, we’re committed to getting you the best possible return from your property. |
		| *Based on a 7 bedroom property in the Lake District with bookings between October 2017 to September 2018.                           |

@ActiveExperiments @ProductionRegressionSuite
Scenario: Experiment LetYourCottages_ContrastAlertsOnLYP18473
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18473
	Then the alerts are displayed on the page
	And the following elements are not dislpayed on the page
		| Elements                                |
		| o-icon c-alert__icon o-icon--size-large |
		| c-alert__cta cta_tint js-alert-close    |

@StoppedExperiments
Scenario: Experiment LetYourCottages_TriggerVisitRequest18459
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18459
	And I close the pop-ups
	Then the following elements are dislpayed on the page
		 | Element                                                  |
		 | Book a visit with one of our expert property consultants |
		 | Book property visit                                      |

@StoppedExperiments
Scenario: Experiment LetYourCottages_RemoveRequestYourOwnerPackCta18486
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_RemoveRequestYourOwnerPackCta18486
	And I close the pop-ups
	Then the How Much Could I Earn CTA is not displayed
	And the Holiday Letting Made Easy CTA is not displayed

@StoppedExperiments
Scenario: Experiment LetYourCottages_OwnerIncentivePromotion18529
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18529
	And I close the pop-ups
	Then the following elements are dislpayed on the page
		 | Element                                                                                                                              |
		 | List your property for a welcome gift of your choice                                                                                 |
		 | Sign your contract by 1st April 2022 and get your property taking bookings by 1st June 2022 to earn a welcome gift of your choice... |
		 | /letyourcottage/information/welcome-gift/                                                                                            |

@StoppedExperiments
Scenario: Experiment LetYourCottages_MoveRegionalTestimonials18277
	Given I have navigated to the following page: letyourcottage/In-Your-Area/South-West/?dev_tools=product
	When I apply the following experiment: 18277
	And I close the pop-ups
	Then the testimonials_region_pc section is displayed at position 2

@StoppedExperiments
Scenario: Experiment LetYourCottages_BurguerMenuTablet18658
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18658
	And I close the pop-ups
	And I set the window size to Tablet
	Then the following element is displayed on the page: burguer-menu collapsed
	When I click burguer-menu collapsed
	Then the following elements are dislpayed on the page
		 | Element                |
		 | Sub Navigation         |
		 | Home                   |
		 | Your account           |
		 | Information Centre     |
		 | Your Location          |
		 | How much could I earn? |
		 | Book a holiday         |

@StoppedExperiments
Scenario: Experiment LetYourCottages_AddDownArrowInHero18579
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18579
	And I close the pop-ups
	Then the following element is displayed on the page: scrolldownarrow

@StoppedExperiments
Scenario: Experiment LetYourCottages_LoopingImageOnHero18461
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18461
	And I close the pop-ups
	And I navigate to https://www.sykescottages.co.uk/letyourcottage/
	Then the following element is displayed on the page: hero-slideshow

@StoppedExperiments
Scenario: Experiment LetYourCottages_SlowHeroTextAndAddInteraction18347
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18347
	And I close the pop-ups
	Then the following slick dot is highlighted 1
	And I wait 12 seconds
	And the following slick dot is highlighted 2
	And I wait 10 seconds
	And the following slick dot is highlighted 3
	When I click holiday properties already working with Sykes
	Then the following slick dot is highlighted 4

@StoppedExperiments
Scenario: Experiment LetYourCottages_QAOwnerCaseStudies18625
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18625
	And I close the pop-ups
	Then the following elements are dislpayed on the page
		 | Element                                                           |
		 | Owner FAQs                                                        |
		 | Frequently asked questions, answered by our owners                |
		 | Why did you choose Sykes?                                         |
		 | What advice would you give to other holiday let owners?           |
		 | How long did it take to convert your property into a holiday let? |
		 | Is holiday letting what you expected?                             |
		 | Have your holiday lets been a good investment for you?            |
		 | How did you first get into holiday letting?                       |
	When I click Why did you choose Sykes?
	Then the following elements are dislpayed on the page
		 | Element                                                               |
		 | We chose to holiday let with an agency as my wife and I are very busy |
		 | Answered by                                                           |
		 | David Howle                                                           |
		 | Joined Sykes in: 2009                                                 |
		 | 7307                                                                  |
		 | 954987                                                                |
	When I click What advice would you give to other holiday let owners?
	And I click How long did it take to convert your property into a holiday let?
	And I click Is holiday letting what you expected?
	And I click Have your holiday lets been a good investment for you?
	And I click How did you first get into holiday letting?

@StoppedExperiments
Scenario: Experiment LetYourCottages_CollapseSectionsOnLypPage18587
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18587
	And I close the pop-ups
	Then the following elements are dislpayed on the page
		 | Element                                     |
		 | colapsible-containers                       |
		 | Owner testimonials                          |
		 | Taking a modern approach                    |
		 | Income calculator                           |
		 | Holiday home management                     |
		 | Award winning marketing                     |
		 | Why list with Sykes?                        |
		 | Free information pack                       |
		 | Looking to get started with holiday letting |
	When I click Owner testimonials
	Then the following elements are dislpayed on the page
		 | Element                                                  |
		 | /images/icons-svg/navigation/chevron/icon-chevron-up.svg |
		 | testimonial_image                                        |
		 | testimonial_quote                                        |
		 | testimonial_owner                                        |

@StoppedExperiments
Scenario: Experiment LetYourCottages_PartnersIntoHero18491
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18491
	And I close the pop-ups
	Then the following elements are dislpayed on the page
		 | Element          |
		 | arrow-hero       |
		 | booking logo     |
		 | airbnb logo      |
		 | telegraph logo   |
		 | homelet logo     |
		 | tripadvisor logo |
		 | icelolly logo    |

@StoppedExperiments
Scenario: Experiment LetYourCottages_IntroducingSisterBrands18705
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18705
	Then the following elements are dislpayed on the page
		 | Element                       |
		 | Introducing our brand network |
		 | c-sisterbrands-logos          |

@StoppedExperiments
Scenario: Experiment LetYourCottages_LYPPhoneNumberSection18569
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18569
	And I close the pop-ups
	Then the following elements are dislpayed on the page
		 | Element                                     |
		 | Can't find the service you are looking for? |
		 | 01244 356 666                               |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ProgressBarUpdatetoWhite18869
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18869
	And I close the pop-ups
	Then the following element is displayed on the page: progressbar

@StoppedExperiments
Scenario: Experiment LetYourCottages_RemoveAlertMessagesonLYP18458
	Given I have navigated to the following page without dismissing alerts: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18458
	Then the following elements are not dislpayed on the page
		| Element                              |
		| An owner has just completed the form |
		| A new property has just gone live    |

@StoppedExperiments
Scenario: Experiment LetYourCottages_DisableEnquiryUntilValidInput18581
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18581
	And I close the pop-ups
	Then the enquiry form submit button is disabled
	When I enter the following details on the enquiry form
		| Key           | Value                         |
		| Full name     | Test Owner                    |
		| Email address | sykescottagestest@example.org |
		| Phone number  | 07000000000                   |
	And I click form-heading-container
	Then the enquiry form submit button is not disabled

@StoppedExperiments
Scenario: Experiment LetYourCottages_IncludeMultipleImages18474
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18474
	And I close the pop-ups
	Then the following element is displayed on the page: platform-slider slick-initialized slick-slider

@StoppedExperiments
Scenario: Experiment LetYourCottages_RemoveSectionsFromLYP18292
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18292
	And I close the pop-ups
	Then the following elements are not dislpayed on the page
		| Element                                |
		| Putting your property in the spotlight |
		| Are you thinking of buying             |
		| Back to Top                            |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ReferAFriend18136
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18136
	And I close the pop-ups
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
	And I close the pop-ups
	Then the following text is displayed on the page: Complete the form to receive your free information pack

@StoppedExperiments
Scenario: Experiment LetYourCottages_StaycationGuideDownload18066
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18066
	And I close the pop-ups
	Then the following text is displayed on the page: Download the Sykes staycation index

@StoppedExperiments
Scenario: Experiment LetYourCottages_TestimonialRefocus18099
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18099
	And I close the pop-ups
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
	And I close the pop-ups
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
	And I close the pop-ups
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
	And I close the pop-ups
    Then the following element is not displayed on the page: We are still open as usual

@StoppedExperiments
Scenario: Experiment LetYourCottages_AddingWebinars17805
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17805
	And I close the pop-ups
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
	And I close the pop-ups
    Then the following element is not displayed on the page: form-heading-container
    And the following elements are dislpayed on the page
         | Element                                                        |
         | Let your property with Sykes and earn up to £125,000 per year* |
         | Get started today                                              |

@StoppedExperiments
Scenario: Experiment LetYourCottages_PnoProcess17640
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17640
	And I close the pop-ups
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
	And I close the pop-ups
    Then the following element is displayed on the page: o-icon o-icon-down-full-hero

@StoppedExperiments
Scenario: Experiment LetYourCottages_RelaxedValidationEnquiry17573
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17573
	And I close the pop-ups
    And I click submit
    Then the following element is not displayed on the page: Please enter a contact number.

@StoppedExperiments
Scenario: Experiment LetYourCottages_ChangeTextForm17977
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17977
	And I close the pop-ups
	Then the following text is displayed on the page: Complete the form to begin your holiday letting journey

@StoppedExperiments
Scenario: Experiment LetYourCottages_FloatingActionButtonDesktopTablet17853
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17853
	And I close the pop-ups
    And I set the window size to Tablet
	Then the following element is displayed on the page: Floating action button mobile

@StoppedExperiments
Scenario: Experiment LetYourCottages_AverageMonthlyIncomeProjection17432
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17432
	And I close the pop-ups
	Then the following text is displayed on the page: Average monthly income