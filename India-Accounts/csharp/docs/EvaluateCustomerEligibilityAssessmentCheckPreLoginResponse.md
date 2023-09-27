# IO.Swagger.Model.EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerName** | **string** | This refers to the name of the customer. | 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | [optional] 
**AccountGroup** | **string** | Account Group associated with the source Account.This is a reference data field. Please use /v1/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. | [optional] 
**MaximumEligibleLoanAmount** | **double?** | The maximum amount of credit that extend to a customer | 
**MinimumEligibleLoanAmount** | **double?** | The minimum amount of credit that extend to a customer | 
**OfferIndicator** | **string** | Indicator to determine if offer is rate or fee based. This is a reference data field. Please use /v1/apac/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | 
**LoanBookingPlan** | [**List&lt;LoanBookingPlan&gt;**](LoanBookingPlan.md) |  | [optional] 
**LopCategory** | **string** | Indicator to determine the type of LOP Offer. This is a reference data field. Please use /v1/utilities/referenceData/{lopCategory} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

