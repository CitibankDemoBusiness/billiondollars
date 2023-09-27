# SwaggerClient::IdentificationDocumentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id_type** | **String** | Type of Identification document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idType} resource to get valid values of this field with descriptions | [optional] 
**id_number** | **String** | Unique identifier of identification document. Ex: Passport Number | [optional] 
**id_expiry_date** | **Date** | Expiry date of identification document. Format: ISO 8601 date format YYYY-MM-DD | [optional] 
**id_issue_date** | **Date** | Issuance date of identification document. Format: ISO 8601 date format YYYY-MM-DD | [optional] 
**id_issue_place** | **String** | Place of issuance | [optional] 
**id_issuing_authority** | **String** | Authority which issued the identification document | [optional] 

