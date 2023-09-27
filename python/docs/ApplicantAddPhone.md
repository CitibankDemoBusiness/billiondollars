# ApplicantAddPhone

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**phone_type** | **str** | The type of phone.This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get valid value of this field with description. You can use phoneType field name as the referenceCode parameter to retrieve the values. | 
**phone_country_code** | **str** | Country code of phone number | 
**area_code** | **str** | The area code of phone number | [optional] 
**phone_number** | **str** | Applicant&#x27;s phone number | 
**extension** | **str** | Extension of phone number | [optional] 
**ok_to_sms** | **bool** | Applicant&#x27;s consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false | [optional] 
**ok_to_call** | **bool** | Applicant&#x27;s consent for receiving phone calls. Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

