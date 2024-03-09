# SwaggerClient::ApplicationInquiryRequestedProductDecision

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **String** | A unique code that identifies the product | 
**organisation_name** | **String** | Card issuing Organisation code | 
**source_code** | **String** | A source code to identify the product | 
**logo** | **String** | Product logo to identify the product | [optional] 
**credit_decision** | **String** | Evaluated Applicant Credit Decision | [optional] 
**credit_specific_recommendations** | [**Array&lt;ApplicationInquiryCreditSpecificRecommendations&gt;**](ApplicationInquiryCreditSpecificRecommendations.md) |  | [optional] 
**loan_specific_recommendations** | [**Array&lt;ApplicationInquiryLoanSpecificRecommendations&gt;**](ApplicationInquiryLoanSpecificRecommendations.md) |  | [optional] 
**required_documents** | [**Array&lt;ApplicationInquiryRequiredDocuments&gt;**](ApplicationInquiryRequiredDocuments.md) |  | [optional] 

