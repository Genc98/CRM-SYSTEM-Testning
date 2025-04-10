Feature: Send Form
	Send form to customer Service

Scenario: Send Forms
	Given I am on the CRM system startpage
	When I enter "Helena@gmail.com" as the email
	And I enter "Trådlös Mus" as the service_product
	And I enter "Hej, min trådlösa mus fungerar inte längre – den svarar inte trots nya batterier och omstart. Vad kan problemet vara, och kan jag få hjälp med detta? Tack på förhand!" as the message
	And I send the form
	Then I will get a confirmation that a confirmation email has been send

	
	
	
	