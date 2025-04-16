Feature: Chat
Send a message in chat

    Scenario: Chat
        Given I am on the Chat as a agent or customer
        When I enter "Ingrid" as my username
        And I enter "Hej! Handduken jag köpte fäller färg och torkar inte bra. Vad kan jag göra?" as my message
        And I click send 
        Then I will se my sent message 
        
        