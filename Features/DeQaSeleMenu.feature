Feature: DeQaSeleDropdwn

A short summary of the feature

@Dropdown
Scenario: Select Menu dropdown
    Given I navigate to Demoqa website 
    Then I verify that home page is displayed successfully
    When I click Widgets tab menu
        And I validate the page is displayed  
        And I click on select menu
        And I click on dropdown to Select group Option
        And I click on dropdown to Select the Title 
        And I select a color from the dropdown labeled Old Style
        And I click on dropdown to Select Multi Colour
        And I click on dropdown to select multi standard 
        | Cars  |
        | volvo |
        | Opel  |
        | audi  |
        | Saab  |
    Then the selected menus should be validated

