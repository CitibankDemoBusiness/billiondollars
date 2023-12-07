# IO.Swagger.Model.EppOffers
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenor** | [**decimal?**](BigDecimal.md) | Tenure of loan in months. | 
**EffectiveInterestRate** | **double?** | The interest rate applicable on Loan Amount. | [optional] 
**AnnualPercentageRate** | **double?** | Interest rate for a whole year. This includes any fees or additional cost associated. | [optional] 
**InstallmentAmount** | **double?** | The montly emi for the loan amount taken based on Tenor | [optional] 
**OneTimeProcessingFeeIndicator** | **string** | One time processing fee indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. | [optional] 
**OneTimeProcessingFeeAmount** | **double?** | Fee charged as part of one time processing. | [optional] 
**OneTimeProcessingFeePercentage** | **double?** | Percentage of one time processing fee charged. | [optional] 
**InitialInterestAmount** | **double?** | Initial interest amount charged to customer from the epp booking date to the first installment start date | [optional] 
**OfferIndicator** | **string** | Indicator to determine if offer is rate or fee based. This is a reference data field. Please use /v1/apac/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

