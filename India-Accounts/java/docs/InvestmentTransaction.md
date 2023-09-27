# InvestmentTransaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**orderDate** | [**LocalDate**](LocalDate.md) | Order date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting |  [optional]
**orderReferenceId** | **String** | Reference Id to uniquely identify the investment transaction |  [optional]
**orderType** | **String** | This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderType} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**code** | **String** | Order code to uniquely identify the transaction, |  [optional]
**name** | **String** | Unique name  for fund/stock |  [optional]
**currencyCode** | **String** | The currency code of the transaction in ISO 4217 format, |  [optional]
**transactionAmount** | **Double** | Transaction amount in local currency. |  [optional]
**price** | **Double** | Order price of  trade |  [optional]
**orderStatus** | **String** | This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderStatus} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**grossAmount** | **Double** | The total amount of the transaction |  [optional]
**orderQuantity** | **Double** | Total number of units ordered |  [optional]
**orderMedium** | **String** | The medium used by customer to place order.This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderMedium} resource to get possible values of This field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**filledQuantity** | **Double** | Number of units received |  [optional]
**balanceQuantity** | **Double** | Number of units not received |  [optional]
**stockMarketCode** | **String** | Trading market code for securities |  [optional]
