# ApplicantUpdateApplicant

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicant_type** | **str** | Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | 
**mother_maiden_name** | **str** | Mothers maiden name | [optional] 
**name** | [**ApplicantUpdateName**](ApplicantUpdateName.md) |  | 
**demographics** | [**ApplicantUpdateDemographics**](ApplicantUpdateDemographics.md) |  | [optional] 
**address** | [**list[ApplicantUpdateAddress]**](ApplicantUpdateAddress.md) |  | [optional] 
**email** | [**list[ApplicantUpdateEmail]**](ApplicantUpdateEmail.md) |  | [optional] 
**phone** | [**list[ApplicantUpdatePhone]**](ApplicantUpdatePhone.md) |  | [optional] 
**financial_information** | [**ApplicantUpdateFinancialInformation**](ApplicantUpdateFinancialInformation.md) |  | [optional] 
**employment_details** | [**list[ApplicantUpdateEmploymentDetails]**](ApplicantUpdateEmploymentDetails.md) |  | [optional] 
**identification_document_details** | [**list[ApplicantUpdateIdentificationDocumentDetails]**](ApplicantUpdateIdentificationDocumentDetails.md) |  | [optional] 
**additional_data** | [**ApplicantUpdateAdditionalData**](ApplicantUpdateAdditionalData.md) |  | [optional] 
**partner_customer_details** | [**ApplicantUpdatePartnerCustomerDetails**](ApplicantUpdatePartnerCustomerDetails.md) |  | [optional] 
**consent_details** | [**list[ApplicantUpdateConsentDetails]**](ApplicantUpdateConsentDetails.md) |  | [optional] 
**kyc_information** | [**ApplicantUpdateKycInformation**](ApplicantUpdateKycInformation.md) |  | [optional] 
**contact_consent** | [**ApplicantUpdateContactConsent**](ApplicantUpdateContactConsent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

