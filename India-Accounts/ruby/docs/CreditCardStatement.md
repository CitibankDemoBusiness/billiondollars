# SwaggerClient::CreditCardStatement

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_account_number** | **String** | A masked account number that can be displayed to the customer | 
**statement_date** | **Date** | The statement date in ISO 8601 format YYYY-MM-DD | 
**statement_summary** | [**StatementSummary**](StatementSummary.md) |  | [optional] 
**un_secured_loans** | [**Array&lt;UnSecuredLoans&gt;**](UnSecuredLoans.md) |  | [optional] 
**transactions** | [**Array&lt;Transactions&gt;**](Transactions.md) |  | [optional] 
**next_start_index** | **String** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

