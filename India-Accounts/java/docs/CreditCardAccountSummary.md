# CreditCardAccountSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productName** | **String** | The name of the product |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**accountNickname** | **String** | The nickname of the account assigned by the customer |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer |  [optional]
**accountId** | **String** | The customer account identifier in encrypted format. |  [optional]
**currencyCode** | **String** | The currency code in ISO 4217 format |  [optional]
**accountClassification** | **String** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**accountStatus** | **String** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**outstandingBalance** | **Double** | The amount of money owed on the credit account. It is the outstanding balance in applicable level (either card, account or relationship levels) |  [optional]
**availableCredit** | **Double** | Available Credit limit on the credit card |  [optional]
**creditLimit** | **Double** | The maximum amount of credit that extend to a customer |  [optional]
**minimumDueAmount** | **Double** | Minimum due amount for a payment cycle |  [optional]
**paymentDueDate** | [**LocalDate**](LocalDate.md) | The payment due date in ISO 8601 date format YYYY-MM-DD |  [optional]
**alternateCurrency** | **String** | The alternate currency |  [optional]
**alternateCurrencyCurrentBalance** | **Double** | The current balance in alternate currency |  [optional]
**cardHolderType** | **String** | Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. |  [optional]
