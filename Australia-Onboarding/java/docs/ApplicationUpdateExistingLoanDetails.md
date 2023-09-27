# ApplicationUpdateExistingLoanDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loanType** | **String** | Loan Type.This is a reference data field. Please use /v1/apac/utilities/referenceData/{loanType} resource to get valid value of this field with description. You can use loanType field name as the referenceCode parameter to retrieve the values. |  [optional]
**otherDebtObligationType** | **String** | Other debt obligation type. |  [optional]
**monthlyInstallmentAmount** | **Double** | Monthly repayment amount |  [optional]
**outstandingBalanceAmount** | **Double** | Balance Owing |  [optional]
**debtOwnership** | **String** | Nature debt ownership. Please use /v1/apac/utilities/referenceData/{debtOwnership} resource to get valid value of this field with description. |  [optional]
**lenderName** | **String** | Name of the lender/non-banking financial institution. |  [optional]
