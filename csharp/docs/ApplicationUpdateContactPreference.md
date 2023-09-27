# IO.Swagger.Model.ApplicationUpdateContactPreference
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SendSmsAdviceFlag** | **bool?** | Applicant&#x27;s subscription for receiving advices through SMS. Valid values: true and false | [optional] 
**SendEmailAdviceFlag** | **bool?** | Applicant&#x27;s subscription for receiving advices through email. Valid values: true and false | [optional] 
**PreferredMailingAddress** | **string** | Preferred Mailing Address by applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**EStatementEnrollmentFlag** | **bool?** | Applicant&#x27;s subscription for receiving statement over email. Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

