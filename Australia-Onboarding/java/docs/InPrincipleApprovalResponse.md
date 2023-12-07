# InPrincipleApprovalResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicationStage** | **String** | Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values. | 
**ipaExpiryDate** | [**LocalDate**](LocalDate.md) | In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD |  [optional]
**requestedProductDecision** | [**List&lt;RequestedProductDecision&gt;**](RequestedProductDecision.md) |  |  [optional]
**counterOffers** | [**List&lt;CounterOffer&gt;**](CounterOffer.md) |  |  [optional]
**crossSellOffers** | [**List&lt;CrossSellOffer&gt;**](CrossSellOffer.md) |  |  [optional]
