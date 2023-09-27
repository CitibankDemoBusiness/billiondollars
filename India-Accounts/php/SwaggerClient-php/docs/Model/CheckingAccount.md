# CheckingAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **string** | The name of the product | [optional] 
**product_code** | **string** | A unique code that identifies the product | [optional] 
**display_account_number** | **string** | A masked account number that can be displayed to the customer | 
**current_balance** | **double** | The current balance including any pending or in progress deposits and withdrawals | [optional] 
**available_balance** | **double** | The amount available  to withdraw or transfer immediately | [optional] 
**overdraft_limit** | **double** | This allows a customer to overdraw their account up to a specific amount | [optional] 
**available_overdraft_limit** | **double** | The amount available under over draft Limit amount | [optional] 
**currency_code** | **string** | The currency code of the account in ISO 4217 format | [optional] 
**last_statement_date** | [**\DateTime**](\DateTime.md) | The date of the last statement in ISO 8601 date format YYYY-MM-DD | [optional] 
**hold_amount** | **double** | The amount of funds that were previously available but are now blocked. It represents funds authorized for withdrawal but not yet withdrawn. The hold amount is included in the ledger/book balance but not in the available balance. It is included in interest | [optional] 
**float_amount** | **double** | The total amount of funds that have not yet been cleared through the collection process for cheque and other instruments deposited to a checking account. These funds are unavailable for withdrawal until they are paid by the drawee bank. | [optional] 
**total_interest_amount** | **double** | Total interest amount on checking account. | [optional] 
**opening_date** | [**\DateTime**](\DateTime.md) | Checking account opening date in ISO 8601 date format YYYY-MM-DD | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

