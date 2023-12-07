# SwaggerClient::RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenized_card_number** | **String** | Tokenized card number | 
**corporate_officer_details** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**cash_limit_update_allowed_flag** | **BOOLEAN** | This field is used to indicate whether cash withdrawal is allowed for the corporate card | [optional] 
**card_status** | **String** | This field is used to indicate whether to  suspend or unsuspend the corporate card.This is a reference data field. Please use /v1/utilities/referenceData/{cardStatus} resource to get possible values of this field with descriptions | [optional] 

