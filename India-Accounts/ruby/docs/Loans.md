# SwaggerClient::Loans

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_reference_id** | **String** | Reference Id to uniquely identify the loan.  | 
**display_account_number** | **String** | Last 4 digits of account number.  | [optional] 
**transaction_date** | **Date** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. | 
**transaction_description** | **String** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | 
**installment_amount** | **Float** | Installment loan payment amount | 
**next_installment_amount** | **Float** | Next installment amount in local currency. | [optional] 
**outstanding_balance_amount** | **Float** | The amount of money owed. | 
**tenor** | [**BigDecimal**](BigDecimal.md) | Tenure of loan in months. | 
**outstanding_tenor** | [**BigDecimal**](BigDecimal.md) | Number of months remaining for completion of loan. | [optional] 
**original_loan_amount** | **Float** | Original loan amount borrowed by customer. | 
**annual_percentage_rate** | **Float** | Interest rate for a whole year. This includes any fees or additional cost associated. | 
**effective_interest_rate** | **Float** | Effective Percentage Rate | [optional] 
**processing_charge_amount** | **Float** | Charges levied on applicant by the bank to process the loan. | [optional] 
**outstanding_interest_amount** | **Float** | Total Outstanding Interest Amount. | [optional] 
**self_early_loan_closure_allowed_flag** | **BOOLEAN** | Flag to identify if the loan is allowed to be early self closed by customer or not.. | [optional] 
**installment_cycle** | **Integer** | Intallment Cycle | [optional] 

