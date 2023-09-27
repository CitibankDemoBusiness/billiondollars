# TransactionDetailsConfirmationResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transactions** | [**List&lt;Transaction&gt;**](Transaction.md) | Transactions list |  [optional]
**investmentTransaction** | [**List&lt;InvestmentTransaction&gt;**](InvestmentTransaction.md) | Investment Transactions list |  [optional]
**nextStartIndex** | **String** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. |  [optional]
