# SwaggerClient::ExistingLoanDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_type** | **String** | Loan Type.This is a reference data field. Please use /v1/utilities/referenceData/{loanType} resource to get valid value of this field with description. | [optional] 
**other_debt_obligation_type** | **String** | Other debt obligation type. Free text if others is selected under loan type. | [optional] 
**monthly_installment_amount** | **Float** | Monthly repayment amount | [optional] 
**outstanding_balance_amount** | **Float** | Balance Owing | [optional] 
**debt_ownership** | **String** | Nature debt ownership. Please use /v1/utilities/referenceData/{debtOwnership} resource to get valid value of this field with description. | [optional] 
**lender_name** | **String** | Name of the lender/non-banking financial institution. | [optional] 

