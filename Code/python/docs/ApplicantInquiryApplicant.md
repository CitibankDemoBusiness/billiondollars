# ApplicantInquiryApplicant

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicant_type** | **str** | Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | 
**applicant_id** | **str** | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | [optional] 
**mother_maiden_name** | **str** | Mothers maiden name | [optional] 
**name** | [**ApplicantInquiryName**](ApplicantInquiryName.md) |  | 
**demographics** | [**ApplicantInquiryDemographics**](ApplicantInquiryDemographics.md) |  | [optional] 
**address** | [**list[ApplicantInquiryAddress]**](ApplicantInquiryAddress.md) |  | [optional] 
**email** | [**list[ApplicantInquiryEmail]**](ApplicantInquiryEmail.md) |  | [optional] 
**phone** | [**list[ApplicantInquiryPhone]**](ApplicantInquiryPhone.md) |  | [optional] 
**financial_information** | [**ApplicantInquiryFinancialInformation**](ApplicantInquiryFinancialInformation.md) |  | [optional] 
**employment_details** | [**list[ApplicantInquiryEmploymentDetails]**](ApplicantInquiryEmploymentDetails.md) |  | [optional] 
**identification_document_details** | [**list[ApplicantInquiryIdentificationDocumentDetails]**](ApplicantInquiryIdentificationDocumentDetails.md) |  | [optional] 
**additional_data** | [**ApplicantInquiryAdditionalData**](ApplicantInquiryAdditionalData.md) |  | [optional] 
**partner_customer_details** | [**ApplicantInquiryPartnerCustomerDetails**](ApplicantInquiryPartnerCustomerDetails.md) |  | [optional] 
**consent_details** | [**list[ApplicantInquiryConsentDetails]**](ApplicantInquiryConsentDetails.md) |  | [optional] 
**required_documents** | [**list[ApplicantInquiryRequiredDocuments]**](ApplicantInquiryRequiredDocuments.md) |  | [optional] 
**kyc_information** | [**ApplicantInquiryKycInformation**](ApplicantInquiryKycInformation.md) |  | [optional] 
**contact_consent** | [**ApplicantInquiryContactConsent**](ApplicantInquiryContactConsent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

