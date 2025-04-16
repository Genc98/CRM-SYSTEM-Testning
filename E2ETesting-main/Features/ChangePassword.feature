Feature: Change Password
Opportunity to change password

    Scenario: Change password as new agent
        Given I am a new agent and I am on the change password page
        When I enter "theodor@hotmail.com" as existing email
        And I enter "kiruna" as new password
        And I click change password
        Then I will get a message below 
      
    Scenario: Change password as new agent with empty input
        Given I am a new agent and I am on the change password page
        When I enter "" as existing email
        And I enter "" as new password
        And I click change password
        Then I will get a message below that email and password are required 
        
    Scenario: Change password as new agent with non existing email
        Given I am a new agent and I am on the change password page
        When I enter "aaaaa@gmail.com" as existing email
        And I enter "udhuhfd" as new password
        And I click change password
        Then I will get a fail message below 
        
    Scenario: Change password as new agent with a deleted account
        Given I am a new agent and I am on the change password page
        When I enter "teddy@gmail.com" as existing email
        And I enter "sundsvall" as new password
        And I click change password
        Then I will get a message below
        
    
