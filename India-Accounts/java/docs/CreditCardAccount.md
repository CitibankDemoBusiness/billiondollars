# CreditCardAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productName** | **String** | The name of the product |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer | 
**currencyCode** | **String** | The currency code of the account in ISO 4217 format |  [optional]
**outstandingBalance** | **Double** | The amount of money owed. |  [optional]
**lastStatementBalance** | **Double** | The balance on last statement date |  [optional]
**lastStatementDate** | [**LocalDate**](LocalDate.md) | The date of the last statement in ISO 8601 date format YYYY-MM-DD |  [optional]
**creditUsed** | **Double** | The part of the credit limit already used |  [optional]
**creditLimit** | **Double** | The maximum amount of credit that extend to a customer |  [optional]
**availableCredit** | **Double** | The available credit |  [optional]
**cashAdvanceLimit** | **Double** | Some percentage of credit limit to withdraw cash |  [optional]
**cashAdvanceAvailableAmount** | **Double** | Cash advance amount available. This will be same as the cash limit if there is no cash advance done. Otherwise, this will be the amount from the cashLimit minus the cash advance amount already used |  [optional]
**lastPaymentAmount** | **Double** | The amount of the last payment made |  [optional]
**lastPaymentDate** | [**LocalDate**](LocalDate.md) | The date of the last payment in ISO 8601 date format YYYY-MM-DD |  [optional]
**minimumDueAmount** | **Double** | Minimum due amount for a payment cycle |  [optional]
**paymentDueDate** | [**LocalDate**](LocalDate.md) | The date of the next payment/payment due date in ISO 8601 date format YYYY-MM-DD |  [optional]
**availablePointBalance** | [**BigDecimal**](BigDecimal.md) | Available reward points on the credit card |  [optional]
