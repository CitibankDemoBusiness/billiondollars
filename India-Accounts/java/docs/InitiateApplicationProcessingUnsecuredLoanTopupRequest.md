# InitiateApplicationProcessingUnsecuredLoanTopupRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**marketingCampaignOffer** | [**MarketingCampaignOffer**](MarketingCampaignOffer.md) |  |  [optional]
**accountId** | **String** | Account number of customer in encrypted form. |  [optional]
**cardId** | **String** | Card number of customer in encrypted form. |  [optional]
**product** | [**Product**](Product.md) |  |  [optional]
**requestedLoanAmount** | **Double** | Requested loan amount |  [optional]
**loanTopupApplicationType** | **String** | Identifies if application is for cross-sell application for new personal loan (PIL) or loan top-up. This is a reference data data field. Please use /v1/utilities/referenceData/{loanTopupApplicationType} resource to get valid value of this field with description. | 
**spokenLanguageCode** | **String** | Code for spoken language of applicant. Please use /v1/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. | 
