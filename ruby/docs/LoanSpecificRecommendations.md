# SwaggerClient::LoanSpecificRecommendations

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_amount** | **Float** | Eligible Loan amount. | [optional] 
**tenor** | **String** | Tenor for the loan repayment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**interest_rate** | **Float** | The rate of interest applicable to product | [optional] 
**handling_fee** | **Float** | Handling fee to be paid. | [optional] 
**installment_amount** | **Float** | Installment amount to be paid. | [optional] 
**annual_percentage_rate** | **Float** | Applicable Annual Percentage Rate | [optional] 
**total_principal_amount** | **Float** | Total principal to be paid by customer | [optional] 
**total_interest_amount** | **Float** | Total interest to be paid by customer | [optional] 
**total_installment_amount** | **Float** | Total installment amount to be paid by customer | [optional] 
**repayment_schedule_issue_date** | **Date** | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD | [optional] 
**repayment_schedule** | [**Array&lt;RepaymentSchedule&gt;**](RepaymentSchedule.md) |  | [optional] 

