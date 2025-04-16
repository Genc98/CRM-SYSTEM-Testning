Feature: Add Agent
Admin can add an agent
        
    Scenario: Add Agent
        Given I am logged in as admin and I am in the agentlist
        When I enter "Lars" as agents firstname
        And I enter "Larsson" as agents lastname
        And I enter "LarsLarsson@gmail.com" as agents email
        And I enter "12345678" as agents password
        Then I will click Add and the new agent will show up
        
        
    Scenario: Add Agent with empty inputs
        Given I am logged in as admin and I am in the agentlist
        When I enter "" as agents firstname
        And I enter "" as agents lastname
        And I enter "" as agents email
        And I enter "" as agents password
        Then I will click Add and the new agent will show up 
        And I will get a error message to fill all fields