# EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**customer_name** | **string** | This refers to the name of the customer. | 
**display_account_number** | **string** | A masked account number that can be displayed to the customer | [optional] 
**account_group** | **string** | Account Group associated with the source Account.This is a reference data field. Please use /v1/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. | [optional] 
**maximum_eligible_loan_amount** | **double** | The maximum amount of credit that extend to a customer | 
**minimum_eligible_loan_amount** | **double** | The minimum amount of credit that extend to a customer | 
**offer_indicator** | **string** | Indicator to determine if offer is rate or fee based. This is a reference data field. Please use /v1/apac/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | 
**loan_booking_plan** | [**\Swagger\Client\Model\LoanBookingPlan[]**](LoanBookingPlan.md) |  | [optional] 
**lop_category** | **string** | Indicator to determine the type of LOP Offer. This is a reference data field. Please use /v1/utilities/referenceData/{lopCategory} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

