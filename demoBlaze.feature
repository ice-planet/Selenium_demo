Feature: demoBlaze

DemoBlaze Application testing


Scenario: Signup for a new user using any unique username and password
	Given I am in Home page of demoBlaze website
	When I click on signup
	And enter the username and password
	Then by clicking signup I should be able to signup successfully
	And login to the website using the same


Scenario Outline: Sending messages to multiple users
Given user is loggedin
When  i clicked on contacts and write <email>,<contact>,<message>
Then i successfully sent the messages

Examples: 
| email          | contact    | message  |
| lily@gmail.com | 9578402908 | hello    |
| john@gmail.com | 9888777666 | good day |
| eva@gmail.com  | 8333444555 | good bye |
