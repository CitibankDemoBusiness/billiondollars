# IO.Swagger.Model.CreditCardLimitDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentContactlessWthoutPinPmtLimit** | [**decimal?**](BigDecimal.md) | Transaction limit set by the customer for the contact less payments without pin | [optional] 
**PosSpendingLimitAmount** | **double?** | Point Sale Transaction Limit for the Credit card depends on customer selection | [optional] 
**InternetPurchaseLimitAmount** | **double?** | Non Point of Sale Transaction Limit for the Credit Card. Example: Online Transaction | [optional] 
**DailyAtmWithdrawalLimitAmount** | **double?** | Field to indicate the limit on local ATM withdrawal amount | [optional] 
**DailyTransactionLimitAmount** | **double?** | This is Daily accumulated Transaction amount Limit and set by customer. | [optional] 
**InternetPurchaseActivationFlag** | **bool?** | The indicator to enable/disable online purchase transaction (E-commerce). | [optional] 
**DomesticTransaction** | [**DomesticTransaction**](DomesticTransaction.md) |  | [optional] 
**InternationalTransaction** | [**InternationalTransaction**](InternationalTransaction.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

