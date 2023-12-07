# SwaggerClient::OriginalTransactionDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_type** | **String** | The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. | [optional] 
**transaction_date** | **Date** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, | [optional] 
**transaction_amount** | **Float** | Transaction amount in account currency. | [optional] 
**transaction_currency_code** | **String** | The currency code for the foreign transaction amount in ISO 4217 format. | [optional] 
**transaction_status** | **String** | Transaction Status of the original transaction | [optional] 
**transaction_reference_number** | **String** | Transaction reference number of the original transaction | [optional] 
**transaction_remarks** | **String** | Transaction Remarks of the original transaction | [optional] 
**end_to_end_identification** | **String** | End to End Identification reference of the original transaction | [optional] 

