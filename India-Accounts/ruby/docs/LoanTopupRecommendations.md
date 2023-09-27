# SwaggerClient::LoanTopupRecommendations

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | **String** | Tenor for the loan repayment.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. | [optional] 
**loan_topup_minium_amount** | **Float** | Recommended loan top-up Minim amount | [optional] 
**loan_topup_maxium_amount** | **Float** | Recommended loan Topup Maxium amount | [optional] 
**annual_percentage_rate** | **Float** | annualPercentageRate -APR | [optional] 
**loan_amount** | **Float** | Recommended loan amount. | [optional] 
**interest_rate** | **Float** | The rate of interest applicable for the product | [optional] 
**handling_fee** | **Float** | One-time processing fee. | [optional] 
**installment_amount** | **Float** | Instalment amount to be paid. | [optional] 
**total_principal_amount** | **Float** | Total principal to be paid by customer | [optional] 
**total_interest_amount** | **Float** | Total interest amount to be paid by applicant. | [optional] 
**total_installment_amount** | **Float** | Total instalment amount to be paid by customer | [optional] 
**repayment_schedule_issue_date** | **Date** | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD | [optional] 

