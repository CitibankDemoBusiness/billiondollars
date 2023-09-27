# SwaggerClient::PendingAuthorizationTransactionRecords

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_date** | **Date** | EffectiveDate should be in ISO 8601 format YYYY-MM-DD | [optional] 
**transaction_time** | **String** | EffectiveTime  should follow ISO 8601 format hh:mm:ss | [optional] 
**transaction_currency_code** | **String** | transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions | [optional] 
**transaction_amount** | **Float** | TransactionAmount | [optional] 
**transaction_status** | **String** | AuthorizationResponseCode of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions | [optional] 
**billed_currency_code** | **String** | billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions | [optional] 
**billed_amount** | **Float** | billedAmount | [optional] 
**merchant_name** | **String** | Merchant Name | [optional] 

