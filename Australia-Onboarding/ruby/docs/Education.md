# SwaggerClient::Education

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**highest_education_level** | **String** | Highest education level of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{highestEducationLevel} resource to get possible values of this field with descriptions. You can use highestEducationLevel field name as the referenceCode parameter to retrieve the values. | [optional] 
**year_of_graduation** | **String** | Year of completing graduation. This is required if prospect is a student | [optional] 
**student_id** | **String** | Unique ID of the student. This is required if prospect is a student | [optional] 
**university** | **String** | Student studying in university. This is a reference data field. Please use /v1/apac/utilities/referenceData/{universityCode} resource to get possible values of this field with descriptions. You can use university field name as the referenceCode parameter to retrieve the values. | [optional] 

