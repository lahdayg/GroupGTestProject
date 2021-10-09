Feature: DataDrivenWithParameter
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Signup Button
	And I enter username text "Richard4567"
	And I enter my email address "learnwithpride44"
	And I enter my password "PasswordSecure"
	When I click on the sign up button
	Then I should be able to register successfully