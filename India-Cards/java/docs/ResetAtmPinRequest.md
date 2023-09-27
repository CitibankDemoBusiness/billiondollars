# ResetAtmPinRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cardId** | **String** | Unique Id of the card in encrypted format. | 
**newPin** | **String** | New pin in encrypted format. | 
**encryptionType** | **String** | Type of the encryption. This is a reference data field. Please use /v1/apac/utilities/referenceData/{encryptionType} resource to get valid value of this field with description. |  [optional]
**keyDeviceId** | **String** | Label to identify the HSM keys used to encrypt ATM PIN. |  [optional]
**keyGenerationId** | **String** | It is the generation ID of the HSM Keys referred for encryption of ATM PIN. |  [optional]
