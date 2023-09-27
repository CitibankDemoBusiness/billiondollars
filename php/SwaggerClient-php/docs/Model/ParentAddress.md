# ParentAddress

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address_type** | **string** | Type of address. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**address_line1** | **string** | Address line 1 | [optional] 
**address_line2** | **string** | Address line 2 | [optional] 
**address_line3** | **string** | Address line 3 | [optional] 
**address_line4** | **string** | Address line 4 | [optional] 
**city_name** | **string** | City | [optional] 
**state** | **string** | State.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description. | [optional] 
**postal_code** | **string** | Postal/ZIP code | [optional] 
**province_code** | **string** | Province code | [optional] 
**country_code** | **string** | ISO country code. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. | [optional] 
**ok_to_mail** | **bool** | Parent&#x27;s consent for receiving mail. Valid values: true and false | [optional] 
**residence_duration_in_years** | **int** | Parent&#x27;s residence duration in the current address in years. Applicable only for residential address. | [optional] 
**residence_duration_in_months** | **int** | Parent&#x27;s residence duration in the current address in months. Applicable only for residential address. | [optional] 
**country_specific_address** | [**\Swagger\Client\Model\ParentCountrySpecificAddress**](ParentCountrySpecificAddress.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

