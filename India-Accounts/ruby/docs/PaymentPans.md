# SwaggerClient::PaymentPans

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | [**BigDecimal**](BigDecimal.md) | Tenure of loan in months. | [optional] 
**effective_interest_rate** | **Float** | Loan effective interest rate | [optional] 
**annual_percentage_rate** | **Float** | Compounded annual interest rate. | [optional] 
**one_time_processing_fee_indicator** | **String** | One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. | [optional] 
**one_time_processing_fee_amount** | **Float** | Fee charged as part of one time processing. | [optional] 
**one_time_processing_fee_percentage** | **Float** | Percentage of one time processing fee charged. | [optional] 

