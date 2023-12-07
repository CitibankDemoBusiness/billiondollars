# IO.Swagger.Model.LoanSpecificRecommendations
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanAmount** | **double?** | Eligible Loan amount. | [optional] 
**Tenor** | **string** | Tenor for the loan repayment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**InterestRate** | **double?** | The rate of interest applicable to product | [optional] 
**HandlingFee** | **double?** | Handling fee to be paid. | [optional] 
**InstallmentAmount** | **double?** | Installment amount to be paid. | [optional] 
**AnnualPercentageRate** | **double?** | Applicable Annual Percentage Rate | [optional] 
**TotalPrincipalAmount** | **double?** | Total principal to be paid by customer | [optional] 
**TotalInterestAmount** | **double?** | Total interest to be paid by customer | [optional] 
**TotalInstallmentAmount** | **double?** | Total installment amount to be paid by customer | [optional] 
**RepaymentScheduleIssueDate** | **DateTime?** | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD | [optional] 
**RepaymentSchedule** | [**List&lt;RepaymentSchedule&gt;**](RepaymentSchedule.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

