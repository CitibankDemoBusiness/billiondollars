# IncomeDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**income_type** | **string** | Income type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{incomeType} resource to get possible values of this field with descriptions. You can use incomeType field name as the referenceCode parameter to retrieve the values. | [optional] 
**fixed_amount** | **double** | Fixed income amount | [optional] 
**variable_amount** | **double** | Variable income amount | [optional] 
**currency_code** | **string** | Currency Code in ISO 4217 format. | [optional] 
**frequency** | **string** | Frequency. This is a reference data field. Please use /v1/apac/utilities/referenceData/{frequency} resource to get possible values of this field with descriptions. You can use frequency field name as the referenceCode parameter to retrieve the values. | [optional] 
**other_income_description** | **string** | Description of income from other sources | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

