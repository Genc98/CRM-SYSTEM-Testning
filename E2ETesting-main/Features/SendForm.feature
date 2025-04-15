Feature: Send Form
	Send form to customer Service

Scenario: Send Forms
	Given I am on the CRM system startpage
	When I enter "Vigo@hotmail.com" as the email
	And I enter "USB-kabel" as the service_product
	And I enter "Hej, USB-kabeln jag beställde fungerar inte när jag försöker ladda min telefon. Jag har testat flera enheter men inget händer. Vad kan jag göra?" as the message
	And I send the form
	Then I will get a confirmation that a confirmation email has been send

	
	
	
	