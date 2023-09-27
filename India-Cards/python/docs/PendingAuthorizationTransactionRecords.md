# PendingAuthorizationTransactionRecords

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_date** | **date** | EffectiveDate should be in ISO 8601 format YYYY-MM-DD | [optional] 
**transaction_time** | **str** | EffectiveTime  should follow ISO 8601 format hh:mm:ss | [optional] 
**transaction_currency_code** | **str** | transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions | [optional] 
**transaction_amount** | **float** | TransactionAmount | [optional] 
**transaction_status** | **str** | AuthorizationResponseCode of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions | [optional] 
**billed_currency_code** | **str** | billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions | [optional] 
**billed_amount** | **float** | billedAmount | [optional] 
**merchant_name** | **str** | Merchant Name | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

