# SwaggerClient::PendingTransaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_date** | **Date** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, | 
**transaction_description** | **String** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | 
**transaction_authorization_code** | **String** | Transaction authorization code is a unique to a sales credit card transaction to indicate that the sale has been authorized. This is applicable only for pending transactions. | [optional] 
**transaction_reference_id** | **String** | Reference Id to uniquely identify the transaction. | [optional] 
**merchant_name** | **String** | Transaction merchant name. | [optional] 
**transaction_amount** | **Float** | Transaction amount in local currency. | 

