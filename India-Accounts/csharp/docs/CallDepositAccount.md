# IO.Swagger.Model.CallDepositAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the product | [optional] 
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | 
**CurrencyCode** | **string** | The currency code of the account in ISO 4217 format | [optional] 
**AvailableBalance** | **double?** | The amount available  to withdraw or transfer immediately | [optional] 
**CurrentBalance** | **double?** | The current balance including any pending or in progress deposits and withdrawals | [optional] 
**InterestRate** | **double?** | The rate of interest applicable for the call deposit account | [optional] 
**OpeningDate** | **DateTime?** | Call deposit account opening date in ISO 8601 date format YYYY-MM-DD | [optional] 
**BaseCurrencyMaturityAmount** | **double?** | Maturity amount on the call deposit account. | [optional] 
**LastInterestPaymentAmount** | **double?** | Last interest payment amount on the call deposit account. | [optional] 
**LastInterestPaymentDate** | **DateTime?** | Last interest payment date in ISO 8601 date format YYYY-MM-DD | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

