# IO.Swagger.Model.SourceAccountsCrossBorderWireTransfer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The primary identifier for ownership of an account.The source account identifier in encrypted format.Typically, this is not displayed to the customer,use displayAccountNumber instead. | 
**DisplaySourceAccountNumber** | **string** | A masked account number that can be displayed to the customer | 
**ProductName** | **string** | The name of the product | [optional] 
**SourceAccountCurrencyCode** | **string** | The currency code of the source account in ISO 4217 format | 
**AccountNickname** | **string** | The nickname of the account assigned by the customer | [optional] 
**AccountGroup** | **string** | Account Group associated with the source Account.This is a reference data field. Please use /v1/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. | 
**AvailableBalance** | **double?** | The available balance including any pending or in progress deposits and withdrawals | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

