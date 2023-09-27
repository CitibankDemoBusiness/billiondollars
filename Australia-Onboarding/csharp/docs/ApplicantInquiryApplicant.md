# IO.Swagger.Model.ApplicantInquiryApplicant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicantType** | **string** | Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. | 
**ApplicantId** | **string** | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | [optional] 
**MotherMaidenName** | **string** | Mothers maiden name | [optional] 
**Name** | [**ApplicantInquiryName**](ApplicantInquiryName.md) |  | 
**Demographics** | [**ApplicantInquiryDemographics**](ApplicantInquiryDemographics.md) |  | [optional] 
**Address** | [**List&lt;ApplicantInquiryAddress&gt;**](ApplicantInquiryAddress.md) |  | [optional] 
**Email** | [**List&lt;ApplicantInquiryEmail&gt;**](ApplicantInquiryEmail.md) |  | [optional] 
**Phone** | [**List&lt;ApplicantInquiryPhone&gt;**](ApplicantInquiryPhone.md) |  | [optional] 
**FinancialInformation** | [**ApplicantInquiryFinancialInformation**](ApplicantInquiryFinancialInformation.md) |  | [optional] 
**EmploymentDetails** | [**List&lt;ApplicantInquiryEmploymentDetails&gt;**](ApplicantInquiryEmploymentDetails.md) |  | [optional] 
**IdentificationDocumentDetails** | [**List&lt;ApplicantInquiryIdentificationDocumentDetails&gt;**](ApplicantInquiryIdentificationDocumentDetails.md) |  | [optional] 
**AdditionalData** | [**ApplicantInquiryAdditionalData**](ApplicantInquiryAdditionalData.md) |  | [optional] 
**PartnerCustomerDetails** | [**ApplicantInquiryPartnerCustomerDetails**](ApplicantInquiryPartnerCustomerDetails.md) |  | [optional] 
**ConsentDetails** | [**List&lt;ApplicantInquiryConsentDetails&gt;**](ApplicantInquiryConsentDetails.md) |  | [optional] 
**RequiredDocuments** | [**List&lt;ApplicantInquiryRequiredDocuments&gt;**](ApplicantInquiryRequiredDocuments.md) |  | [optional] 
**KycInformation** | [**ApplicantInquiryKycInformation**](ApplicantInquiryKycInformation.md) |  | [optional] 
**ContactConsent** | [**ApplicantInquiryContactConsent**](ApplicantInquiryContactConsent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

