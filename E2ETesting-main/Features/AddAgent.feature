Feature: Add Agent
Admin can add an agent
        
    Scenario: Add Agent
        Given I am logged in as admin and I am in the agentlist
        When I enter "Lars" as agents firstname
        And I enter "Larsson" as agents lastname
        And I enter "LarsLarsson@gmail.com" as agents email
        And I enter "12345678" as agents password
        Then I will click Add and the new agent will show up