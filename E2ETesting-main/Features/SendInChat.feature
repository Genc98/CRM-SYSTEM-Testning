Feature: Chat
Send a message in chat

    Scenario: Chat
        Given I am on the Chat as a agent or customer
        When I enter "Viktor" as my username
        And I enter "Okej, tack för svar!" as my message
        Then I click send and will se my send message
        