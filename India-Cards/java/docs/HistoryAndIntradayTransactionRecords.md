# HistoryAndIntradayTransactionRecords

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transactionDate** | [**LocalDate**](LocalDate.md) | Transaction date in ISO 8601  format YYYY-MM-DD |  [optional]
**merchantName** | **String** | This field indicates the merchant Name |  [optional]
**merchantLocation** | **String** | This filed indicates the Merchant Address |  [optional]
**transactionStatus** | **String** | This field provides the status of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. |  [optional]
**reasonDescription** | **String** | Decline Description- for declined transaction |  [optional]
**transactionAmount** | **Double** | Amount of funds the cardholder requested in source location of the transaction. |  [optional]
**transactionCurrencyCode** | **String** | transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions |  [optional]
**billedAmount** | **Double** | Amount billed to the cardholder in the cardholder account currency |  [optional]
**billedCurrencyCode** | **String** | billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions |  [optional]
