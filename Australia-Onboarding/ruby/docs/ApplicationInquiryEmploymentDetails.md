# SwaggerClient::ApplicationInquiryEmploymentDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**employer_name** | **String** | Name of the employer. | [optional] 
**job_title** | **String** | Job Title. This is a reference data field. Please use /v1/apac/utilities/referenceData/{jobTitle} resource to get valid value of this field with description. You can use jobTitle field name as the referenceCode parameter to retrieve the values. | [optional] 
**occupation_code** | **String** | Occupation code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{occupationCode} resource to get valid value of this field with description. You can use occupationCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**industry_code** | **String** | Code of the industry of employment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{industryCode} resource to get valid value of this field with description. You can use industryCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**employment_duration_in_years** | **Integer** | Employment duration in years | [optional] 
**employment_duration_in_months** | **Integer** | Employment duration in months | [optional] 
**employment_status** | **String** | Status of the employment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**months_in_previous_employment** | **Integer** | Months spent in the previouse employment | [optional] 
**years_in_previous_employment** | **Integer** | Years spent in the previouse employment | [optional] 
**accountant_name** | **String** | Accountant or contact&#x27;s name | [optional] 
**accountant_firm_name** | **String** | Accountant&#x27;s firm or business name | [optional] 
**years_in_industry** | **Integer** | Years spent in industry | [optional] 
**months_in_industry** | **Integer** | Months spent in industry | [optional] 

