# SwaggerClient::HistoryAndIntradayTransactionRecords

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_date** | **Date** | Transaction date in ISO 8601  format YYYY-MM-DD | [optional] 
**merchant_name** | **String** | This field indicates the merchant Name | [optional] 
**merchant_location** | **String** | This filed indicates the Merchant Address | [optional] 
**transaction_status** | **String** | This field provides the status of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. | [optional] 
**reason_description** | **String** | Decline Description- for declined transaction | [optional] 
**transaction_amount** | **Float** | Amount of funds the cardholder requested in source location of the transaction. | [optional] 
**transaction_currency_code** | **String** | transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions | [optional] 
**billed_amount** | **Float** | Amount billed to the cardholder in the cardholder account currency | [optional] 
**billed_currency_code** | **String** | billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions | [optional] 

