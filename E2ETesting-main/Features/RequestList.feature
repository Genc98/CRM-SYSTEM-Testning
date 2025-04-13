Feature: See request list
Requests list for agents

    Scenario: See request list
        Given I am logged in as agent and am in the dashboard
        When I click the navbar and I click requests
        And I see the requests I will press join chat
        And I will se a chat for specific request
        And I enter "Lars" as my username
        And I enter "Hej! Det låter frustrerande. Har du testat att rengöra sensorerna och återställa enheten? Om problemet kvarstår kan vi hjälpa dig vidare med en reklamation." as my message
        Then I click send and will se my send message
       