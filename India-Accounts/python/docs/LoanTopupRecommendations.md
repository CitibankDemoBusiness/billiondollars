# LoanTopupRecommendations

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | **str** | Tenor for the loan repayment.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. | [optional] 
**loan_topup_minium_amount** | **float** | Recommended loan top-up Minim amount | [optional] 
**loan_topup_maxium_amount** | **float** | Recommended loan Topup Maxium amount | [optional] 
**annual_percentage_rate** | **float** | annualPercentageRate -APR | [optional] 
**loan_amount** | **float** | Recommended loan amount. | [optional] 
**interest_rate** | **float** | The rate of interest applicable for the product | [optional] 
**handling_fee** | **float** | One-time processing fee. | [optional] 
**installment_amount** | **float** | Instalment amount to be paid. | [optional] 
**total_principal_amount** | **float** | Total principal to be paid by customer | [optional] 
**total_interest_amount** | **float** | Total interest amount to be paid by applicant. | [optional] 
**total_installment_amount** | **float** | Total instalment amount to be paid by customer | [optional] 
**repayment_schedule_issue_date** | **date** | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

