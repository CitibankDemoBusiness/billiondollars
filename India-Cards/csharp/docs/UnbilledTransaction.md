# IO.Swagger.Model.UnbilledTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionDate** | **DateTime?** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. | 
**TransactionDescription** | **string** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | 
**TransactionReferenceId** | **string** | Reference Id to uniquely identify the transaction.This is applicable for successful transactions.  | [optional] 
**TransactionAmount** | **double?** | Transaction amount in local currency. | 
**CurrencyCode** | **string** | The currency code in ISO 4217 format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

