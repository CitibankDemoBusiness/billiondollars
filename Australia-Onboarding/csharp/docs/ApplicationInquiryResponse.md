# IO.Swagger.Model.ApplicationInquiryResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationStage** | **string** | Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values. | 
**HasAnySupplementaryFlag** | **bool?** | Flag indicating whether the primary applicant has any supplementary. | [optional] 
**IpaExpiryDate** | **DateTime?** | In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD | [optional] 
**Product** | [**ApplicationInquiryProduct**](ApplicationInquiryProduct.md) |  | 
**Applicant** | [**ApplicationInquiryApplicant**](ApplicationInquiryApplicant.md) |  | 
**RequestedProductDecision** | [**List&lt;ApplicationInquiryRequestedProductDecision&gt;**](ApplicationInquiryRequestedProductDecision.md) |  | [optional] 
**CounterOffers** | [**List&lt;ApplicationInquiryCounterOffer&gt;**](ApplicationInquiryCounterOffer.md) |  | [optional] 
**CrossSellOffers** | [**List&lt;ApplicationInquiryCrossSellOffer&gt;**](ApplicationInquiryCrossSellOffer.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

