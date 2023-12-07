# HistoryAndIntradayTransactionRecords

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_date** | [**\DateTime**](\DateTime.md) | Transaction date in ISO 8601  format YYYY-MM-DD | [optional] 
**merchant_name** | **string** | This field indicates the merchant Name | [optional] 
**merchant_location** | **string** | This filed indicates the Merchant Address | [optional] 
**transaction_status** | **string** | This field provides the status of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. | [optional] 
**reason_description** | **string** | Decline Description- for declined transaction | [optional] 
**transaction_amount** | **double** | Amount of funds the cardholder requested in source location of the transaction. | [optional] 
**transaction_currency_code** | **string** | transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions | [optional] 
**billed_amount** | **double** | Amount billed to the cardholder in the cardholder account currency | [optional] 
**billed_currency_code** | **string** | billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

