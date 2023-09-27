# SwaggerClient::UnbilledTransaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_date** | **Date** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. | 
**transaction_description** | **String** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | 
**transaction_reference_id** | **String** | Reference Id to uniquely identify the transaction.This is applicable for successful transactions.  | [optional] 
**transaction_amount** | **Float** | Transaction amount in local currency. | 
**currency_code** | **String** | The currency code in ISO 4217 format | [optional] 

