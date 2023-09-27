# FinancialInformationAdd

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**hasForeseeableFinancialChanges** | **Boolean** | Indicates whether any foreseeable changes in customer&#x27;s financial circumstances. |  [optional]
**nonBankDebtObligationFlag** | **Boolean** | Indicates if the applicant has any loan with any non-banking financial organization. |  [optional]
**expenseDetails** | [**List&lt;ExpenseDetails&gt;**](ExpenseDetails.md) |  |  [optional]
**incomeDetails** | [**List&lt;IncomeDetails&gt;**](IncomeDetails.md) |  |  [optional]
**existingLoanDetails** | [**List&lt;ExistingLoanDetails&gt;**](ExistingLoanDetails.md) |  |  [optional]
**externalCreditCardDetails** | [**List&lt;ExternalCreditCardDetailsAdd&gt;**](ExternalCreditCardDetailsAdd.md) |  |  [optional]
**selfEmployedBusinessAssetValue** | **String** | This field is used to capture the total assets of  the self employed business. This is applicable only for Self Employed Business/ Professionals. This is a reference data field. Please use /v1/utilities/referenceData/{selfEmployedBusinessAssetValue} resource to get valid value of this field with description. |  [optional]
