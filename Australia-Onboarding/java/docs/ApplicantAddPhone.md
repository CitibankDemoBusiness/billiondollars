# ApplicantAddPhone

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**phoneType** | **String** | The type of phone.This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get valid value of this field with description. You can use phoneType field name as the referenceCode parameter to retrieve the values. | 
**phoneCountryCode** | **String** | Country code of phone number | 
**areaCode** | **String** | The area code of phone number |  [optional]
**phoneNumber** | **String** | Applicant&#x27;s phone number | 
**extension** | **String** | Extension of phone number |  [optional]
**okToSms** | **Boolean** | Applicant&#x27;s consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false |  [optional]
**okToCall** | **Boolean** | Applicant&#x27;s consent for receiving phone calls. Valid values: true and false |  [optional]
