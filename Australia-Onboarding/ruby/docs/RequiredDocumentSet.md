# SwaggerClient::RequiredDocumentSet

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**document_set** | **String** | Document set a mandated combination of document types for each proof. This is a reference data field. Please use /v1/utilities/referenceData/{documentIdType} resource to get valid values of this field with descriptions. | [optional] 
**product_code** | **String** | A unique code that identifies the product | [optional] 
**proof_type** | **String** | Type of document. This is a reference data field. Please use /v1/utilities/referenceData/{proofType} resource to get possible values of this field with descriptions. | [optional] 
**applicant_type** | **String** | Applicant relationship with the Bank. Currently supported value is primary.This is a reference data data field. Please use /v1/utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions | [optional] 

