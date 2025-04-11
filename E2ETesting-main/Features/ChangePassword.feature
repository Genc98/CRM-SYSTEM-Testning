Feature: Change Password
Opportunity to change password

    Scenario: Change password as new agent
        Given I am a new agent and I am on the change password page that i recived from my email
        When I enter "Dolly@hotmail.com" as existing email
        And I enter "helloworld" as new password
        And I click change password
        Then I will get a message below 
       