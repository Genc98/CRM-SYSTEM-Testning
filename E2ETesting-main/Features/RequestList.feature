Feature: See request list
Requests list for agents

    Scenario: See request list
        Given I am logged in as agent and I am in the dashboard
        When I click the navbar and I click requests
        And I see the requests I will press join chat
        And I will se a chat for specific request
        And I enter "Sara" as my username
        And I enter "Hej! Tack för att du hör av dig. Det låter inte som det ska – skicka gärna ditt ordernummer så hjälper vi dig att lösa det!" as my message
        And I click send 
        Then I will se my sent message 
       