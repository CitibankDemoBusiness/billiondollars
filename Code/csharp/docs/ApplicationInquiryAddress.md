# IO.Swagger.Model.ApplicationInquiryAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressType** | **string** | Type of address. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | [optional] 
**AddressLine1** | **string** | Address line 1 | [optional] 
**AddressLine2** | **string** | Address line 2 | [optional] 
**AddressLine3** | **string** | Address line 3 | [optional] 
**AddressLine4** | **string** | Address line 4 | [optional] 
**CityName** | **string** | City | [optional] 
**State** | **string** | State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values. | [optional] 
**PostalCode** | **string** | Postal/ZIP code | [optional] 
**ProvinceCode** | **string** | Province code | [optional] 
**CountryCode** | **string** | ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**OkToMail** | **bool?** | Applicant&#x27;s consent for receiving mail. Valid values: true and false | [optional] 
**ResidenceDurationInYears** | **int?** | Applicant&#x27;s residence duration in the current address in years. Applicable only for residential address. | [optional] 
**ResidenceDurationInMonths** | **int?** | Applicant&#x27;s residence duration in the current address in months. Applicable only for residential address. | [optional] 
**CountrySpecificAddress** | [**ApplicationInquiryCountrySpecificAddress**](ApplicationInquiryCountrySpecificAddress.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

