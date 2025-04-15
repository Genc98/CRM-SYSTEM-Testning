Feature: See request list
Requests list for agents

    Scenario: See request list
        Given I am logged in as agent and am in the dashboard
        When I click the navbar and I click requests
        And I see the requests I will press join chat
        And I will se a chat for specific request
        And I enter "Sara" as my username
        And I enter "Hej! Det låter inte som det ska. Skicka gärna ditt ordernummer så hjälper vi dig att lösa det!" as my message
        Then I click send and will se my send message
       