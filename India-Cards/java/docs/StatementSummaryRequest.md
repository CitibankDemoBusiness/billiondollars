# StatementSummaryRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cardId** | **String** | The card id  in encrypted format |  [optional]
**currencyCode** | **String** | The currency code of the destination account in ISO 4217 format |  [optional]
**statementList** | [**List&lt;StatementList&gt;**](StatementList.md) |  |  [optional]
**nextStartIndex** | **String** | The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex. |  [optional]
