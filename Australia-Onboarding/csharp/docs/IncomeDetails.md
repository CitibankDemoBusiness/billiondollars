# IO.Swagger.Model.IncomeDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncomeType** | **string** | Income type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{incomeType} resource to get possible values of this field with descriptions. You can use incomeType field name as the referenceCode parameter to retrieve the values. | [optional] 
**FixedAmount** | **double?** | Fixed income amount | [optional] 
**VariableAmount** | **double?** | Variable income amount | [optional] 
**CurrencyCode** | **string** | Currency Code in ISO 4217 format. | [optional] 
**Frequency** | **string** | Frequency. This is a reference data field. Please use /v1/apac/utilities/referenceData/{frequency} resource to get possible values of this field with descriptions. You can use frequency field name as the referenceCode parameter to retrieve the values. | [optional] 
**OtherIncomeDescription** | **string** | Description of income from other sources | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

