# IO.Swagger.Model.ApplicationUpdatePhone
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhoneType** | **string** | The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get valid value of this field with description. You can use phoneType field name as the referenceCode parameter to retrieve the values. | 
**PhoneCountryCode** | **string** | Country code of telephone number | 
**AreaCode** | **string** | The area code of telephone number | [optional] 
**PhoneNumber** | **string** | The phone number of applicant | 
**Extension** | **string** | Extension of telephone number | [optional] 
**OkToSms** | **bool?** | Applicant&#x27;s consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false | [optional] 
**OkToCall** | **bool?** | Applicant&#x27;s consent for receiving phone calls. Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

