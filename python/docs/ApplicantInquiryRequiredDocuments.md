# ApplicantInquiryRequiredDocuments

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**document_id_type** | **str** | Document ID for each proof. This is a reference data field. Please use /v1/apac/utilities/referenceData/{documentIdType} resource to get valid values of this field with descriptions.You can use the documentIdType as the referenceCode parameter to retrieve the values. | [optional] 
**document_status** | **str** | Status of document proof.This is a reference data field. Please use /v1/apac/utilities/referenceData/{documentStatus} resource to get possible values of this field with descriptions.You can use the documentStatus as the referenceCode parameter to retrieve the values. | [optional] 
**product_code** | **str** | A unique code that identifies the product | [optional] 
**proof_type** | **str** | Type of document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{proofType} resource to get possible values of this field with descriptions.You can use the proofType as the referenceCode parameter to retrieve the values. | [optional] 
**linked_document_id** | **str** | Linked document id specifies that the same document can be used for different proof types | [optional] 
**applicant_type** | **str** | Applicant&#x27;s relationship with the Bank. Currently supported is Primary - P.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicantType} resource to get valid value of this field with description.You can use the documentType as the referenceCode parameter to retrieve the values. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

