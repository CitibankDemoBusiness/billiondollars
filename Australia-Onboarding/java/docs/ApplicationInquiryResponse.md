# ApplicationInquiryResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicationStage** | **String** | Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values. | 
**hasAnySupplementaryFlag** | **Boolean** | Flag indicating whether the primary applicant has any supplementary. |  [optional]
**ipaExpiryDate** | [**LocalDate**](LocalDate.md) | In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD |  [optional]
**product** | [**ApplicationInquiryProduct**](ApplicationInquiryProduct.md) |  | 
**applicant** | [**ApplicationInquiryApplicant**](ApplicationInquiryApplicant.md) |  | 
**requestedProductDecision** | [**List&lt;ApplicationInquiryRequestedProductDecision&gt;**](ApplicationInquiryRequestedProductDecision.md) |  |  [optional]
**counterOffers** | [**List&lt;ApplicationInquiryCounterOffer&gt;**](ApplicationInquiryCounterOffer.md) |  |  [optional]
**crossSellOffers** | [**List&lt;ApplicationInquiryCrossSellOffer&gt;**](ApplicationInquiryCrossSellOffer.md) |  |  [optional]
