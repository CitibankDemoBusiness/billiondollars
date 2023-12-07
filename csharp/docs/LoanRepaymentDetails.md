# IO.Swagger.Model.LoanRepaymentDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanAmount** | **double?** | Requested disbursement amount | [optional] 
**LoanRepaymentMethod** | **string** | Loan repayment method for the unsecured loan selected by the applicant Ex:SI,PDC,UAE Exchange,Direct Debit,Manual Direct Debit Please use /v1/utilities/referenceData/{loanRepaymentMethod} resource to get valid value of this field with description. | [optional] 
**PaymentAccountNumber** | **string** | Payment account number associated with the bank   through which the loan repayment is carried out  by the applicant | [optional] 
**AccountReferenceKey** | **string** | Account reference key to link account in a customer session, | [optional] 
**AccountNickName** | **string** | The nick name of the account assigned by the customer | [optional] 
**BankDetails** | [**BankDetails**](BankDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

