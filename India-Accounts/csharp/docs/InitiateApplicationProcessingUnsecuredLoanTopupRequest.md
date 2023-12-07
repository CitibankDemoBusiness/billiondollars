# IO.Swagger.Model.InitiateApplicationProcessingUnsecuredLoanTopupRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketingCampaignOffer** | [**MarketingCampaignOffer**](MarketingCampaignOffer.md) |  | [optional] 
**AccountId** | **string** | Account number of customer in encrypted form. | [optional] 
**CardId** | **string** | Card number of customer in encrypted form. | [optional] 
**Product** | [**Product**](Product.md) |  | [optional] 
**RequestedLoanAmount** | **double?** | Requested loan amount | [optional] 
**LoanTopupApplicationType** | **string** | Identifies if application is for cross-sell application for new personal loan (PIL) or loan top-up. This is a reference data data field. Please use /v1/utilities/referenceData/{loanTopupApplicationType} resource to get valid value of this field with description. | 
**SpokenLanguageCode** | **string** | Code for spoken language of applicant. Please use /v1/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

