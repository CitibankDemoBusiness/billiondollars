# PendingAuthorizationTransactionRecords

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_date** | [**\DateTime**](\DateTime.md) | EffectiveDate should be in ISO 8601 format YYYY-MM-DD | [optional] 
**transaction_time** | **string** | EffectiveTime  should follow ISO 8601 format hh:mm:ss | [optional] 
**transaction_currency_code** | **string** | transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions | [optional] 
**transaction_amount** | **double** | TransactionAmount | [optional] 
**transaction_status** | **string** | AuthorizationResponseCode of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions | [optional] 
**billed_currency_code** | **string** | billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions | [optional] 
**billed_amount** | **double** | billedAmount | [optional] 
**merchant_name** | **string** | Merchant Name | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

