# IdentificationDocumentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id_type** | **string** | Type of Identification document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idType} resource to get valid values of this field with descriptions | [optional] 
**id_number** | **string** | Unique identifier of identification document. Ex: Passport Number | [optional] 
**id_expiry_date** | [**\DateTime**](\DateTime.md) | Expiry date of identification document. Format: ISO 8601 date format YYYY-MM-DD | [optional] 
**id_issue_date** | [**\DateTime**](\DateTime.md) | Issuance date of identification document. Format: ISO 8601 date format YYYY-MM-DD | [optional] 
**id_issue_place** | **string** | Place of issuance | [optional] 
**id_issuing_authority** | **string** | Authority which issued the identification document | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

