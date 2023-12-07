# StatementSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**outstanding_balance** | **double** | Outstanding balance amount on the statement date | [optional] 
**credit_limit** | **double** | The maximum amount of credit that extend to a customer | [optional] 
**active_equal_payment_plan_count** | **double** | Number of active plans under equal payment plan | [optional] 
**beginning_balance_amount** | **double** | Balance as on Last Statement Date | [optional] 
**total_debit_amount** | **double** | Total debits made during the statement period | [optional] 
**total_credit_amount** | **double** | Total payments made during the statement period. | [optional] 
**net_interest_amount** | **double** | Total interest amount of monetary transactions posted to cardholder account | [optional] 
**payment_due_date** | [**\DateTime**](\DateTime.md) | Next payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**past_due_amount** | **double** | Past due amount to be paid | [optional] 
**cash_advance_limit** | **double** | Some percentage of credit limit to withdraw cash | [optional] 
**cycle_to_date_fee_amount** | **double** | The total fee applied in the cycle | [optional] 
**interest_paid_amount** | **double** | Interest amount paid on the credit card from the last billing cycle. | [optional] 
**billing_currency_code** | **string** | Billing currency code in  in ISO 4217 format | [optional] 
**cash_advance_available_amount** | **double** | Available Cash Amount for withdrawal | [optional] 
**retail_cycle_interest_rate** | **double** | Retail Interest Rate for merchant transactions. | [optional] 
**cash_cycle_interest_rate** | **double** | Cash Interest Rate for withdrawal | [optional] 
**private_label_credit_cards** | [**\Swagger\Client\Model\PrivateLabelCreditCards**](PrivateLabelCreditCards.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

