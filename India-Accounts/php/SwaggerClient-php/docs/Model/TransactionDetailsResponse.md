# TransactionDetailsResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transactions** | [**\Swagger\Client\Model\Transaction[]**](Transaction.md) | Transactions list | [optional] 
**investment_transaction** | [**\Swagger\Client\Model\InvestmentTransaction[]**](InvestmentTransaction.md) | Investment Transactions list | [optional] 
**next_start_index** | **string** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

