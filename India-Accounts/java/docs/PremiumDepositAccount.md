# PremiumDepositAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productName** | **String** | The name of the product |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer | 
**baseCurrencyPrincipalAmount** | **Double** | The investment amount in base currency |  [optional]
**baseCurrencyCode** | **String** | The base currency code in ISO 4217 format |  [optional]
**alternateCurrencyPrincipalAmount** | **Double** | The investment amount in alternate currency |  [optional]
**openingDate** | [**LocalDate**](LocalDate.md) | Premium deposit open date in ISO 8601 date format YYYY-MM-DD |  [optional]
**alternateCurrencyCode** | **String** | The alternate currency code in ISO 4217 format |  [optional]
**baseCurrencyDisposalAccount** | **String** | The account number to deposit returns of base currency, upon maturity |  [optional]
**alternateCurrencyDisposalAccount** | **String** | The account number to deposit returns of alternate currency, upon maturity |  [optional]
**baseCurrencyInterestAmount** | **Double** | The accrued interest amount in base currency |  [optional]
**alternateCurrencyInterestAmount** | **Double** | The accrued interest amount in alternate currency |  [optional]
**baseCurrencyMaturityAmount** | **Double** | The investment amount and accrued interest in base currency |  [optional]
**alternateCurrencyMaturityAmount** | **Double** | The investment amount and accrued interest in alternate currency |  [optional]
**baseCurrencyPremiumAmount** | **Double** | A part or all of the interest the customer earns on the Premium Account represents the premium that the bank pays the customer for the currency option |  [optional]
**maturityDate** | [**LocalDate**](LocalDate.md) | The date when the premium deposit will mature, in ISO8601 date format YYYY-MM-DD |  [optional]
**strikePrice** | **Double** | The Pre-agreed exchange rate |  [optional]
**customerInterestRate** | **Double** | The customer interest rate applicable for the premium deposit |  [optional]
**accruedInterestRate** | **Double** | The accrued interest rate applicable for the premium deposit |  [optional]
**benchmarkInterestRate** | **Double** | The benchmark interest rate applicable for the premium deposit |  [optional]
**dealStatus** | **String** | The deal status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{dealStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**expiryDate** | [**LocalDate**](LocalDate.md) | The date when the premium deposit deal will expire, in ISO8601 date format YYYY-MM-DD |  [optional]
**tenorTerm** | **Integer** | The tenor term for deposit |  [optional]
**tenorPeriod** | **String** | This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenorPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**relationship** | [**Relationship**](Relationship.md) |  |  [optional]
