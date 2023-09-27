# StatementSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**outstandingBalance** | **Double** | Outstanding balance amount on the statement date |  [optional]
**creditLimit** | **Double** | The maximum amount of credit that extend to a customer |  [optional]
**activeEqualPaymentPlanCount** | **Double** | Number of active plans under equal payment plan |  [optional]
**beginningBalanceAmount** | **Double** | Balance as on Last Statement Date |  [optional]
**totalDebitAmount** | **Double** | Total debits made during the statement period |  [optional]
**totalCreditAmount** | **Double** | Total payments made during the statement period. |  [optional]
**netInterestAmount** | **Double** | Total interest amount of monetary transactions posted to cardholder account |  [optional]
**paymentDueDate** | [**LocalDate**](LocalDate.md) | Next payment due date in ISO 8601 date format YYYY-MM-DD |  [optional]
**pastDueAmount** | **Double** | Past due amount to be paid |  [optional]
**cashAdvanceLimit** | **Double** | Some percentage of credit limit to withdraw cash |  [optional]
**cycleToDateFeeAmount** | **Double** | The total fee applied in the cycle |  [optional]
**interestPaidAmount** | **Double** | Interest amount paid on the credit card from the last billing cycle. |  [optional]
**billingCurrencyCode** | **String** | Billing currency code in  in ISO 4217 format |  [optional]
**cashAdvanceAvailableAmount** | **Double** | Available Cash Amount for withdrawal |  [optional]
**retailCycleInterestRate** | **Double** | Retail Interest Rate for merchant transactions. |  [optional]
**cashCycleInterestRate** | **Double** | Cash Interest Rate for withdrawal |  [optional]
**privateLabelCreditCards** | [**PrivateLabelCreditCards**](PrivateLabelCreditCards.md) |  |  [optional]
