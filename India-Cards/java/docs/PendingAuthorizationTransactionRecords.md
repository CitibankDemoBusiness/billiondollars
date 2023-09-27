# PendingAuthorizationTransactionRecords

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transactionDate** | [**LocalDate**](LocalDate.md) | EffectiveDate should be in ISO 8601 format YYYY-MM-DD |  [optional]
**transactionTime** | **String** | EffectiveTime  should follow ISO 8601 format hh:mm:ss |  [optional]
**transactionCurrencyCode** | **String** | transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions |  [optional]
**transactionAmount** | **Double** | TransactionAmount |  [optional]
**transactionStatus** | **String** | AuthorizationResponseCode of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions |  [optional]
**billedCurrencyCode** | **String** | billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions |  [optional]
**billedAmount** | **Double** | billedAmount |  [optional]
**merchantName** | **String** | Merchant Name |  [optional]
