# LoanSpecificRecommendations

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_amount** | **float** | Eligible Loan amount. | [optional] 
**tenor** | **str** | Tenor for the loan repayment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**interest_rate** | **float** | The rate of interest applicable to product | [optional] 
**handling_fee** | **float** | Handling fee to be paid. | [optional] 
**installment_amount** | **float** | Installment amount to be paid. | [optional] 
**annual_percentage_rate** | **float** | Applicable Annual Percentage Rate | [optional] 
**total_principal_amount** | **float** | Total principal to be paid by customer | [optional] 
**total_interest_amount** | **float** | Total interest to be paid by customer | [optional] 
**total_installment_amount** | **float** | Total installment amount to be paid by customer | [optional] 
**repayment_schedule_issue_date** | **date** | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD | [optional] 
**repayment_schedule** | [**list[RepaymentSchedule]**](RepaymentSchedule.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

