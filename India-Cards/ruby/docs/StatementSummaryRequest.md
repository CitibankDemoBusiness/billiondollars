# SwaggerClient::StatementSummaryRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_id** | **String** | The card id  in encrypted format | [optional] 
**currency_code** | **String** | The currency code of the destination account in ISO 4217 format | [optional] 
**statement_list** | [**Array&lt;StatementList&gt;**](StatementList.md) |  | [optional] 
**next_start_index** | **String** | The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex. | [optional] 

