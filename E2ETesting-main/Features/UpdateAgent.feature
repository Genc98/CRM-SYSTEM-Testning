Feature: Update Agent
Update agent information

    Scenario: Update Agent
        Given I am logged in as admin and I am in the agentlist
        When I press the edit button for specific agent and edit form will show up
        Then I want to update an agents data to 'Molly','Rovan','MolRovan@hotmail.com', 'landskrona1332' and press save
       
        