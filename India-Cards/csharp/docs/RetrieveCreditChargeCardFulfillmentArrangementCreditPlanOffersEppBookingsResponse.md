# IO.Swagger.Model.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanReferenceId** | **string** | The unique  reference Id used to identify this Loan from all the other Loans | 
**InstallmentAmount** | **double?** | Installment amount to be paid by customer in order to repay the loan. | [optional] 
**PrincipalAmount** | **double?** | The portion of the Principal Amount Paid for the loan. | [optional] 
**InstallmentInterestAmount** | **double?** | The interest amount to be paid as installment. | [optional] 
**InitialInterestAmount** | **double?** | Initial interest amount charged to customer from the epp booking date to the first installment start date | [optional] 
**StatementUnpaidBalanceAmount** | **double?** | This field indicates the remaining statement balance amount that remains due and payable. | [optional] 
**StatementMinimumDueBalanceAmount** | **double?** | Minimum due amount for a payment cycle | [optional] 
**StatementPaymentDueDate** | **DateTime?** | Next payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

