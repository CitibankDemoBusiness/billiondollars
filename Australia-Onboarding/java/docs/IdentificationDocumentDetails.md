# IdentificationDocumentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**idType** | **String** | Type of Identification document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idType} resource to get valid values of this field with descriptions |  [optional]
**idNumber** | **String** | Unique identifier of identification document. Ex: Passport Number |  [optional]
**idExpiryDate** | [**LocalDate**](LocalDate.md) | Expiry date of identification document. Format: ISO 8601 date format YYYY-MM-DD |  [optional]
**idIssueDate** | [**LocalDate**](LocalDate.md) | Issuance date of identification document. Format: ISO 8601 date format YYYY-MM-DD |  [optional]
**idIssuePlace** | **String** | Place of issuance |  [optional]
**idIssuingAuthority** | **String** | Authority which issued the identification document |  [optional]
