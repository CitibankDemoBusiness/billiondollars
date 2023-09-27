# ApplicationStatusInqRequestedProductDecision

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productCode** | **String** | A unique code that identifies the product |  [optional]
**organisationName** | **String** | Card issuing Organisation |  [optional]
**sourceCode** | **String** | A source code to identify the product |  [optional]
**creditDecision** | **String** | Evaluated Applicant Credit Decision. This is a reference data field. Please use /v1/apac/utilities/referenceData/{creditDecision} resource to get valid value of this field with description. |  [optional]
**creditSpecificRecommendations** | [**List&lt;CreditSpecificRecommendations&gt;**](CreditSpecificRecommendations.md) |  |  [optional]
**loanSpecificRecommendations** | [**List&lt;LoanSpecificRecommendations&gt;**](LoanSpecificRecommendations.md) |  |  [optional]
**requiredDocuments** | [**List&lt;RequiredDocuments&gt;**](RequiredDocuments.md) |  |  [optional]
