# ApplicationAddExistingLoanDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_type** | **string** | Loan Type.This is a reference data field. Please use /v1/apac/utilities/referenceData/{loanType} resource to get valid value of this field with description. You can use loanType field name as the referenceCode parameter to retrieve the values. | [optional] 
**other_debt_obligation_type** | **string** | Other debt obligation type. Free text if others is selected under loan type. Please use /v1/apac/utilities/referenceData/{otherDebtObligationType} resource to get valid value of this field with description. You can use loanType field name as the referenceCode parameter to retrieve the values. | [optional] 
**monthly_installment_amount** | **double** | Monthly repayment amount | [optional] 
**outstanding_balance_amount** | **double** | Balance Owing | [optional] 
**debt_ownership** | **string** | Nature debt ownership. Please use /v1/apac/utilities/referenceData/{debtOwnership} resource to get valid value of this field with description. | [optional] 
**lender_name** | **string** | Name of the lender/non-banking financial institution. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

