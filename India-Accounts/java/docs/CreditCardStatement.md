# CreditCardStatement

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer | 
**statementDate** | [**LocalDate**](LocalDate.md) | The statement date in ISO 8601 format YYYY-MM-DD | 
**statementSummary** | [**StatementSummary**](StatementSummary.md) |  |  [optional]
**unSecuredLoans** | [**List&lt;UnSecuredLoans&gt;**](UnSecuredLoans.md) |  |  [optional]
**transactions** | [**List&lt;Transactions&gt;**](Transactions.md) |  |  [optional]
**nextStartIndex** | **String** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. |  [optional]
