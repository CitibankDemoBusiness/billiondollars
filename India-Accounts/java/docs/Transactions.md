# Transactions

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**displayCardNumber** | **String** | A masked card number that can be displayed to the customer | 
**cardHolderType** | **String** | Indicator to specify whether the card is primary or supplementary.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**transactionDate** | [**LocalDate**](LocalDate.md) | The transaction date in ISO 8601 format YYYY-MM-DD |  [optional]
**transactionPostingDate** | [**LocalDate**](LocalDate.md) | The transaction posting date in ISO 8601 format YYYY-MM-DD |  [optional]
**merchantName** | **String** | The merchant name with which this transaction was made. |  [optional]
**transactionCode** | **String** | The transaction code |  [optional]
**transactionDescription** | **String** | Transaction description from the merchant, POS or bank. |  [optional]
**transactionType** | **String** | The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**foreignTransactionAmount** | **Double** | The transaction amount in the foreign currency |  [optional]
**foreignCurrencyCode** | **String** | The foreign currency code of the transaction in ISO 4217 format |  [optional]
**transactionAmount** | **Double** | Transaction amount in local currency |  [optional]
**currencyCode** | **String** | The currency code of the transaction in ISO 4217 format |  [optional]
**eligibleForEqualPaymentPlan** | **String** | The EPP allowed indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**transactionReferenceId** | **String** | The unique transaction reference Id used to identify this transaction from all the other transactions, |  [optional]
