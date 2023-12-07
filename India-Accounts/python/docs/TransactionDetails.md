# TransactionDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **str** | The account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**transactions** | [**list[Transaction]**](Transaction.md) | Transactions list | [optional] 
**statements** | [**list[Statements]**](Statements.md) | Applicable only for credit cards and will be returned only in the first request. If there is additional data available then in subsequent request this will not be returned. | [optional] 
**investment_transaction** | [**list[InvestmentTransaction]**](InvestmentTransaction.md) | Investment Transactions list | [optional] 
**transaction_error_details** | [**ErrorResponse**](ErrorResponse.md) |  | [optional] 
**next_start_index** | **str** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

