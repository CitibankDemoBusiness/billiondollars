# SwaggerClient::AccountClosureRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **String** | The account identifier in encrypted format.Typically, this is not displayed to the customer | 
**account_closure_reason_code** | **String** | Account closure reason code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClosureReasonCode} resource to get valid value of this field with description. | [optional] 
**consent_given_flag** | **BOOLEAN** | This is consent flag from the customer to pay back if any outstanding on that account while closure | 

