# SwaggerClient::SecuritiesBrokerageAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **String** | The name of the product | [optional] 
**product_code** | **String** | A unique code that identifies the product | [optional] 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | 
**currency_code** | **String** | The currency code of the account in ISO 4217 format | [optional] 
**total_securities_value_amount** | **Float** | The total market worth of securities | [optional] 
**total_transaction_amount** | **Float** | Total transaction amount in local currency | [optional] 
**total_unrealized_gains** | **Float** | Total unrealized gains amount, profitable position that has yet to be cashed in | [optional] 
**relationship** | [**Relationship**](Relationship.md) |  | [optional] 
**security** | [**Array&lt;Security&gt;**](Security.md) |  | [optional] 

