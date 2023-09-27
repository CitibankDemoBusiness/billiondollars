# PaymentPans

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | **float** | Tenure of loan in months. | [optional] 
**effective_interest_rate** | **double** | Loan effective interest rate | [optional] 
**annual_percentage_rate** | **double** | Compounded annual interest rate. | [optional] 
**one_time_processing_fee_indicator** | **string** | One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. | [optional] 
**one_time_processing_fee_amount** | **double** | Fee charged as part of one time processing. | [optional] 
**one_time_processing_fee_percentage** | **double** | Percentage of one time processing fee charged. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

