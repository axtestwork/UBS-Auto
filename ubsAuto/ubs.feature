Feature: ubs
	Automate UBS

@mytag
Scenario: Navigate to url and Verify the page title
	Given I open the browser
	When I navigate to URL
	Then I can see Page title

Scenario: Verify What we offer
	Given I navigate to URL
	When I Navigate to What we offer page
	Then I can see valid offer links

Scenario: Verify About US
	Given I navigate to URL
	When I Navigate to What we offer page
	When I Navigate to About US page
	Then I can see About US page as landing page

Scenario: Verify Focus page
	Given I navigate to URL
	When I Navigate to What we offer page
	When I Navigate to Focus page
	Then I can see Focus Submenu

Scenario: Verify Regulatory Directory
	Given I navigate to URL
	When I Navigate to What we offer page
	When I Navigate to Regulatory Directory
	Then I can see Regulatory Directory