# Phone

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**phone_type** | **str** | The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get possible values of this field with descriptions. You can use phoneType field name as the referenceCode parameter to retrieve the values. | 
**phone_country_code** | **str** | Country code of telephone number | [optional] 
**area_code** | **str** | The area code of telephone number | [optional] 
**phone_number** | **str** | The phone number of prospect | 
**extension** | **str** | Extension of telephone number | [optional] 
**ok_to_sms** | **bool** | Flag to indicate whether prospect wants to receive SMS or not. This is applicable only if phone type is MOBILE. Valid values: true and false | [optional] 
**ok_to_call** | **bool** | Flag to indicate whether prospect wants to receive calls or not. Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

