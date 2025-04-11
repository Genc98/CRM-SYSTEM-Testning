Feature: Send Form
	Send form to customer Service

Scenario: Send Forms
	Given I am on the CRM system startpage
	When I enter "Viktor12@hotmail.com" as the email
	And I enter "Bärbar AC" as the service_product
	And I enter "Hej, jag har nyligen köpt en bärbar AC men den verkar inte kyla som den ska. Den blåser bara ljummen luft trots att den varit igång länge. Vad kan det bero på, och kan jag få hjälp med detta?" as the message
	And I send the form
	Then I will get a confirmation that a confirmation email has been send

	
	
	
	