# SwaggerClient::FinancialInformationAdd

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**has_foreseeable_financial_changes** | **BOOLEAN** | Indicates whether any foreseeable changes in customer&#x27;s financial circumstances. | [optional] 
**non_bank_debt_obligation_flag** | **BOOLEAN** | Indicates if the applicant has any loan with any non-banking financial organization. | [optional] 
**expense_details** | [**Array&lt;ExpenseDetails&gt;**](ExpenseDetails.md) |  | [optional] 
**income_details** | [**Array&lt;IncomeDetails&gt;**](IncomeDetails.md) |  | [optional] 
**existing_loan_details** | [**Array&lt;ExistingLoanDetails&gt;**](ExistingLoanDetails.md) |  | [optional] 
**external_credit_card_details** | [**Array&lt;ExternalCreditCardDetailsAdd&gt;**](ExternalCreditCardDetailsAdd.md) |  | [optional] 
**self_employed_business_asset_value** | **String** | This field is used to capture the total assets of  the self employed business. This is applicable only for Self Employed Business/ Professionals. This is a reference data field. Please use /v1/utilities/referenceData/{selfEmployedBusinessAssetValue} resource to get valid value of this field with description. | [optional] 

