# ApplicantInquiryApplicant

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicant_type** | **string** | Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | 
**applicant_id** | **string** | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | [optional] 
**mother_maiden_name** | **string** | Mothers maiden name | [optional] 
**name** | [**\Swagger\Client\Model\ApplicantInquiryName**](ApplicantInquiryName.md) |  | 
**demographics** | [**\Swagger\Client\Model\ApplicantInquiryDemographics**](ApplicantInquiryDemographics.md) |  | [optional] 
**address** | [**\Swagger\Client\Model\ApplicantInquiryAddress[]**](ApplicantInquiryAddress.md) |  | [optional] 
**email** | [**\Swagger\Client\Model\ApplicantInquiryEmail[]**](ApplicantInquiryEmail.md) |  | [optional] 
**phone** | [**\Swagger\Client\Model\ApplicantInquiryPhone[]**](ApplicantInquiryPhone.md) |  | [optional] 
**financial_information** | [**\Swagger\Client\Model\ApplicantInquiryFinancialInformation**](ApplicantInquiryFinancialInformation.md) |  | [optional] 
**employment_details** | [**\Swagger\Client\Model\ApplicantInquiryEmploymentDetails[]**](ApplicantInquiryEmploymentDetails.md) |  | [optional] 
**identification_document_details** | [**\Swagger\Client\Model\ApplicantInquiryIdentificationDocumentDetails[]**](ApplicantInquiryIdentificationDocumentDetails.md) |  | [optional] 
**additional_data** | [**\Swagger\Client\Model\ApplicantInquiryAdditionalData**](ApplicantInquiryAdditionalData.md) |  | [optional] 
**partner_customer_details** | [**\Swagger\Client\Model\ApplicantInquiryPartnerCustomerDetails**](ApplicantInquiryPartnerCustomerDetails.md) |  | [optional] 
**consent_details** | [**\Swagger\Client\Model\ApplicantInquiryConsentDetails[]**](ApplicantInquiryConsentDetails.md) |  | [optional] 
**required_documents** | [**\Swagger\Client\Model\ApplicantInquiryRequiredDocuments[]**](ApplicantInquiryRequiredDocuments.md) |  | [optional] 
**kyc_information** | [**\Swagger\Client\Model\ApplicantInquiryKycInformation**](ApplicantInquiryKycInformation.md) |  | [optional] 
**contact_consent** | [**\Swagger\Client\Model\ApplicantInquiryContactConsent**](ApplicantInquiryContactConsent.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

