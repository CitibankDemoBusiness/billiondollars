# LoanSpecificRecommendations

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_amount** | **double** | Eligible Loan amount. | [optional] 
**tenor** | **string** | Tenor for the loan repayment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**interest_rate** | **double** | The rate of interest applicable to product | [optional] 
**handling_fee** | **double** | Handling fee to be paid. | [optional] 
**installment_amount** | **double** | Installment amount to be paid. | [optional] 
**annual_percentage_rate** | **double** | Applicable Annual Percentage Rate | [optional] 
**total_principal_amount** | **double** | Total principal to be paid by customer | [optional] 
**total_interest_amount** | **double** | Total interest to be paid by customer | [optional] 
**total_installment_amount** | **double** | Total installment amount to be paid by customer | [optional] 
**repayment_schedule_issue_date** | [**\DateTime**](\DateTime.md) | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD | [optional] 
**repayment_schedule** | [**\Swagger\Client\Model\RepaymentSchedule[]**](RepaymentSchedule.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

