# IO.Swagger.Model.MutualFundAccountSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the product | [optional] 
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**AccountNickname** | **string** | The nickname of the account assigned by the customer | [optional] 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | [optional] 
**AccountId** | **string** | The customer account identifier in encrypted format. | [optional] 
**CurrencyCode** | **string** | The currency code in ISO 4217 format | [optional] 
**AccountStatus** | **string** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**AccountClassification** | **string** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**CurrentBalance** | **double?** | Total fund value for the Investment mutual fund account. It is the current market worth of investment | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

