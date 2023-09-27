# IO.Swagger.Model.OriginalTransactionDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentType** | **string** | The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. | [optional] 
**TransactionDate** | **DateTime?** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, | [optional] 
**TransactionAmount** | **double?** | Transaction amount in account currency. | [optional] 
**TransactionCurrencyCode** | **string** | The currency code for the foreign transaction amount in ISO 4217 format. | [optional] 
**TransactionStatus** | **string** | Transaction Status of the original transaction | [optional] 
**TransactionReferenceNumber** | **string** | Transaction reference number of the original transaction | [optional] 
**TransactionRemarks** | **string** | Transaction Remarks of the original transaction | [optional] 
**EndToEndIdentification** | **string** | End to End Identification reference of the original transaction | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

