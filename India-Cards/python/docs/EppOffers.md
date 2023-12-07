# EppOffers

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | **float** | Tenure of loan in months. | 
**effective_interest_rate** | **float** | The interest rate applicable on loan amount. | 
**annual_percentage_rate** | **float** | Interest rate for a whole year. This includes any fees or additional cost associated. | [optional] 
**installment_amount** | **float** | Installment amount to be paid by customer in order to repay the loan. | 
**one_time_processing_fee_indicator** | **str** | One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. | [optional] 
**one_time_processing_fee_amount** | **float** | Fee charged as part of one time processing. | [optional] 
**one_time_processing_fee_percentage** | **float** | Percentage of one time processing fee charged. | [optional] 
**offer_indicator** | **str** | This is to indicate if the offer is rate/fee/hybrid based. This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | 
**total_interest_amount** | **float** | This is the total interest amount for the loan account. | [optional] 
**total_repayment_amount** | **float** | This is the total amount to be paid back which includes principal, interest and any fees incurred. | [optional] 
**monthly_servicing_fee_amount** | **float** | This the applicable monthly servicing/maintenance fee for administrating the loan which is included in the monthly installment amount. | [optional] 
**interest_calculation_method** | **str** | Interest calculation method. This is a reference data field. Please use /v1/utilities/referenceData/{interestCalculationMethod} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

