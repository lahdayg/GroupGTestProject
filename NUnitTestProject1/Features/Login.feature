Feature: Login
	In order to use all the benefits on the website
	I will need to login first

@mytag
Scenario: Valid Registration
	Given I navigate to the website
	And I click on Signup Button
	And I enter my username
	#And I enter username text "Dele"
	And I enter my email address
	And I enter my password
	When I click on the sign up button
	Then I should be able to register successfully