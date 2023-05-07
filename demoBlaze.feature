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
When  i clicked on contacts  
Then i enter "<email>" as email,"<contact>" as contact and "<message>" as message
And click on send

Examples: 
| email          | contact    | message  |
| lily@gmail.com | liy        | hello    |
| john@gmail.com | john       | good day |
| eva@gmail.com  | eva        | good bye |


Scenario: To verify if a item is added successfully
Given user is loggedin in the website
When i click on laptop section
And click on Macbook Air to add it to the cart
Then I navigate to the cart
And I verify whether the Macbook Air is present or not
