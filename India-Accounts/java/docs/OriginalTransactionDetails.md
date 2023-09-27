# OriginalTransactionDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**paymentType** | **String** | The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. |  [optional]
**transactionDate** | [**LocalDate**](LocalDate.md) | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, |  [optional]
**transactionAmount** | **Double** | Transaction amount in account currency. |  [optional]
**transactionCurrencyCode** | **String** | The currency code for the foreign transaction amount in ISO 4217 format. |  [optional]
**transactionStatus** | **String** | Transaction Status of the original transaction |  [optional]
**transactionReferenceNumber** | **String** | Transaction reference number of the original transaction |  [optional]
**transactionRemarks** | **String** | Transaction Remarks of the original transaction |  [optional]
**endToEndIdentification** | **String** | End to End Identification reference of the original transaction |  [optional]
