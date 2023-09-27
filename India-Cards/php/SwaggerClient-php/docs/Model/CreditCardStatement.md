# CreditCardStatement

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**statement_date** | [**\DateTime**](\DateTime.md) | The statement date in ISO 8601 format YYYY-MM-DD | [optional] 
**statement_id** | **string** | Unique identifier for the statement | [optional] 
**currency_code** | **string** | The currency code of the statement in ISO 4217 format | [optional] 
**credit_limit** | **double** | The maximum amount of credit that extend to a customer | [optional] 
**outstanding_balance** | **double** | Outstanding balance amount on the statement date | [optional] 
**last_statement_balance** | **double** | The balance on last statement date | [optional] 
**payment_due_date** | [**\DateTime**](\DateTime.md) | Next payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**minimum_due_amount** | **double** | Minimum due amount for a payment cycle | [optional] 
**eligible_for_equal_payment_plans** | [**\Swagger\Client\Model\EligibleForEqualPaymentPlan[]**](EligibleForEqualPaymentPlan.md) |  | [optional] 
**reward_points** | [**\Swagger\Client\Model\RewardPoints**](RewardPoints.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

