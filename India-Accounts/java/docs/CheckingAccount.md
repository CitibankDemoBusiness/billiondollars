# CheckingAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productName** | **String** | The name of the product |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer | 
**currentBalance** | **Double** | The current balance including any pending or in progress deposits and withdrawals |  [optional]
**availableBalance** | **Double** | The amount available  to withdraw or transfer immediately |  [optional]
**overdraftLimit** | **Double** | This allows a customer to overdraw their account up to a specific amount |  [optional]
**availableOverdraftLimit** | **Double** | The amount available under over draft Limit amount |  [optional]
**currencyCode** | **String** | The currency code of the account in ISO 4217 format |  [optional]
**lastStatementDate** | [**LocalDate**](LocalDate.md) | The date of the last statement in ISO 8601 date format YYYY-MM-DD |  [optional]
**holdAmount** | **Double** | The amount of funds that were previously available but are now blocked. It represents funds authorized for withdrawal but not yet withdrawn. The hold amount is included in the ledger/book balance but not in the available balance. It is included in interest |  [optional]
**floatAmount** | **Double** | The total amount of funds that have not yet been cleared through the collection process for cheque and other instruments deposited to a checking account. These funds are unavailable for withdrawal until they are paid by the drawee bank. |  [optional]
**totalInterestAmount** | **Double** | Total interest amount on checking account. |  [optional]
**openingDate** | [**LocalDate**](LocalDate.md) | Checking account opening date in ISO 8601 date format YYYY-MM-DD |  [optional]
