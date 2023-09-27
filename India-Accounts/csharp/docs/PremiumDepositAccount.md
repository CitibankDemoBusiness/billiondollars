# IO.Swagger.Model.PremiumDepositAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the product | [optional] 
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | 
**BaseCurrencyPrincipalAmount** | **double?** | The investment amount in base currency | [optional] 
**BaseCurrencyCode** | **string** | The base currency code in ISO 4217 format | [optional] 
**AlternateCurrencyPrincipalAmount** | **double?** | The investment amount in alternate currency | [optional] 
**OpeningDate** | **DateTime?** | Premium deposit open date in ISO 8601 date format YYYY-MM-DD | [optional] 
**AlternateCurrencyCode** | **string** | The alternate currency code in ISO 4217 format | [optional] 
**BaseCurrencyDisposalAccount** | **string** | The account number to deposit returns of base currency, upon maturity | [optional] 
**AlternateCurrencyDisposalAccount** | **string** | The account number to deposit returns of alternate currency, upon maturity | [optional] 
**BaseCurrencyInterestAmount** | **double?** | The accrued interest amount in base currency | [optional] 
**AlternateCurrencyInterestAmount** | **double?** | The accrued interest amount in alternate currency | [optional] 
**BaseCurrencyMaturityAmount** | **double?** | The investment amount and accrued interest in base currency | [optional] 
**AlternateCurrencyMaturityAmount** | **double?** | The investment amount and accrued interest in alternate currency | [optional] 
**BaseCurrencyPremiumAmount** | **double?** | A part or all of the interest the customer earns on the Premium Account represents the premium that the bank pays the customer for the currency option | [optional] 
**MaturityDate** | **DateTime?** | The date when the premium deposit will mature, in ISO8601 date format YYYY-MM-DD | [optional] 
**StrikePrice** | **double?** | The Pre-agreed exchange rate | [optional] 
**CustomerInterestRate** | **double?** | The customer interest rate applicable for the premium deposit | [optional] 
**AccruedInterestRate** | **double?** | The accrued interest rate applicable for the premium deposit | [optional] 
**BenchmarkInterestRate** | **double?** | The benchmark interest rate applicable for the premium deposit | [optional] 
**DealStatus** | **string** | The deal status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{dealStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**ExpiryDate** | **DateTime?** | The date when the premium deposit deal will expire, in ISO8601 date format YYYY-MM-DD | [optional] 
**TenorTerm** | **int?** | The tenor term for deposit | [optional] 
**TenorPeriod** | **string** | This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenorPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**Relationship** | [**Relationship**](Relationship.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

