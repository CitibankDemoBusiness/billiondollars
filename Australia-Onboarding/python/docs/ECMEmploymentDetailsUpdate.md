# ECMEmploymentDetailsUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**employer_name** | **str** | Name of the employer. | [optional] 
**employer_registration_number** | **str** | Employer registration number | [optional] 
**occupation_code** | **str** | Occupation code. This is a reference data field. Please use /v1/utilities/referenceData/{occupationCode} resource to get valid value of this field with description. | [optional] 
**other_occupation_description** | **str** | Other Occupation details entered by the Applicant.This is applicable if Applicant selects Others from the occupation Code drop down | [optional] 
**industry_code** | **str** | Code of the industry of employment. This is a reference data field. Please use /v1/utilities/referenceData/{industryCode} resource to get valid value of this field with description. | [optional] 
**other_industry_description** | **str** | Other Industry details entered by the Applicant.This is applicable if Applicant selects Others from the industry code drop down | [optional] 
**employment_duration_in_years** | **int** | Employment duration in years | [optional] 
**employment_duration_in_months** | **int** | Employment duration in months | [optional] 
**previous_employer_name** | **str** | Name of the previous employer. | [optional] 
**months_in_previous_employment** | **int** | Months spent in the previous employment | [optional] 
**years_in_previous_employment** | **int** | Years spent in the previous employment | [optional] 
**email_address** | **str** | Employers email address | [optional] 
**employment_status** | **str** | Status of the employment.This is a reference data field. Please use /v1/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

