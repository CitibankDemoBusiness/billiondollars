# Loans

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_reference_id** | **str** | Reference Id to uniquely identify the loan.  | 
**display_account_number** | **str** | Last 4 digits of account number.  | [optional] 
**transaction_date** | **date** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. | 
**transaction_description** | **str** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | 
**installment_amount** | **float** | Installment loan payment amount | 
**next_installment_amount** | **float** | Next installment amount in local currency. | [optional] 
**outstanding_balance_amount** | **float** | The amount of money owed. | 
**tenor** | **float** | Tenure of loan in months. | 
**outstanding_tenor** | **float** | Number of months remaining for completion of loan. | [optional] 
**original_loan_amount** | **float** | Original loan amount borrowed by customer. | 
**annual_percentage_rate** | **float** | Interest rate for a whole year. This includes any fees or additional cost associated. | 
**effective_interest_rate** | **float** | Effective Percentage Rate | [optional] 
**processing_charge_amount** | **float** | Charges levied on applicant by the bank to process the loan. | [optional] 
**outstanding_interest_amount** | **float** | Total Outstanding Interest Amount. | [optional] 
**self_early_loan_closure_allowed_flag** | **bool** | Flag to identify if the loan is allowed to be early self closed by customer or not.. | [optional] 
**installment_cycle** | **int** | Intallment Cycle | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

