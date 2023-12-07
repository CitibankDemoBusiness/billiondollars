# RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_reference_id** | **string** | The unique  reference Id used to identify this Loan from all the other Loans | 
**installment_amount** | **double** | Installment amount to be paid by customer in order to repay the loan. | [optional] 
**principal_amount** | **double** | The portion of the Principal Amount Paid for the loan. | [optional] 
**installment_interest_amount** | **double** | The interest amount to be paid as installment. | [optional] 
**initial_interest_amount** | **double** | Initial interest amount charged to customer from the epp booking date to the first installment start date | [optional] 
**statement_unpaid_balance_amount** | **double** | This field indicates the remaining statement balance amount that remains due and payable. | [optional] 
**statement_minimum_due_balance_amount** | **double** | Minimum due amount for a payment cycle | [optional] 
**statement_payment_due_date** | [**\DateTime**](\DateTime.md) | Next payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

