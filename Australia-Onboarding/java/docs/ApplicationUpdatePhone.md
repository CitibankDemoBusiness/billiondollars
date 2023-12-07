# ApplicationUpdatePhone

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**phoneType** | **String** | The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get valid value of this field with description. You can use phoneType field name as the referenceCode parameter to retrieve the values. | 
**phoneCountryCode** | **String** | Country code of telephone number | 
**areaCode** | **String** | The area code of telephone number |  [optional]
**phoneNumber** | **String** | The phone number of applicant | 
**extension** | **String** | Extension of telephone number |  [optional]
**okToSms** | **Boolean** | Applicant&#x27;s consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false |  [optional]
**okToCall** | **Boolean** | Applicant&#x27;s consent for receiving phone calls. Valid values: true and false |  [optional]
