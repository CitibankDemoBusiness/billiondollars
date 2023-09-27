# IO.Swagger.Model.FinancialInformationAdd
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HasForeseeableFinancialChanges** | **bool?** | Indicates whether any foreseeable changes in customer&#x27;s financial circumstances. | [optional] 
**NonBankDebtObligationFlag** | **bool?** | Indicates if the applicant has any loan with any non-banking financial organization. | [optional] 
**ExpenseDetails** | [**List&lt;ExpenseDetails&gt;**](ExpenseDetails.md) |  | [optional] 
**IncomeDetails** | [**List&lt;IncomeDetails&gt;**](IncomeDetails.md) |  | [optional] 
**ExistingLoanDetails** | [**List&lt;ExistingLoanDetails&gt;**](ExistingLoanDetails.md) |  | [optional] 
**ExternalCreditCardDetails** | [**List&lt;ExternalCreditCardDetailsAdd&gt;**](ExternalCreditCardDetailsAdd.md) |  | [optional] 
**SelfEmployedBusinessAssetValue** | **string** | This field is used to capture the total assets of  the self employed business. This is applicable only for Self Employed Business/ Professionals. This is a reference data field. Please use /v1/utilities/referenceData/{selfEmployedBusinessAssetValue} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

