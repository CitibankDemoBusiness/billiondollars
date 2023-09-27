# CreditCardStatement

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_account_number** | **str** | A masked account number that can be displayed to the customer | 
**statement_date** | **date** | The statement date in ISO 8601 format YYYY-MM-DD | 
**statement_summary** | [**StatementSummary**](StatementSummary.md) |  | [optional] 
**un_secured_loans** | [**list[UnSecuredLoans]**](UnSecuredLoans.md) |  | [optional] 
**transactions** | [**list[Transactions]**](Transactions.md) |  | [optional] 
**next_start_index** | **str** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

