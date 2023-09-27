# IO.Swagger.Model.ApplicationUpdateIncomeDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncomeType** | **string** | Income type. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{incomeType} resource to get valid value of this field with description. You can use incomeType field name as the referenceCode parameter to retrieve the values. | [optional] 
**FixedAmount** | **double?** | Fixed income amount of applicant | [optional] 
**VariableAmount** | **double?** | Variable income amount of appliacnt | [optional] 
**Frequency** | **string** | Income Frequency. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{frequency} resource to get valid value of this field with description. You can use frequency field name as the referenceCode parameter to retrieve the values. | [optional] 
**OtherIncomeDescription** | **string** | Description of income from other sources | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

