Feature: Chat
Send a message in chat

    Scenario: Chat
        Given I am on the Chat as a agent or customer
        When I enter "Viktor" as my username
        And I enter "Hej! Min robotdammsugare fastnar hela tiden och kör bara runt i cirklar. Vad kan jag göra?" as my message
        Then I click send and will se my send message
        