# IO.Swagger.Model.TransactionDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**Transactions** | [**List&lt;Transaction&gt;**](Transaction.md) | Transactions list | [optional] 
**Statements** | [**List&lt;Statements&gt;**](Statements.md) | Applicable only for credit cards and will be returned only in the first request. If there is additional data available then in subsequent request this will not be returned. | [optional] 
**InvestmentTransaction** | [**List&lt;InvestmentTransaction&gt;**](InvestmentTransaction.md) | Investment Transactions list | [optional] 
**TransactionErrorDetails** | [**ErrorResponse**](ErrorResponse.md) |  | [optional] 
**NextStartIndex** | **string** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

