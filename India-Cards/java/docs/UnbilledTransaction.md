# UnbilledTransaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transactionDate** | [**LocalDate**](LocalDate.md) | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. | 
**transactionDescription** | **String** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | 
**transactionReferenceId** | **String** | Reference Id to uniquely identify the transaction.This is applicable for successful transactions.  |  [optional]
**transactionAmount** | **Double** | Transaction amount in local currency. | 
**currencyCode** | **String** | The currency code in ISO 4217 format |  [optional]
