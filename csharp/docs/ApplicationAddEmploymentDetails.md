# IO.Swagger.Model.ApplicationAddEmploymentDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployerName** | **string** | Name of the employer. | [optional] 
**JobTitle** | **string** | Job Title. This is a reference data field. Please use /v1/apac/utilities/referenceData/{jobTitle} resource to get valid value of this field with description. You can use jobTitle field name as the referenceCode parameter to retrieve the values. | [optional] 
**OccupationCode** | **string** | Occupation code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{occupationCode} resource to get valid value of this field with description. You can use occupationCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**IndustryCode** | **string** | Code of the industry of employment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{industryCode} resource to get valid value of this field with description. You can use industryCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**EmploymentDurationInYears** | **int?** | Employment duration in years | [optional] 
**EmploymentDurationInMonths** | **int?** | Employment duration in months | [optional] 
**EmploymentStatus** | **string** | Status of the employment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**MonthsInPreviousEmployment** | **int?** | Months spent in the previouse employment | [optional] 
**YearsInPreviousEmployment** | **int?** | Years spent in the previouse employment | [optional] 
**AccountantName** | **string** | Accountant or contact&#x27;s name | [optional] 
**AccountantFirmName** | **string** | Accountant&#x27;s firm or business name | [optional] 
**YearsInIndustry** | **int?** | Years spent in industry | [optional] 
**MonthsInIndustry** | **int?** | Months spent in industry | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

