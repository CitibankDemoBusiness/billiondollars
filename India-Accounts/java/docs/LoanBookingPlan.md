# LoanBookingPlan

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | **Integer** | Period of time for which the Loan is taken. This will be reference data. | 
**effectiveInterestRate** | **Double** | The interest rate applicable on Loan Amount. |  [optional]
**annualPercentageRate** | **Double** | Interest rate for a whole year. This includes any fees or additional cost associated. |  [optional]
**installmentAmount** | **Double** | The montly emi for the loan amount taken based on Tenor |  [optional]
**oneTimeProcessingFeeIndicator** | **String** | One time processing fee indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. |  [optional]
**oneTimeProcessingFeeAmount** | **Double** | Fee charged as part of one time processing. |  [optional]
**initialFeeAmount** | **Double** | First month fee/interest charge incurred from booking date to next statement cycle date. |  [optional]
**oneTimeProcessingFeePercentage** | **Double** | Percentage of one time processing fee charged. |  [optional]
