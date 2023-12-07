# RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**old_loan_list** | [**list[Loan]**](Loan.md) |  | [optional] 
**total_loan_amount** | **float** | Total amount borrowed by customer as Loan ie., Old Loan Amount+Top up Amount. | 
**loan_tenure_inmonths** | **int** | Tenure of loan against credit card. It is considered in terms of number of months. | 
**top_up_amount** | **float** | Additonal Topup Amount | 
**loan_description** | **str** | New Loan Description | [optional] 
**disbursement_option** | **str** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**disbursement_account_id** | **str** | The disbursement account identifier in encrypted format. | [optional] 
**payee_id** | **str** | Payee Indicator to be mapped against Payee Detail Key | [optional] 
**beneficiary_bank_detail** | [**BeneficiaryBankDetail**](BeneficiaryBankDetail.md) |  | [optional] 
**loan_purpose** | **str** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

