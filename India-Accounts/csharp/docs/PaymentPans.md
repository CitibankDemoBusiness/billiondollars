# IO.Swagger.Model.PaymentPans
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenor** | [**decimal?**](BigDecimal.md) | Tenure of loan in months. | [optional] 
**EffectiveInterestRate** | **double?** | Loan effective interest rate | [optional] 
**AnnualPercentageRate** | **double?** | Compounded annual interest rate. | [optional] 
**OneTimeProcessingFeeIndicator** | **string** | One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. | [optional] 
**OneTimeProcessingFeeAmount** | **double?** | Fee charged as part of one time processing. | [optional] 
**OneTimeProcessingFeePercentage** | **double?** | Percentage of one time processing fee charged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

