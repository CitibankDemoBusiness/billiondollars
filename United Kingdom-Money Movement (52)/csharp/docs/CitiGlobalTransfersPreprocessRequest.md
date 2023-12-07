# IO.Swagger.Model.CitiGlobalTransfersPreprocessRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The source account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**PayeeId** | **string** | The payee identifier in encrypted format.Typically, this is not displayed to the customer. | 
**TransactionAmount** | **double?** | The transaction amount | 
**TransactionCurrencyCode** | **string** | The currency code for the transaction amount in ISO 4217 format. | [optional] 
**TransferPurpose** | **string** | Purpose of transfer.Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

