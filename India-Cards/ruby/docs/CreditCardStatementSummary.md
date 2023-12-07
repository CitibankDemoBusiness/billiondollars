# SwaggerClient::CreditCardStatementSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_id** | **String** | The card id  in encrypted format | 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | 
**eligible_source_accts_for_payment_flag** | **BOOLEAN** | ’Flag to indicate if eligible source accounts are available to make credit card payment on-line. | [optional] 
**epp_eligible_amount** | **Float** | Eligible amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. | [optional] 
**epp_minimum_eligible_amount** | **Float** | Minimum eligible amount for which Equal Payment Plan can be booked. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. | [optional] 
**epp_minimum_installment_amount** | **Float** | Minimum instalment amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. | [optional] 
**credit_card_statement** | [**Array&lt;CreditCardStatement&gt;**](CreditCardStatement.md) |  | [optional] 
**statement_summary_error_details** | [**ErrorResponse**](ErrorResponse.md) |  | [optional] 
**next_start_index** | **String** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

