# SwaggerClient::CreditCardStatement

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**statement_date** | **Date** | The statement date in ISO 8601 format YYYY-MM-DD | [optional] 
**statement_id** | **String** | Unique identifier for the statement | [optional] 
**currency_code** | **String** | The currency code of the statement in ISO 4217 format | [optional] 
**credit_limit** | **Float** | The maximum amount of credit that extend to a customer | [optional] 
**outstanding_balance** | **Float** | Outstanding balance amount on the statement date | [optional] 
**last_statement_balance** | **Float** | The balance on last statement date | [optional] 
**payment_due_date** | **Date** | Next payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**minimum_due_amount** | **Float** | Minimum due amount for a payment cycle | [optional] 
**eligible_for_equal_payment_plans** | [**Array&lt;EligibleForEqualPaymentPlan&gt;**](EligibleForEqualPaymentPlan.md) |  | [optional] 
**reward_points** | [**RewardPoints**](RewardPoints.md) |  | [optional] 

