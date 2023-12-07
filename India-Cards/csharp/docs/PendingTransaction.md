# IO.Swagger.Model.PendingTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionDate** | **DateTime?** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, | 
**TransactionDescription** | **string** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | 
**TransactionAuthorizationCode** | **string** | Transaction authorization code is a unique to a sales credit card transaction to indicate that the sale has been authorized. This is applicable only for pending transactions. | [optional] 
**TransactionReferenceId** | **string** | Reference Id to uniquely identify the transaction. | [optional] 
**MerchantName** | **string** | Transaction merchant name. | [optional] 
**TransactionAmount** | **double?** | Transaction amount in local currency. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

