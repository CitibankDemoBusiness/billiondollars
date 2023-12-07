# InitiateCreditChargeCardCorporateCardsClosureRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenized_card_number** | **string** | Tokenized card number | 
**corporate_officer_details** | [**\Swagger\Client\Model\CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**cancellation_reason_code** | **string** | cancellationReasonCode. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationReasonCode} resource to get possible values of this field with descriptions | [optional] 
**cancellation_type** | **string** | cancellationReasonDescription. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationType} resource to get possible values of this field with descriptions | [optional] 
**effective_cancel_date** | [**\DateTime**](\DateTime.md) | Cancellation date in ISO 8601 date format YYYY-MM-DD | [optional] 
**postal_mail_code** | **string** | Mail letter code if business opt to send letter to customer. This is a reference data field. Please use /v1/utilities/referenceData/{postalMailCode} resource to get possible values of this field with descriptions. | [optional] 
**permenant_account_closure_flag** | **bool** | Permanent Account Closure Flag | [optional] 
**consent_given_flag** | **bool** | This is consent flag from the customer to pay back if any outstanding on that account while closure | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

