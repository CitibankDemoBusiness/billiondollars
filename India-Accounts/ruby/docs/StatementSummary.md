# SwaggerClient::StatementSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**outstanding_balance** | **Float** | Outstanding balance amount on the statement date | [optional] 
**credit_limit** | **Float** | The maximum amount of credit that extend to a customer | [optional] 
**active_equal_payment_plan_count** | **Float** | Number of active plans under equal payment plan | [optional] 
**beginning_balance_amount** | **Float** | Balance as on Last Statement Date | [optional] 
**total_debit_amount** | **Float** | Total debits made during the statement period | [optional] 
**total_credit_amount** | **Float** | Total payments made during the statement period. | [optional] 
**net_interest_amount** | **Float** | Total interest amount of monetary transactions posted to cardholder account | [optional] 
**payment_due_date** | **Date** | Next payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**past_due_amount** | **Float** | Past due amount to be paid | [optional] 
**cash_advance_limit** | **Float** | Some percentage of credit limit to withdraw cash | [optional] 
**cycle_to_date_fee_amount** | **Float** | The total fee applied in the cycle | [optional] 
**interest_paid_amount** | **Float** | Interest amount paid on the credit card from the last billing cycle. | [optional] 
**billing_currency_code** | **String** | Billing currency code in  in ISO 4217 format | [optional] 
**cash_advance_available_amount** | **Float** | Available Cash Amount for withdrawal | [optional] 
**retail_cycle_interest_rate** | **Float** | Retail Interest Rate for merchant transactions. | [optional] 
**cash_cycle_interest_rate** | **Float** | Cash Interest Rate for withdrawal | [optional] 
**private_label_credit_cards** | [**PrivateLabelCreditCards**](PrivateLabelCreditCards.md) |  | [optional] 

