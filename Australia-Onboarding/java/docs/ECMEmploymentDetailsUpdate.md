# ECMEmploymentDetailsUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**employerName** | **String** | Name of the employer. |  [optional]
**employerRegistrationNumber** | **String** | Employer registration number |  [optional]
**occupationCode** | **String** | Occupation code. This is a reference data field. Please use /v1/utilities/referenceData/{occupationCode} resource to get valid value of this field with description. |  [optional]
**otherOccupationDescription** | **String** | Other Occupation details entered by the Applicant.This is applicable if Applicant selects Others from the occupation Code drop down |  [optional]
**industryCode** | **String** | Code of the industry of employment. This is a reference data field. Please use /v1/utilities/referenceData/{industryCode} resource to get valid value of this field with description. |  [optional]
**otherIndustryDescription** | **String** | Other Industry details entered by the Applicant.This is applicable if Applicant selects Others from the industry code drop down |  [optional]
**employmentDurationInYears** | **Integer** | Employment duration in years |  [optional]
**employmentDurationInMonths** | **Integer** | Employment duration in months |  [optional]
**previousEmployerName** | **String** | Name of the previous employer. |  [optional]
**monthsInPreviousEmployment** | **Integer** | Months spent in the previous employment |  [optional]
**yearsInPreviousEmployment** | **Integer** | Years spent in the previous employment |  [optional]
**emailAddress** | **String** | Employers email address |  [optional]
**employmentStatus** | **String** | Status of the employment.This is a reference data field. Please use /v1/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. |  [optional]
