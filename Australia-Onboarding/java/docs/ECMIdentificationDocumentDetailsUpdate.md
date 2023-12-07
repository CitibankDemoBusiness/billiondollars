# ECMIdentificationDocumentDetailsUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**idIssueDate** | **String** | Issuance date of identification document in ISO 8601 date format YYYY-MM-DD |  [optional]
**idIssuePlace** | **String** | Identification document issuance place |  [optional]
**idStatus** | **String** | Identification document issuance status |  [optional]
**idIssueCountry** | **String** | Country of issuance. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. |  [optional]
**idType** | **String** | Type of Identification document. This is a reference  data field. Please use /v1/utilities/referenceData/{idType} resource to get valid values of this field with descriptions |  [optional]
**idNumber** | **String** | Unique identifier of identification document. Ex: Passport Number |  [optional]
