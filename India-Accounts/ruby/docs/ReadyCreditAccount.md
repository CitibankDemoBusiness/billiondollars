# SwaggerClient::ReadyCreditAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **String** | The name of the product | [optional] 
**product_code** | **String** | A unique code that identifies the product | [optional] 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | 
**currency_code** | **String** | The currency code of the account in ISO 4217 format | [optional] 
**outstanding_balance** | **Float** | The amount of money owed | [optional] 
**last_statement_balance** | **Float** | The balance on last statement date | [optional] 
**last_statement_date** | **Date** | The date of the last statement in ISO 8601 date format YYYY-MM-DD | [optional] 
**minimum_due_amount** | **Float** | Minimum due amount for a payment cycle | [optional] 
**credit_limit** | **Float** | The maximum amount of credit that extend to a customer | [optional] 
**available_credit** | **Float** | Available credit limit of ready credit account | [optional] 
**cash_advance_limit** | **Float** | Some percentage of credit limit to withdraw cash | [optional] 
**cash_advance_available_amount** | **Float** | The amount available under cash advance limit | [optional] 
**last_payment_amount** | **Float** | The amount of the last payment made | [optional] 
**last_payment_date** | **Date** | The date of the last payment in ISO 8601 date format YYYY-MM-DD | [optional] 
**next_payment_amount** | **Float** | The next payment amount due | [optional] 
**next_payment_date** | **Date** | The date of the next payment in ISO 8601 date format YYYY-MM-DD | [optional] 

