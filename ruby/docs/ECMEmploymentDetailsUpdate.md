# SwaggerClient::ECMEmploymentDetailsUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**employer_name** | **String** | Name of the employer. | [optional] 
**employer_registration_number** | **String** | Employer registration number | [optional] 
**occupation_code** | **String** | Occupation code. This is a reference data field. Please use /v1/utilities/referenceData/{occupationCode} resource to get valid value of this field with description. | [optional] 
**other_occupation_description** | **String** | Other Occupation details entered by the Applicant.This is applicable if Applicant selects Others from the occupation Code drop down | [optional] 
**industry_code** | **String** | Code of the industry of employment. This is a reference data field. Please use /v1/utilities/referenceData/{industryCode} resource to get valid value of this field with description. | [optional] 
**other_industry_description** | **String** | Other Industry details entered by the Applicant.This is applicable if Applicant selects Others from the industry code drop down | [optional] 
**employment_duration_in_years** | **Integer** | Employment duration in years | [optional] 
**employment_duration_in_months** | **Integer** | Employment duration in months | [optional] 
**previous_employer_name** | **String** | Name of the previous employer. | [optional] 
**months_in_previous_employment** | **Integer** | Months spent in the previous employment | [optional] 
**years_in_previous_employment** | **Integer** | Years spent in the previous employment | [optional] 
**email_address** | **String** | Employers email address | [optional] 
**employment_status** | **String** | Status of the employment.This is a reference data field. Please use /v1/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. | [optional] 

