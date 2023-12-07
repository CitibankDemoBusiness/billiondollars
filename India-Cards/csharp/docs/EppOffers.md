# IO.Swagger.Model.EppOffers
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenor** | [**decimal?**](BigDecimal.md) | Tenure of loan in months. | 
**EffectiveInterestRate** | **double?** | The interest rate applicable on loan amount. | 
**AnnualPercentageRate** | **double?** | Interest rate for a whole year. This includes any fees or additional cost associated. | [optional] 
**InstallmentAmount** | **double?** | Installment amount to be paid by customer in order to repay the loan. | 
**OneTimeProcessingFeeIndicator** | **string** | One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description. | [optional] 
**OneTimeProcessingFeeAmount** | **double?** | Fee charged as part of one time processing. | [optional] 
**OneTimeProcessingFeePercentage** | **double?** | Percentage of one time processing fee charged. | [optional] 
**OfferIndicator** | **string** | This is to indicate if the offer is rate/fee/hybrid based. This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | 
**TotalInterestAmount** | **double?** | This is the total interest amount for the loan account. | [optional] 
**TotalRepaymentAmount** | **double?** | This is the total amount to be paid back which includes principal, interest and any fees incurred. | [optional] 
**MonthlyServicingFeeAmount** | **double?** | This the applicable monthly servicing/maintenance fee for administrating the loan which is included in the monthly installment amount. | [optional] 
**InterestCalculationMethod** | **string** | Interest calculation method. This is a reference data field. Please use /v1/utilities/referenceData/{interestCalculationMethod} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

