# IO.Swagger.Model.DestinationSourceAcctCombinations
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DestinationAccountId** | **string** | The destination account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**DisplayDestinationAccountNumber** | **string** | A masked account number that can be displayed to the customer | 
**DestinationAccountCurrencyCode** | **string** | The currency code of the payee account in ISO 4217 format | 
**ProductName** | **string** | The name of the product | [optional] 
**AvailableBalance** | **double?** | The amount available  to withdraw or transfer immediately. | [optional] 
**NextPaymentAmount** | **double?** | The next payment amount due. | [optional] 
**OutstandingBalance** | **double?** | Previous balance amount. | [optional] 
**MinimumDueAmount** | **double?** | Minimum due amount for a payment cycle. | [optional] 
**LastStatementDate** | **DateTime?** | The date of the last statement in ISO 8601 date format YYYY-MM-DD. | [optional] 
**PaymentDueDate** | **DateTime?** | The payment due date in ISO 8601 date format YYYY-MM-DD. | [optional] 
**SourceAccountIds** | [**List&lt;SourceAccountIds&gt;**](SourceAccountIds.md) |  | 
**AccountNickName** | **string** | The nick name of the account assigned by the customer | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

