# IO.Swagger.Model.Phone
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhoneType** | **string** | The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get possible values of this field with descriptions. You can use phoneType field name as the referenceCode parameter to retrieve the values. | 
**PhoneCountryCode** | **string** | Country code of telephone number | [optional] 
**AreaCode** | **string** | The area code of telephone number | [optional] 
**PhoneNumber** | **string** | The phone number of prospect | 
**Extension** | **string** | Extension of telephone number | [optional] 
**OkToSms** | **bool?** | Flag to indicate whether prospect wants to receive SMS or not. This is applicable only if phone type is MOBILE. Valid values: true and false | [optional] 
**OkToCall** | **bool?** | Flag to indicate whether prospect wants to receive calls or not. Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

