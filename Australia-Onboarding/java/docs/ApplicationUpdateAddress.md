# ApplicationUpdateAddress

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**addressType** | **String** | Type of address. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**addressLine1** | **String** | Address line 1 |  [optional]
**addressLine2** | **String** | Address line 2 |  [optional]
**addressLine3** | **String** | Address line 3 |  [optional]
**addressLine4** | **String** | Address line 4 |  [optional]
**cityName** | **String** | City |  [optional]
**state** | **String** | State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values. |  [optional]
**postalCode** | **String** | Postal/ZIP code |  [optional]
**provinceCode** | **String** | Province code |  [optional]
**countryCode** | **String** | ISO country code. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values. |  [optional]
**okToMail** | **Boolean** | Applicant&#x27;s consent for receiving mail. Valid values: true and false |  [optional]
**residenceDurationInYears** | **Integer** | Applicant&#x27;s residence duration in the current address in years. Applicable only for residential address. |  [optional]
**residenceDurationInMonths** | **Integer** | Applicant&#x27;s residence duration in the current address in months. Applicable only for residential address. |  [optional]
**countrySpecificAddress** | [**ApplicationUpdateCountrySpecificAddress**](ApplicationUpdateCountrySpecificAddress.md) |  |  [optional]
