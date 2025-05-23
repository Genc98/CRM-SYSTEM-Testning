Feature: Login Agent
Login as a agent

    Scenario Outline: Login as a Agent
         Given I am on the CRM system startpage
         When I click on login and will get to login page
         And I enter "<email>" as email 
         And I enter "<password>" as password 
         And I select "<role>" as role
         And I click login as agent
         Then I am on the dashboard
         
         
    Examples:
      | email               | password | role  |
      | valllle25@gmail.com | hello123 | agent |
      | Sara@gmail.com      | sara123  | agent |
      