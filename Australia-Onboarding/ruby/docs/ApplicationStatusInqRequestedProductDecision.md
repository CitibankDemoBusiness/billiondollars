# SwaggerClient::ApplicationStatusInqRequestedProductDecision

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **String** | A unique code that identifies the product | [optional] 
**organisation_name** | **String** | Card issuing Organisation | [optional] 
**source_code** | **String** | A source code to identify the product | [optional] 
**credit_decision** | **String** | Evaluated Applicant Credit Decision. This is a reference data field. Please use /v1/apac/utilities/referenceData/{creditDecision} resource to get valid value of this field with description. | [optional] 
**credit_specific_recommendations** | [**Array&lt;CreditSpecificRecommendations&gt;**](CreditSpecificRecommendations.md) |  | [optional] 
**loan_specific_recommendations** | [**Array&lt;LoanSpecificRecommendations&gt;**](LoanSpecificRecommendations.md) |  | [optional] 
**required_documents** | [**Array&lt;RequiredDocuments&gt;**](RequiredDocuments.md) |  | [optional] 

