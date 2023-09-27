# LoanPaymentAccountDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**disbursement_amount** | **double** | Disbursement Amount to the applicant | [optional] 
**loan_disbursement_method** | **string** | Loan disbursement method for the unsecured loan product selected by the applicant.This a reference data field. Please use /utilities/referenceData/{disbursementType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | [optional] 
**account_reference_key** | **string** | Account reference key to link account in a customer session, | [optional] 
**display_account_number** | **string** | A masked account number that can be displayed to the customer | [optional] 
**account_nick_name** | **string** | The nick name of the account assigned by the customer | [optional] 
**bank_name** | **string** | Indicates the bank name of the customer&#x27;s account to which the loan amount will be transferred. Also, indicates the bank name of the customer&#x27;s account from which the repayment of the loan will be debited. Please use /v1/utilities/referenceData/{bankName} resource to get valid value of this field with description. | [optional] 
**bank_code** | **string** | This field is to indicate the bank code. | [optional] 
**branch_code** | **string** | This field is to indicate the branch code. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

