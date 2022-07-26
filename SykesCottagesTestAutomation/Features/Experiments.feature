Feature: Experiments
	Test specific experiments

In development:
LetYourCottages_RequestACallForm55
LetYourCottages_MultiStepFormLYP67

@ActiveExperiments
Scenario: Experiment LetYourCottages_AddLabeltoStickyEnquireButtonLYP44
	Given I have navigated to the following page: letyourcottage/information/buy-own-sell-holiday-lets/?dev_tools=product
	When I apply the following experiment: LetYourCottages_AddLabeltoStickyEnquireButtonLYP44
	And I scroll to the following element: page-footer
	Then the following element is displayed: //*[contains(@class,'fixed-bottom__fab-button')]//*[text()='Enquire today']

@ActiveExperiments
Scenario: Experiment LetYourCottages_AddLabeltoStickyBacktoTopIconLYP43
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_AddLabeltoStickyBacktoTopIconLYP43
	And I scroll to the following element: page-footer
	Then the following element is displayed: //a[@id='backtotop']//*[text()='Back to top']

@ActiveExperiments
Scenario: Experiment LetYourCottages_RemoveWeAreStillOpen17921
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17921
    Then the following element is not displayed: We are still open as usual

@ActiveExperiments
Scenario: Experiment LetYourCottages_VersionCOfMarketingPrefs25
	Given I have navigated to the following page: letyourcottage/information/investment-advice-for-holiday-lets/?dev_tools=product
	When I apply the following experiment: LetYourCottages_VersionCOfMarketingPrefs25
	Then the relevant elements are dislpayed
	| Element                              |
	| form-heading-container               |
	| heroform_first_name                  |
	| heroform_first_name_validation_error |
	| heroform_email                       |
	| heroform_email_validation_error      |
	| heroform_phone                       |
	| heroform_phone_validation_error      |
	| Get started                          |
	When I enter Test Owner in the following form field: heroform_first_name
	When I enter test@test.com in the following form field: heroform_email
	When I enter 07000000000 in the following form field: heroform_phone
	When I click enquiry-button lyc-cta u-full-width js-enquiry-form-button-25 lyc-cta--blue u-cursor-pointer
	Then the relevant elements are dislpayed
	| Element                                              |
	| Your enquiry                                         |
	| Please ensure the following details are correct      |
	| How would you like the Sykes Group to keep in touch? |
	| marketing_phone                                      |
	| marketing_email                                      |
	| Complete enquiry                                     |

@ActiveExperiments
Scenario: Experiment LetYourCottages_EarningCalculatoronInformationPages19170
	Given I have navigated to the following page: letyourcottage/information/marketing-your-holiday-let/?dev_tools=product
	When I apply the following experiment: LetYourCottages_EarningCalculatoronInformationPages19170
	Then the relevant elements are dislpayed
	| Element                           |
	| How much could I earn with Sykes? |
	| Estimated earnings                |

@ActiveExperiments
Scenario: Experiment LetYourCottages_LYPConversionFormFieldOrderLYP53
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_LYPConversionFormFieldOrderLYP53
	Then the relevant elements are dislpayed
	| Element                                                      |
	| //form[@*='heroform']/div[1]/label[@*='heroform_first_name'] |
	| //form[@*='heroform']/div[2]/label[@*='heroform_phone']      |
	| //form[@*='heroform']/div[3]/label[@*='heroform_email']      |

@ActiveExperiments
Scenario: Experiment LetYourCottages_ContentImprovementsonHowtorunholidayletinfopage19169
	Given I have navigated to the following page: letyourcottage/information/how-to-run-your-holiday-let/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ContentImprovementsonHowtorunholidayletinfopage19169
	Then the relevant elements are dislpayed
	| Element       |
	| Enquire now   |
	| FAQ           |
	| question_logo |

@ActiveExperiments
Scenario: Experiment LetYourCottages_InfopagecontentcollapsedsectionsLYP30
	Given I have navigated to the following page: letyourcottage/information/investment-advice-for-holiday-lets/?dev_tools=product
	When I apply the following experiment: LetYourCottages_InfopagecontentcollapsedsectionsLYP30
	Then the relevant elements are dislpayed
	| Element            |
	| collapsible_header |
	| header_chevron     |

@ActiveExperiments
Scenario: Experiment LetYourCottages_GetstartedsectioninsteadofbrochuredownloadLYP31
	Given I have navigated to the following page: letyourcottage/information/investment-advice-for-holiday-lets/?dev_tools=product
	When I apply the following experiment: LetYourCottages_GetstartedsectioninsteadofbrochuredownloadLYP31
	Then the following element is displayed: Enquire today to get started with Sykes

@ActiveExperiments
Scenario: Experiment LetYourCottages_InformationPageSearchMvpLyp12
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_InformationPageSearchMvpLyp12
	Then the relevant elements are dislpayed within the searcher-section section
	| Element                                |
	| Search for holiday letting information |
	| searchTerm                             |
	| Search                                 |
	| Managed services                       |
	| Investment advice                      |
	| How to run a holiday let               |
	When I enter Mortgage in the following form field: searchTerm
	And I click searcher-bar__action
	Then the relevant elements are dislpayed
	| Element                                           |
	| 12 results for 'Mortgage'                         |
	| back-container                                    |
	| A complete guide to holiday let mortgages         |
	| Holiday let mortgages                             |
	| Running your holiday let                          |
	| Why now is a good time to invest in a holiday let |

@ActiveExperiments
Scenario: Experiment LetYourCottages_ImagesbeforecontentLYP32
	Given I have navigated to the following page: letyourcottage/information/investment-advice-for-holiday-lets/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ImagesbeforecontentLYP32
	Then the following element is displayed: /images/let_your_cottage/lyp32-desktop-tablet.png

@ActiveExperiments
Scenario: Experiment LetYourCottages_HeroFormTitleChange24
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_HeroFormTitleChange24
	Then the following text is displayed: Start your letting journey with Sykes
	And the following elements are not dislpayed
	| Element                                                  |
	| Complete the form to receive your information pack       |
	| //div[@class='form-heading-container']//*[text()='Free'] |

Scenario: Experiment LetYourCottages_InformationPagesHeroImageExperimentAmendLYP65
	Given I have navigated to the following page: <Path>
	When I apply the following experiment: LetYourCottages_InformationPagesHeroImageExperimentAmendLYP65
	Then the following element is displayed: <Element>
	Examples:
	| Path																		       | Element                                     |
	| letyourcottage/information/marketing-your-holiday-let/?dev_tools=product         | advertising-and-marketing.png               |
	| letyourcottage/information/buy-own-sell-holiday-lets/?dev_tools=product          | buying-owning-and-selling-a-holiday-let.png |
	| letyourcottage/information/investment-advice-for-holiday-lets/?dev_tools=product | investment-advice-for-holiday-lets.png      |
	| letyourcottage/information/regulations-for-holiday-lets/?dev_tools=product       | legal-regulations-for-holiday-lets.png      |
	| letyourcottage/information/holiday-let-mortgages/?dev_tools=product              | holiday-let-mortgages.png                   |
	| letyourcottage/information/how-to-run-your-holiday-let/?dev_tools=product        | how-to-run-your-holiday-let.png             |
	| letyourcottage/information/tax-information-on-holiday-lets/?dev_tools=product    | tax-information-on-holiday-lets.png         |

Scenario: Experiment LetYourCottages_RemoveDirectMailSmsFromForm19051
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_RemoveDirectMailSmsFromForm19051
	And I enter the following details on the enquiry form
	| Key           | Value                 |
	| Full name     | Test Owner            |
	| Email address | sykestest@example.org |
	| Phone number  | 07000000000           |
	And I click o-heading-title__heading
	Then the relevant elements are dislpayed
	| Element         |
	| marketing_email |
	| marketing_phone |
	And the following elements are not dislpayed
	| Element        |
	| marketing_sms  |
	| marketing_post |

Scenario: Experiment LetYourCottages_FormSmallPrintChange27
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_FormSmallPrintChange27
	Then the relevant elements are dislpayed
	| Element                                                                                                   |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| You can opt out or unsubscribe at any time by contacting us or using an unsubscribe link.                 |
	| /terms/privacypolicy                                                                                      |

Scenario: Experiment LetYourCottages_FormSmallPrintChange27 Sister Brands
	Given I am on the following webpage: <URL>
	When I apply the following experiment: LetYourCottages_FormSmallPrintChange27
	Then the relevant elements are dislpayed within the heroform section
	| Element                                                                                                   |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| You can opt out or unsubscribe at any time by contacting us or using an unsubscribe link.                 |
	| /terms/privacypolicy                                                                                      |
	Examples:
	| URL                                                         |
	| https://www.character-cottages.co.uk/letyourcottage/        |
	| https://www.carbisbayholidays.co.uk/letyourcottage/         |
	| https://www.coastandcountry.co.uk/letyourcottage/           |
	| https://www.cornishcottageholidays.co.uk/letyourcottage/    |
	| https://www.dream-cottages.co.uk/letyourcottage/            |
	| https://www.heartofthelakes.co.uk/letyourcottage/           |
	| https://www.helpfulholidays.co.uk/letyourcottage/           |
	| https://www.hogansirishcottages.com/letyourcottage/         |
	| https://www.johnbraycornishholidays.co.uk/letyourcottage/   |
	| https://www.lakedistrictlodgeholidays.co.uk/letyourcottage/ |
	| https://www.lakescottageholiday.co.uk/letyourcottage/       |
	| https://www.lakelovers.co.uk/letyourcottage/                |
	| https://www.manorcottages.co.uk/letyourcottage/             |
	| https://www.menaiholidays.co.uk/letyourcottage/             |
	| https://www.welsh-cottages.co.uk/letyourcottage/            |
	| https://www.yorkshirecoastalcottages.com/cottage-owners/    |

@StoppedExperiments
Scenario: Experiment LetYourCottages_MortgageLetterSectionLYP22
	Given I have navigated to the following page: letyourcottage/information/investment-advice-for-holiday-lets/?dev_tools=product
	When I apply the following experiment: LetYourCottages_MortgageLetterSectionLYP22
	Then the relevant elements are dislpayed
	| Element                                                    |
	| Need a Holiday Let Mortgage Letter?                        |
	| Start application                                          |
	| /images/let_your_cottage/landing_pages/mortgage_letter.jpg |

@StoppedExperiments
Scenario: Experiment LetYourCottages_BespokeheroimagesoninformationpagesLYP29
	Given I have navigated to the following page: <Path>
	When I apply the following experiment: <Experiment>
	Then the following element is displayed: <Element>
	Examples:
	| Path                                                          | Experiment                                                                | Element                                     |
	| letyourcottage/information/marketing-your-holiday-let         | LetYourCottages_BespokeheroimagesoninformationpagesmarketingLYP29         | advertising-and-marketing.png               |
	| letyourcottage/information/buy-own-sell-holiday-lets          | LetYourCottages_BespokeheroimagesoninformationpagesbuysellLYP29           | buying-owning-and-selling-a-holiday-let.png |
	| letyourcottage/information/investment-advice-for-holiday-lets | LetYourCottages_BespokeheroimagesoninformationpagesinvestmentLYP29        | investment-advice-for-holiday-lets.png      |
	| letyourcottage/information/regulations-for-holiday-lets       | LetYourCottages_BespokeheroimagesoninformationpagesregulationsLYP29       | legal-regulations-for-holiday-lets.png      |
	| letyourcottage/information/holiday-let-mortgages              | LetYourCottages_BespokeheroimagesoninformationpagesmortgagesLYP29         | holiday-let-mortgages.png                   |
	| letyourcottage/information/how-to-run-your-holiday-let        | LetYourCottages_BespokeheroimagesoninformationpagesrunyourholidayletLYP29 | how-to-run-your-holiday-let.png             |
	| letyourcottage/information/tax-information-on-holiday-lets    | LetYourCottages_BespokeheroimagesoninformationpagestaxLYP29               | tax-information-on-holiday-lets.png         |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ToolTipsonLYPHeaders18582
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ToolTipsonLYPHeaders18582
	And I close the pop-ups
	Then the relevant elements are dislpayed
	| Element                                                                                                         |
	| LYPtooltip                                                                                                      |
	| We have over 9000 owners  listing with Sykes, and 17,902 properties.                                            |
	| Average potential earnings are based on the average annual earnings a property within that region might expect. |
	| We can tailor our services to fit your needs. Find out how by using the button below.                           |
	| Access our expert knowledge on listing and managing holiday lets.                                               |

@StoppedExperiments
Scenario: Experiment LetYourCottages_UpdateInfoPageHeaders19095
	Given I have navigated to the following page: letyourcottage/information/marketing-your-holiday-let/?dev_tools=product
	When I apply the following experiment: LetYourCottages_UpdateInfoPageHeaders19095
	Then the relevant elements are dislpayed
	| Element                              |
	| Book a holiday                       |
	| nav_top_link nav_telephone_container |
	| Your account                         |
	And the following elements are not dislpayed
    | Element           |
    | Your Location     |
    | Get Started Today |

@StoppedExperiments
Scenario: Experiment LetYourCottages_OwnerIncentivePromotion4
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_OwnerIncentivePromotion4
	Then the relevant elements are dislpayed
	| Element                                        |
	| overlay-owner-incentive-promotion              |
	| Ready to get started                           |
	When I click Ready to get started
	Then the relevant elements are dislpayed
	| Element                                                     |
	| owner-incentive-promotion is-open                           |
	| List your property before October and recieve £500 cashback |
	| 01244 746 279                                               |
	| propertyexperts@sykescottages.co.uk                         |
	| owner-incentive-get-started                                 |
	| owner-incentive-dismiss                                     |
	| View terms and conditions                                   |
	When I click owner-incentive-get-started
	Then the relevant elements are dislpayed
	| Element                                                                                           |
	| owner-promotion-form_first_name                                                                   |
	| owner-promotion-form_first_name_validation_error                                                  |
	| owner-promotion-form_email                                                                        |
	| owner-promotion-form_email_validation_error                                                       |
	| owner-promotion-form_phone                                                                        |
	| owner-promotion-form_phone_validation_error                                                       |
	| Your details will be stored and used to send you information about our property letting services. |
	| /terms/privacypolicy                                                                              |
	| Submit enquiry                                                                                    |
	| Back                                                                                              |
	| /blog/welcome-cashback-offer-terms-and-conditions/                                                |

@StoppedExperiments
Scenario: Experiment LetYourCottages_PartnersInteractiveCarrousel18699
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_PartnersInteractiveCarrousel18699
	Then the relevant elements are dislpayed
	| Element          |
	| airbnb logo      |
	| holidu logo      |
	| tripadvisor logo |
	| vrbo logo        |
	| booking logo     |
	| expedia logo     |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ManagedServicesBannerOnLYP18552
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ManagedServicesBannerOnLYP18552
	Then the following element is displayed: We tailor our managed service package to suit your specific needs.

@StoppedExperiments
Scenario: Experiment LetYourCottages_InformationCentreCarousel19036
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_InformationCentreCarousel19036
	Then the relevant elements are dislpayed
	| Element                      |
	| Information centre           |
	| A bespoke letting experience |
	| Holiday homes for sale       |
	| Enquire now                  |
	| Buying, owning and selling   |
	| How to run your holiday let  |
	| Tax information and advice   |
	| Advertising and marketing    |
	| Investment advice            |
	| Holiday let mortgages        |
	| Legal regulations            |

@StoppedExperiments
Scenario: Experiment LetYourCottages_HeroImagesBasedOnHeadingForLoop18704
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_HeroImagesBasedOnHeadingForLoop18704
	Then the following element is displayed: hero-slideshow

@StoppedExperiments
Scenario: Experiment LetYourCottages_ManagedServicesBannerOnInfoPages19101
	Given I have navigated to the following page: letyourcottage/information/marketing-your-holiday-let/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ManagedServicesBannerOnInfoPages19101
	Then the following element is displayed: We tailor our managed service package to suit your specific needs.

@StoppedExperiments
Scenario: Experiment LetYourCottages_ApplyNewDesignToInfoPages19055
	Given I have navigated to the following page: <Path>
	When I apply the following experiment: LetYourCottages_ApplyNewDesignToInfoPages19055
	Then the relevant elements are dislpayed
    | Element                                |
    | form-heading-container                 |
    | <Header>                               |
    | hero__image                            |
    | Customer reviews powered by Trustpilot |
    | Information centre                     |
    | Share article                          |
    | Twitter                                |
    | Facebook                               |
    | Instagram                              |
    | Linkedin                               |
	Examples:
	| Path														    | Header                                     |
	| letyourcottage/information/marketing-your-holiday-let         | Advertising and marketing your holiday let |
	| letyourcottage/information/buy-own-sell-holiday-lets          | Buying, owning and selling a holiday let   |
	| letyourcottage/information/investment-advice-for-holiday-lets | Investment advice for holiday lets         |
	| letyourcottage/information/legal-regulations-for-holiday-lets | Legal regulations for holiday lets         |
	| letyourcottage/information/holiday-let-mortgages              | Holiday let mortgages                      |
	| letyourcottage/information/how-to-run-your-holiday-let        | How to run your holiday let                |
	| letyourcottage/information/Tax-information-on-holiday-lets    | Tax information on holiday lets            |

@StoppedExperiments
Scenario: Experiment LetYourCottages_RemoveSecondHeroCopy18494
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_RemoveSecondHeroCopy18494
	And I close the pop-ups
	Then the following elements are not dislpayed
		| Elements                                                                                                                            |
		| Let your property with Sykes and earn up to £125,000 per year*                                                                      |
		| As the UK’s leading independent holiday letting agency, we’re committed to getting you the best possible return from your property. |
		| *Based on a 7 bedroom property in the Lake District with bookings between October 2017 to September 2018.                           |

@StoppedExperiments
Scenario: Experiment LetYourCottages_AddTOBAlerts18280
	Given I have navigated to the following page: letyourcottage/holiday-homes-for-sale/?dev_tools=product
	When I apply the following experiment: LetYourCottages_AddTOBAlerts18280
	Then the alerts are displayed on the page

@StoppedExperiments
Scenario: Experiment LetYourCottages_HHFSDesktopHeader18987
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_HHFSDesktopHeader18987
	Then the relevant elements are dislpayed
		| Elements                               |
		| Holiday homes for sale                 |
		| /letyourcottage/holiday-homes-for-sale |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ContrastAlertsOnLYP18473
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ContrastAlertsOnLYP18473
	Then the alerts are displayed on the page
	And the following elements are not dislpayed
		| Elements                                |
		| o-icon c-alert__icon o-icon--size-large |
		| c-alert__cta cta_tint js-alert-close    |

@StoppedExperiments
Scenario: Experiment LetYourCottages_CreateTextSupportEnquiry18460
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_CreateTextSupportEnquiry18460
	And I close the pop-ups
	Then the relevant elements are dislpayed
         | Element                          |
         | Please enter your full name      |
         | Please enter your email address  |
         | Please enter your contact number |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ProductShowCasePromotion18893
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ProductShowCasePromotion18893
	Then the relevant elements are dislpayed
		 | Element                           |
		 | Sykes Product Showcase 2022       |
		 | Sykes Cottages Showcase promotion |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ChangingPhoneNumberFormat18993
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ChangingPhoneNumberFormat18993
	Then the following text is displayed: 01244 356 666

@StoppedExperiments
Scenario: Experiment LetYourCottages_EnquiryFormPhoneSubCopy18889
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_EnquiryFormPhoneSubCopy18889
	Then the following text is displayed: Get started to access free holiday letting advice
	When I enter the following details on the enquiry form
	| Key           | Value                         |
	| Full name     | Test Owner                    |
	| Email address | sykescottagestest@example.org |
	| Phone number  | 07000000000                   |
	And I click form-heading-container
	And I click o-checkbox__input js-marketing-preferences-phone
	Then I wait 2 seconds
	Then the following text is displayed: If you would like a call from our property experts regarding this enquiry, please leave the phone option selected below.

@StoppedExperiments
Scenario: Experiment LetYourCottages_TriggerVisitRequest18459
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18459
	And I close the pop-ups
	Then the relevant elements are dislpayed
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
	Then the relevant elements are dislpayed
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
	Then the following element is displayed: burguer-menu collapsed
	When I click burguer-menu collapsed
	Then the relevant elements are dislpayed
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
	Then the following element is displayed: scrolldownarrow

@StoppedExperiments
Scenario: Experiment LetYourCottages_LoopingImageOnHero18461
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18461
	And I close the pop-ups
	And I navigate to https://www.sykescottages.co.uk/letyourcottage/
	Then the following element is displayed: hero-slideshow

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
	Then the relevant elements are dislpayed
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
	Then the relevant elements are dislpayed
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
	Then the relevant elements are dislpayed
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
	Then the relevant elements are dislpayed
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
	Then the relevant elements are dislpayed
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
	Then the relevant elements are dislpayed
		 | Element                       |
		 | Introducing our brand network |
		 | c-sisterbrands-logos          |

@StoppedExperiments
Scenario: Experiment LetYourCottages_LYPPhoneNumberSection18569
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18569
	And I close the pop-ups
	Then the relevant elements are dislpayed
		 | Element                                     |
		 | Can't find the service you are looking for? |
		 | 01244 356 666                               |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ProgressBarUpdatetoWhite18869
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18869
	And I close the pop-ups
	Then the following element is displayed: progressbar

@StoppedExperiments
Scenario: Experiment LetYourCottages_RemoveAlertMessagesonLYP18458
	Given I have navigated to the following page without dismissing alerts: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18458
	Then the following elements are not dislpayed
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
	Then the following element is displayed: platform-slider slick-initialized slick-slider

@StoppedExperiments
Scenario: Experiment LetYourCottages_RemoveSectionsFromLYP18292
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18292
	And I close the pop-ups
	Then the following elements are not dislpayed
		| Element                                |
		| Putting your property in the spotlight |
		| Are you thinking of buying             |
		| Back to Top                            |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ReferAFriend18136
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18136
	And I close the pop-ups
	Then the following element is displayed: Refer a friend

@StoppedExperiments
Scenario: Experiment LetYourCottages_InformationPageAlerts18281
	Given I have navigated to the following page without dismissing alerts: letyourcottage/information/marketing-your-holiday-let/?dev_tools=product
	When I apply the following experiment: 18281
	Then the following element is displayed: c-alert c-alert--standard js-alert is-visible

@StoppedExperiments
Scenario: Experiment LetYourCottages_TOBAlertModal18279
	Given I have navigated to the following page without dismissing alerts: letyourcottage/holiday-homes-for-sale/?dev_tools=product
	When I apply the following experiment: 18279
	And I select the alert Get Started button
	And I select the close icon on the form
	Then the following element is displayed: Enquire with Sykes today

@StoppedExperiments
Scenario: Experiment LetYourCottages_EnquiryFormCopyUpdate18283
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18283
	And I close the pop-ups
	Then the following text is displayed: Complete the form to receive your free information pack

@StoppedExperiments
Scenario: Experiment LetYourCottages_StaycationGuideDownload18066
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18066
	And I close the pop-ups
	Then the following text is displayed: Download the Sykes staycation index

@StoppedExperiments
Scenario: Experiment LetYourCottages_TestimonialRefocus18099
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18099
	And I close the pop-ups
	Then the relevant elements are dislpayed
         | Element                                                                             |
         | testimonial-slider                                                                  |
         | Sykes instilled a lot of confidence in us and now I wouldn’t use anybody else       |
         | Sykes have taken the stress out of us taking bookings, they are so professional     |
         | It is great working with Sykes - they are always available and they pay you quickly |
    And the following element is not displayed: What do our owners say?

@StoppedExperiments
Scenario: Experiment LetYourCottages_AlternativeMethodsOfContact18065
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 18065
	And I close the pop-ups
	Then the relevant elements are dislpayed
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
	Then the relevant elements are dislpayed
         | Element                    |
         | Expand your reach with our |
         | 700+ partner channels      |
         | airbnb logo                |
         | icelolly logo              |
         | vrbo logo                  |
         | expedia logo               |
         | tripadvisor logo           |

@StoppedExperiments
Scenario: Experiment LetYourCottages_AddingWebinars17805
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17805
	And I close the pop-ups
	Then the relevant elements are dislpayed
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
    Then the following element is not displayed: form-heading-container
    And the following elements are dislpayed
         | Element                                                        |
         | Let your property with Sykes and earn up to £125,000 per year* |
         | Get started today                                              |

@StoppedExperiments
Scenario: Experiment LetYourCottages_PnoProcess17640
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17640
	And I close the pop-ups
	Then the relevant elements are dislpayed
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
    Then the following element is displayed: o-icon o-icon-down-full-hero

@StoppedExperiments
Scenario: Experiment LetYourCottages_RelaxedValidationEnquiry17573
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17573
	And I close the pop-ups
    And I click submit
    Then the following element is not displayed: Please enter a contact number.

@StoppedExperiments
Scenario: Experiment LetYourCottages_ChangeTextForm17977
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17977
	And I close the pop-ups
	Then the following text is displayed: Complete the form to begin your holiday letting journey

@StoppedExperiments
Scenario: Experiment LetYourCottages_FloatingActionButtonDesktopTablet17853
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17853
	And I close the pop-ups
    And I set the window size to Tablet
	Then the following element is displayed: Floating action button mobile

@StoppedExperiments
Scenario: Experiment LetYourCottages_AverageMonthlyIncomeProjection17432
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17432
	And I close the pop-ups
	Then the following text is displayed: Average monthly income