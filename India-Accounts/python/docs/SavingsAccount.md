# SavingsAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **str** | The name of the product | [optional] 
**product_code** | **str** | A unique code that identifies the product | [optional] 
**display_account_number** | **str** | A masked account number that can be displayed to the customer | 
**current_balance** | **float** | The current balance including any pending or in progress deposits and withdrawals | [optional] 
**available_balance** | **float** | The amount available  to withdraw or transfer immediately | [optional] 
**currency_code** | **str** | The currency code of the account in ISO 4217 format | [optional] 
**last_statement_date** | **date** | The date of the last statement in ISO 8601 date format YYYY-MM-DD | [optional] 
**hold_amount** | **float** | A portion of account balance unavailable for use for a set period | [optional] 
**opening_date** | **date** | Saving account opening date in ISO 8601 date format YYYY-MM-DD | [optional] 
**float_amount** | **float** | The total amount of funds that have not yet been cleared through the collection process for cheque and other instruments deposited to a savings account. These funds are unavailable for withdrawal until they are paid by the drawee bank. | [optional] 
**total_interest_amount** | **float** | Total interest amount on the saving account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

