# SwaggerClient::ApplicantUpdateApplicant

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicant_type** | **String** | Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | 
**mother_maiden_name** | **String** | Mothers maiden name | [optional] 
**name** | [**ApplicantUpdateName**](ApplicantUpdateName.md) |  | 
**demographics** | [**ApplicantUpdateDemographics**](ApplicantUpdateDemographics.md) |  | [optional] 
**address** | [**Array&lt;ApplicantUpdateAddress&gt;**](ApplicantUpdateAddress.md) |  | [optional] 
**email** | [**Array&lt;ApplicantUpdateEmail&gt;**](ApplicantUpdateEmail.md) |  | [optional] 
**phone** | [**Array&lt;ApplicantUpdatePhone&gt;**](ApplicantUpdatePhone.md) |  | [optional] 
**financial_information** | [**ApplicantUpdateFinancialInformation**](ApplicantUpdateFinancialInformation.md) |  | [optional] 
**employment_details** | [**Array&lt;ApplicantUpdateEmploymentDetails&gt;**](ApplicantUpdateEmploymentDetails.md) |  | [optional] 
**identification_document_details** | [**Array&lt;ApplicantUpdateIdentificationDocumentDetails&gt;**](ApplicantUpdateIdentificationDocumentDetails.md) |  | [optional] 
**additional_data** | [**ApplicantUpdateAdditionalData**](ApplicantUpdateAdditionalData.md) |  | [optional] 
**partner_customer_details** | [**ApplicantUpdatePartnerCustomerDetails**](ApplicantUpdatePartnerCustomerDetails.md) |  | [optional] 
**consent_details** | [**Array&lt;ApplicantUpdateConsentDetails&gt;**](ApplicantUpdateConsentDetails.md) |  | [optional] 
**kyc_information** | [**ApplicantUpdateKycInformation**](ApplicantUpdateKycInformation.md) |  | [optional] 
**contact_consent** | [**ApplicantUpdateContactConsent**](ApplicantUpdateContactConsent.md) |  | [optional] 

