# CreditCardAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **string** | The name of the product | [optional] 
**product_code** | **string** | A unique code that identifies the product | [optional] 
**display_account_number** | **string** | A masked account number that can be displayed to the customer | 
**currency_code** | **string** | The currency code of the account in ISO 4217 format | [optional] 
**outstanding_balance** | **double** | The amount of money owed. | [optional] 
**last_statement_balance** | **double** | The balance on last statement date | [optional] 
**last_statement_date** | [**\DateTime**](\DateTime.md) | The date of the last statement in ISO 8601 date format YYYY-MM-DD | [optional] 
**credit_used** | **double** | The part of the credit limit already used | [optional] 
**credit_limit** | **double** | The maximum amount of credit that extend to a customer | [optional] 
**available_credit** | **double** | The available credit | [optional] 
**cash_advance_limit** | **double** | Some percentage of credit limit to withdraw cash | [optional] 
**cash_advance_available_amount** | **double** | Cash advance amount available. This will be same as the cash limit if there is no cash advance done. Otherwise, this will be the amount from the cashLimit minus the cash advance amount already used | [optional] 
**last_payment_amount** | **double** | The amount of the last payment made | [optional] 
**last_payment_date** | [**\DateTime**](\DateTime.md) | The date of the last payment in ISO 8601 date format YYYY-MM-DD | [optional] 
**minimum_due_amount** | **double** | Minimum due amount for a payment cycle | [optional] 
**payment_due_date** | [**\DateTime**](\DateTime.md) | The date of the next payment/payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**available_point_balance** | **float** | Available reward points on the credit card | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

