# Transactions

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_card_number** | **string** | A masked card number that can be displayed to the customer | 
**card_holder_type** | **string** | Indicator to specify whether the card is primary or supplementary.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**transaction_date** | [**\DateTime**](\DateTime.md) | The transaction date in ISO 8601 format YYYY-MM-DD | [optional] 
**transaction_posting_date** | [**\DateTime**](\DateTime.md) | The transaction posting date in ISO 8601 format YYYY-MM-DD | [optional] 
**merchant_name** | **string** | The merchant name with which this transaction was made. | [optional] 
**transaction_code** | **string** | The transaction code | [optional] 
**transaction_description** | **string** | Transaction description from the merchant, POS or bank. | [optional] 
**transaction_type** | **string** | The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**foreign_transaction_amount** | **double** | The transaction amount in the foreign currency | [optional] 
**foreign_currency_code** | **string** | The foreign currency code of the transaction in ISO 4217 format | [optional] 
**transaction_amount** | **double** | Transaction amount in local currency | [optional] 
**currency_code** | **string** | The currency code of the transaction in ISO 4217 format | [optional] 
**eligible_for_equal_payment_plan** | **string** | The EPP allowed indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**transaction_reference_id** | **string** | The unique transaction reference Id used to identify this transaction from all the other transactions, | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

