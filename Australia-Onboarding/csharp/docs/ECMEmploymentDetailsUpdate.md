# IO.Swagger.Model.ECMEmploymentDetailsUpdate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployerName** | **string** | Name of the employer. | [optional] 
**EmployerRegistrationNumber** | **string** | Employer registration number | [optional] 
**OccupationCode** | **string** | Occupation code. This is a reference data field. Please use /v1/utilities/referenceData/{occupationCode} resource to get valid value of this field with description. | [optional] 
**OtherOccupationDescription** | **string** | Other Occupation details entered by the Applicant.This is applicable if Applicant selects Others from the occupation Code drop down | [optional] 
**IndustryCode** | **string** | Code of the industry of employment. This is a reference data field. Please use /v1/utilities/referenceData/{industryCode} resource to get valid value of this field with description. | [optional] 
**OtherIndustryDescription** | **string** | Other Industry details entered by the Applicant.This is applicable if Applicant selects Others from the industry code drop down | [optional] 
**EmploymentDurationInYears** | **int?** | Employment duration in years | [optional] 
**EmploymentDurationInMonths** | **int?** | Employment duration in months | [optional] 
**PreviousEmployerName** | **string** | Name of the previous employer. | [optional] 
**MonthsInPreviousEmployment** | **int?** | Months spent in the previous employment | [optional] 
**YearsInPreviousEmployment** | **int?** | Years spent in the previous employment | [optional] 
**EmailAddress** | **string** | Employers email address | [optional] 
**EmploymentStatus** | **string** | Status of the employment.This is a reference data field. Please use /v1/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

