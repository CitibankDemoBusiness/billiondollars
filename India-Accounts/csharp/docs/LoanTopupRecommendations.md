# IO.Swagger.Model.LoanTopupRecommendations
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenor** | **string** | Tenor for the loan repayment.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. | [optional] 
**LoanTopupMiniumAmount** | **double?** | Recommended loan top-up Minim amount | [optional] 
**LoanTopupMaxiumAmount** | **double?** | Recommended loan Topup Maxium amount | [optional] 
**AnnualPercentageRate** | **double?** | annualPercentageRate -APR | [optional] 
**LoanAmount** | **double?** | Recommended loan amount. | [optional] 
**InterestRate** | **double?** | The rate of interest applicable for the product | [optional] 
**HandlingFee** | **double?** | One-time processing fee. | [optional] 
**InstallmentAmount** | **double?** | Instalment amount to be paid. | [optional] 
**TotalPrincipalAmount** | **double?** | Total principal to be paid by customer | [optional] 
**TotalInterestAmount** | **double?** | Total interest amount to be paid by applicant. | [optional] 
**TotalInstallmentAmount** | **double?** | Total instalment amount to be paid by customer | [optional] 
**RepaymentScheduleIssueDate** | **DateTime?** | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

