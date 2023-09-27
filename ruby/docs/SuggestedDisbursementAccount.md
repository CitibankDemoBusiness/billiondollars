# SwaggerClient::SuggestedDisbursementAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_account_number** | **String** | A masked account number that can be displayed to the customer | [optional] 
**account_reference_key** | **String** | Account reference key for linking account in a customer session. | [optional] 
**account_type** | **String** | Type of the account. This is a reference data field. Please use /v1/utilities/referenceData/{accountType} resource to get valid value of this field with description. | [optional] 
**bank_name** | **String** | bank name to be displayed to customer | [optional] 
**current_dda_flag** | **BOOLEAN** | Identifies whether account is current direct disbursement account or not. Valid values: true and false | [optional] 

