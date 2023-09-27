# DocumentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**documentIdType** | **String** | Document ID for each proof.This is a reference data field. Please use /v1/apac/utilities/referenceData/{documentIdType} resource to get possible value of this field with description. You can use the documentIdType as the referenceCode parameter to retrieve the values. | 
**documentFormat** | **String** | Format of the scanned document.This is a reference data field. Please use /v1/apac/utilities/referenceData/{documentFormat} resource to get possible value of this field with description. You can use the documentFormat as the referenceCode parameter to retrieve the values. | 
**proofType** | **String** | Classification of the document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{proofType} resource to get possible values of this field with descriptions.You can use the proofType as the referenceCode parameter to retrieve the values. | 
**applicantType** | **String** | Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the applicantType as the referenceCode parameter to retrieve the values. |  [optional]
**applicantId** | **String** | Unique identifier to be provided for a supplementary applicant. |  [optional]
**binaryData** | **String** | This field contains binary data of the uploaded document. | 
