# ApplicantUpdateDemographics

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**gender** | **string** | Gender/sex. This is a reference data field. Please use /v1/apac/utilities/referenceData/{gender} resource to get valid value of this field with description. You can use gender field name as the referenceCode parameter to retrieve the values. | [optional] 
**date_of_birth** | [**\DateTime**](\DateTime.md) | Applicant&#x27;s date of birth in  ISO 8601 date format YYYY-MM-DD | [optional] 
**place_of_birth** | **string** | Applicant&#x27;s place of birth | [optional] 
**country_of_birth** | **string** | Applicant&#x27;s Country of birth. This is a reference data field. Please use /utilities/referenceData/{country} resource to get valid values of this field with descriptions. You can use the countryOfBirth as the referenceCode parameter to retrieve the values. | [optional] 
**nationality** | **string** | Applicant&#x27;s nationality. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use nationality field name as the referenceCode parameter to retrieve the values. | [optional] 
**marital_status** | **string** | Applicant&#x27;s marital status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{maritalStatus} resource to get valid value of this field with description. You can use maritalStatus field name as the referenceCode parameter to retrieve the values. | [optional] 
**residential_status** | **string** | Indicate status of residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceStatus} resource to get valid value of this field with description. You can use residenceStatus field name as the referenceCode parameter to retrieve the values. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

