# SwaggerClient::UpdateCreditChargeCardCorporateCardsCreditLimitRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenized_card_number** | **String** | Tokenized card number | 
**corporate_officer_details** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**credit_limit_amount** | **Float** | New Credit Limit Amount | 
**credit_limit_indicator** | **String** | To indicate whether the limit udpate is for account level or card level. This is a reference data field. Please use /v1/utilities/referenceData/{creditLimitIndicator} resource to get possible values of this field with descriptions | 

