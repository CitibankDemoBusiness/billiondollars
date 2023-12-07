# ApplicationInquiryLoanSpecificRecommendations

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_amount** | **double** | Recommended loan amount. | [optional] 
**tenor** | **string** | Tenor for the loan repayment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. | [optional] 
**interest_rate** | **double** | The rate of interest applicable for the product | [optional] 
**handling_fee** | **double** | One-time processing fee. | [optional] 
**installment_amount** | **double** | Instalment amount to be paid. | [optional] 
**annual_percentage_rate** | **double** | Applicable Annual Percentage Rate | [optional] 
**total_principal_amount** | **double** | Total principal to be paid by customer | [optional] 
**total_interest_amount** | **double** | Total interest amount to be paid by applicant. | [optional] 
**total_installment_amount** | **double** | Total instalment amount to be paid by customer | [optional] 
**repayment_schedule_issue_date** | [**\DateTime**](\DateTime.md) | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD | [optional] 
**repayment_schedule** | [**\Swagger\Client\Model\ApplicationInquiryRepaymentSchedule[]**](ApplicationInquiryRepaymentSchedule.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

