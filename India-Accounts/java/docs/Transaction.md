# Transaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer |  [optional]
**transactionDate** | [**LocalDate**](LocalDate.md) | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, |  [optional]
**transactionDescription** | **String** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. |  [optional]
**transactionReferenceId** | **String** | Reference Id to uniquely identify the transaction |  [optional]
**checkSerialNumber** | **String** | The check serial number. Applicable for checking accounts only |  [optional]
**transactionAmount** | **Double** | Transaction amount in local currency. |  [optional]
**currencyCode** | **String** | The currency code of the transaction in ISO 4217 format |  [optional]
**foreignTransactionAmount** | [**BigDecimal**](BigDecimal.md) | The transaction amount in the foreign currency |  [optional]
**foreignCurrencyCode** | **String** | The foreign currency code of the transaction in ISO 4217 format |  [optional]
**foreignExchangeRate** | [**BigDecimal**](BigDecimal.md) | The exchange rate at the time the foreign transaction was done |  [optional]
**transactionType** | **String** | The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values |  [optional]
**transactionStatus** | **String** | The status of the transaction.  Applicable for credit cards only.. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values |  [optional]
**runningBalance** | **Double** | The amount available to transact immediately |  [optional]
**transactionPostingDate** | [**LocalDate**](LocalDate.md) | Transaction posting date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting |  [optional]
**transactionCode** | **String** | The transaction code |  [optional]
**merchantName** | **String** | The merchant name with which this transaction was made with |  [optional]
**eligibleForEqualPaymentPlan** | **String** | The EPP allowed indicator. This is applicable for credit cards transactions only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values |  [optional]
