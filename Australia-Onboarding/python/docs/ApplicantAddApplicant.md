# ApplicantAddApplicant

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicant_type** | **str** | Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | 
**mother_maiden_name** | **str** | Mothers maiden name | [optional] 
**name** | [**ApplicantAddName**](ApplicantAddName.md) |  | 
**demographics** | [**ApplicantAddDemographics**](ApplicantAddDemographics.md) |  | [optional] 
**address** | [**list[ApplicantAddAddress]**](ApplicantAddAddress.md) |  | [optional] 
**email** | [**list[ApplicantAddEmail]**](ApplicantAddEmail.md) |  | [optional] 
**phone** | [**list[ApplicantAddPhone]**](ApplicantAddPhone.md) |  | [optional] 
**financial_information** | [**ApplicantAddFinancialInformation**](ApplicantAddFinancialInformation.md) |  | [optional] 
**employment_details** | [**list[ApplicantAddEmploymentDetails]**](ApplicantAddEmploymentDetails.md) |  | [optional] 
**identification_document_details** | [**list[ApplicantAddIdentificationDocumentDetails]**](ApplicantAddIdentificationDocumentDetails.md) |  | [optional] 
**additional_data** | [**ApplicantAddAdditionalData**](ApplicantAddAdditionalData.md) |  | [optional] 
**partner_customer_details** | [**ApplicantAddPartnerCustomerDetails**](ApplicantAddPartnerCustomerDetails.md) |  | [optional] 
**consent_details** | [**list[ApplicantAddConsentDetails]**](ApplicantAddConsentDetails.md) |  | [optional] 
**kyc_information** | [**ApplicantAddKycInformation**](ApplicantAddKycInformation.md) |  | [optional] 
**contact_consent** | [**ApplicantAddContactConsent**](ApplicantAddContactConsent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

