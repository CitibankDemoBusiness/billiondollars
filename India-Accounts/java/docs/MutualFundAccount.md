# MutualFundAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productName** | **String** | The name of the product |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer | 
**currencyCode** | **String** | The currency code of the account in ISO 4217 format |  [optional]
**totalNetAssetValueAmount** | **Double** | Total of net asset value of mutual funds |  [optional]
**totalTransactionAmount** | **Double** | Total transaction amount in local currency |  [optional]
**totalUnrealizedGains** | **Double** | Total unrealized gains amount, profitable position that has yet to be cashed in |  [optional]
**relationship** | [**Relationship**](Relationship.md) |  |  [optional]
**mutualFund** | [**List&lt;MutualFund&gt;**](MutualFund.md) |  |  [optional]
