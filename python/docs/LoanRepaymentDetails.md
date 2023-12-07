# LoanRepaymentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_amount** | **float** | Requested disbursement amount | [optional] 
**loan_repayment_method** | **str** | Loan repayment method for the unsecured loan selected by the applicant Ex:SI,PDC,UAE Exchange,Direct Debit,Manual Direct Debit Please use /v1/utilities/referenceData/{loanRepaymentMethod} resource to get valid value of this field with description. | [optional] 
**payment_account_number** | **str** | Payment account number associated with the bank   through which the loan repayment is carried out  by the applicant | [optional] 
**account_reference_key** | **str** | Account reference key to link account in a customer session, | [optional] 
**account_nick_name** | **str** | The nick name of the account assigned by the customer | [optional] 
**bank_details** | [**BankDetails**](BankDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

