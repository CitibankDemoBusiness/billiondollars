# SwaggerClient::LoanRepaymentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_amount** | **Float** | Requested disbursement amount | [optional] 
**loan_repayment_method** | **String** | Loan repayment method for the unsecured loan selected by the applicant Ex:SI,PDC,UAE Exchange,Direct Debit,Manual Direct Debit Please use /v1/utilities/referenceData/{loanRepaymentMethod} resource to get valid value of this field with description. | [optional] 
**payment_account_number** | **String** | Payment account number associated with the bank   through which the loan repayment is carried out  by the applicant | [optional] 
**account_reference_key** | **String** | Account reference key to link account in a customer session, | [optional] 
**account_nick_name** | **String** | The nick name of the account assigned by the customer | [optional] 
**bank_details** | [**BankDetails**](BankDetails.md) |  | [optional] 

