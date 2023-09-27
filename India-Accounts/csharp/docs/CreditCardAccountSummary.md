# IO.Swagger.Model.CreditCardAccountSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the product | [optional] 
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**AccountNickname** | **string** | The nickname of the account assigned by the customer | [optional] 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | [optional] 
**AccountId** | **string** | The customer account identifier in encrypted format. | [optional] 
**CurrencyCode** | **string** | The currency code in ISO 4217 format | [optional] 
**AccountClassification** | **string** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**AccountStatus** | **string** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**OutstandingBalance** | **double?** | The amount of money owed on the credit account. It is the outstanding balance in applicable level (either card, account or relationship levels) | [optional] 
**AvailableCredit** | **double?** | Available Credit limit on the credit card | [optional] 
**CreditLimit** | **double?** | The maximum amount of credit that extend to a customer | [optional] 
**MinimumDueAmount** | **double?** | Minimum due amount for a payment cycle | [optional] 
**PaymentDueDate** | **DateTime?** | The payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**AlternateCurrency** | **string** | The alternate currency | [optional] 
**AlternateCurrencyCurrentBalance** | **double?** | The current balance in alternate currency | [optional] 
**CardHolderType** | **string** | Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

