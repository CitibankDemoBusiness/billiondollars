# IO.Swagger.Model.TimeDepositAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the product | [optional] 
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | 
**OriginalPrincipalAmount** | **double?** | The original principal amount when account opened. | [optional] 
**CurrencyCode** | **string** | The currency code of the account in ISO 4217 format | [optional] 
**InterestRate** | **double?** | The rate of interest applicable for the time deposit | [optional] 
**OpeningDate** | **DateTime?** | The opening date of the time deposit, in ISO 8601 format YYYY-MM-DD | [optional] 
**MaturityDate** | **DateTime?** | The date when the time deposit will mature, in ISO 8601 format YYYY-MM-DD | [optional] 
**NextInterestPaymentDate** | **DateTime?** | The date when interest will be paid by Citibank, in ISO8601 format YYYY-MM-DD | [optional] 
**InterestAmountDue** | **double?** | The accrued interest amount which has not yet been paid by Citibank | [optional] 
**RenewalInstructions** | **string** | The instructions for time deposit renewal. This is a reference data field. Please use /v1/apac/utilities/referenceData/{renewalInstructions} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**TenorTerm** | **int?** | The tenor term for the deposit, expressed as a whole number | [optional] 
**TenorPeriod** | **string** | The unit of the tenor term. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenorPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**BaseCurrencyMaturityAmount** | **double?** | The investment amount and accrued interest in base currency | [optional] 
**MaturityInterestAmount** | **double?** | The accrued interest in base currency. | [optional] 
**LastInterestPaymentAmount** | **double?** | Last interest amount for the time deposit account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

