# EppOffers

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | [**BigDecimal**](BigDecimal.md) | Tenure of loan in months. | 
**effectiveInterestRate** | **Double** | The interest rate applicable on loan amount. | 
**annualPercentageRate** | **Double** | Interest rate for a whole year. This includes any fees or additional cost associated. |  [optional]
**installmentAmount** | **Double** | Installment amount to be paid by customer in order to repay the loan. | 
**oneTimeProcessingFeeIndicator** | **String** | One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. |  [optional]
**oneTimeProcessingFeeAmount** | **Double** | Fee charged as part of one time processing. |  [optional]
**oneTimeProcessingFeePercentage** | **Double** | Percentage of one time processing fee charged. |  [optional]
**offerIndicator** | **String** | This is to indicate if the offer is rate/fee/hybrid based. This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | 
**totalInterestAmount** | **Double** | This is the total interest amount for the loan account. |  [optional]
**totalRepaymentAmount** | **Double** | This is the total amount to be paid back which includes principal, interest and any fees incurred. |  [optional]
**monthlyServicingFeeAmount** | **Double** | This the applicable monthly servicing/maintenance fee for administrating the loan which is included in the monthly installment amount. |  [optional]
**interestCalculationMethod** | **String** | Interest calculation method. This is a reference data field. Please use /v1/utilities/referenceData/{interestCalculationMethod} resource to get valid value of this field with description. |  [optional]
