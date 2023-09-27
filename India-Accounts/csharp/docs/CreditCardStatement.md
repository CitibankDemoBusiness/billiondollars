# IO.Swagger.Model.CreditCardStatement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | 
**StatementDate** | **DateTime?** | The statement date in ISO 8601 format YYYY-MM-DD | 
**StatementSummary** | [**StatementSummary**](StatementSummary.md) |  | [optional] 
**UnSecuredLoans** | [**List&lt;UnSecuredLoans&gt;**](UnSecuredLoans.md) |  | [optional] 
**Transactions** | [**List&lt;Transactions&gt;**](Transactions.md) |  | [optional] 
**NextStartIndex** | **string** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

