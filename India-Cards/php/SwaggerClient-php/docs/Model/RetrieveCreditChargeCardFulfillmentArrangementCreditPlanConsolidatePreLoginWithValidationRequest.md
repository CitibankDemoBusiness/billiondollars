# RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**old_loan_list** | [**\Swagger\Client\Model\Loan[]**](Loan.md) |  | [optional] 
**total_loan_amount** | **double** | Total amount borrowed by customer as Loan ie., Old Loan Amount+Top up Amount | [optional] 
**loan_tenure_in_months** | **int** | Tenure of loan against credit card. It is considered in terms of number of months | [optional] 
**top_up_amount** | **double** | Additonal Topup Amount | [optional] 
**disbursement_option** | **string** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | [optional] 
**beneficiary_detail** | [**\Swagger\Client\Model\BeneficiaryDetail**](BeneficiaryDetail.md) |  | [optional] 
**payee_id** | **string** | Payee Indicator to be mapped against Payee Detail Key | [optional] 
**loan_purpose** | **string** | This field indicates the options/mode in which the loan amount will be disbursed | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

