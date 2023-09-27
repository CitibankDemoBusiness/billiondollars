# TimeDepositAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productName** | **String** | The name of the product |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer | 
**originalPrincipalAmount** | **Double** | The original principal amount when account opened. |  [optional]
**currencyCode** | **String** | The currency code of the account in ISO 4217 format |  [optional]
**interestRate** | **Double** | The rate of interest applicable for the time deposit |  [optional]
**openingDate** | [**LocalDate**](LocalDate.md) | The opening date of the time deposit, in ISO 8601 format YYYY-MM-DD |  [optional]
**maturityDate** | [**LocalDate**](LocalDate.md) | The date when the time deposit will mature, in ISO 8601 format YYYY-MM-DD |  [optional]
**nextInterestPaymentDate** | [**LocalDate**](LocalDate.md) | The date when interest will be paid by Citibank, in ISO8601 format YYYY-MM-DD |  [optional]
**interestAmountDue** | **Double** | The accrued interest amount which has not yet been paid by Citibank |  [optional]
**renewalInstructions** | **String** | The instructions for time deposit renewal. This is a reference data field. Please use /v1/apac/utilities/referenceData/{renewalInstructions} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**tenorTerm** | **Integer** | The tenor term for the deposit, expressed as a whole number |  [optional]
**tenorPeriod** | **String** | The unit of the tenor term. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenorPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**baseCurrencyMaturityAmount** | **Double** | The investment amount and accrued interest in base currency |  [optional]
**maturityInterestAmount** | **Double** | The accrued interest in base currency. |  [optional]
**lastInterestPaymentAmount** | **Double** | Last interest amount for the time deposit account |  [optional]
