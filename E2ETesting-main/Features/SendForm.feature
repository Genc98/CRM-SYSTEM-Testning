Feature: Send Form
	Send form to customer Service

Scenario: Send Forms
	Given I am on the CRM system startpage
	When I enter "Ingrid@hotmail.com" as the email
	And I enter "Handduk" as the service_product
	And I enter "Hej, handduken jag beställde fäller mycket färg vid tvätt och torkar dåligt. Är det normalt eller kan jag byta den?" as the message
	And I send the form
	Then I will get a confirmation that a confirmation email has been send

	
	
	
	