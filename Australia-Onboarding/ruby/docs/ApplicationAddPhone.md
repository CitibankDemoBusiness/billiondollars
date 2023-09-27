# SwaggerClient::ApplicationAddPhone

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**phone_type** | **String** | The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get valid value of this field with description. You can use phoneType field name as the referenceCode parameter to retrieve the values. | 
**phone_country_code** | **String** | Country code of phone number | 
**area_code** | **String** | The area code of phone number | [optional] 
**phone_number** | **String** | Applicant&#x27;s phone number | 
**extension** | **String** | Extension of telephone number | [optional] 
**ok_to_sms** | **BOOLEAN** | Applicant&#x27;s consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false | [optional] 
**ok_to_call** | **BOOLEAN** | Applicant&#x27;s consent for receiving phone calls. Valid values: true and false | [optional] 

