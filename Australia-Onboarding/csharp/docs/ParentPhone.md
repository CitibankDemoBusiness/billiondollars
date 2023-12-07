# IO.Swagger.Model.ParentPhone
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhoneType** | **string** | The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/utilities/referenceData/{phoneType} resource to get valid value of this field with description. | 
**PhoneCountryCode** | **string** | Country code of phone number | 
**AreaCode** | **string** | The area code of phone number | [optional] 
**PhoneNumber** | **string** | Parent&#x27;s phone number | 
**Extension** | **string** | Extension of telephone number | [optional] 
**OkToSms** | **bool?** | Parent&#x27;s consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false | [optional] 
**OkToCall** | **bool?** | Parent&#x27;s consent for receiving phone calls. Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

