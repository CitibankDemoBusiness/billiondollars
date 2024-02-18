# IO.Swagger.Model.ParentAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressType** | **string** | Type of address. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**AddressLine1** | **string** | Address line 1 | [optional] 
**AddressLine2** | **string** | Address line 2 | [optional] 
**AddressLine3** | **string** | Address line 3 | [optional] 
**AddressLine4** | **string** | Address line 4 | [optional] 
**CityName** | **string** | City | [optional] 
**State** | **string** | State.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description. | [optional] 
**PostalCode** | **string** | Postal/ZIP code | [optional] 
**ProvinceCode** | **string** | Province code | [optional] 
**CountryCode** | **string** | ISO country code. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. | [optional] 
**OkToMail** | **bool?** | Parent&#x27;s consent for receiving mail. Valid values: true and false | [optional] 
**ResidenceDurationInYears** | **int?** | Parent&#x27;s residence duration in the current address in years. Applicable only for residential address. | [optional] 
**ResidenceDurationInMonths** | **int?** | Parent&#x27;s residence duration in the current address in months. Applicable only for residential address. | [optional] 
**CountrySpecificAddress** | [**ParentCountrySpecificAddress**](ParentCountrySpecificAddress.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

