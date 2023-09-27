# ParentPhone

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**phoneType** | **String** | The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/utilities/referenceData/{phoneType} resource to get valid value of this field with description. | 
**phoneCountryCode** | **String** | Country code of phone number | 
**areaCode** | **String** | The area code of phone number |  [optional]
**phoneNumber** | **String** | Parent&#x27;s phone number | 
**extension** | **String** | Extension of telephone number |  [optional]
**okToSms** | **Boolean** | Parent&#x27;s consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false |  [optional]
**okToCall** | **Boolean** | Parent&#x27;s consent for receiving phone calls. Valid values: true and false |  [optional]
