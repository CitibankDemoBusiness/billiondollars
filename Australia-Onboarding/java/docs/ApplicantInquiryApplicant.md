# ApplicantInquiryApplicant

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicantType** | **String** | Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | 
**applicantId** | **String** | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. |  [optional]
**motherMaidenName** | **String** | Mothers maiden name |  [optional]
**name** | [**ApplicantInquiryName**](ApplicantInquiryName.md) |  | 
**demographics** | [**ApplicantInquiryDemographics**](ApplicantInquiryDemographics.md) |  |  [optional]
**address** | [**List&lt;ApplicantInquiryAddress&gt;**](ApplicantInquiryAddress.md) |  |  [optional]
**email** | [**List&lt;ApplicantInquiryEmail&gt;**](ApplicantInquiryEmail.md) |  |  [optional]
**phone** | [**List&lt;ApplicantInquiryPhone&gt;**](ApplicantInquiryPhone.md) |  |  [optional]
**financialInformation** | [**ApplicantInquiryFinancialInformation**](ApplicantInquiryFinancialInformation.md) |  |  [optional]
**employmentDetails** | [**List&lt;ApplicantInquiryEmploymentDetails&gt;**](ApplicantInquiryEmploymentDetails.md) |  |  [optional]
**identificationDocumentDetails** | [**List&lt;ApplicantInquiryIdentificationDocumentDetails&gt;**](ApplicantInquiryIdentificationDocumentDetails.md) |  |  [optional]
**additionalData** | [**ApplicantInquiryAdditionalData**](ApplicantInquiryAdditionalData.md) |  |  [optional]
**partnerCustomerDetails** | [**ApplicantInquiryPartnerCustomerDetails**](ApplicantInquiryPartnerCustomerDetails.md) |  |  [optional]
**consentDetails** | [**List&lt;ApplicantInquiryConsentDetails&gt;**](ApplicantInquiryConsentDetails.md) |  |  [optional]
**requiredDocuments** | [**List&lt;ApplicantInquiryRequiredDocuments&gt;**](ApplicantInquiryRequiredDocuments.md) |  |  [optional]
**kycInformation** | [**ApplicantInquiryKycInformation**](ApplicantInquiryKycInformation.md) |  |  [optional]
**contactConsent** | [**ApplicantInquiryContactConsent**](ApplicantInquiryContactConsent.md) |  |  [optional]
