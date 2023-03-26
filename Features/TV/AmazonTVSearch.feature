Feature: AmazonTVSearch

  As a user, I would like to search the TV in Amazon
  And Filter it on the search with available criteria
  And list it by price low to high

Rule: 
  1. Products are sorted by price
  2. Only Filtered products are listed

@search
Scenario: Verify Amazon Product Search with Filter for Sony TV
	Given I open the Amazon to Buy a product
	And I enter the product to be searched as Sony TV
	And I click on the search
    And I apply search filter by Brand with criteria as Sony
    And I apply search filter by Resolution with criteria as 4K
    And I apply search filter by Model Year with criteria as 2022
    And I will apply sort by Price: Low to High

 @search
Scenario: Verify Amazon Product Search with Filter for Samsung
	Given I open the Amazon to Buy a product
	And I enter the product to be searched as Samsung TV
	And I click on the search
    And I apply search filter by Brand with criteria as Samsung
    And I apply search filter by Resolution with criteria as 4K
    And I apply search filter by Model Year with criteria as 2022
    And I will apply sort by Price: Low to High
