Feature: Chat
Send a message in chat

    Scenario: Chat
        Given I am on the Chat as a agent or customer
        When I enter "Gustav" as my username
        And I enter "Kan jag lämna tillbaka laddkabeln" as my message
        Then I click send and will se my send message
        