# SwaggerClient::LoanPaymentAccountDetailsAdd

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**disbursement_amount** | **Float** | Disbursement Amount to the applicant | [optional] 
**loan_disbursement_method** | **String** | Loan disbursement method for the unsecured loan product selected by the applicant.This a reference data field. Please use /utilities/referenceData/{disbursementType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | [optional] 
**account_number** | **String** | Account number of the payee. | 
**account_reference_key** | **String** | Account reference key to link account in a customer session, | [optional] 
**account_nick_name** | **String** | The nick name of the account assigned by the customer | [optional] 
**bank_name** | **String** | Indicates the bank name of the customer&#x27;s account to which the loan amount will be transferred. Also, indicates the bank name of the customer&#x27;s account from which the repayment of the loan will be debited. Please use /v1/utilities/referenceData/{bankName} resource to get valid value of this field with description. | 
**bank_code** | **String** | This field is to indicate the bank code. | [optional] 
**branch_code** | **String** | This field is to indicate the branch code of the bank. | 

