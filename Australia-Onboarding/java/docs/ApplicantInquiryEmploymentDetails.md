# ApplicantInquiryEmploymentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**employmentDurationInYears** | **Integer** | Employment duration in years |  [optional]
**employmentDurationiInMonths** | **Integer** | Employment duration in months |  [optional]
**employerName** | **String** | Name of the employer. |  [optional]
**jobTitle** | **String** | Job Title. This a reference data field. Please use /utilities/referenceData/{jobTitle} resource to get valid values of this field with descriptions. You can use the jobTitle as the referenceCode parameter to retrieve the values. |  [optional]
**occupationCode** | **String** | Occupation code. This is a reference data field. Please use /utilities/referenceData/{occupationCode} resource to get valid values of this field with descriptions. You can use the occupationCode as the referenceCode parameter to retrieve the values. |  [optional]
**employmentStatus** | **String** | Status of the employment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
