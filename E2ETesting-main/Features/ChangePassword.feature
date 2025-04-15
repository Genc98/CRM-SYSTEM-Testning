Feature: Change Password
Opportunity to change password

    Scenario: Change password as new agent
        Given I am a new agent and I am on the change password page
        When I enter "teddy@gmail.com" as existing email
        And I enter "teddy123" as new password
        And I click change password
        Then I will get a message below 
       