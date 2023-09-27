# PaymentPans

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | [**BigDecimal**](BigDecimal.md) | Tenure of loan in months. |  [optional]
**effectiveInterestRate** | **Double** | Loan effective interest rate |  [optional]
**annualPercentageRate** | **Double** | Compounded annual interest rate. |  [optional]
**oneTimeProcessingFeeIndicator** | **String** | One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. |  [optional]
**oneTimeProcessingFeeAmount** | **Double** | Fee charged as part of one time processing. |  [optional]
**oneTimeProcessingFeePercentage** | **Double** | Percentage of one time processing fee charged. |  [optional]
