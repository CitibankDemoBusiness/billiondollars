# IO.Swagger.Model.ApplicationStatusInqRequestedProductDecision
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**OrganisationName** | **string** | Card issuing Organisation | [optional] 
**SourceCode** | **string** | A source code to identify the product | [optional] 
**CreditDecision** | **string** | Evaluated Applicant Credit Decision. This is a reference data field. Please use /v1/apac/utilities/referenceData/{creditDecision} resource to get valid value of this field with description. | [optional] 
**CreditSpecificRecommendations** | [**List&lt;CreditSpecificRecommendations&gt;**](CreditSpecificRecommendations.md) |  | [optional] 
**LoanSpecificRecommendations** | [**List&lt;LoanSpecificRecommendations&gt;**](LoanSpecificRecommendations.md) |  | [optional] 
**RequiredDocuments** | [**List&lt;RequiredDocuments&gt;**](RequiredDocuments.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

