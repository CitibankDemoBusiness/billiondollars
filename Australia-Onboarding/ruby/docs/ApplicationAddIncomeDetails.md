# SwaggerClient::ApplicationAddIncomeDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**income_type** | **String** | Income type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{incomeType} resource to get valid value of this field with description. You can use incomeType field name as the referenceCode parameter to retrieve the values. | [optional] 
**fixed_amount** | **Float** | Fixed income amount of applicant | [optional] 
**variable_amount** | **Float** | Variable income amount of applicant | [optional] 
**frequency** | **String** | Income Frequency. This is a reference data field. Please use /v1/apac/utilities/referenceData/{frequency} resource to get valid value of this field with description. You can use frequency field name as the referenceCode parameter to retrieve the values. | [optional] 
**other_income_description** | **String** | Description of income from other sources | [optional] 

