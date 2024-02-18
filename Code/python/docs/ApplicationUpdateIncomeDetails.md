# ApplicationUpdateIncomeDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**income_type** | **str** | Income type. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{incomeType} resource to get valid value of this field with description. You can use incomeType field name as the referenceCode parameter to retrieve the values. | [optional] 
**fixed_amount** | **float** | Fixed income amount of applicant | [optional] 
**variable_amount** | **float** | Variable income amount of appliacnt | [optional] 
**frequency** | **str** | Income Frequency. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{frequency} resource to get valid value of this field with description. You can use frequency field name as the referenceCode parameter to retrieve the values. | [optional] 
**other_income_description** | **str** | Description of income from other sources | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

