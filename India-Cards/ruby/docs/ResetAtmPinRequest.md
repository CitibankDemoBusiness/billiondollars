# SwaggerClient::ResetAtmPinRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_id** | **String** | Unique Id of the card in encrypted format. | 
**new_pin** | **String** | New pin in encrypted format. | 
**encryption_type** | **String** | Type of the encryption. This is a reference data field. Please use /v1/apac/utilities/referenceData/{encryptionType} resource to get valid value of this field with description. | [optional] 
**key_device_id** | **String** | Label to identify the HSM keys used to encrypt ATM PIN. | [optional] 
**key_generation_id** | **String** | It is the generation ID of the HSM Keys referred for encryption of ATM PIN. | [optional] 

