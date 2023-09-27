# EppOffers

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | **float** | Tenure of loan in months. | 
**effective_interest_rate** | **float** | The interest rate applicable on Loan Amount. | [optional] 
**annual_percentage_rate** | **float** | Interest rate for a whole year. This includes any fees or additional cost associated. | [optional] 
**installment_amount** | **float** | The montly emi for the loan amount taken based on Tenor | [optional] 
**one_time_processing_fee_indicator** | **str** | One time processing fee indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. | [optional] 
**one_time_processing_fee_amount** | **float** | Fee charged as part of one time processing. | [optional] 
**one_time_processing_fee_percentage** | **float** | Percentage of one time processing fee charged. | [optional] 
**initial_interest_amount** | **float** | Initial interest amount charged to customer from the epp booking date to the first installment start date | [optional] 
**offer_indicator** | **str** | Indicator to determine if offer is rate or fee based. This is a reference data field. Please use /v1/apac/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

