# ApplicationStatusInqRequestedProductDecision

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **string** | A unique code that identifies the product | [optional] 
**organisation_name** | **string** | Card issuing Organisation | [optional] 
**source_code** | **string** | A source code to identify the product | [optional] 
**credit_decision** | **string** | Evaluated Applicant Credit Decision. This is a reference data field. Please use /v1/apac/utilities/referenceData/{creditDecision} resource to get valid value of this field with description. | [optional] 
**credit_specific_recommendations** | [**\Swagger\Client\Model\CreditSpecificRecommendations[]**](CreditSpecificRecommendations.md) |  | [optional] 
**loan_specific_recommendations** | [**\Swagger\Client\Model\LoanSpecificRecommendations[]**](LoanSpecificRecommendations.md) |  | [optional] 
**required_documents** | [**\Swagger\Client\Model\RequiredDocuments[]**](RequiredDocuments.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

