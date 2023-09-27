# IdentificationDocumentDetailsAdd

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**idType** | **String** | Type of Identification document. This is a reference data field. Please use /v1/utilities/referenceData/{idType} resource to get valid values of this field with descriptions |  [optional]
**idNumber** | **String** | Unique identifier of identification document. Ex: Passport Number |  [optional]
**idExpiryDate** | [**LocalDate**](LocalDate.md) | Expiry date of identification document in ISO 8601 date format YYYY-MM-DD |  [optional]
**idIssueDate** | [**LocalDate**](LocalDate.md) | Issuance date of identification document in ISO 8601 date format YYYY-MM-DD |  [optional]
**idIssuePlace** | **String** | Identification document issuance place |  [optional]
**idStatus** | **String** | Identification document issuance status |  [optional]
**idIssueState** | **String** | State from which identification document was issued.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description. |  [optional]
**idIssueCountry** | **String** | Country of issuance. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. |  [optional]
**isPrimaryId** | **Boolean** | Flag to mark primary identification document. Valid values: true and false |  [optional]
**referenceNumber** | **String** | Medicare reference number. |  [optional]
**middleName** | **String** | Middle name printed on Medicare ID. |  [optional]
**color** | **String** | Color of Medicare ID. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idCardColor} resource to get possible values of this field with descriptions. |  [optional]
