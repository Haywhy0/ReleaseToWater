Feature: ReleaseToWater
	I want to login to application
	so am able to create new records ,verify and delete records

Background: Release To Water
Given I navigate to https://stirling.she-development.net/automation
And I logged in to application 
When I click on modules dropdown
And Select Environment
And select Release to water


@Record1
Scenario: Create New Record1
	When  I click on new record button
	And I fill the description fields 
	And I fill the sample date
	And I click save and close button
	Then A new record is sucessfully created

@Record2
	Scenario: Create New Record2
	When  I click on new record button 
	And I fill the description field
	And I enter the sample date
	And I click save and close button
	Then A new record is sucessfully created

@Delete
	Scenario: Delete New Record1
	When I click on coqdropdown record1
	And I click on delete
	And I click on confirm Button
	Then I Logout