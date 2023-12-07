# SwaggerClient::TransactionDetailsConfirmationResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transactions** | [**Array&lt;Transaction&gt;**](Transaction.md) | Transactions list | [optional] 
**investment_transaction** | [**Array&lt;InvestmentTransaction&gt;**](InvestmentTransaction.md) | Investment Transactions list | [optional] 
**next_start_index** | **String** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

