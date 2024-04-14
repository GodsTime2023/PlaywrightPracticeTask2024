Feature: Calculator

As a user i want to be able to complete Elements form

@Elements
Scenario: Complete Element Form
	Given user is on demoqa page
	When user click on Elements
	And user click Text Box menu
	And user enters the following details
	| FullName | Email      | CurrentAddress   | ParmanentAddress  |
	| Test     | A@test.com | mycurrentaddress | myparmanentadress |
	And user click submit button
	Then the following details are displayed in output
	| FullName | Email      | CurrentAddress   | ParmanentAddress  |
	| Test     | A@test.com | mycurrentaddress | myparmanentadress |