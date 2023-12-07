# ResetAtmPinRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_id** | **str** | Unique Id of the card in encrypted format. | 
**new_pin** | **str** | New pin in encrypted format. | 
**encryption_type** | **str** | Type of the encryption. This is a reference data field. Please use /v1/apac/utilities/referenceData/{encryptionType} resource to get valid value of this field with description. | [optional] 
**key_device_id** | **str** | Label to identify the HSM keys used to encrypt ATM PIN. | [optional] 
**key_generation_id** | **str** | It is the generation ID of the HSM Keys referred for encryption of ATM PIN. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

