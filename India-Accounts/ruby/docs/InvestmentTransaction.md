# SwaggerClient::InvestmentTransaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**order_date** | **Date** | Order date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting | [optional] 
**order_reference_id** | **String** | Reference Id to uniquely identify the investment transaction | [optional] 
**order_type** | **String** | This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderType} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**code** | **String** | Order code to uniquely identify the transaction, | [optional] 
**name** | **String** | Unique name  for fund/stock | [optional] 
**currency_code** | **String** | The currency code of the transaction in ISO 4217 format, | [optional] 
**transaction_amount** | **Float** | Transaction amount in local currency. | [optional] 
**price** | **Float** | Order price of  trade | [optional] 
**order_status** | **String** | This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderStatus} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**gross_amount** | **Float** | The total amount of the transaction | [optional] 
**order_quantity** | **Float** | Total number of units ordered | [optional] 
**order_medium** | **String** | The medium used by customer to place order.This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderMedium} resource to get possible values of This field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**filled_quantity** | **Float** | Number of units received | [optional] 
**balance_quantity** | **Float** | Number of units not received | [optional] 
**stock_market_code** | **String** | Trading market code for securities | [optional] 

