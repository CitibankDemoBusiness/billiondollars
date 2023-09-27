# ApplicationInquiryContactPreference

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**send_sms_advice_flag** | **bool** | Applicant&#x27;s subscription for receiving advices through SMS. Valid values: true and false | [optional] 
**send_email_advice_flag** | **bool** | Applicant&#x27;s subscription for receiving advices through email. Valid values: true and false | [optional] 
**preferred_mailing_address** | **string** | Preferred Mailing Address by applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use preferredMailingAddress field name as the referenceCode parameter to retrieve the values. | [optional] 
**e_statement_enrollment_flag** | **bool** | Applicant&#x27;s subscription for receiving statement over email. Valid values: true and false | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

