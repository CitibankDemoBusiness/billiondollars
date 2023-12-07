# SwaggerClient::Address

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**country_specific_address** | [**CountrySpecificAddress**](CountrySpecificAddress.md) |  | [optional] 
**city** | **String** | Town/City | [optional] 
**address_type** | **String** | Type of the address. This is a reference data field. Please use /utilities/referenceData/{addressType} resource to get valid values of this field with descriptions. | 
**country_code** | **String** | ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. | [optional] 
**postal_code** | **String** | Postal/ZIP code | [optional] 
**address_line1** | **String** | Address line 1 | [optional] 
**address_line2** | **String** | Address line 2. It is the unit number for Australia | [optional] 
**address_line3** | **String** | Address line 3. | [optional] 
**state** | **String** | State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. | [optional] 
**address_line4** | **String** | Address line 4. | [optional] 

