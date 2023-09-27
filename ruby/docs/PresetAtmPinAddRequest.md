# SwaggerClient::PresetAtmPinAddRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**application_id** | **String** | The unique identifier of the application. | 
**control_flow_id** | **String** | Control flow id is used to control the flow for subsequent requests in the session. | 
**encrypted_pin** | **String** | Encrypted ATM PIN set by the customer | 
**pin_registration_key** | **String** | Unique key used for the registration of ATM PIN | 
**pin_length** | **Integer** | Length of the ATM  PIN | 
**key_device_id** | **String** | Label to identify the HSM keys used to encrypt PIN | 
**key_generation_id** | **String** | It is the generation ID of the HSM Keys referred for encryption for PIN | 

