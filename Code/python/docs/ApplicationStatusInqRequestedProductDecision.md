# ApplicationStatusInqRequestedProductDecision

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **str** | A unique code that identifies the product | [optional] 
**organisation_name** | **str** | Card issuing Organisation | [optional] 
**source_code** | **str** | A source code to identify the product | [optional] 
**credit_decision** | **str** | Evaluated Applicant Credit Decision. This is a reference data field. Please use /v1/apac/utilities/referenceData/{creditDecision} resource to get valid value of this field with description. | [optional] 
**credit_specific_recommendations** | [**list[CreditSpecificRecommendations]**](CreditSpecificRecommendations.md) |  | [optional] 
**loan_specific_recommendations** | [**list[LoanSpecificRecommendations]**](LoanSpecificRecommendations.md) |  | [optional] 
**required_documents** | [**list[RequiredDocuments]**](RequiredDocuments.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

