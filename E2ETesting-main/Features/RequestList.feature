Feature: See request list
Requests list for agents

    Scenario: See request list
        Given I am logged in as agent and am in the dashboard
        When I click the navbar and I click requests
        When I see the requests I will press join chat
        Then I will se a chat for specific request
       