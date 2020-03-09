Feature: Customer
	In order to manage Customer record
	As a Turn Up portal admin
	I want to Add, Edit and Delete Customer Record

@automation @p1
Scenario: Add a new Customer entry with valid data
	Given I have logged in TUrnUp Portal
	And I have selected Customer page
	Then I shoud be able to Add new customer with valid data

@automation @p1
Scenario: Edit a Customer entry with valid data
	Given I have logged in TUrnUp Portal
	And I have selected Customer page
	Then I should be able to Edit customer with valid data

@automation @p1
Scenario: Delete a Customer
	Given I have logged in TUrnUp Portal
	And I have selected Customer page
	Then I should be able to Delete Customer