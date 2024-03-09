# IO.Swagger.Model.ExistingLoanDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanType** | **string** | Loan Type.This is a reference data field. Please use /v1/utilities/referenceData/{loanType} resource to get valid value of this field with description. | [optional] 
**OtherDebtObligationType** | **string** | Other debt obligation type. Free text if others is selected under loan type. | [optional] 
**MonthlyInstallmentAmount** | **double?** | Monthly repayment amount | [optional] 
**OutstandingBalanceAmount** | **double?** | Balance Owing | [optional] 
**DebtOwnership** | **string** | Nature debt ownership. Please use /v1/utilities/referenceData/{debtOwnership} resource to get valid value of this field with description. | [optional] 
**LenderName** | **string** | Name of the lender/non-banking financial institution. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

