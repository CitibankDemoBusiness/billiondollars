# IO.Swagger.Model.ResetAtmPinRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardId** | **string** | Unique Id of the card in encrypted format. | 
**NewPin** | **string** | New pin in encrypted format. | 
**EncryptionType** | **string** | Type of the encryption. This is a reference data field. Please use /v1/apac/utilities/referenceData/{encryptionType} resource to get valid value of this field with description. | [optional] 
**KeyDeviceId** | **string** | Label to identify the HSM keys used to encrypt ATM PIN. | [optional] 
**KeyGenerationId** | **string** | It is the generation ID of the HSM Keys referred for encryption of ATM PIN. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

