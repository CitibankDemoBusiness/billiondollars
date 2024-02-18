# FinancialInformationAdd

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**has_foreseeable_financial_changes** | **bool** | Indicates whether any foreseeable changes in customer&#x27;s financial circumstances. | [optional] 
**non_bank_debt_obligation_flag** | **bool** | Indicates if the applicant has any loan with any non-banking financial organization. | [optional] 
**expense_details** | [**list[ExpenseDetails]**](ExpenseDetails.md) |  | [optional] 
**income_details** | [**list[IncomeDetails]**](IncomeDetails.md) |  | [optional] 
**existing_loan_details** | [**list[ExistingLoanDetails]**](ExistingLoanDetails.md) |  | [optional] 
**external_credit_card_details** | [**list[ExternalCreditCardDetailsAdd]**](ExternalCreditCardDetailsAdd.md) |  | [optional] 
**self_employed_business_asset_value** | **str** | This field is used to capture the total assets of  the self employed business. This is applicable only for Self Employed Business/ Professionals. This is a reference data field. Please use /v1/utilities/referenceData/{selfEmployedBusinessAssetValue} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

