Feature: See service list
Service list for admins to see

    Scenario: See service list
        Given I am logged in as admin and I am in the adminpage
        When I click the navbar and I click on list and I will be redirected to list page
        Then I click on delete to remove a handled ärende with "Mobilhållare" as productname
        
        