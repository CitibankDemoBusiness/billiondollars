# SwaggerClient::Phone

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**phone_type** | **String** | The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get possible values of this field with descriptions. You can use phoneType field name as the referenceCode parameter to retrieve the values. | 
**phone_country_code** | **String** | Country code of telephone number | [optional] 
**area_code** | **String** | The area code of telephone number | [optional] 
**phone_number** | **String** | The phone number of prospect | 
**extension** | **String** | Extension of telephone number | [optional] 
**ok_to_sms** | **BOOLEAN** | Flag to indicate whether prospect wants to receive SMS or not. This is applicable only if phone type is MOBILE. Valid values: true and false | [optional] 
**ok_to_call** | **BOOLEAN** | Flag to indicate whether prospect wants to receive calls or not. Valid values: true and false | [optional] 

