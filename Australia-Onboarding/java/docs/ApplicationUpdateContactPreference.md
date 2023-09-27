# ApplicationUpdateContactPreference

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**sendSmsAdviceFlag** | **Boolean** | Applicant&#x27;s subscription for receiving advices through SMS. Valid values: true and false |  [optional]
**sendEmailAdviceFlag** | **Boolean** | Applicant&#x27;s subscription for receiving advices through email. Valid values: true and false |  [optional]
**preferredMailingAddress** | **String** | Preferred Mailing Address by applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**eStatementEnrollmentFlag** | **Boolean** | Applicant&#x27;s subscription for receiving statement over email. Valid values: true and false |  [optional]
