# SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**old_loan_list** | [**Array&lt;Loan&gt;**](Loan.md) |  | [optional] 
**total_loan_amount** | **Float** | Total amount borrowed by customer as Loan ie., Old Loan Amount+Top up Amount. | 
**loan_tenure_inmonths** | **Integer** | Tenure of loan against credit card. It is considered in terms of number of months. | 
**top_up_amount** | **Float** | Additonal Topup Amount | 
**loan_description** | **String** | New Loan Description | 
**disbursement_option** | **String** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description | 
**account_number** | **String** | Customers Account Number with the Bank.   An account number is the primary identifier for ownership of an account, whether a checking account or savings account or credit card account or investment account, or a loan account. | [optional] 
**payee_id** | **String** | Payee Indicator to be mapped against Payee Detail Key | [optional] 
**birth_year** | [**BigDecimal**](BigDecimal.md) | Year of birth of customer | [optional] 
**beneficiary_bank_detail** | [**BeneficiaryBankDetail**](BeneficiaryBankDetail.md) |  | [optional] 
**loan_purpose** | **String** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 

