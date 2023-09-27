# SwaggerClient::ECMIdentificationDocumentDetailsUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id_issue_date** | **String** | Issuance date of identification document in ISO 8601 date format YYYY-MM-DD | [optional] 
**id_issue_place** | **String** | Identification document issuance place | [optional] 
**id_status** | **String** | Identification document issuance status | [optional] 
**id_issue_country** | **String** | Country of issuance. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. | [optional] 
**id_type** | **String** | Type of Identification document. This is a reference  data field. Please use /v1/utilities/referenceData/{idType} resource to get valid values of this field with descriptions | [optional] 
**id_number** | **String** | Unique identifier of identification document. Ex: Passport Number | [optional] 

