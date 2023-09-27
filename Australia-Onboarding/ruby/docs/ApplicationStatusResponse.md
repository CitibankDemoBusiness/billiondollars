# SwaggerClient::ApplicationStatusResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**application_stage** | **String** | Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values. | 
**ipa_expiry_date** | **Date** | In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD | [optional] 
**requested_product_decision** | [**Array&lt;ApplicationStatusInqRequestedProductDecision&gt;**](ApplicationStatusInqRequestedProductDecision.md) |  | [optional] 
**counter_offers** | [**Array&lt;CounterOffer&gt;**](CounterOffer.md) |  | [optional] 
**cross_sell_offers** | [**Array&lt;CrossSellOffer&gt;**](CrossSellOffer.md) |  | [optional] 

