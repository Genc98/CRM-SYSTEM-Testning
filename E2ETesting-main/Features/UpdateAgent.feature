Feature: Update Agent
Update agent information

    Scenario: Update Agent
        Given I am logged in as admin and I am in the agentlist
        When I press the edit button for specific agent
        Then I want update an agents data to 'Dory','William','Dory@hotmail.com', 'hejsan' as press save
       
        