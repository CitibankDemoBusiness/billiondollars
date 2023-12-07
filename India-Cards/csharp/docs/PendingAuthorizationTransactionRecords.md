# IO.Swagger.Model.PendingAuthorizationTransactionRecords
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionDate** | **DateTime?** | EffectiveDate should be in ISO 8601 format YYYY-MM-DD | [optional] 
**TransactionTime** | **string** | EffectiveTime  should follow ISO 8601 format hh:mm:ss | [optional] 
**TransactionCurrencyCode** | **string** | transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions | [optional] 
**TransactionAmount** | **double?** | TransactionAmount | [optional] 
**TransactionStatus** | **string** | AuthorizationResponseCode of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions | [optional] 
**BilledCurrencyCode** | **string** | billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions | [optional] 
**BilledAmount** | **double?** | billedAmount | [optional] 
**MerchantName** | **string** | Merchant Name | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

