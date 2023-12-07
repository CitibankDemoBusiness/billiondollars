# SwaggerClient::AccountCurrencyDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_account_number** | **String** | A masked account number that can be displayed to the customer | [optional] 
**account_id** | **String** | The customer account identifier in encrypted format | [optional] 
**new_account_opened_flag** | **BOOLEAN** | This field is to indicate if the  account is newly opened or not. | 
**global_wallet_account_type** | **String** | Type of account.Type of account.This is a reference data field. Please use /v1/apac/utilities/referenceData/{globalWalletAccountType} resource to get possible values of this field with descriptions. | [optional] 
**enrollment_status_flag** | **BOOLEAN** | Flag to indicate whether new FCY account is enrolled to Multi currency account(Global Wallet). | [optional] 

