# SavingsAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productName** | **String** | The name of the product |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer | 
**currentBalance** | **Double** | The current balance including any pending or in progress deposits and withdrawals |  [optional]
**availableBalance** | **Double** | The amount available  to withdraw or transfer immediately |  [optional]
**currencyCode** | **String** | The currency code of the account in ISO 4217 format |  [optional]
**lastStatementDate** | [**LocalDate**](LocalDate.md) | The date of the last statement in ISO 8601 date format YYYY-MM-DD |  [optional]
**holdAmount** | **Double** | A portion of account balance unavailable for use for a set period |  [optional]
**openingDate** | [**LocalDate**](LocalDate.md) | Saving account opening date in ISO 8601 date format YYYY-MM-DD |  [optional]
**floatAmount** | **Double** | The total amount of funds that have not yet been cleared through the collection process for cheque and other instruments deposited to a savings account. These funds are unavailable for withdrawal until they are paid by the drawee bank. |  [optional]
**totalInterestAmount** | **Double** | Total interest amount on the saving account |  [optional]
