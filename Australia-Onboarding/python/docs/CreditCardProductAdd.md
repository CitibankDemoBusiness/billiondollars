# CreditCardProductAdd

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **str** | A unique code that identifies the product. | [optional] 
**source_code** | **str** | A source code to identify the product | 
**organization** | **str** | Card issuing organization name | 
**logo** | **str** | Product logo to identify the product | 
**request_credit_shield** | **bool** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**requested_credit_limit** | **float** | Credit limit requested by applicant for the product. | [optional] 
**emboss_name** | **str** | Name to be embossed on card.If blank, bank will assign automatically based on the market norms. | [optional] 
**billing_address** | **str** | Billing address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**card_delivery_address** | **str** | Card delivery address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**pin_delivery_address** | **str** | Delivery address  for card pin of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**card_delivery_branch** | **str** | Pick-up branch detail of the Citi bank for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryBranch} resource to get valid value of this field. | [optional] 
**card_delivery_option** | **str** | Pick-up option for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryOption} resource to get valid value of this field. | [optional] 
**gift_code** | **str** | A  unique code that identifies the gift offered along with the product | [optional] 
**credit_limit_increase_indicator** | **bool** | Option  to review the credit limit in the future.Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

