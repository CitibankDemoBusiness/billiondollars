# IO.Swagger.Model.CreditCardAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the product | [optional] 
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | 
**CurrencyCode** | **string** | The currency code of the account in ISO 4217 format | [optional] 
**OutstandingBalance** | **double?** | The amount of money owed. | [optional] 
**LastStatementBalance** | **double?** | The balance on last statement date | [optional] 
**LastStatementDate** | **DateTime?** | The date of the last statement in ISO 8601 date format YYYY-MM-DD | [optional] 
**CreditUsed** | **double?** | The part of the credit limit already used | [optional] 
**CreditLimit** | **double?** | The maximum amount of credit that extend to a customer | [optional] 
**AvailableCredit** | **double?** | The available credit | [optional] 
**CashAdvanceLimit** | **double?** | Some percentage of credit limit to withdraw cash | [optional] 
**CashAdvanceAvailableAmount** | **double?** | Cash advance amount available. This will be same as the cash limit if there is no cash advance done. Otherwise, this will be the amount from the cashLimit minus the cash advance amount already used | [optional] 
**LastPaymentAmount** | **double?** | The amount of the last payment made | [optional] 
**LastPaymentDate** | **DateTime?** | The date of the last payment in ISO 8601 date format YYYY-MM-DD | [optional] 
**MinimumDueAmount** | **double?** | Minimum due amount for a payment cycle | [optional] 
**PaymentDueDate** | **DateTime?** | The date of the next payment/payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**AvailablePointBalance** | [**decimal?**](BigDecimal.md) | Available reward points on the credit card | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

