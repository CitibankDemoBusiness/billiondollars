# IO.Swagger.Model.HistoryAndIntradayTransactionRecords
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionDate** | **DateTime?** | Transaction date in ISO 8601  format YYYY-MM-DD | [optional] 
**MerchantName** | **string** | This field indicates the merchant Name | [optional] 
**MerchantLocation** | **string** | This filed indicates the Merchant Address | [optional] 
**TransactionStatus** | **string** | This field provides the status of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. | [optional] 
**ReasonDescription** | **string** | Decline Description- for declined transaction | [optional] 
**TransactionAmount** | **double?** | Amount of funds the cardholder requested in source location of the transaction. | [optional] 
**TransactionCurrencyCode** | **string** | transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions | [optional] 
**BilledAmount** | **double?** | Amount billed to the cardholder in the cardholder account currency | [optional] 
**BilledCurrencyCode** | **string** | billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

