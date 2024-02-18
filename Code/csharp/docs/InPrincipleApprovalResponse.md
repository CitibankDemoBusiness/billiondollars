# IO.Swagger.Model.InPrincipleApprovalResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationStage** | **string** | Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values. | 
**IpaExpiryDate** | **DateTime?** | In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD | [optional] 
**RequestedProductDecision** | [**List&lt;RequestedProductDecision&gt;**](RequestedProductDecision.md) |  | [optional] 
**CounterOffers** | [**List&lt;CounterOffer&gt;**](CounterOffer.md) |  | [optional] 
**CrossSellOffers** | [**List&lt;CrossSellOffer&gt;**](CrossSellOffer.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

