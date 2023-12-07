# DataRequirementsRequirementDetail

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**nationality** | [**NationalityEnum**](#NationalityEnum) | Nationality of the applicant | 
**nationalityRemark** | **String** | Remark on nationality |  [optional]
**residency** | [**ResidencyEnum**](#ResidencyEnum) | Resident status of the applicant | 
**accountHolderFlag** | **Boolean** | Requirement to have account with the bank |  [optional]
**applicant** | [**List&lt;DataRequirementsApplicant&gt;**](DataRequirementsApplicant.md) |  |  [optional]

<a name="NationalityEnum"></a>
## Enum: NationalityEnum
Name | Value
---- | -----
MALAYSIAN | &quot;malaysian&quot;
NON_MALAYSIAN | &quot;non_malaysian&quot;
ANY | &quot;any&quot;

<a name="ResidencyEnum"></a>
## Enum: ResidencyEnum
Name | Value
---- | -----
RESIDENT | &quot;resident&quot;
NON_RESIDENT | &quot;non_resident&quot;
ANY | &quot;any&quot;
