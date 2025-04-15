Feature: Chat
Send a message in chat

    Scenario: Chat
        Given I am on the Chat as a agent or customer
        When I enter "Hasse" as my username
        And I enter "Hej! Min ficklampa fungerar inte alls trots nya batterier. Vad kan jag göra?" as my message
        Then I click send and I will see my send message
        