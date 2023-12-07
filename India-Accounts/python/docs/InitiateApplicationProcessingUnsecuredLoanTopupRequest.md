# InitiateApplicationProcessingUnsecuredLoanTopupRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**marketing_campaign_offer** | [**MarketingCampaignOffer**](MarketingCampaignOffer.md) |  | [optional] 
**account_id** | **str** | Account number of customer in encrypted form. | [optional] 
**card_id** | **str** | Card number of customer in encrypted form. | [optional] 
**product** | [**Product**](Product.md) |  | [optional] 
**requested_loan_amount** | **float** | Requested loan amount | [optional] 
**loan_topup_application_type** | **str** | Identifies if application is for cross-sell application for new personal loan (PIL) or loan top-up. This is a reference data data field. Please use /v1/utilities/referenceData/{loanTopupApplicationType} resource to get valid value of this field with description. | 
**spoken_language_code** | **str** | Code for spoken language of applicant. Please use /v1/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

