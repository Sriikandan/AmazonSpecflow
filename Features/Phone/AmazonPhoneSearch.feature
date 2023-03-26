﻿Feature: AmazonPhoneSearch

  As a user, I would like to search the Phone in Amazon
  And Filter it on the search with available criteria
  And list it by price low to high

Rule: 
  1. Products are sorted by price
  2. Only Filtered products are listed
 @search
Scenario: Verify Amazon Product Search with Filter for iPhone
	Given I open the Amazon to Buy a product
	And I enter the product to be searched as Phone
	And I click on the search
    And I apply search filter by Brand with criteria as Apple
    And I apply search filter by Screen Size with criteria as 5.5 in & above
    And I apply search filter by Model Year with criteria as 2022
    And I will apply sort by Price: Low to High
