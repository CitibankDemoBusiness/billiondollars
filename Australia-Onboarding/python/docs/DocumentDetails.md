# DocumentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**document_id_type** | **str** | Document ID for each proof.This is a reference data field. Please use /v1/apac/utilities/referenceData/{documentIdType} resource to get possible value of this field with description. You can use the documentIdType as the referenceCode parameter to retrieve the values. | 
**document_format** | **str** | Format of the scanned document.This is a reference data field. Please use /v1/apac/utilities/referenceData/{documentFormat} resource to get possible value of this field with description. You can use the documentFormat as the referenceCode parameter to retrieve the values. | 
**proof_type** | **str** | Classification of the document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{proofType} resource to get possible values of this field with descriptions.You can use the proofType as the referenceCode parameter to retrieve the values. | 
**applicant_type** | **str** | Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the applicantType as the referenceCode parameter to retrieve the values. | [optional] 
**applicant_id** | **str** | Unique identifier to be provided for a supplementary applicant. | [optional] 
**binary_data** | **str** | This field contains binary data of the uploaded document. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

