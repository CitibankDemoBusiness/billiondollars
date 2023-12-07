# RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**oldLoanList** | [**List&lt;Loan&gt;**](Loan.md) |  |  [optional]
**totalLoanAmount** | **Double** | Total amount borrowed by customer as Loan ie., Old Loan Amount+Top up Amount |  [optional]
**loanTenureInMonths** | **Integer** | Tenure of loan against credit card. It is considered in terms of number of months |  [optional]
**topUpAmount** | **Double** | Additonal Topup Amount |  [optional]
**disbursementOption** | **String** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. |  [optional]
**beneficiaryDetail** | [**BeneficiaryDetail**](BeneficiaryDetail.md) |  |  [optional]
**payeeId** | **String** | Payee Indicator to be mapped against Payee Detail Key |  [optional]
**loanPurpose** | **String** | This field indicates the options/mode in which the loan amount will be disbursed |  [optional]
