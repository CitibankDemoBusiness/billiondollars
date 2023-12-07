# ApplicationInquiryEducation

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**highestEducationLevel** | **String** | Highest education level of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{highestEducationLevel} resource to get valid value of this field with description. You can use highestEducationLevel field name as the referenceCode parameter to retrieve the values. |  [optional]
**yearOfGraduation** | **String** | Year of completing graduation. This is required if applicant is a student |  [optional]
**studentId** | **String** | Unique ID of the student. This is required if applicant is a student |  [optional]
**university** | **String** | University name. This is a reference data field. Please use /v1/apac/utilities/referenceData/{universityCode} resource to get valid value of this field with description. You can use university field name as the referenceCode parameter to retrieve the values. |  [optional]
