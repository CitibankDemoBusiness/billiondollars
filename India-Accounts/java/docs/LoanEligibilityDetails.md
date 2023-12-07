# LoanEligibilityDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountId** | **String** | The account id  in encrypted format. | 
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer. | 
**lopSupportedAccountGroup** | **String** | This field refers the account group supported by Loan over phone. This is a reference data field. Please use /v1/utilities/referenceData/{lopSupportedAccountGroup} resource to get valid value of this field with description. |  [optional]
**maximumEligibleLoanAmount** | **Double** | This field indicates the maximum eligible amount for loan. | 
**minimumEligibleLoanAmount** | **Double** | This field indicates the minimum eligible amount for loan. |  [optional]
**offerIndicator** | **String** | This is to indicate if the offer is rate/fee/hybrid based. This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | 
**interestCalculationMethod** | **String** | Interest calculation method. This is a reference data field. Please use /v1/utilities/referenceData/{interestCalculationMethod} resource to get valid value of this field with description. |  [optional]
