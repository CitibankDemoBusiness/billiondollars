# ApplicationAddIncomeDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**incomeType** | **String** | Income type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{incomeType} resource to get valid value of this field with description. You can use incomeType field name as the referenceCode parameter to retrieve the values. |  [optional]
**fixedAmount** | **Double** | Fixed income amount of applicant |  [optional]
**variableAmount** | **Double** | Variable income amount of applicant |  [optional]
**frequency** | **String** | Income Frequency. This is a reference data field. Please use /v1/apac/utilities/referenceData/{frequency} resource to get valid value of this field with description. You can use frequency field name as the referenceCode parameter to retrieve the values. |  [optional]
**otherIncomeDescription** | **String** | Description of income from other sources |  [optional]
