Feature: Registration
	In Order to benefit from the website
	I will need to first register

@mytag
Scenario: Valid Registration
	Given I navigate to the website
	And I enter my first name
	And I enter my last name
	And I enter my email address
	And I enter my phone number
	And I click on my gender
	#When I click on submit button
	#Then I can register successfully