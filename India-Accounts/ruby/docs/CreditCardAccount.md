# SwaggerClient::CreditCardAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **String** | The name of the product | [optional] 
**product_code** | **String** | A unique code that identifies the product | [optional] 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | 
**currency_code** | **String** | The currency code of the account in ISO 4217 format | [optional] 
**outstanding_balance** | **Float** | The amount of money owed. | [optional] 
**last_statement_balance** | **Float** | The balance on last statement date | [optional] 
**last_statement_date** | **Date** | The date of the last statement in ISO 8601 date format YYYY-MM-DD | [optional] 
**credit_used** | **Float** | The part of the credit limit already used | [optional] 
**credit_limit** | **Float** | The maximum amount of credit that extend to a customer | [optional] 
**available_credit** | **Float** | The available credit | [optional] 
**cash_advance_limit** | **Float** | Some percentage of credit limit to withdraw cash | [optional] 
**cash_advance_available_amount** | **Float** | Cash advance amount available. This will be same as the cash limit if there is no cash advance done. Otherwise, this will be the amount from the cashLimit minus the cash advance amount already used | [optional] 
**last_payment_amount** | **Float** | The amount of the last payment made | [optional] 
**last_payment_date** | **Date** | The date of the last payment in ISO 8601 date format YYYY-MM-DD | [optional] 
**minimum_due_amount** | **Float** | Minimum due amount for a payment cycle | [optional] 
**payment_due_date** | **Date** | The date of the next payment/payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**available_point_balance** | [**BigDecimal**](BigDecimal.md) | Available reward points on the credit card | [optional] 

