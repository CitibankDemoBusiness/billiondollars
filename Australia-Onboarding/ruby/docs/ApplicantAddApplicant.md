# SwaggerClient::ApplicantAddApplicant

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicant_type** | **String** | Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | 
**mother_maiden_name** | **String** | Mothers maiden name | [optional] 
**name** | [**ApplicantAddName**](ApplicantAddName.md) |  | 
**demographics** | [**ApplicantAddDemographics**](ApplicantAddDemographics.md) |  | [optional] 
**address** | [**Array&lt;ApplicantAddAddress&gt;**](ApplicantAddAddress.md) |  | [optional] 
**email** | [**Array&lt;ApplicantAddEmail&gt;**](ApplicantAddEmail.md) |  | [optional] 
**phone** | [**Array&lt;ApplicantAddPhone&gt;**](ApplicantAddPhone.md) |  | [optional] 
**financial_information** | [**ApplicantAddFinancialInformation**](ApplicantAddFinancialInformation.md) |  | [optional] 
**employment_details** | [**Array&lt;ApplicantAddEmploymentDetails&gt;**](ApplicantAddEmploymentDetails.md) |  | [optional] 
**identification_document_details** | [**Array&lt;ApplicantAddIdentificationDocumentDetails&gt;**](ApplicantAddIdentificationDocumentDetails.md) |  | [optional] 
**additional_data** | [**ApplicantAddAdditionalData**](ApplicantAddAdditionalData.md) |  | [optional] 
**partner_customer_details** | [**ApplicantAddPartnerCustomerDetails**](ApplicantAddPartnerCustomerDetails.md) |  | [optional] 
**consent_details** | [**Array&lt;ApplicantAddConsentDetails&gt;**](ApplicantAddConsentDetails.md) |  | [optional] 
**kyc_information** | [**ApplicantAddKycInformation**](ApplicantAddKycInformation.md) |  | [optional] 
**contact_consent** | [**ApplicantAddContactConsent**](ApplicantAddContactConsent.md) |  | [optional] 

