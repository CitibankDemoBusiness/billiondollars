# LoanEligibilityDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **str** | The account id  in encrypted format. | 
**display_account_number** | **str** | A masked account number that can be displayed to the customer. | 
**lop_supported_account_group** | **str** | This field refers the account group supported by Loan over phone. This is a reference data field. Please use /v1/utilities/referenceData/{lopSupportedAccountGroup} resource to get valid value of this field with description. | [optional] 
**maximum_eligible_loan_amount** | **float** | This field indicates the maximum eligible amount for loan. | 
**minimum_eligible_loan_amount** | **float** | This field indicates the minimum eligible amount for loan. | [optional] 
**offer_indicator** | **str** | This is to indicate if the offer is rate/fee/hybrid based. This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | 
**interest_calculation_method** | **str** | Interest calculation method. This is a reference data field. Please use /v1/utilities/referenceData/{interestCalculationMethod} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

