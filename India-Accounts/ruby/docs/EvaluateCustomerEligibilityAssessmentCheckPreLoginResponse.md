# SwaggerClient::EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**customer_name** | **String** | This refers to the name of the customer. | 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | [optional] 
**account_group** | **String** | Account Group associated with the source Account.This is a reference data field. Please use /v1/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. | [optional] 
**maximum_eligible_loan_amount** | **Float** | The maximum amount of credit that extend to a customer | 
**minimum_eligible_loan_amount** | **Float** | The minimum amount of credit that extend to a customer | 
**offer_indicator** | **String** | Indicator to determine if offer is rate or fee based. This is a reference data field. Please use /v1/apac/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | 
**loan_booking_plan** | [**Array&lt;LoanBookingPlan&gt;**](LoanBookingPlan.md) |  | [optional] 
**lop_category** | **String** | Indicator to determine the type of LOP Offer. This is a reference data field. Please use /v1/utilities/referenceData/{lopCategory} resource to get valid value of this field with description. | [optional] 

