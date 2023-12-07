# SecuritiesBrokerageAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **string** | The name of the product | [optional] 
**product_code** | **string** | A unique code that identifies the product | [optional] 
**display_account_number** | **string** | A masked account number that can be displayed to the customer | 
**currency_code** | **string** | The currency code of the account in ISO 4217 format | [optional] 
**total_securities_value_amount** | **double** | The total market worth of securities | [optional] 
**total_transaction_amount** | **double** | Total transaction amount in local currency | [optional] 
**total_unrealized_gains** | **double** | Total unrealized gains amount, profitable position that has yet to be cashed in | [optional] 
**relationship** | [**\Swagger\Client\Model\Relationship**](Relationship.md) |  | [optional] 
**security** | [**\Swagger\Client\Model\Security[]**](Security.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

