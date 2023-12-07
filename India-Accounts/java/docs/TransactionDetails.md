# TransactionDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountId** | **String** | The account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**transactions** | [**List&lt;Transaction&gt;**](Transaction.md) | Transactions list |  [optional]
**statements** | [**List&lt;Statements&gt;**](Statements.md) | Applicable only for credit cards and will be returned only in the first request. If there is additional data available then in subsequent request this will not be returned. |  [optional]
**investmentTransaction** | [**List&lt;InvestmentTransaction&gt;**](InvestmentTransaction.md) | Investment Transactions list |  [optional]
**transactionErrorDetails** | [**ErrorResponse**](ErrorResponse.md) |  |  [optional]
**nextStartIndex** | **String** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. |  [optional]
