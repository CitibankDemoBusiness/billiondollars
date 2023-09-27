# Address

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**addressType** | **String** | Type of address. Ex: Residential, commercial, etc. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get possible value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | 
**addressLine1** | **String** | Address line 1 | 
**addressLine2** | **String** | Address line 2 |  [optional]
**addressLine3** | **String** | Address line 3 |  [optional]
**addressLine4** | **String** | Address line 4 |  [optional]
**cityName** | **String** | City |  [optional]
**state** | **String** | State |  [optional]
**postalCode** | **String** | Postal/ZIP code |  [optional]
**provinceCode** | **String** | Province code |  [optional]
**countryCode** | **String** | ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get possible value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values. |  [optional]
**okToMail** | **Boolean** | To indicate whether the prospect is ok to be sent mails. Valid values: true and false |  [optional]
