# LoanPaymentAccountDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**disbursementAmount** | **Double** | Disbursement Amount to the applicant |  [optional]
**loanDisbursementMethod** | **String** | Loan disbursement method for the unsecured loan product selected by the applicant.This a reference data field. Please use /utilities/referenceData/{disbursementType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. |  [optional]
**accountReferenceKey** | **String** | Account reference key to link account in a customer session, |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer |  [optional]
**accountNickName** | **String** | The nick name of the account assigned by the customer |  [optional]
**bankName** | **String** | Indicates the bank name of the customer&#x27;s account to which the loan amount will be transferred. Also, indicates the bank name of the customer&#x27;s account from which the repayment of the loan will be debited. Please use /v1/utilities/referenceData/{bankName} resource to get valid value of this field with description. |  [optional]
**bankCode** | **String** | This field is to indicate the bank code. |  [optional]
**branchCode** | **String** | This field is to indicate the branch code. |  [optional]
