# SwaggerClient::EmploymentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**employer_name** | **String** | Name of the Employer. | [optional] 
**job_title** | **String** | Job Title. This is a reference data field. Please use /v1/apac/utilities/referenceData/{jobTitle} resource to get possible values of this field with descriptions. You can use jobTitle field name as the referenceCode parameter to retrieve the values. | [optional] 
**occupation_code** | **String** | Occupation code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{occupationCode} resource to get possible values of this field with descriptions. You can use occupationCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**industry_code** | **String** | Code of the industry of employment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{industryCode} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 

