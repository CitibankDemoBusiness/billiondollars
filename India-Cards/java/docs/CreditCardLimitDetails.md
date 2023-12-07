# CreditCardLimitDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**currentContactlessWthoutPinPmtLimit** | [**BigDecimal**](BigDecimal.md) | Transaction limit set by the customer for the contact less payments without pin |  [optional]
**posSpendingLimitAmount** | **Double** | Point Sale Transaction Limit for the Credit card depends on customer selection |  [optional]
**internetPurchaseLimitAmount** | **Double** | Non Point of Sale Transaction Limit for the Credit Card. Example: Online Transaction |  [optional]
**dailyAtmWithdrawalLimitAmount** | **Double** | Field to indicate the limit on local ATM withdrawal amount |  [optional]
**dailyTransactionLimitAmount** | **Double** | This is Daily accumulated Transaction amount Limit and set by customer. |  [optional]
**internetPurchaseActivationFlag** | **Boolean** | The indicator to enable/disable online purchase transaction (E-commerce). |  [optional]
**domesticTransaction** | [**DomesticTransaction**](DomesticTransaction.md) |  |  [optional]
**internationalTransaction** | [**InternationalTransaction**](InternationalTransaction.md) |  |  [optional]
