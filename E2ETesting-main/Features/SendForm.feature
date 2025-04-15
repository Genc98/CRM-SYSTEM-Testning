Feature: Send Form
	Send form to customer Service

Scenario: Send Forms
	Given I am on the CRM system startpage
	When I enter "Hasse@hotmail.com" as the email
	And I enter "Ficklampa" as the service_product
	And I enter "Hej, ficklampan jag beställde fungerar inte alls. Jag har satt i nya batterier men den lyser inte. Vad gör jag nu?" as the message
	And I send the form
	Then I will get a confirmation that a confirmation email has been send

	
	
	
	