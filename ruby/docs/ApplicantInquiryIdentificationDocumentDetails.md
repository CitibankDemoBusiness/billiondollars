# SwaggerClient::ApplicantInquiryIdentificationDocumentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id_type** | **String** | Type of Identification document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idType} resource to get valid values of this field with descriptions | [optional] 
**id_number** | **String** | Unique identifier of identification document. | [optional] 
**id_expiry_date** | **Date** | Expiry date of identification document in ISO 8601 date format YYYY-MM-DD | [optional] 
**id_issue_date** | **Date** | Issuance date of identification document in ISO 8601 date format YYYY-MM-DD | [optional] 
**id_issue_place** | **String** | Identification document issuance place | [optional] 
**id_issue_state** | **String** | State from which identification document was issued | [optional] 
**id_issue_country** | **String** | Country of issuance. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use idIssueCountry field name as the referenceCode parameter to retrieve the values. | [optional] 
**is_primary_id** | **BOOLEAN** | Flag to mark primary identification document. Valid values: true and false | [optional] 

