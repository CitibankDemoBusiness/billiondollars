# SwaggerClient::Address

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address_type** | **String** | Type of address. Ex: Residential, commercial, etc. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get possible value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | 
**address_line1** | **String** | Address line 1 | 
**address_line2** | **String** | Address line 2 | [optional] 
**address_line3** | **String** | Address line 3 | [optional] 
**address_line4** | **String** | Address line 4 | [optional] 
**city_name** | **String** | City | [optional] 
**state** | **String** | State | [optional] 
**postal_code** | **String** | Postal/ZIP code | [optional] 
**province_code** | **String** | Province code | [optional] 
**country_code** | **String** | ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get possible value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**ok_to_mail** | **BOOLEAN** | To indicate whether the prospect is ok to be sent mails. Valid values: true and false | [optional] 

