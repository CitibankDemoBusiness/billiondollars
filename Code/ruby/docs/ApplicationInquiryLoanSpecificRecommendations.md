# SwaggerClient::ApplicationInquiryLoanSpecificRecommendations

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_amount** | **Float** | Recommended loan amount. | [optional] 
**tenor** | **String** | Tenor for the loan repayment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. | [optional] 
**interest_rate** | **Float** | The rate of interest applicable for the product | [optional] 
**handling_fee** | **Float** | One-time processing fee. | [optional] 
**installment_amount** | **Float** | Instalment amount to be paid. | [optional] 
**annual_percentage_rate** | **Float** | Applicable Annual Percentage Rate | [optional] 
**total_principal_amount** | **Float** | Total principal to be paid by customer | [optional] 
**total_interest_amount** | **Float** | Total interest amount to be paid by applicant. | [optional] 
**total_installment_amount** | **Float** | Total instalment amount to be paid by customer | [optional] 
**repayment_schedule_issue_date** | **Date** | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD | [optional] 
**repayment_schedule** | [**Array&lt;ApplicationInquiryRepaymentSchedule&gt;**](ApplicationInquiryRepaymentSchedule.md) |  | [optional] 

