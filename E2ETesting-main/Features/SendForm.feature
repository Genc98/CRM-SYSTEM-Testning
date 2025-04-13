Feature: Send Form
	Send form to customer Service

Scenario: Send Forms
	Given I am on the CRM system startpage
	When I enter "Viktor12@hotmail.com" as the email
	And I enter "Robotdammsugare" as the service_product
	And I enter "Hej, min robotdammsugare har slutat navigera som den ska. Den fastnar ofta och kör i cirklar. Vad kan jag göra för att lösa problemet, eller behöver jag skicka tillbaka den?" as the message
	And I send the form
	Then I will get a confirmation that a confirmation email has been send

	
	
	
	