# IO.Swagger.Model.Transactions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayCardNumber** | **string** | A masked card number that can be displayed to the customer | 
**CardHolderType** | **string** | Indicator to specify whether the card is primary or supplementary.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**TransactionDate** | **DateTime?** | The transaction date in ISO 8601 format YYYY-MM-DD | [optional] 
**TransactionPostingDate** | **DateTime?** | The transaction posting date in ISO 8601 format YYYY-MM-DD | [optional] 
**MerchantName** | **string** | The merchant name with which this transaction was made. | [optional] 
**TransactionCode** | **string** | The transaction code | [optional] 
**TransactionDescription** | **string** | Transaction description from the merchant, POS or bank. | [optional] 
**TransactionType** | **string** | The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**ForeignTransactionAmount** | **double?** | The transaction amount in the foreign currency | [optional] 
**ForeignCurrencyCode** | **string** | The foreign currency code of the transaction in ISO 4217 format | [optional] 
**TransactionAmount** | **double?** | Transaction amount in local currency | [optional] 
**CurrencyCode** | **string** | The currency code of the transaction in ISO 4217 format | [optional] 
**EligibleForEqualPaymentPlan** | **string** | The EPP allowed indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**TransactionReferenceId** | **string** | The unique transaction reference Id used to identify this transaction from all the other transactions, | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

