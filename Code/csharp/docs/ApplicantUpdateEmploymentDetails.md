# IO.Swagger.Model.ApplicantUpdateEmploymentDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmploymentDurationInYears** | **int?** | Employment duration in years | [optional] 
**EmploymentDurationiInMonths** | **int?** | Employment duration in months | [optional] 
**EmployerName** | **string** | Name of the employer. | [optional] 
**JobTitle** | **string** | Job Title. This a reference data field. Please use /utilities/referenceData/{jobTitle} resource to get valid values of this field with descriptions. You can use the jobTitle as the referenceCode parameter to retrieve the values. | [optional] 
**OccupationCode** | **string** | Occupation code. This is a reference data field. Please use /utilities/referenceData/{occupationCode} resource to get valid values of this field with descriptions. You can use the occupationCode as the referenceCode parameter to retrieve the values. | [optional] 
**EmploymentStatus** | **string** | Status of the employment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

