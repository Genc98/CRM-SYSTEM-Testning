Feature: Send Form
	Send form to customer Service

Scenario: Send Forms
	Given I am on the CRM system startpage
	When I enter "Anna@hotmail.com" as the email
	And I enter "Diskborste" as the service_product
	And I enter "Hej, diskborsten jag fick gick sönder efter bara ett par användningar. Borsten lossnade från handtaget. Kan jag få en ny?" as the message
	And I send the form
	Then I will get a confirmation that a confirmation email has been send

	
	
	
	