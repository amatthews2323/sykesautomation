Feature: Experiments
	Test specific experiments

@Experiments
Scenario: Get all active experiments from Holmes
	Given I am accessing http://holmes.staging.sykes.cloud/experiments
	Then I store the experiment IDs

@Experiments
Scenario: Get all active experiments in a given session
	Given I have navigated to the following page: letyourcottage
	When I store the active experiment IDs
	Given I am accessing http://holmes.prod.sykes.cloud/experiments
	When I search for the experiment details

@Experiments
Scenario: Experiment LetYourCottages_PnoProcess17640
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17640
	Then the following elements are dislpayed on the page
         | Element                |
         | How to list with Sykes |
         | Request for contact    |
         | Self-service           |
         | Start taking bookings  |

@Experiments
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

@Experiments
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

@Experiments
Scenario: Experiment LetYourCottages_AlertTob17803
	Given I have navigated to the following page: letyourcottage/holiday-homes-for-sale/?dev_tools=product
	When I apply the following experiment: 17803
	Then the following elements are dislpayed on the page
         | Element                  |
         | c-alert__icon-wrap       |
         | Enquire with Sykes today |
         | Get started              |

@Experiments
Scenario: Experiment LetYourCottages_FloatingActionButtonDesktopTablet17853
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17853
    And I set the window to tablet size
	Then the following elements are dislpayed on the page
         | Element                       |
         | Floating action button mobile |

@Experiments
Scenario: Experiment LetYourCottages_FullHeightHero17731
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17731
    Then the following elements are dislpayed on the page
         | Element                      |
         | o-icon o-icon-down-full-hero |

@Experiments
Scenario: Experiment LetYourCottages_SingleCTAWithinTheHero17973
	Given I have navigated to the following page: letyourcottage/?dev_tools=product
	When I apply the following experiment: 17973
    Then the following elements are dislpayed on the page
         | Element                                                        |
         | Let your property with Sykes and earn up to £125,000 per year* |
         | Get started today                                              |