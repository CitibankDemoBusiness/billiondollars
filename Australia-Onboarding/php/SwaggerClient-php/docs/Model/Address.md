# Address

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address_type** | **string** | Type of address. Ex: Residential, commercial, etc. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get possible value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | 
**address_line1** | **string** | Address line 1 | 
**address_line2** | **string** | Address line 2 | [optional] 
**address_line3** | **string** | Address line 3 | [optional] 
**address_line4** | **string** | Address line 4 | [optional] 
**city_name** | **string** | City | [optional] 
**state** | **string** | State | [optional] 
**postal_code** | **string** | Postal/ZIP code | [optional] 
**province_code** | **string** | Province code | [optional] 
**country_code** | **string** | ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get possible value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**ok_to_mail** | **bool** | To indicate whether the prospect is ok to be sent mails. Valid values: true and false | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

