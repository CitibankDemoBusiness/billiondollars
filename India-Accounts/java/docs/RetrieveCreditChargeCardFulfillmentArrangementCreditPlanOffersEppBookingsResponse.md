# RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loanReferenceId** | **String** | The unique  reference Id used to identify this Loan from all the other Loans | 
**installmentAmount** | **Double** | Installment amount to be paid by customer in order to repay the loan. |  [optional]
**principalAmount** | **Double** | The portion of the Principal Amount Paid for the loan. |  [optional]
**installmentInterestAmount** | **Double** | The interest amount to be paid as installment. |  [optional]
**initialInterestAmount** | **Double** | Initial interest amount charged to customer from the epp booking date to the first installment start date |  [optional]
**statementUnpaidBalanceAmount** | **Double** | This field indicates the remaining statement balance amount that remains due and payable. |  [optional]
**statementMinimumDueBalanceAmount** | **Double** | Minimum due amount for a payment cycle |  [optional]
**statementPaymentDueDate** | [**LocalDate**](LocalDate.md) | Next payment due date in ISO 8601 date format YYYY-MM-DD |  [optional]
