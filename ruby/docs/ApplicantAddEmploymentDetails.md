# SwaggerClient::ApplicantAddEmploymentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**employment_duration_in_years** | **Integer** | Employment duration in years | [optional] 
**employment_durationi_in_months** | **Integer** | Employment duration in months | [optional] 
**employer_name** | **String** | Name of the employer. | [optional] 
**job_title** | **String** | Job Title. This a reference data field. Please use /utilities/referenceData/{jobTitle} resource to get valid values of this field with descriptions. You can use the jobTitle as the referenceCode parameter to retrieve the values. | [optional] 
**occupation_code** | **String** | Occupation code. This is a reference data field. Please use /utilities/referenceData/{occupationCode} resource to get valid values of this field with descriptions. You can use the occupationCode as the referenceCode parameter to retrieve the values. | [optional] 
**employment_status** | **String** | Status of the employment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 

