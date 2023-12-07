# RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenized_card_number** | **string** | Tokenized card number | 
**corporate_officer_details** | [**\Swagger\Client\Model\CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**cash_limit_update_allowed_flag** | **bool** | This field is used to indicate whether cash withdrawal is allowed for the corporate card | [optional] 
**card_status** | **string** | This field is used to indicate whether to  suspend or unsuspend the corporate card.This is a reference data field. Please use /v1/utilities/referenceData/{cardStatus} resource to get possible values of this field with descriptions | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

