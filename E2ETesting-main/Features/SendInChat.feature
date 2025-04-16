Feature: Chat
Send a message in chat

    Scenario: Chat
        Given I am on the Chat as a agent or customer
        When I enter "Fredde" as my username
        And I enter "Hej! Väggkroken lossnar hela tiden från väggen. Vad kan jag göra?" as my message
        Then I click send and I will send my message
        
        