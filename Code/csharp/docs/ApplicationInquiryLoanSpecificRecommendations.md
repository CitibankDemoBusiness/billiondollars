# IO.Swagger.Model.ApplicationInquiryLoanSpecificRecommendations
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanAmount** | **double?** | Recommended loan amount. | [optional] 
**Tenor** | **string** | Tenor for the loan repayment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. | [optional] 
**InterestRate** | **double?** | The rate of interest applicable for the product | [optional] 
**HandlingFee** | **double?** | One-time processing fee. | [optional] 
**InstallmentAmount** | **double?** | Instalment amount to be paid. | [optional] 
**AnnualPercentageRate** | **double?** | Applicable Annual Percentage Rate | [optional] 
**TotalPrincipalAmount** | **double?** | Total principal to be paid by customer | [optional] 
**TotalInterestAmount** | **double?** | Total interest amount to be paid by applicant. | [optional] 
**TotalInstallmentAmount** | **double?** | Total instalment amount to be paid by customer | [optional] 
**RepaymentScheduleIssueDate** | **DateTime?** | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD | [optional] 
**RepaymentSchedule** | [**List&lt;ApplicationInquiryRepaymentSchedule&gt;**](ApplicationInquiryRepaymentSchedule.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

