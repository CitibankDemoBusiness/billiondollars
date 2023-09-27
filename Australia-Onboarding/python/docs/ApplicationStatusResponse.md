# ApplicationStatusResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**application_stage** | **str** | Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values. | 
**ipa_expiry_date** | **date** | In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD | [optional] 
**requested_product_decision** | [**list[ApplicationStatusInqRequestedProductDecision]**](ApplicationStatusInqRequestedProductDecision.md) |  | [optional] 
**counter_offers** | [**list[CounterOffer]**](CounterOffer.md) |  | [optional] 
**cross_sell_offers** | [**list[CrossSellOffer]**](CrossSellOffer.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

