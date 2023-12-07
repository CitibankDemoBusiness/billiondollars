# SwaggerClient::InitiateCreditChargeCardCorporateCardsClosureRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenized_card_number** | **String** | Tokenized card number | 
**corporate_officer_details** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**cancellation_reason_code** | **String** | cancellationReasonCode. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationReasonCode} resource to get possible values of this field with descriptions | [optional] 
**cancellation_type** | **String** | cancellationReasonDescription. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationType} resource to get possible values of this field with descriptions | [optional] 
**effective_cancel_date** | **Date** | Cancellation date in ISO 8601 date format YYYY-MM-DD | [optional] 
**postal_mail_code** | **String** | Mail letter code if business opt to send letter to customer. This is a reference data field. Please use /v1/utilities/referenceData/{postalMailCode} resource to get possible values of this field with descriptions. | [optional] 
**permenant_account_closure_flag** | **BOOLEAN** | Permanent Account Closure Flag | [optional] 
**consent_given_flag** | **BOOLEAN** | This is consent flag from the customer to pay back if any outstanding on that account while closure | [optional] 

