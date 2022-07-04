Feature: TestBuilder
	Tests to help with writing more tests

@TestBuilder
Scenario: Get all headers on the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/letyourcottage
	Then I store all headers on the page

@TestBuilder
Scenario: Get all links on the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/letyourcottage
	Then I store all links on the page

@TestBuilder
Scenario: Get all images on the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/letyourcottage
	Then I store all images on the page

@TestBuilder
Scenario: Build a test that checks all headers on the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/letyourcottage
	Then I store the headers and output a test script

@TestBuilder
Scenario: Build a test that checks all links on the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/letyourcottage
	Then I store the links and output a test script

@TestBuilder
Scenario: Build a test that checks all images on the page
	Given I am on the following webpage: https://www.sykescottages.co.uk/letyourcottage
	Then I store the images and output a test script