# RequiredDocuments

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**documentIdType** | **String** | Document ID for each proof. This is a reference data field. Please use /v1/apac/utilities/referenceData/{documentIdType} resource to get valid values of this field with descriptions.You can use the documentIdType as the referenceCode parameter to retrieve the values. |  [optional]
**documentStatus** | **String** | Status of document ID proof. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{documentStatus} resource to get valid values of this field with descriptions |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**proofType** | **String** | Type of document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{proofType} resource to get possible values of this field with descriptions.You can use the proofType as the referenceCode parameter to retrieve the values. |  [optional]
**linkedDocumentId** | **String** | Linked document id is used to link different documents for the required documents/proof type. |  [optional]
**applicantType** | **String** | Applicant relationship with the Bank. Currently supported value is primary.This is a reference data data field. Please use /v1/apac/utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions |  [optional]
