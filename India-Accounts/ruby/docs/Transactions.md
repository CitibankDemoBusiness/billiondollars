# SwaggerClient::Transactions

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_card_number** | **String** | A masked card number that can be displayed to the customer | 
**card_holder_type** | **String** | Indicator to specify whether the card is primary or supplementary.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**transaction_date** | **Date** | The transaction date in ISO 8601 format YYYY-MM-DD | [optional] 
**transaction_posting_date** | **Date** | The transaction posting date in ISO 8601 format YYYY-MM-DD | [optional] 
**merchant_name** | **String** | The merchant name with which this transaction was made. | [optional] 
**transaction_code** | **String** | The transaction code | [optional] 
**transaction_description** | **String** | Transaction description from the merchant, POS or bank. | [optional] 
**transaction_type** | **String** | The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**foreign_transaction_amount** | **Float** | The transaction amount in the foreign currency | [optional] 
**foreign_currency_code** | **String** | The foreign currency code of the transaction in ISO 4217 format | [optional] 
**transaction_amount** | **Float** | Transaction amount in local currency | [optional] 
**currency_code** | **String** | The currency code of the transaction in ISO 4217 format | [optional] 
**eligible_for_equal_payment_plan** | **String** | The EPP allowed indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**transaction_reference_id** | **String** | The unique transaction reference Id used to identify this transaction from all the other transactions, | [optional] 

