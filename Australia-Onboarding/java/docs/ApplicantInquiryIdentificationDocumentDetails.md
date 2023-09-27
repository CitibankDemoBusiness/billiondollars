# ApplicantInquiryIdentificationDocumentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**idType** | **String** | Type of Identification document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idType} resource to get valid values of this field with descriptions |  [optional]
**idNumber** | **String** | Unique identifier of identification document. |  [optional]
**idExpiryDate** | [**LocalDate**](LocalDate.md) | Expiry date of identification document in ISO 8601 date format YYYY-MM-DD |  [optional]
**idIssueDate** | [**LocalDate**](LocalDate.md) | Issuance date of identification document in ISO 8601 date format YYYY-MM-DD |  [optional]
**idIssuePlace** | **String** | Identification document issuance place |  [optional]
**idIssueState** | **String** | State from which identification document was issued |  [optional]
**idIssueCountry** | **String** | Country of issuance. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use idIssueCountry field name as the referenceCode parameter to retrieve the values. |  [optional]
**isPrimaryId** | **Boolean** | Flag to mark primary identification document. Valid values: true and false |  [optional]
