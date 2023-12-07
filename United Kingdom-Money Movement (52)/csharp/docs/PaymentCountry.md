# IO.Swagger.Model.PaymentCountry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountryName** | **string** | This field is to indicate the country name of the payee. This is a reference data field. Please use /v1/utilities/referenceData/{countryName} resource to get valid value of this field with description. | 
**CountryCode** | **string** | ISO country code. This is a reference data field. Please use /utilities/referenceData/{country} resource to get possible values of this field with descriptions. | 
**LocalCurrencyCode** | **string** | This is the local currency code in ISO 4217 Format. | [optional] 
**CountryBankBranchIdentifier** | **string** | This field is to indicate the name of the bank branch identifier supported for the country. | [optional] 
**CountryIbanFlag** | **bool?** | This field is used to indicate if the country supports IBAN. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

