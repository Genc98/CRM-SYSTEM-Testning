Feature: Send Form
	Send form to customer Service

Scenario: Send Forms
	Given I am on the CRM system startpage
	When I enter "Britney@hotmail.com" as the email
	And I enter "Vattenkokare" as the service_product
	And I enter "Hej, min vattenkokare stänger inte av sig automatiskt när vattnet kokar. Är det något fel eller kan jag justera det på något sätt?" as the message
	And I send the form
	Then I will get a confirmation that a confirmation email has been send

	
	
	
	