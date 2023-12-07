# TransactionDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **string** | The account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**transactions** | [**\Swagger\Client\Model\Transaction[]**](Transaction.md) | Transactions list | [optional] 
**statements** | [**\Swagger\Client\Model\Statements[]**](Statements.md) | Applicable only for credit cards and will be returned only in the first request. If there is additional data available then in subsequent request this will not be returned. | [optional] 
**investment_transaction** | [**\Swagger\Client\Model\InvestmentTransaction[]**](InvestmentTransaction.md) | Investment Transactions list | [optional] 
**transaction_error_details** | [**\Swagger\Client\Model\ErrorResponse**](ErrorResponse.md) |  | [optional] 
**next_start_index** | **string** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

