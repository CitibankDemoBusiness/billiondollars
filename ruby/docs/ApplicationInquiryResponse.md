# SwaggerClient::ApplicationInquiryResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**application_stage** | **String** | Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values. | 
**has_any_supplementary_flag** | **BOOLEAN** | Flag indicating whether the primary applicant has any supplementary. | [optional] 
**ipa_expiry_date** | **Date** | In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD | [optional] 
**product** | [**ApplicationInquiryProduct**](ApplicationInquiryProduct.md) |  | 
**applicant** | [**ApplicationInquiryApplicant**](ApplicationInquiryApplicant.md) |  | 
**requested_product_decision** | [**Array&lt;ApplicationInquiryRequestedProductDecision&gt;**](ApplicationInquiryRequestedProductDecision.md) |  | [optional] 
**counter_offers** | [**Array&lt;ApplicationInquiryCounterOffer&gt;**](ApplicationInquiryCounterOffer.md) |  | [optional] 
**cross_sell_offers** | [**Array&lt;ApplicationInquiryCrossSellOffer&gt;**](ApplicationInquiryCrossSellOffer.md) |  | [optional] 

