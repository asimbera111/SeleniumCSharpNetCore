Feature: Login
	Check if login functionality works

@mytag
Scenario: Login user as administrator
	Given I navigate to application
	And I click the login link
	When I enter username and password
		| username | password |
		| admin    | password |  
	And I click login
	Then I should see user logged in to the application
