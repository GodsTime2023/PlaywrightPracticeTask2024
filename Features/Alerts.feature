Feature: Alerts

As a user, I want to be able to click and see alerts

@Alert
Scenario: First Alert button
	Given user is on demoqa page
	When user click on Alerts, Frame & Windows
	Then I am on alert windows page
	And I click Alerts 
	And I click on the first Click me button 
	Then an alert message is displayed

@Alert
Scenario: Second Alert button
	Given user is on demoqa page
	When user click on Alerts, Frame & Windows
	Then I am on alert windows page
	And I click Alerts 
	And I click on the second Click me button 
	Then an Alert message will appear 5 second later

@Alert
Scenario: Third Alert button
	Given user is on demoqa page
	When user click on Alerts, Frame & Windows
	Then I am on alert windows page
	And I click Alerts
	And I click on the third Click me button 
	Then I click on the OK or Cancel button
	And the following text is displayed in green:
	| value           |
	| You selected Ok |

@Alert
Scenario: Fourth Alert button
	Given user is on demoqa page
	When user click on Alerts, Frame & Windows
	Then I am on alert windows page
	And I click Alerts 
	And I click on the fourth Click me button 
	And I enter the following word:
	| value     |
	| Masterful |
	And I click ok button
	Then the following word is displayed in green color:
	| value     |
	| Masterful |


