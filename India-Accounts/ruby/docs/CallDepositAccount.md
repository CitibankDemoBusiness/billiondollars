# SwaggerClient::CallDepositAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **String** | The name of the product | [optional] 
**product_code** | **String** | A unique code that identifies the product | [optional] 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | 
**currency_code** | **String** | The currency code of the account in ISO 4217 format | [optional] 
**available_balance** | **Float** | The amount available  to withdraw or transfer immediately | [optional] 
**current_balance** | **Float** | The current balance including any pending or in progress deposits and withdrawals | [optional] 
**interest_rate** | **Float** | The rate of interest applicable for the call deposit account | [optional] 
**opening_date** | **Date** | Call deposit account opening date in ISO 8601 date format YYYY-MM-DD | [optional] 
**base_currency_maturity_amount** | **Float** | Maturity amount on the call deposit account. | [optional] 
**last_interest_payment_amount** | **Float** | Last interest payment amount on the call deposit account. | [optional] 
**last_interest_payment_date** | **Date** | Last interest payment date in ISO 8601 date format YYYY-MM-DD | [optional] 

