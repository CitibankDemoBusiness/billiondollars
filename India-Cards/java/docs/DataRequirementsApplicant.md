# DataRequirementsApplicant

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicationType** | [**ApplicationTypeEnum**](#ApplicationTypeEnum) | Type of the card application | 
**employmentStatus** | [**EmploymentStatusEnum**](#EmploymentStatusEnum) | Employment status of the applicant |  [optional]
**minAge** | **Integer** | Minimum age of applicant |  [optional]
**maxAge** | **Integer** | Maximum age of applicant |  [optional]
**minAnnualIncome** | **Integer** | Minimum annual income |  [optional]
**minAnnualIncomeCurrencyCode** | **String** | ISO-4217 3 characters currency code for minimum annual income |  [optional]
**document** | [**List&lt;DataRequirementsDocument&gt;**](DataRequirementsDocument.md) |  |  [optional]

<a name="ApplicationTypeEnum"></a>
## Enum: ApplicationTypeEnum
Name | Value
---- | -----
PRINCIPAL | &quot;principal&quot;
SUPPLEMENTARY | &quot;supplementary&quot;
ANY | &quot;any&quot;

<a name="EmploymentStatusEnum"></a>
## Enum: EmploymentStatusEnum
Name | Value
---- | -----
EMPLOYED | &quot;employed&quot;
SELF_EMPLOYED | &quot;self_employed&quot;
GRADUATE | &quot;graduate&quot;
OTHERS | &quot;others&quot;
ANY | &quot;any&quot;
