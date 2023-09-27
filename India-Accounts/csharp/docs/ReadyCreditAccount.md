# IO.Swagger.Model.ReadyCreditAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the product | [optional] 
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | 
**CurrencyCode** | **string** | The currency code of the account in ISO 4217 format | [optional] 
**OutstandingBalance** | **double?** | The amount of money owed | [optional] 
**LastStatementBalance** | **double?** | The balance on last statement date | [optional] 
**LastStatementDate** | **DateTime?** | The date of the last statement in ISO 8601 date format YYYY-MM-DD | [optional] 
**MinimumDueAmount** | **double?** | Minimum due amount for a payment cycle | [optional] 
**CreditLimit** | **double?** | The maximum amount of credit that extend to a customer | [optional] 
**AvailableCredit** | **double?** | Available credit limit of ready credit account | [optional] 
**CashAdvanceLimit** | **double?** | Some percentage of credit limit to withdraw cash | [optional] 
**CashAdvanceAvailableAmount** | **double?** | The amount available under cash advance limit | [optional] 
**LastPaymentAmount** | **double?** | The amount of the last payment made | [optional] 
**LastPaymentDate** | **DateTime?** | The date of the last payment in ISO 8601 date format YYYY-MM-DD | [optional] 
**NextPaymentAmount** | **double?** | The next payment amount due | [optional] 
**NextPaymentDate** | **DateTime?** | The date of the next payment in ISO 8601 date format YYYY-MM-DD | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

