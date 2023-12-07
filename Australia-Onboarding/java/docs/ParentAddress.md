# ParentAddress

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**addressType** | **String** | Type of address. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. |  [optional]
**addressLine1** | **String** | Address line 1 |  [optional]
**addressLine2** | **String** | Address line 2 |  [optional]
**addressLine3** | **String** | Address line 3 |  [optional]
**addressLine4** | **String** | Address line 4 |  [optional]
**cityName** | **String** | City |  [optional]
**state** | **String** | State.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description. |  [optional]
**postalCode** | **String** | Postal/ZIP code |  [optional]
**provinceCode** | **String** | Province code |  [optional]
**countryCode** | **String** | ISO country code. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. |  [optional]
**okToMail** | **Boolean** | Parent&#x27;s consent for receiving mail. Valid values: true and false |  [optional]
**residenceDurationInYears** | **Integer** | Parent&#x27;s residence duration in the current address in years. Applicable only for residential address. |  [optional]
**residenceDurationInMonths** | **Integer** | Parent&#x27;s residence duration in the current address in months. Applicable only for residential address. |  [optional]
**countrySpecificAddress** | [**ParentCountrySpecificAddress**](ParentCountrySpecificAddress.md) |  |  [optional]
