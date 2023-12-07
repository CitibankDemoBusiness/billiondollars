# IO.Swagger.Model.EppRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EppLoanBookingType** | **string** | Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/apac/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description. | 
**Tenor** | [**decimal?**](BigDecimal.md) | Tenure of loan in months. | [optional] 
**LoanAmount** | **double?** | Eligible loan amount. Applicable only for EPP of type STATEMENT. | [optional] 
**TransactionReferenceIds** | [**List&lt;TransactionReferenceId&gt;**](TransactionReferenceId.md) |  | [optional] 
**TransactionAuthorizationCodes** | [**List&lt;TransactionAuthorizationCodes&gt;**](TransactionAuthorizationCodes.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

