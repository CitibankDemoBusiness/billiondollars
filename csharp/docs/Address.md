# IO.Swagger.Model.Address
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressType** | **string** | Type of address. Ex: Residential, commercial, etc. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get possible value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | 
**AddressLine1** | **string** | Address line 1 | 
**AddressLine2** | **string** | Address line 2 | [optional] 
**AddressLine3** | **string** | Address line 3 | [optional] 
**AddressLine4** | **string** | Address line 4 | [optional] 
**CityName** | **string** | City | [optional] 
**State** | **string** | State | [optional] 
**PostalCode** | **string** | Postal/ZIP code | [optional] 
**ProvinceCode** | **string** | Province code | [optional] 
**CountryCode** | **string** | ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get possible value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**OkToMail** | **bool?** | To indicate whether the prospect is ok to be sent mails. Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

