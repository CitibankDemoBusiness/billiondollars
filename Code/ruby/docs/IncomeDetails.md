# SwaggerClient::IncomeDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**income_type** | **String** | Income type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{incomeType} resource to get possible values of this field with descriptions. You can use incomeType field name as the referenceCode parameter to retrieve the values. | [optional] 
**fixed_amount** | **Float** | Fixed income amount | [optional] 
**variable_amount** | **Float** | Variable income amount | [optional] 
**currency_code** | **String** | Currency Code in ISO 4217 format. | [optional] 
**frequency** | **String** | Frequency. This is a reference data field. Please use /v1/apac/utilities/referenceData/{frequency} resource to get possible values of this field with descriptions. You can use frequency field name as the referenceCode parameter to retrieve the values. | [optional] 
**other_income_description** | **String** | Description of income from other sources | [optional] 

