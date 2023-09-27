# SwaggerClient::Address

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address_type** | **String** | Type of the address. This is a reference data field. Please use /utilities/referenceData/{addressType} resource to get valid values of this field with descriptions. | 
**address_line1** | **String** | Address line 1 | 
**address_line2** | **String** | Address line 2 | [optional] 
**address_line3** | **String** | Address line 3 | [optional] 
**address_line4** | **String** | Address line 4 | [optional] 
**city_name** | **String** | City | [optional] 
**state** | **String** | State.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description. | [optional] 
**postal_code** | **String** | Postal/ZIP code | [optional] 
**country_code** | **String** | ISO country code. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. | [optional] 

