Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Login as admin
	Given I navigate to homepage
	And I enter username and password
	| Username | Password |
	| Agent    | agent    |
	And I click login
	Then I should see user is logged in
