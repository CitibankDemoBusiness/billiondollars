# ReadyCreditAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **string** | The name of the product | [optional] 
**product_code** | **string** | A unique code that identifies the product | [optional] 
**display_account_number** | **string** | A masked account number that can be displayed to the customer | 
**currency_code** | **string** | The currency code of the account in ISO 4217 format | [optional] 
**outstanding_balance** | **double** | The amount of money owed | [optional] 
**last_statement_balance** | **double** | The balance on last statement date | [optional] 
**last_statement_date** | [**\DateTime**](\DateTime.md) | The date of the last statement in ISO 8601 date format YYYY-MM-DD | [optional] 
**minimum_due_amount** | **double** | Minimum due amount for a payment cycle | [optional] 
**credit_limit** | **double** | The maximum amount of credit that extend to a customer | [optional] 
**available_credit** | **double** | Available credit limit of ready credit account | [optional] 
**cash_advance_limit** | **double** | Some percentage of credit limit to withdraw cash | [optional] 
**cash_advance_available_amount** | **double** | The amount available under cash advance limit | [optional] 
**last_payment_amount** | **double** | The amount of the last payment made | [optional] 
**last_payment_date** | [**\DateTime**](\DateTime.md) | The date of the last payment in ISO 8601 date format YYYY-MM-DD | [optional] 
**next_payment_amount** | **double** | The next payment amount due | [optional] 
**next_payment_date** | [**\DateTime**](\DateTime.md) | The date of the next payment in ISO 8601 date format YYYY-MM-DD | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

