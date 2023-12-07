# IO.Swagger.Model.LoanPaymentAccountDetailsAdd
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisbursementAmount** | **double?** | Disbursement Amount to the applicant | [optional] 
**LoanDisbursementMethod** | **string** | Loan disbursement method for the unsecured loan product selected by the applicant.This a reference data field. Please use /utilities/referenceData/{disbursementType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | [optional] 
**AccountNumber** | **string** | Account number of the payee. | 
**AccountReferenceKey** | **string** | Account reference key to link account in a customer session, | [optional] 
**AccountNickName** | **string** | The nick name of the account assigned by the customer | [optional] 
**BankName** | **string** | Indicates the bank name of the customer&#x27;s account to which the loan amount will be transferred. Also, indicates the bank name of the customer&#x27;s account from which the repayment of the loan will be debited. Please use /v1/utilities/referenceData/{bankName} resource to get valid value of this field with description. | 
**BankCode** | **string** | This field is to indicate the bank code. | [optional] 
**BranchCode** | **string** | This field is to indicate the branch code of the bank. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

