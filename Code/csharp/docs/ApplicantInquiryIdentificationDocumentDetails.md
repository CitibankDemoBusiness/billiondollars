# IO.Swagger.Model.ApplicantInquiryIdentificationDocumentDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdType** | **string** | Type of Identification document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idType} resource to get valid values of this field with descriptions | [optional] 
**IdNumber** | **string** | Unique identifier of identification document. | [optional] 
**IdExpiryDate** | **DateTime?** | Expiry date of identification document in ISO 8601 date format YYYY-MM-DD | [optional] 
**IdIssueDate** | **DateTime?** | Issuance date of identification document in ISO 8601 date format YYYY-MM-DD | [optional] 
**IdIssuePlace** | **string** | Identification document issuance place | [optional] 
**IdIssueState** | **string** | State from which identification document was issued | [optional] 
**IdIssueCountry** | **string** | Country of issuance. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use idIssueCountry field name as the referenceCode parameter to retrieve the values. | [optional] 
**IsPrimaryId** | **bool?** | Flag to mark primary identification document. Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

