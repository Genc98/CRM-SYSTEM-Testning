Feature: Chat
Send a message in chat

    Scenario: Chat
        Given I am on the Chat as a agent or customer
        When I enter "Genc" as my username
        And I enter "Hej! Min vattenflaska läcker från locket även när den är stängd. Vad kan jag göra?" as my message
        Then I click send and will se my send message
        