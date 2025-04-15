Feature: See request list
Requests list for agents

    Scenario: See request list
        Given I am logged in as agent and I am in the dashboard
        When I click the navbar and I click requests
        And I see the requests I will press join chat
        And I will se a chat for specific request
        And I enter "Sara" as my username
        And I enter "Hej! Tack för att du hör av dig. Om ficklampan inte fungerar trots nya batterier låter det som ett fel. Skicka gärna ditt ordernummer så hjälper vi dig vidare!" as my message
        Then I click send and I will see my send message
       