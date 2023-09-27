# IO.Swagger.Model.StatementSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OutstandingBalance** | **double?** | Outstanding balance amount on the statement date | [optional] 
**CreditLimit** | **double?** | The maximum amount of credit that extend to a customer | [optional] 
**ActiveEqualPaymentPlanCount** | **double?** | Number of active plans under equal payment plan | [optional] 
**BeginningBalanceAmount** | **double?** | Balance as on Last Statement Date | [optional] 
**TotalDebitAmount** | **double?** | Total debits made during the statement period | [optional] 
**TotalCreditAmount** | **double?** | Total payments made during the statement period. | [optional] 
**NetInterestAmount** | **double?** | Total interest amount of monetary transactions posted to cardholder account | [optional] 
**PaymentDueDate** | **DateTime?** | Next payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**PastDueAmount** | **double?** | Past due amount to be paid | [optional] 
**CashAdvanceLimit** | **double?** | Some percentage of credit limit to withdraw cash | [optional] 
**CycleToDateFeeAmount** | **double?** | The total fee applied in the cycle | [optional] 
**InterestPaidAmount** | **double?** | Interest amount paid on the credit card from the last billing cycle. | [optional] 
**BillingCurrencyCode** | **string** | Billing currency code in  in ISO 4217 format | [optional] 
**CashAdvanceAvailableAmount** | **double?** | Available Cash Amount for withdrawal | [optional] 
**RetailCycleInterestRate** | **double?** | Retail Interest Rate for merchant transactions. | [optional] 
**CashCycleInterestRate** | **double?** | Cash Interest Rate for withdrawal | [optional] 
**PrivateLabelCreditCards** | [**PrivateLabelCreditCards**](PrivateLabelCreditCards.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

