Feature: Delete Agent
Delete a agent

    Scenario: Delete Agent
        Given I am logged in as admin and I am in the agentlist
        Then I press the delete button for specific agent with email 'teddy@gmail.com'