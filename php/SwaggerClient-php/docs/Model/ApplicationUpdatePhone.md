# ApplicationUpdatePhone

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**phone_type** | **string** | The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get valid value of this field with description. You can use phoneType field name as the referenceCode parameter to retrieve the values. | 
**phone_country_code** | **string** | Country code of telephone number | 
**area_code** | **string** | The area code of telephone number | [optional] 
**phone_number** | **string** | The phone number of applicant | 
**extension** | **string** | Extension of telephone number | [optional] 
**ok_to_sms** | **bool** | Applicant&#x27;s consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false | [optional] 
**ok_to_call** | **bool** | Applicant&#x27;s consent for receiving phone calls. Valid values: true and false | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

