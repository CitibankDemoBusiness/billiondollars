# MutualFundAccountSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productName** | **String** | The name of the product |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**accountNickname** | **String** | The nickname of the account assigned by the customer |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer |  [optional]
**accountId** | **String** | The customer account identifier in encrypted format. |  [optional]
**currencyCode** | **String** | The currency code in ISO 4217 format |  [optional]
**accountStatus** | **String** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**accountClassification** | **String** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**currentBalance** | **Double** | Total fund value for the Investment mutual fund account. It is the current market worth of investment |  [optional]
