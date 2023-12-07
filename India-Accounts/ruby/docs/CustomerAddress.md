# SwaggerClient::CustomerAddress

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address_line1** | **String** | Address line 1 | [optional] 
**address_line2** | **String** | Address line 2 | [optional] 
**address_line3** | **String** | Address line 3 | [optional] 
**address_line4** | **String** | Address line 4 | [optional] 
**city_name** | **String** | City | [optional] 
**state** | **String** | State.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description. | [optional] 
**postal_code** | **String** | Postal/ZIP code | [optional] 
**province_code** | **String** | Province code | [optional] 
**country_code** | **String** | ISO country code. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values. | [optional] 

