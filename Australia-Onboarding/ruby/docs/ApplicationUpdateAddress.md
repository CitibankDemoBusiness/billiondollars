# SwaggerClient::ApplicationUpdateAddress

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address_type** | **String** | Type of address. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**address_line1** | **String** | Address line 1 | [optional] 
**address_line2** | **String** | Address line 2 | [optional] 
**address_line3** | **String** | Address line 3 | [optional] 
**address_line4** | **String** | Address line 4 | [optional] 
**city_name** | **String** | City | [optional] 
**state** | **String** | State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values. | [optional] 
**postal_code** | **String** | Postal/ZIP code | [optional] 
**province_code** | **String** | Province code | [optional] 
**country_code** | **String** | ISO country code. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**ok_to_mail** | **BOOLEAN** | Applicant&#x27;s consent for receiving mail. Valid values: true and false | [optional] 
**residence_duration_in_years** | **Integer** | Applicant&#x27;s residence duration in the current address in years. Applicable only for residential address. | [optional] 
**residence_duration_in_months** | **Integer** | Applicant&#x27;s residence duration in the current address in months. Applicable only for residential address. | [optional] 
**country_specific_address** | [**ApplicationUpdateCountrySpecificAddress**](ApplicationUpdateCountrySpecificAddress.md) |  | [optional] 

