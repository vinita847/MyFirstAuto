Feature: TimeandMaterial
	In order to manage Time and Material record
	As a Turn Up portal admin
	I want to Add, Edit and Delete Time and Material Record

@automation @p1
Scenario: Add a new Time and Material entry with valid data
	Given I have logged in TurnUp Portal
	And I have selected Time and Material page
	Then I should be able to add new Time and Material entry with valid data

@automation @p1
Scenario: Edit a new Time and Material entry with valid data
	Given I have logged in TurnUp Portal
	And I have selected Time and Material page
	Then I should be able to Edit Time and Material entry with valid data

@automation @p1
Scenario: Delete a new Time and Material entry with valid data
	Given I have logged in TurnUp Portal
	And I have selected Time and Material page
	Then I should be able to Delete Time and Material entry with valid data

@automation
Scenario: Add a new Time and Material entry with invalid data
    Given I have logged in TurnUp Portal
	And I have selected Time and Material page
	Then I should not be able to add new Time and Material entry with invalid data

@automation
Scenario: Edit a Time and Material entry with invalid data
	Given I have logged in TurnUp Portal
	And I have selected Time and Material page
	Then I should not be able to Edit Time and Material entry with invalid data

@manual
Scenario: Validate UI for Time and Material page
	Given I have logged in TurnUp Portal
	And I have selected Time and Material page
	Then The layout of the page should be expected for all Add, Edit and Delete functionalities 

@manual @p1
Scenario: Validate pagination function (UX) for Time and Material
	Given I have logged in TurnUp Portal
	And I have selected Time and Material page
	Then I should be able to perform pagination function for pages as expected

@manual @p2
Scenario: Validate refresh button (UX) for Time and Material
	Given I have logged in TurnUp Portal
	And I have selected Time and Material page
	Then I should be able to click on refresh and perform the action

@manual @p2
Scenario: Validate table headers functionalities (UX) for Time and Material
	Given I have logged in TurnUp Portal
	And I have selected Time and Material page
	Then I should be able to perfoem Table headers icon for ascending and descending

@manual @p1 @mac
Scenario: Cross system test to ensure the look and feel of the Time and Material page on mac
	Given I have mac system
	And I navigate to Time and Material page on mac system
	Then Time and Material page should work perfectly on mac system

@manual @p1 @UNIX
Scenario: Cross system test to ensure the look and feel of the Time and Material page on UNIX system
	Given I have UNIX system
	And I navigate to Time and Material page on UNIX system
	Then Time and Material page should work perfectly on UNIX system

@manual @p1 @Windows
Scenario: Cross system test to ensure the look and feel of the Time and Material page on windows
	Given I have windows system
	And I navigate to Time and Material page on windows system
	Then Time and Material page should work perfectly on windows system

@manual @p1 @Android
Scenario: Cross Mobile device test for Android
	Given I have mac system
	And I navigate to Time and Material page on Android moblie
	Then Time and Material page should work perfectly on Anroid mobile

@manual @p1 @IOS
Scenario: Cross Mobile device test for IOS
	Given I have an Android mobile device
	And I navigate to Time and Material page on IOS mobile
	Then Time and Material page should work perfectly on mac system

@manual @p2
Scenario: Responsiveness of Time and Material page
	Given I have logged in TurnUp Portal
	And I have selected Time and Material page
	Then The responce of TIme and Material page should be expected