Feature: Experiments
	Test specific experiments

@ActiveExperiments
Scenario: Experiment LetYourCottages_InfoPageInvestmentAdviceLYP223
	Given the following experiment is active: LetYourCottages_InfoPageInvestmentAdviceLYP223
	And I have navigated to the following page: letyourcottage
	When I store the active experiment IDs
	Then experiment LetYourCottages_InfoPageInvestmentAdviceLYP223 is applied

@ActiveExperiments
Scenario: Experiment LetYourCottages_LinkbackforconsumertrafficLYP192
	Given the following experiment is active: LetYourCottages_LinkbackforconsumertrafficLYP192
	And I have navigated to the following page: letyourcottage
	When I store the active experiment IDs
	Then experiment LetYourCottages_LinkbackforconsumertrafficLYP192 is applied

@ActiveExperiments
Scenario: Experiment LetYourCottages_RemovereadingtimefrominformationpageheroLYP216
	Given the following experiment is active: LetYourCottages_RemovereadingtimefrominformationpageheroLYP216
	And I have navigated to the following page: letyourcottage
	When I store the active experiment IDs
	Then experiment LetYourCottages_RemovereadingtimefrominformationpageheroLYP216 is applied

@ActiveExperiments
Scenario: Experiment LetYourCottages_LYPStickyHeader202
	Given the following experiment is active: LetYourCottages_LYPStickyHeader202
	And I have navigated to the following page: letyourcottage
	When I store the active experiment IDs
	Then experiment LetYourCottages_LYPStickyHeader202 is applied

@StoppedExperiments
Scenario: Experiment LetYourCottages_CaptureIfPnoHasAProperty19842
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_CaptureIfPnoHasAProperty19842
	Then the relevant elements are dislpayed within the heroform section
	| Element                                 |
	| Do you own or manage a property to let? |
	| lyc-dropdown-heroform_has_a_property    |
	When I select Get Started
	Then the relevant elements are dislpayed within the heroform section
	| Element                                  |
	| heroform_has_a_property_validation_error |
	| Please select an option.                 |

@StoppedExperiments
Scenario: Experiment LetYourCottages_RequestACallForm55
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_RequestACallForm55
	And I click #js-request-a-call
	Then the relevant elements are dislpayed within the request-a-call section
	| Element                                                                                                   |
	| request-a-call_first_name                                                                                 |
	| request-a-call_last_name                                                                                  |
	| request-a-call_phone                                                                                      |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| /terms/privacypolicy                                                                                      |
	| Have us call you                                                                                          |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ReplaceWeAreStillOpenSectionwithHolidayLettingMadeEasyLYP143
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ReplaceWeAreStillOpenSectionwithHolidayLettingMadeEasyLYP143
	Then the following element is not displayed: We are still open as usual
	Then the page sections are displayed in the relevant positions
	| Key                       | Position |
	| Holiday letting made easy | 5        |

@StoppedExperiments
Scenario: Experiment LetYourCottages_BedrockMortgageLetterSectiononHomepageLYP37
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_BedrockMortgageLetterSectiononHomepageLYP37
	Then the relevant elements are dislpayed
	| Element                             |
	| Need a Holiday Let Mortgage letter? |
	| Sykes Cottages Mortgage letter      |
	| Start application                   |

@StoppedExperiments
Scenario: Experiment LetYourCottages_AddPhoneNumberToForm19768
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_AddPhoneNumberToForm19768
	Then the relevant elements are dislpayed within the heroform section
	| Element                                     |
	| Or, call us to chat directly with an expert |
	| 01244 617832                                |
	| lyp_number_press                            |

@StoppedExperiments
Scenario: Experiment LetYourCottages_HomepageOwnerStoriesSectionLYP123
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_HomepageOwnerStoriesSectionLYP123
	Then the relevant elements are dislpayed
	| Element                                |
	| youtube-banner__content                |
	| Sykes Owner Stories: Anna and Alistair |
	| Watch Owner Story                      |
	When I click Watch Owner Story
	Then the relevant elements are dislpayed
	| Element                                   |
	| youtube-banner                            |
	| youtube-story-frame                       |
	| https://www.youtube.com/embed/Ub391Pv_DA0 |
	And the relevant elements are not dislpayed
	| Element                 |
	| What do our owners say? |

@StoppedExperiments
Scenario: Experiment LetYourCottages_RemoveWeAreStillOpen17921
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17921
    Then the following element is not displayed: We are still open as usual

@StoppedExperiments
Scenario: Experiment LetYourCottages_ContentImprovementsonHowtorunholidayletinfopage19169
	Given I have navigated to the following page: letyourcottage/information/how-to-run-your-holiday-let/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ContentImprovementsonHowtorunholidayletinfopage19169
	Then the relevant elements are dislpayed
	| Element       |
	| Enquire now   |
	| FAQ           |
	| question_logo |

@StoppedExperiments
Scenario: Experiment LetYourCottages_InfopagecontentcollapsedsectionsLYP30
	Given I have navigated to the following page: letyourcottage/information/investment-advice-for-holiday-lets/?dev_tools=product
	When I apply the following experiment: LetYourCottages_InfopagecontentcollapsedsectionsLYP30
	Then the relevant elements are dislpayed
	| Element            |
	| collapsible_header |
	| header_chevron     |

@StoppedExperiments
Scenario: Experiment LetYourCottages_MakeAllEarningCalculatorRegionsHoneypotLYP142
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_MakeAllEarningCalculatorRegionsHoneypotLYP142
	And I select option Bath from the region dropdown
	Then the following element is not displayed: Your property details are unique, please contact our team at 01244 356 666 for a more accurate estimate.

@StoppedExperiments
Scenario: Experiment LetYourCottages_TestRequestaCallForminHeroLYP166
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_TestRequestaCallForminHeroLYP166
	Then the following text is displayed: Get information and advice from our team of holiday letting experts
	Then the relevant elements are dislpayed within the request-a-call-hero section
	| Element                                                                            |
	| request-a-call-hero_first_name                                                     |
	| request-a-call-hero_last_name                                                      |
	| request-a-call-hero_phone                                                          |
	| Sykes' Group will use your number to call you about our property letting services. |
	| /terms/privacypolicy                                                               |
	When I select Get started within the request-a-call-hero section
	Then the relevant elements are dislpayed within the request-a-call-hero section
	| Element                                         |
	| request-a-call-hero_first_name_validation_error |
	| Please enter your first name.                   |
	| request-a-call-hero_last_name_validation_error  |
	| Please enter your surname.                      |
	| request-a-call-hero_phone_validation_error      |
	| Please enter a contact number.                  |

@StoppedExperiments
Scenario: The Inactivity Modal is displayed correctly
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	Then I wait 305 seconds
	And the relevant elements are dislpayed
    | Element                  |
    | idleform                 |
    | We're ready when you are |
    | Open form                |
	When I click Open form
	Then the relevant elements are dislpayed
    | Element                                                                                                   |
    | inactive-form_first_name                                                                                  |
    | inactive-form_first_name_validation_error                                                                 |
    | inactive-form_email                                                                                       |
    | inactive-form_email_validation_error                                                                      |
    | inactive-form_phone                                                                                       |
    | inactive-form_phone_validation_error                                                                      |
    | Your details will be used by the Sykes group to send you information about our property letting services. |
    | You can opt out or unsubscribe at any time by contacting us or using an unsubscribe link.                 |
    | /terms/privacypolicy                                                                                      |
	And the relevant elements are not dislpayed
	| Element        |
	| marketing_sms  |
	| marketing_post |

@StoppedExperiments
Scenario: The Inactivity Modal form can be submitted
	Given I have navigated to the following page: letyourcottage
	When I wait 305 seconds
	And I enter Test Owner in the following form field: inactive-form_first_name
	And I enter test@test.com in the following form field: inactive-form_email
	And I enter 07000000000 in the following form field: inactive-form_phone
	And I click We're ready when you are
	And I click //*[@*='idle-enquiry-form']//button[@*='submit']
	And I wait 5 seconds
	Then the following page title is displayed: Thank you for your enquiry | Sykes Cottages
	And the relevant elements are dislpayed
	| Element                                     |
	| Hi, we’re ready when you are                |
	| Ask one of our property experts to call you |
	| Ask us to call you                          |
	| Start your Sykes letting journey online     |
	| Continue Online                             |

@StoppedExperiments
Scenario: The Request a Call hero form is displayed correctly
	Given I have navigated to the following page: <Path>
	When I apply the following experiment: LetYourCottages_TestRequestaCallForminHeroLYP166
	Then the following text is displayed: Get information and advice from our team of holiday letting experts
	Then the relevant elements are dislpayed within the request-a-call-hero section
	| Element                                                                            |
	| request-a-call-hero_first_name                                                     |
	| request-a-call-hero_last_name                                                      |
	| request-a-call-hero_phone                                                          |
	| Sykes' Group will use your number to call you about our property letting services. |
	| /terms/privacypolicy                                                               |
	When I select Get started within the request-a-call-hero section
	Then the relevant elements are dislpayed within the request-a-call-hero section
	| Element                                         |
	| request-a-call-hero_first_name_validation_error |
	| Please enter your first name.                   |
	| request-a-call-hero_last_name_validation_error  |
	| Please enter your surname.                      |
	| request-a-call-hero_phone_validation_error      |
	| Please enter a contact number.                  |
	When I enter test in the following form field: request-a-call-hero_phone
	When I select Get started within the request-a-call-hero section
	Then the following text is displayed: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	When I enter 070000000 in the following form field: request-a-call-hero_phone
	When I select Get started within the request-a-call-hero section
	Then the following text is displayed: Please provide a contact number that is no less than 10 digits long.
	When I enter 0700000000000000 in the following form field: request-a-call-hero_phone
	When I select Get started within the request-a-call-hero section
	Then the following text is displayed: Please provide a contact number that is no more than 15 digits long.
	When I enter +44 7000 000 000 in the following form field: request-a-call-hero_phone
	When I select Get started within the request-a-call-hero section
	Then the following element is not displayed: Please enter a valid contact number that does not include letters, spaces, special characters and contains no less than 10 digits.
	Then the following element is not displayed: Already started?
	And the relevant elements are not dislpayed
	| Element        |
	| marketing_sms  |
	| marketing_post |
	Examples:
	| Path                                                          |
	| letyourcottage/                                               |
	| letyourcottage/managed-services/                              |
	| letyourcottage/In-Your-Area/South-West                        |
	| letyourcottage/In-Your-Area/South-of-England                  |
	| letyourcottage/In-Your-Area/Heart-of-England                  |
	| letyourcottage/In-Your-Area/East-Anglia                       |
	| letyourcottage/In-Your-Area/Peak-District                     |
	| letyourcottage/In-Your-Area/North-York-Moors-and-Coast        |
	| letyourcottage/In-Your-Area/The-Lake-District-and-Cumbria     |
	| letyourcottage/In-Your-Area/Northumberland                    |
	| letyourcottage/In-Your-Area/Wales                             |
	| letyourcottage/In-Your-Area/Ireland                           |
	| letyourcottage/In-Your-Area/Scotland                          |
	| letyourcottage/information/marketing-your-holiday-let         |
	| letyourcottage/information/buy-own-sell-holiday-lets          |
	| letyourcottage/information/investment-advice-for-holiday-lets |
	| letyourcottage/information/legal-regulations-for-holiday-lets |
	| letyourcottage/information/holiday-let-mortgages              |
	| letyourcottage/information/how-to-run-your-holiday-let        |
	| letyourcottage/information/Tax-information-on-holiday-lets    |
	| letyourcottage/information/run-holiday-let-as-business        |
	| letyourcottage/information/leading-holiday-let-agency         |
	| letyourcottage/information/holiday-management-services        |

@StoppedExperiments
Scenario: The Income Projection is displayed upon interaction
	Given I have navigated to the following page: letyourcottage
	When I select option Northumberland from the region dropdown
	Then the following element is displayed: homepage_calculator_cta_blue

@StoppedExperiments
Scenario: Experiment LetYourCottages_MultiStepFormLYP67
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_MultiStepFormLYP67
	Then the relevant elements are dislpayed within the enquiry-multi-step section
	| Element                                                                                                   |
	| first_name                                                                                                |
	| last_name                                                                                                 |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	| /terms/privacypolicy                                                                                      |
	When I click //*[@*='enquiry-multi-step']/button[@*='submit']
	Then the following element is displayed: Please provide your first and last name
	When I enter Test in the following form field: //*[@*='enquiry-multi-step']//input[@*='first_name']
	And I enter Owner in the following form field: //*[@*='enquiry-multi-step']//input[@*='last_name']
	And I click //*[@*='enquiry-multi-step']/button[@*='submit']
	Then the relevant elements are dislpayed within the enquiry-form-step2 section
	| Element                                                                                                   |
	| phone                                                                                                     |
	| email                                                                                                     |
	| Your details will be used by the Sykes group to send you information about our property letting services. |
	When I click //*[@*='enquiry-form-step2']//button[@*='submit']
	Then the following element is displayed: Please provide at least one contact method
	When I enter 07000000000 in the following form field: //*[@*='enquiry-form-step2']//input[@*='phone']
	And I enter test@test.com in the following form field: //*[@*='enquiry-form-step2']//input[@*='email']
	And I click //*[@*='enquiry-form-step2']//button[@*='submit']
	Then the following element is displayed: Please ensure the following details are correct

@StoppedExperiments
Scenario: Experiment LetYourCottages_MultiStepFormFormFieldOrderLYP150
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_MultiStepFormFormFieldOrderLYP150

@StoppedExperiments
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

@StoppedExperiments
Scenario: Experiment LetYourCottages_LYPConversionFormFieldOrderLYP53
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_LYPConversionFormFieldOrderLYP53
	Then the relevant elements are dislpayed
	| Element                                                      |
	| //form[@*='heroform']/div[1]/label[@*='heroform_first_name'] |
	| //form[@*='heroform']/div[2]/label[@*='heroform_phone']      |
	| //form[@*='heroform']/div[3]/label[@*='heroform_email']      |

@StoppedExperiments
Scenario: Experiment LetYourCottages_HeroFormTitleChange24
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_HeroFormTitleChange24
	Then the following text is displayed: Start your letting journey with Sykes
	And the relevant elements are not dislpayed
	| Element                                                  |
	| Complete the form to receive your information pack       |
	| //div[@class='form-heading-container']//*[text()='Free'] |

@StoppedExperiments
Scenario: Experiment LetYourCottages_ImagesbeforecontentLYP32
	Given I have navigated to the following page: letyourcottage/information/investment-advice-for-holiday-lets/?dev_tools=product
	When I apply the following experiment: LetYourCottages_ImagesbeforecontentLYP32
	Then the following element is displayed: /images/let_your_cottage/lyp32-desktop-tablet.png

@StoppedExperiments
Scenario: Experiment LetYourCottages_AddLabeltoStickyEnquireButtonLYP44
	Given I have navigated to the following page: letyourcottage/information/buy-own-sell-holiday-lets/?dev_tools=product
	When I apply the following experiment: LetYourCottages_AddLabeltoStickyEnquireButtonLYP44
	And I scroll to the following element: page-footer
	Then the following element is displayed: //*[contains(@class,'fixed-bottom__fab-button')]//*[text()='Enquire today']

@StoppedExperiments
Scenario: Experiment LetYourCottages_AddLabeltoStickyBacktoTopIconLYP43
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: LetYourCottages_AddLabeltoStickyBacktoTopIconLYP43
	And I scroll to the following element: page-footer
	Then the following element is displayed: //a[@id='backtotop']//*[text()='Back to top']

@StoppedExperiments
Scenario: Experiment LetYourCottages_SearcherOnInfoPagesLYP46
	Given I have navigated to the following page: letyourcottage/information/investment-advice-for-holiday-lets/?dev_tools=product
	When I apply the following experiment: LetYourCottages_SearcherOnInfoPagesLYP46
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
	And the relevant elements are not dislpayed
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
	Then the relevant elements are not dislpayed
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
	And the relevant elements are not dislpayed
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
	Then the relevant elements are not dislpayed
		| Element                              |
		| An owner has just completed the form |
		| A new property has just gone live    |

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
	Then the relevant elements are not dislpayed
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
    And the relevant elements are dislpayed
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