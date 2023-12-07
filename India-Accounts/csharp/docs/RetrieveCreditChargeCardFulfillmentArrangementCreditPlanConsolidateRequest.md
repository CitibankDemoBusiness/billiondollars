# IO.Swagger.Model.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OldLoanList** | [**List&lt;Loan&gt;**](Loan.md) |  | [optional] 
**TotalLoanAmount** | **double?** | Total amount borrowed by customer as Loan ie., Old Loan Amount+Top up Amount. | 
**LoanTenureInmonths** | **int?** | Tenure of loan against credit card. It is considered in terms of number of months. | 
**TopUpAmount** | **double?** | Additonal Topup Amount | 
**LoanDescription** | **string** | New Loan Description | [optional] 
**DisbursementOption** | **string** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**DisbursementAccountId** | **string** | The disbursement account identifier in encrypted format. | [optional] 
**PayeeId** | **string** | Payee Indicator to be mapped against Payee Detail Key | [optional] 
**BeneficiaryBankDetail** | [**BeneficiaryBankDetail**](BeneficiaryBankDetail.md) |  | [optional] 
**LoanPurpose** | **string** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

