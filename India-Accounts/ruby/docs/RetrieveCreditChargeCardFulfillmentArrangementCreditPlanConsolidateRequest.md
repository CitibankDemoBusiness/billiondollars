# SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**old_loan_list** | [**Array&lt;Loan&gt;**](Loan.md) |  | [optional] 
**total_loan_amount** | **Float** | Total amount borrowed by customer as Loan ie., Old Loan Amount+Top up Amount. | 
**loan_tenure_inmonths** | **Integer** | Tenure of loan against credit card. It is considered in terms of number of months. | 
**top_up_amount** | **Float** | Additonal Topup Amount | 
**loan_description** | **String** | New Loan Description | [optional] 
**disbursement_option** | **String** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**disbursement_account_id** | **String** | The disbursement account identifier in encrypted format. | [optional] 
**payee_id** | **String** | Payee Indicator to be mapped against Payee Detail Key | [optional] 
**beneficiary_bank_detail** | [**BeneficiaryBankDetail**](BeneficiaryBankDetail.md) |  | [optional] 
**loan_purpose** | **String** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 

