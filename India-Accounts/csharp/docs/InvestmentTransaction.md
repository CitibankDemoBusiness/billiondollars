# IO.Swagger.Model.InvestmentTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderDate** | **DateTime?** | Order date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting | [optional] 
**OrderReferenceId** | **string** | Reference Id to uniquely identify the investment transaction | [optional] 
**OrderType** | **string** | This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderType} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**Code** | **string** | Order code to uniquely identify the transaction, | [optional] 
**Name** | **string** | Unique name  for fund/stock | [optional] 
**CurrencyCode** | **string** | The currency code of the transaction in ISO 4217 format, | [optional] 
**TransactionAmount** | **double?** | Transaction amount in local currency. | [optional] 
**Price** | **double?** | Order price of  trade | [optional] 
**OrderStatus** | **string** | This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderStatus} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**GrossAmount** | **double?** | The total amount of the transaction | [optional] 
**OrderQuantity** | **double?** | Total number of units ordered | [optional] 
**OrderMedium** | **string** | The medium used by customer to place order.This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderMedium} resource to get possible values of This field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**FilledQuantity** | **double?** | Number of units received | [optional] 
**BalanceQuantity** | **double?** | Number of units not received | [optional] 
**StockMarketCode** | **string** | Trading market code for securities | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

