# LoanRepaymentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loanAmount** | **Double** | Requested disbursement amount |  [optional]
**loanRepaymentMethod** | **String** | Loan repayment method for the unsecured loan selected by the applicant Ex:SI,PDC,UAE Exchange,Direct Debit,Manual Direct Debit Please use /v1/utilities/referenceData/{loanRepaymentMethod} resource to get valid value of this field with description. |  [optional]
**paymentAccountNumber** | **String** | Payment account number associated with the bank   through which the loan repayment is carried out  by the applicant |  [optional]
**accountReferenceKey** | **String** | Account reference key to link account in a customer session, |  [optional]
**accountNickName** | **String** | The nick name of the account assigned by the customer |  [optional]
**bankDetails** | [**BankDetails**](BankDetails.md) |  |  [optional]
