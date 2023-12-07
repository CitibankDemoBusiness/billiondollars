# SecuritiesBrokerageAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **str** | The name of the product | [optional] 
**product_code** | **str** | A unique code that identifies the product | [optional] 
**display_account_number** | **str** | A masked account number that can be displayed to the customer | 
**currency_code** | **str** | The currency code of the account in ISO 4217 format | [optional] 
**total_securities_value_amount** | **float** | The total market worth of securities | [optional] 
**total_transaction_amount** | **float** | Total transaction amount in local currency | [optional] 
**total_unrealized_gains** | **float** | Total unrealized gains amount, profitable position that has yet to be cashed in | [optional] 
**relationship** | [**Relationship**](Relationship.md) |  | [optional] 
**security** | [**list[Security]**](Security.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

