# IO.Swagger.Model.SavingsAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the product | [optional] 
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | 
**CurrentBalance** | **double?** | The current balance including any pending or in progress deposits and withdrawals | [optional] 
**AvailableBalance** | **double?** | The amount available  to withdraw or transfer immediately | [optional] 
**CurrencyCode** | **string** | The currency code of the account in ISO 4217 format | [optional] 
**LastStatementDate** | **DateTime?** | The date of the last statement in ISO 8601 date format YYYY-MM-DD | [optional] 
**HoldAmount** | **double?** | A portion of account balance unavailable for use for a set period | [optional] 
**OpeningDate** | **DateTime?** | Saving account opening date in ISO 8601 date format YYYY-MM-DD | [optional] 
**FloatAmount** | **double?** | The total amount of funds that have not yet been cleared through the collection process for cheque and other instruments deposited to a savings account. These funds are unavailable for withdrawal until they are paid by the drawee bank. | [optional] 
**TotalInterestAmount** | **double?** | Total interest amount on the saving account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

