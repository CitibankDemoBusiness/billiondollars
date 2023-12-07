# StatementSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**outstanding_balance** | **float** | Outstanding balance amount on the statement date | [optional] 
**credit_limit** | **float** | The maximum amount of credit that extend to a customer | [optional] 
**active_equal_payment_plan_count** | **float** | Number of active plans under equal payment plan | [optional] 
**beginning_balance_amount** | **float** | Balance as on Last Statement Date | [optional] 
**total_debit_amount** | **float** | Total debits made during the statement period | [optional] 
**total_credit_amount** | **float** | Total payments made during the statement period. | [optional] 
**net_interest_amount** | **float** | Total interest amount of monetary transactions posted to cardholder account | [optional] 
**payment_due_date** | **date** | Next payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**past_due_amount** | **float** | Past due amount to be paid | [optional] 
**cash_advance_limit** | **float** | Some percentage of credit limit to withdraw cash | [optional] 
**cycle_to_date_fee_amount** | **float** | The total fee applied in the cycle | [optional] 
**interest_paid_amount** | **float** | Interest amount paid on the credit card from the last billing cycle. | [optional] 
**billing_currency_code** | **str** | Billing currency code in  in ISO 4217 format | [optional] 
**cash_advance_available_amount** | **float** | Available Cash Amount for withdrawal | [optional] 
**retail_cycle_interest_rate** | **float** | Retail Interest Rate for merchant transactions. | [optional] 
**cash_cycle_interest_rate** | **float** | Cash Interest Rate for withdrawal | [optional] 
**private_label_credit_cards** | [**PrivateLabelCreditCards**](PrivateLabelCreditCards.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

