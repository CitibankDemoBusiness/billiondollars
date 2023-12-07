# CreditCardStatementSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_id** | **str** | The card id  in encrypted format | 
**display_account_number** | **str** | A masked account number that can be displayed to the customer | 
**eligible_source_accts_for_payment_flag** | **bool** | ’Flag to indicate if eligible source accounts are available to make credit card payment on-line. | [optional] 
**epp_eligible_amount** | **float** | Eligible amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. | [optional] 
**epp_minimum_eligible_amount** | **float** | Minimum eligible amount for which Equal Payment Plan can be booked. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. | [optional] 
**epp_minimum_installment_amount** | **float** | Minimum instalment amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. | [optional] 
**credit_card_statement** | [**list[CreditCardStatement]**](CreditCardStatement.md) |  | [optional] 
**statement_summary_error_details** | [**ErrorResponse**](ErrorResponse.md) |  | [optional] 
**next_start_index** | **str** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

