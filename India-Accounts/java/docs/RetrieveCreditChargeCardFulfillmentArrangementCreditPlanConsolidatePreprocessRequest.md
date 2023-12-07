# RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreprocessRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan** | [**List&lt;Loan&gt;**](Loan.md) |  |  [optional]
**totalLoanAmount** | **Double** | Total amount borrowed by customer as Loan ie., Old Loan Amount+Top up Amount. | 
**loanTenureInmonths** | **Integer** | Tenure of loan against credit card. It is considered in terms of number of months. | 
**topUpAmount** | **Double** | Additonal Topup Amount | 
**loanDescription** | **String** | New Loan Description | 
**disbursementOption** | **String** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description | 
**disbursementAccountId** | **String** | Customers Account Number with the Bank.   An account number is the primary identifier for ownership of an account, whether a checking account or savings account or credit card account or investment account, or a loan account. |  [optional]
**payeeId** | **String** | Payee Indicator to be mapped against Payee Detail Key |  [optional]
**beneficiaryBankDetail** | [**BeneficiaryBankDetail**](BeneficiaryBankDetail.md) |  |  [optional]
**loanPurpose** | **String** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. |  [optional]
