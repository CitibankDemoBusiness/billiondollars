# InvestmentTransaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**order_date** | [**\DateTime**](\DateTime.md) | Order date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting | [optional] 
**order_reference_id** | **string** | Reference Id to uniquely identify the investment transaction | [optional] 
**order_type** | **string** | This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderType} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**code** | **string** | Order code to uniquely identify the transaction, | [optional] 
**name** | **string** | Unique name  for fund/stock | [optional] 
**currency_code** | **string** | The currency code of the transaction in ISO 4217 format, | [optional] 
**transaction_amount** | **double** | Transaction amount in local currency. | [optional] 
**price** | **double** | Order price of  trade | [optional] 
**order_status** | **string** | This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderStatus} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**gross_amount** | **double** | The total amount of the transaction | [optional] 
**order_quantity** | **double** | Total number of units ordered | [optional] 
**order_medium** | **string** | The medium used by customer to place order.This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderMedium} resource to get possible values of This field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**filled_quantity** | **double** | Number of units received | [optional] 
**balance_quantity** | **double** | Number of units not received | [optional] 
**stock_market_code** | **string** | Trading market code for securities | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

