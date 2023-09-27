# IO.Swagger.Model.LoanAccountSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the product | [optional] 
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**AccountNickname** | **string** | The nickname of the account assigned by the customer | [optional] 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | [optional] 
**AccountId** | **string** | The customer account identifier in encrypted format. | [optional] 
**CurrencyCode** | **string** | The currency code in ISO 4217 format | [optional] 
**AccountClassification** | **string** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**AccountStatus** | **string** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**OriginalPrincipalAmount** | **double?** | The amount borrowed | [optional] 
**OutstandingBalance** | **double?** | The amount of money owed. | [optional] 
**NextPaymentAmount** | **double?** | The next payment amount due | [optional] 
**NextPaymentDate** | **DateTime?** | The date of the next payment in ISO 8601 date format YYYY-MM-DD | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

