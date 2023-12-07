# CallDepositAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productName** | **String** | The name of the product |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer | 
**currencyCode** | **String** | The currency code of the account in ISO 4217 format |  [optional]
**availableBalance** | **Double** | The amount available  to withdraw or transfer immediately |  [optional]
**currentBalance** | **Double** | The current balance including any pending or in progress deposits and withdrawals |  [optional]
**interestRate** | **Double** | The rate of interest applicable for the call deposit account |  [optional]
**openingDate** | [**LocalDate**](LocalDate.md) | Call deposit account opening date in ISO 8601 date format YYYY-MM-DD |  [optional]
**baseCurrencyMaturityAmount** | **Double** | Maturity amount on the call deposit account. |  [optional]
**lastInterestPaymentAmount** | **Double** | Last interest payment amount on the call deposit account. |  [optional]
**lastInterestPaymentDate** | [**LocalDate**](LocalDate.md) | Last interest payment date in ISO 8601 date format YYYY-MM-DD |  [optional]
