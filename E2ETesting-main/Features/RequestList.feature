Feature: See request list
Requests list for agents

    Scenario: See request list
        Given I am logged in as agent and I am in the dashboard
        When I click the navbar and I click requests
        And I see the requests I will press join chat
        And I will se a chat for specific request
        And I enter "Sara" as my username
        And I enter "Hej! Testa gärna att rengöra ytan noggrant innan du sätter upp kroken. Om problemet kvarstår kan vi hjälpa dig med en ersättning – skicka gärna ditt ordernummer. " as my message
        Then I click send and I will send my message
       