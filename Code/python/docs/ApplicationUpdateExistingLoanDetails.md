# ApplicationUpdateExistingLoanDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_type** | **str** | Loan Type.This is a reference data field. Please use /v1/apac/utilities/referenceData/{loanType} resource to get valid value of this field with description. You can use loanType field name as the referenceCode parameter to retrieve the values. | [optional] 
**other_debt_obligation_type** | **str** | Other debt obligation type. | [optional] 
**monthly_installment_amount** | **float** | Monthly repayment amount | [optional] 
**outstanding_balance_amount** | **float** | Balance Owing | [optional] 
**debt_ownership** | **str** | Nature debt ownership. Please use /v1/apac/utilities/referenceData/{debtOwnership} resource to get valid value of this field with description. | [optional] 
**lender_name** | **str** | Name of the lender/non-banking financial institution. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

