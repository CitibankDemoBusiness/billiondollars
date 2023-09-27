# ApplicationInquiryIdentificationDocumentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id_type** | **str** | Type of Identification document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idType} resource to get valid values of this field with descriptions | 
**id_number** | **str** | Unique identifier of identification document. Ex: Passport Number | 
**id_expiry_date** | **date** | Expiry date of identification document in ISO 8601 date format YYYY-MM-DD | [optional] 
**id_issue_date** | **date** | Issuance date of identification document in ISO 8601 date format YYYY-MM-DD | [optional] 
**id_issue_place** | **str** | Identification document issuance place | [optional] 
**id_issue_state** | **str** | State from which identification document was issued. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values. | [optional] 
**id_issue_country** | **str** | Country of issuance. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use idIssueCountry field name as the referenceCode parameter to retrieve the values. | [optional] 
**is_primary_id** | **bool** | Flag to mark primary identification document. Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

