# IO.Swagger.Model.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OldLoanList** | [**List&lt;Loan&gt;**](Loan.md) |  | [optional] 
**TotalLoanAmount** | **double?** | Total amount borrowed by customer as Loan ie., Old Loan Amount+Top up Amount | [optional] 
**LoanTenureInMonths** | **int?** | Tenure of loan against credit card. It is considered in terms of number of months | [optional] 
**TopUpAmount** | **double?** | Additonal Topup Amount | [optional] 
**DisbursementOption** | **string** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | [optional] 
**BeneficiaryDetail** | [**BeneficiaryDetail**](BeneficiaryDetail.md) |  | [optional] 
**PayeeId** | **string** | Payee Indicator to be mapped against Payee Detail Key | [optional] 
**LoanPurpose** | **string** | This field indicates the options/mode in which the loan amount will be disbursed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

