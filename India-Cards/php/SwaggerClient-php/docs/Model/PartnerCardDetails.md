# PartnerCardDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_id** | **string** | The card id  in encrypted format | 
**display_card_number** | **string** | A masked card number that can be displayed to the customer. | [optional] 
**local_card_activation_indicator** | **string** | The card activation indicator for local usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{localCardActivationIndicator} resource to get valid value of this field with description. | 
**overseas_card_activation_indicator** | **string** | The card activation indicator for overseas usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardActivationIndicator} resource to get valid value of this field with description. | [optional] 
**perpetual_activation_flag** | **bool** | Flag to specify whether the card is activated perpetually, till card expiration | [optional] 
**overseas_card_activation_start_date** | [**\DateTime**](\DateTime.md) | Card activation start date in ISO 8601 date format YYYY-MM-DD for overseas usage. | [optional] 
**overseas_card_activation_end_date** | [**\DateTime**](\DateTime.md) | Card activation end date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, value is card expiry date | [optional] 
**current_credit_limit_amount** | **double** | Current credit limit amount on the credit card | 
**maximum_permanent_credit_limit_amount** | **double** | Maximum permanent credit limit amount allowed on the credit card | [optional] 
**maximum_temporary_credit_limit_amount** | **double** | Maximum temporary credit limit amount allowed on the credit card | [optional] 
**sub_card_type** | **string** | Type of the card. Debit or Credit.This is a reference data field. Please use /v1/apac/utilities/referenceData/{subCardType} resource to get valid value of this field with description. | 
**card_holder_type** | **string** | Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. | [optional] 
**card_issue_reason** | **string** | Specifies the reason for the card issuance. Applicable only for recently issued cards. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardIssueReason} resource to get valid value of this field with description. | [optional] 
**card_functions_allowed** | [**\Swagger\Client\Model\CardFunctionsAllowed[]**](CardFunctionsAllowed.md) |  | [optional] 
**emboss_name** | **string** | Name to be embossed on card.If blank, bank will assign automatically based on the market norms. | [optional] 
**organization** | **string** | Card issuing organization name | [optional] 
**logo** | **string** | Product logo to identify the product | [optional] 
**product_name** | **string** | The name of the product | [optional] 
**primary_card_id** | **string** | The primary card id in encrypted format. Applicable only for supplementary cards. | [optional] 
**display_primary_card_number** | **string** | A masked primary card number that can be displayed to the customer. Applicable only for supplementary cards. | [optional] 
**card_plastic_type** | **string** | Indicates the card plastic type used for embossing.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardPlasticType} resource to get valid value of this field with description. | [optional] 
**current_contactless_wthout_pin_pmt_limit** | **double** | Current transaction limit for the contact less payments without pin set by the customer | [optional] 
**max_contactless_without_pin_pmt_limit** | **double** | Maximum transaction limit for the contact less payments without pin | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

