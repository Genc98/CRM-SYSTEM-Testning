Feature: Login Admin
Login as a admin

    Scenario: Login as a Admin
        Given I am on the CRM system startpage
        When I click on login and will get to login page
        And I enter "<email>" as email 
        And I enter "<password>" as password 
        And I select "<role>" as role
        And I click login as admin
        Then I am on the dashboard for admins
         
         
    Examples:
      | email            | password | role  |
      | admin1@gmail.com | 12345678 | admin |
      | admin2@gmail.com | 87654321 | admin |
      
     