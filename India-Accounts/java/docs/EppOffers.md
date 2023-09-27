# EppOffers

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | [**BigDecimal**](BigDecimal.md) | Tenure of loan in months. | 
**effectiveInterestRate** | **Double** | The interest rate applicable on Loan Amount. |  [optional]
**annualPercentageRate** | **Double** | Interest rate for a whole year. This includes any fees or additional cost associated. |  [optional]
**installmentAmount** | **Double** | The montly emi for the loan amount taken based on Tenor |  [optional]
**oneTimeProcessingFeeIndicator** | **String** | One time processing fee indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. |  [optional]
**oneTimeProcessingFeeAmount** | **Double** | Fee charged as part of one time processing. |  [optional]
**oneTimeProcessingFeePercentage** | **Double** | Percentage of one time processing fee charged. |  [optional]
**initialInterestAmount** | **Double** | Initial interest amount charged to customer from the epp booking date to the first installment start date |  [optional]
**offerIndicator** | **String** | Indicator to determine if offer is rate or fee based. This is a reference data field. Please use /v1/apac/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. |  [optional]
