# IO.Swagger.Model.LoanEligibilityDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account id  in encrypted format. | 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer. | 
**LopSupportedAccountGroup** | **string** | This field refers the account group supported by Loan over phone. This is a reference data field. Please use /v1/utilities/referenceData/{lopSupportedAccountGroup} resource to get valid value of this field with description. | [optional] 
**MaximumEligibleLoanAmount** | **double?** | This field indicates the maximum eligible amount for loan. | 
**MinimumEligibleLoanAmount** | **double?** | This field indicates the minimum eligible amount for loan. | [optional] 
**OfferIndicator** | **string** | This is to indicate if the offer is rate/fee/hybrid based. This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | 
**InterestCalculationMethod** | **string** | Interest calculation method. This is a reference data field. Please use /v1/utilities/referenceData/{interestCalculationMethod} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

