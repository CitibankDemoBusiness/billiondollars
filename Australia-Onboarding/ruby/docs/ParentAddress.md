# SwaggerClient::ParentAddress

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address_type** | **String** | Type of address. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**address_line1** | **String** | Address line 1 | [optional] 
**address_line2** | **String** | Address line 2 | [optional] 
**address_line3** | **String** | Address line 3 | [optional] 
**address_line4** | **String** | Address line 4 | [optional] 
**city_name** | **String** | City | [optional] 
**state** | **String** | State.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description. | [optional] 
**postal_code** | **String** | Postal/ZIP code | [optional] 
**province_code** | **String** | Province code | [optional] 
**country_code** | **String** | ISO country code. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. | [optional] 
**ok_to_mail** | **BOOLEAN** | Parent&#x27;s consent for receiving mail. Valid values: true and false | [optional] 
**residence_duration_in_years** | **Integer** | Parent&#x27;s residence duration in the current address in years. Applicable only for residential address. | [optional] 
**residence_duration_in_months** | **Integer** | Parent&#x27;s residence duration in the current address in months. Applicable only for residential address. | [optional] 
**country_specific_address** | [**ParentCountrySpecificAddress**](ParentCountrySpecificAddress.md) |  | [optional] 

