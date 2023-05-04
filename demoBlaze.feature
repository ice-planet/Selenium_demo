Feature: demoBlaze

DemoBlaze Application testing


Scenario: Signup for a new user using any unique username and password
	Given I am in Home page of demoBlaze website
	When I click on signup
	And enter the username and password
	Then by clicking signup I should be able to signup successfully
	And login to the website using the same
