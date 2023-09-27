# ReadyCreditAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productName** | **String** | The name of the product |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer | 
**currencyCode** | **String** | The currency code of the account in ISO 4217 format |  [optional]
**outstandingBalance** | **Double** | The amount of money owed |  [optional]
**lastStatementBalance** | **Double** | The balance on last statement date |  [optional]
**lastStatementDate** | [**LocalDate**](LocalDate.md) | The date of the last statement in ISO 8601 date format YYYY-MM-DD |  [optional]
**minimumDueAmount** | **Double** | Minimum due amount for a payment cycle |  [optional]
**creditLimit** | **Double** | The maximum amount of credit that extend to a customer |  [optional]
**availableCredit** | **Double** | Available credit limit of ready credit account |  [optional]
**cashAdvanceLimit** | **Double** | Some percentage of credit limit to withdraw cash |  [optional]
**cashAdvanceAvailableAmount** | **Double** | The amount available under cash advance limit |  [optional]
**lastPaymentAmount** | **Double** | The amount of the last payment made |  [optional]
**lastPaymentDate** | [**LocalDate**](LocalDate.md) | The date of the last payment in ISO 8601 date format YYYY-MM-DD |  [optional]
**nextPaymentAmount** | **Double** | The next payment amount due |  [optional]
**nextPaymentDate** | [**LocalDate**](LocalDate.md) | The date of the next payment in ISO 8601 date format YYYY-MM-DD |  [optional]
