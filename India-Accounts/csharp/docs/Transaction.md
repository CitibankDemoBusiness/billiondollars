# IO.Swagger.Model.Transaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | [optional] 
**TransactionDate** | **DateTime?** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, | [optional] 
**TransactionDescription** | **string** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | [optional] 
**TransactionReferenceId** | **string** | Reference Id to uniquely identify the transaction | [optional] 
**CheckSerialNumber** | **string** | The check serial number. Applicable for checking accounts only | [optional] 
**TransactionAmount** | **double?** | Transaction amount in local currency. | [optional] 
**CurrencyCode** | **string** | The currency code of the transaction in ISO 4217 format | [optional] 
**ForeignTransactionAmount** | [**decimal?**](BigDecimal.md) | The transaction amount in the foreign currency | [optional] 
**ForeignCurrencyCode** | **string** | The foreign currency code of the transaction in ISO 4217 format | [optional] 
**ForeignExchangeRate** | [**decimal?**](BigDecimal.md) | The exchange rate at the time the foreign transaction was done | [optional] 
**TransactionType** | **string** | The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values | [optional] 
**TransactionStatus** | **string** | The status of the transaction.  Applicable for credit cards only.. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values | [optional] 
**RunningBalance** | **double?** | The amount available to transact immediately | [optional] 
**TransactionPostingDate** | **DateTime?** | Transaction posting date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting | [optional] 
**TransactionCode** | **string** | The transaction code | [optional] 
**MerchantName** | **string** | The merchant name with which this transaction was made with | [optional] 
**EligibleForEqualPaymentPlan** | **string** | The EPP allowed indicator. This is applicable for credit cards transactions only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

