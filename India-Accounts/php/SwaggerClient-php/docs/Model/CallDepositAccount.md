# CallDepositAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **string** | The name of the product | [optional] 
**product_code** | **string** | A unique code that identifies the product | [optional] 
**display_account_number** | **string** | A masked account number that can be displayed to the customer | 
**currency_code** | **string** | The currency code of the account in ISO 4217 format | [optional] 
**available_balance** | **double** | The amount available  to withdraw or transfer immediately | [optional] 
**current_balance** | **double** | The current balance including any pending or in progress deposits and withdrawals | [optional] 
**interest_rate** | **double** | The rate of interest applicable for the call deposit account | [optional] 
**opening_date** | [**\DateTime**](\DateTime.md) | Call deposit account opening date in ISO 8601 date format YYYY-MM-DD | [optional] 
**base_currency_maturity_amount** | **double** | Maturity amount on the call deposit account. | [optional] 
**last_interest_payment_amount** | **double** | Last interest payment amount on the call deposit account. | [optional] 
**last_interest_payment_date** | [**\DateTime**](\DateTime.md) | Last interest payment date in ISO 8601 date format YYYY-MM-DD | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

