Feature: SwitchWindow

A short summary of the feature

@Switch
Scenario: Switch between Tab
	Given user is on demoqa page
	When user click on Alerts, Frame & Windows
	Then I am on alert windows page
	When I click Browser windows
		And I click New Tab button
		And I switch to the new tab
	Then I am on browser windows new tab page
	Then 'This is a sample page' is displayed on tab page 2

@Switch
Scenario: Switch between Window
	Given user is on demoqa page
	When user click on Alerts, Frame & Windows
	Then I am on alert windows page
	When I click Browser windows
		And I click New Window button
		And I switch to the new window
	Then I am on browser windows new window page
	Then 'This is a sample page' is displayed on window page 2