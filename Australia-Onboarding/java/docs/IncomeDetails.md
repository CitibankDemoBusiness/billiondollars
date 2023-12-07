# IncomeDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**incomeType** | **String** | Income type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{incomeType} resource to get possible values of this field with descriptions. You can use incomeType field name as the referenceCode parameter to retrieve the values. |  [optional]
**fixedAmount** | **Double** | Fixed income amount |  [optional]
**variableAmount** | **Double** | Variable income amount |  [optional]
**currencyCode** | **String** | Currency Code in ISO 4217 format. |  [optional]
**frequency** | **String** | Frequency. This is a reference data field. Please use /v1/apac/utilities/referenceData/{frequency} resource to get possible values of this field with descriptions. You can use frequency field name as the referenceCode parameter to retrieve the values. |  [optional]
**otherIncomeDescription** | **String** | Description of income from other sources |  [optional]
