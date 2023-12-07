# EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**customerName** | **String** | This refers to the name of the customer. | 
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer |  [optional]
**accountGroup** | **String** | Account Group associated with the source Account.This is a reference data field. Please use /v1/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. |  [optional]
**maximumEligibleLoanAmount** | **Double** | The maximum amount of credit that extend to a customer | 
**minimumEligibleLoanAmount** | **Double** | The minimum amount of credit that extend to a customer | 
**offerIndicator** | **String** | Indicator to determine if offer is rate or fee based. This is a reference data field. Please use /v1/apac/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description. | 
**loanBookingPlan** | [**List&lt;LoanBookingPlan&gt;**](LoanBookingPlan.md) |  |  [optional]
**lopCategory** | **String** | Indicator to determine the type of LOP Offer. This is a reference data field. Please use /v1/utilities/referenceData/{lopCategory} resource to get valid value of this field with description. |  [optional]
