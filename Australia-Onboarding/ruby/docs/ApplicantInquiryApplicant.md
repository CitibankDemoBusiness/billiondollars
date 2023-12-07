# SwaggerClient::ApplicantInquiryApplicant

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicant_type** | **String** | Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | 
**applicant_id** | **String** | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | [optional] 
**mother_maiden_name** | **String** | Mothers maiden name | [optional] 
**name** | [**ApplicantInquiryName**](ApplicantInquiryName.md) |  | 
**demographics** | [**ApplicantInquiryDemographics**](ApplicantInquiryDemographics.md) |  | [optional] 
**address** | [**Array&lt;ApplicantInquiryAddress&gt;**](ApplicantInquiryAddress.md) |  | [optional] 
**email** | [**Array&lt;ApplicantInquiryEmail&gt;**](ApplicantInquiryEmail.md) |  | [optional] 
**phone** | [**Array&lt;ApplicantInquiryPhone&gt;**](ApplicantInquiryPhone.md) |  | [optional] 
**financial_information** | [**ApplicantInquiryFinancialInformation**](ApplicantInquiryFinancialInformation.md) |  | [optional] 
**employment_details** | [**Array&lt;ApplicantInquiryEmploymentDetails&gt;**](ApplicantInquiryEmploymentDetails.md) |  | [optional] 
**identification_document_details** | [**Array&lt;ApplicantInquiryIdentificationDocumentDetails&gt;**](ApplicantInquiryIdentificationDocumentDetails.md) |  | [optional] 
**additional_data** | [**ApplicantInquiryAdditionalData**](ApplicantInquiryAdditionalData.md) |  | [optional] 
**partner_customer_details** | [**ApplicantInquiryPartnerCustomerDetails**](ApplicantInquiryPartnerCustomerDetails.md) |  | [optional] 
**consent_details** | [**Array&lt;ApplicantInquiryConsentDetails&gt;**](ApplicantInquiryConsentDetails.md) |  | [optional] 
**required_documents** | [**Array&lt;ApplicantInquiryRequiredDocuments&gt;**](ApplicantInquiryRequiredDocuments.md) |  | [optional] 
**kyc_information** | [**ApplicantInquiryKycInformation**](ApplicantInquiryKycInformation.md) |  | [optional] 
**contact_consent** | [**ApplicantInquiryContactConsent**](ApplicantInquiryContactConsent.md) |  | [optional] 

