# SwaggerClient::CardDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_id** | **String** | The card id  in encrypted format | 
**display_card_number** | **String** | A masked card number that can be displayed to the customer. | [optional] 
**local_card_activation_indicator** | **String** | The card activation indicator for local usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{localCardActivationIndicator} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 
**overseas_card_activation_indicator** | **String** | The card activation indicator for overseas usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardActivationIndicator} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**perpetual_activation_flag** | **BOOLEAN** | Flag to specify whether the card is activated perpetually, till card expiration | [optional] 
**overseas_card_activation_start_date** | **Date** | Card activation start date in ISO 8601 date format YYYY-MM-DD for overseas usage. | [optional] 
**overseas_card_activation_end_date** | **Date** | Card activation end date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, value is card expiry date | [optional] 
**current_credit_limit_amount** | **Float** | Current credit limit amount on the credit card | 
**maximum_permanent_credit_limit_amount** | **Float** | Maximum permanent credit limit amount allowed on the credit card | [optional] 
**maximum_temporary_credit_limit_amount** | **Float** | Maximum temporary credit limit amount allowed on the credit card | [optional] 
**sub_card_type** | **String** | Type of the card. Debit or Credit.This is a reference data field. Please use /v1/apac/utilities/referenceData/{subCardType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 
**card_holder_type** | **String** | Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. | [optional] 
**card_issue_reason** | **String** | Specifies the reason for the card issuance. Applicable only for recently issued cards. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardIssueReason} resource to get valid value of this field with description. | [optional] 
**card_functions_allowed** | [**Array&lt;CardFunctionsAllowed&gt;**](CardFunctionsAllowed.md) |  | [optional] 

