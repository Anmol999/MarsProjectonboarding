Feature: AddSellerProfile
	As I am a skilled I
	I would like to add the profile details
	So that people seeking for skills can look into my details
#
#@Positive
#Scenario: Add the descrption details
#	Given I login to the website
#	And I navigate to profile page
#	When I click on description's edit button
#	And I add descrption details
#	Then I should be able to add description details to the profile

#	@Negative
#Scenario Outline: Add the descrption details with invalid value
#	Given I login to the website
#	And I navigate to profile page
#	When I click on description's edit button
#	And I add invalid '<Description>' details
#	Then I should not be able to add description details to the profile
#	Examples: 
#	|Description|
#	||
#	|DuplicateDescription1|
#	|DuplicateDescription2|	
	

	@Positive
	Scenario: Add the language and update the details
	Given Seller login to the website 
	And navigate to profile page
	Then I should be able to add language's details to the profile
	Then I Should be able to update language's details to the profile

#	@Negative
#Scenario Outline: Add the languages details with invalid value
#	Given I login to the website
#	And I navigate to profile page
#	When I click on laguages edit button
#	And I add invalid '<Language>', '<Lev>' details
#	Then I should not be able to add languages details to the profile
#	Examples: 
#	| Language           | Lev  |
#	|||
#	| DuplicateLanguage1 | Fluent |
#	| DuplicateLanguage2 | Fluent |
#	
#	@Positive
#	Scenario: Add the skills details
#	Given I login to the website
#	And I navigate to profile page
#	When I click on skill's add button
#	And I add skills details
#	Then I should be able to add skills details to the profile


	@Negative
Scenario Outline: Add the skills details with invalid value(Null)
	Given Seller login to the website
	And navigate to profile page
	Then I should not be able to add skills details to the profile



	@Positive
Scenario Outline: Add the education details and delete it 
	Given Seller login to the website
	And navigate to profile page
	Then I should be able to add education datails like '<CollegeName>','<Degree>','<Countr>','<Tit>' to the profile
	Then I should be able to delete the education details with added '<CollegeName>','<Degree>','<Countr>','<Tit>'
	Examples: 
	| College       | Deg          | Countr      | Tit |
	| Valid College | Valid Degree | New Zealand | PHD |

	#@Negative
#Scenario Outline: Add the education details with invalid value
#	Given I login to the website
#	And I navigate to profile page
#	And I add invalid '<CollegeName>','<Degree>','<Countr>','<Tit> ','<Yr>' details
#	Then I should not be able to add education details to the profile
#	Examples: 
#	| College           | Deg       | Countr       | Tit | Yr   |
#	||||||
#	| DuplicateCollege1 | Degreege1 | New Zewaland | PHD | 2020 |
#	| DuplicateCollege2 | Degreege2 | New Zewaland | PHD | 2020 |

#	
#	@Positive
#	Scenario: Add the certification details
#	Given I login to the website
#	And I navigate to profile page
#	When I click on certification's add button
#	And I add certification details
#	Then I should be able to add certification deatils to the profile
#
#	@Negative
#Scenario Outline: Add the certification details with invalid value
#	Given I login to the website
#	And I navigate to profile page
#	When I click on certification edit button
#	And I add invalid '<Certification>','<CertificationForm>','<Yr>' details
#	Then I should not be able to add certification details to the profile
#	Examples: 
#	| Certification | CertificationForm | Yr |
#	||||
#	| DuplicateCertification1 | CertificationForm1 | 2020 |
#	| DuplicateCertification2 | CertificationForm2 | 2020 |

	#@Positive
	#Scenario: Select the availaibility details
	#Given I login to the website
	#And I navigate to profile page
	#Then I should be able to select avialaibility to the profile

#	@Positive
#	Scenario: Select the hours details
#	Given I login to the website
#	And I navigate to profile page
#	When I click on hours's edit button
#	And I Select the required hours option
#	Then I should be able to select hours to the profile
#
#	@Positive
#	Scenario: Select the earn target details
#	Given I login to the website
#	And I navigate to profile page
#	When I click on earn's edit button
#	And I Select the required earn target option
#	Then I should be able to select earn target to the profile