# IO.Swagger.Model.LoanBookingPlan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenor** | **int?** | Period of time for which the Loan is taken. This will be reference data. | 
**EffectiveInterestRate** | **double?** | The interest rate applicable on Loan Amount. | [optional] 
**AnnualPercentageRate** | **double?** | Interest rate for a whole year. This includes any fees or additional cost associated. | [optional] 
**InstallmentAmount** | **double?** | The montly emi for the loan amount taken based on Tenor | [optional] 
**OneTimeProcessingFeeIndicator** | **string** | One time processing fee indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. | [optional] 
**OneTimeProcessingFeeAmount** | **double?** | Fee charged as part of one time processing. | [optional] 
**InitialFeeAmount** | **double?** | First month fee/interest charge incurred from booking date to next statement cycle date. | [optional] 
**OneTimeProcessingFeePercentage** | **double?** | Percentage of one time processing fee charged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

