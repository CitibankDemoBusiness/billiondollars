# IO.Swagger.Model.TaxPaymentDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdType** | **string** | Type of Identification document. This is a reference data field. Please use /v1/utilities/referenceData/{idType} resource to get valid values of this field with descriptions | 
**IdNumber** | **string** | Unique identifier of identification document. | 
**TaxDeclarationType** | **string** | This field is to indicate the type of tax declaration.This is a reference data field. Please use /v1/utilities/referenceData/{taxDeclarationType} resource to get valid values of this field with descriptions | 
**TaxPaymentYear** | **string** | This field is to indicate the tax payment year. | 
**TaxPaymentMonth** | **string** | This field is to indicate the tax payment month. Applicable when taxPaymentPeriod&#x3D;DECADE or DATE. | [optional] 
**TaxPaymentDay** | **string** | This field is to indicate the tax payment day. Applicable when taxPaymentPeriod&#x3D;DATE. | [optional] 
**TaxPaymentPeriod** | **string** | This field is to indicate the period of the tax payment. This is a reference data field. Please use /v1/utilities/referenceData/{taxPaymentPeriod} resource to get valid values of this field with descriptions | [optional] 
**TaxPaymentPeriodNumber** | **string** | This field is to indicate the period number of the tax payment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

