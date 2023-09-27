# RequiredDocumentSet

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**documentSet** | **String** | Document set a mandated combination of document types for each proof. This is a reference data field. Please use /v1/utilities/referenceData/{documentIdType} resource to get valid values of this field with descriptions. |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**proofType** | **String** | Type of document. This is a reference data field. Please use /v1/utilities/referenceData/{proofType} resource to get possible values of this field with descriptions. |  [optional]
**applicantType** | **String** | Applicant relationship with the Bank. Currently supported value is primary.This is a reference data data field. Please use /v1/utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions |  [optional]
