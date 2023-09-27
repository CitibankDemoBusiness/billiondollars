# Address

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address_type** | **str** | Type of address. Ex: Residential, commercial, etc. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get possible value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | 
**address_line1** | **str** | Address line 1 | 
**address_line2** | **str** | Address line 2 | [optional] 
**address_line3** | **str** | Address line 3 | [optional] 
**address_line4** | **str** | Address line 4 | [optional] 
**city_name** | **str** | City | [optional] 
**state** | **str** | State | [optional] 
**postal_code** | **str** | Postal/ZIP code | [optional] 
**province_code** | **str** | Province code | [optional] 
**country_code** | **str** | ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get possible value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**ok_to_mail** | **bool** | To indicate whether the prospect is ok to be sent mails. Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

