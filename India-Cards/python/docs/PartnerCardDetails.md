# PartnerCardDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_id** | **str** | The card id  in encrypted format | 
**display_card_number** | **str** | A masked card number that can be displayed to the customer. | [optional] 
**local_card_activation_indicator** | **str** | The card activation indicator for local usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{localCardActivationIndicator} resource to get valid value of this field with description. | 
**overseas_card_activation_indicator** | **str** | The card activation indicator for overseas usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardActivationIndicator} resource to get valid value of this field with description. | [optional] 
**perpetual_activation_flag** | **bool** | Flag to specify whether the card is activated perpetually, till card expiration | [optional] 
**overseas_card_activation_start_date** | **date** | Card activation start date in ISO 8601 date format YYYY-MM-DD for overseas usage. | [optional] 
**overseas_card_activation_end_date** | **date** | Card activation end date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, value is card expiry date | [optional] 
**current_credit_limit_amount** | **float** | Current credit limit amount on the credit card | 
**maximum_permanent_credit_limit_amount** | **float** | Maximum permanent credit limit amount allowed on the credit card | [optional] 
**maximum_temporary_credit_limit_amount** | **float** | Maximum temporary credit limit amount allowed on the credit card | [optional] 
**sub_card_type** | **str** | Type of the card. Debit or Credit.This is a reference data field. Please use /v1/apac/utilities/referenceData/{subCardType} resource to get valid value of this field with description. | 
**card_holder_type** | **str** | Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. | [optional] 
**card_issue_reason** | **str** | Specifies the reason for the card issuance. Applicable only for recently issued cards. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardIssueReason} resource to get valid value of this field with description. | [optional] 
**card_functions_allowed** | [**list[CardFunctionsAllowed]**](CardFunctionsAllowed.md) |  | [optional] 
**emboss_name** | **str** | Name to be embossed on card.If blank, bank will assign automatically based on the market norms. | [optional] 
**organization** | **str** | Card issuing organization name | [optional] 
**logo** | **str** | Product logo to identify the product | [optional] 
**product_name** | **str** | The name of the product | [optional] 
**primary_card_id** | **str** | The primary card id in encrypted format. Applicable only for supplementary cards. | [optional] 
**display_primary_card_number** | **str** | A masked primary card number that can be displayed to the customer. Applicable only for supplementary cards. | [optional] 
**card_plastic_type** | **str** | Indicates the card plastic type used for embossing.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardPlasticType} resource to get valid value of this field with description. | [optional] 
**current_contactless_wthout_pin_pmt_limit** | **float** | Current transaction limit for the contact less payments without pin set by the customer | [optional] 
**max_contactless_without_pin_pmt_limit** | **float** | Maximum transaction limit for the contact less payments without pin | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

