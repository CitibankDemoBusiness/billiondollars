# Phone

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**phoneType** | **String** | The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get possible values of this field with descriptions. You can use phoneType field name as the referenceCode parameter to retrieve the values. | 
**phoneCountryCode** | **String** | Country code of telephone number |  [optional]
**areaCode** | **String** | The area code of telephone number |  [optional]
**phoneNumber** | **String** | The phone number of prospect | 
**extension** | **String** | Extension of telephone number |  [optional]
**okToSms** | **Boolean** | Flag to indicate whether prospect wants to receive SMS or not. This is applicable only if phone type is MOBILE. Valid values: true and false |  [optional]
**okToCall** | **Boolean** | Flag to indicate whether prospect wants to receive calls or not. Valid values: true and false |  [optional]
