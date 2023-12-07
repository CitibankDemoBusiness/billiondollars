# CreditCardStatement

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**statement_date** | **date** | The statement date in ISO 8601 format YYYY-MM-DD | [optional] 
**statement_id** | **str** | Unique identifier for the statement | [optional] 
**currency_code** | **str** | The currency code of the statement in ISO 4217 format | [optional] 
**credit_limit** | **float** | The maximum amount of credit that extend to a customer | [optional] 
**outstanding_balance** | **float** | Outstanding balance amount on the statement date | [optional] 
**last_statement_balance** | **float** | The balance on last statement date | [optional] 
**payment_due_date** | **date** | Next payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**minimum_due_amount** | **float** | Minimum due amount for a payment cycle | [optional] 
**eligible_for_equal_payment_plans** | [**list[EligibleForEqualPaymentPlan]**](EligibleForEqualPaymentPlan.md) |  | [optional] 
**reward_points** | [**RewardPoints**](RewardPoints.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

