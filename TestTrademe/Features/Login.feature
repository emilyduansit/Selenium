Feature: Login
	In order to avoid silly mistakes
	As a user
	I want to search a car

@mytag
Scenario: search same name cars
	Given gotohomepage
	And clickmotor
	When input car name and click search
	Then get search results