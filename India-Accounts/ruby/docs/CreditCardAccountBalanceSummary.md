# SwaggerClient::CreditCardAccountBalanceSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**total_disputed_transaction_amount** | **Float** | This is the total disputed transaction amount. | [optional] 
**current_outstanding_amount** | **Float** | This includes the current intra-day transactions which yet to be posted on card. | 
**current_accrued_interest** | **Float** | Interest which has been accrued till last accrual date. | 
**payment_due_amount** | **Float** | Total amount customer needs to pay in order to clear the balance. | 
**available_point_balance** | **Float** | Available reward points on the credit card | [optional] 
**partial_response_information** | [**Array&lt;PartialResponseInformation&gt;**](PartialResponseInformation.md) | Partial success response | [optional] 

