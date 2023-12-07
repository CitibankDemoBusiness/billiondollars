# IO.Swagger.Model.AdhocCitiGlobalTransfersPreprocessRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The source account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**PayeeAccountDetails** | [**PayeeAccountDetailsAdhocCitiGlobalTransferPreprocess**](PayeeAccountDetailsAdhocCitiGlobalTransferPreprocess.md) |  | 
**TransactionAmount** | **double?** | The transaction amount | 
**TransferCurrencyIndicator** | **string** | Indicator to specify whether the transfer is in source or destination account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description. | 
**TransferPurpose** | **string** | This is to indicate the purpose of transfer. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description. | [optional] 
**Remarks** | **string** | Free text that usually describes purpose of payment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

