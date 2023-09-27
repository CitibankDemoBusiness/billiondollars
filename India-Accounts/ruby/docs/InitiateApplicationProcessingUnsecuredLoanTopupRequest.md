# SwaggerClient::InitiateApplicationProcessingUnsecuredLoanTopupRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**marketing_campaign_offer** | [**MarketingCampaignOffer**](MarketingCampaignOffer.md) |  | [optional] 
**account_id** | **String** | Account number of customer in encrypted form. | [optional] 
**card_id** | **String** | Card number of customer in encrypted form. | [optional] 
**product** | [**Product**](Product.md) |  | [optional] 
**requested_loan_amount** | **Float** | Requested loan amount | [optional] 
**loan_topup_application_type** | **String** | Identifies if application is for cross-sell application for new personal loan (PIL) or loan top-up. This is a reference data data field. Please use /v1/utilities/referenceData/{loanTopupApplicationType} resource to get valid value of this field with description. | 
**spoken_language_code** | **String** | Code for spoken language of applicant. Please use /v1/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. | 

