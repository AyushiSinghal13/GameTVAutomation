Feature: UserForm
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Enter user details
	Given I navigate to homepage
	And I enter username and password
	| Username | Password |
	| Agent    | agent    |
	And I click login	
	And I start entering user details
	Then User details should be added successfully