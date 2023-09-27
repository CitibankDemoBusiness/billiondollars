# ApplicationInquiryResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**application_stage** | **str** | Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values. | 
**has_any_supplementary_flag** | **bool** | Flag indicating whether the primary applicant has any supplementary. | [optional] 
**ipa_expiry_date** | **date** | In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD | [optional] 
**product** | [**ApplicationInquiryProduct**](ApplicationInquiryProduct.md) |  | 
**applicant** | [**ApplicationInquiryApplicant**](ApplicationInquiryApplicant.md) |  | 
**requested_product_decision** | [**list[ApplicationInquiryRequestedProductDecision]**](ApplicationInquiryRequestedProductDecision.md) |  | [optional] 
**counter_offers** | [**list[ApplicationInquiryCounterOffer]**](ApplicationInquiryCounterOffer.md) |  | [optional] 
**cross_sell_offers** | [**list[ApplicationInquiryCrossSellOffer]**](ApplicationInquiryCrossSellOffer.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

