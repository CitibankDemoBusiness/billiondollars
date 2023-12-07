# SwaggerClient::CreditCardLimitDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**current_contactless_wthout_pin_pmt_limit** | [**BigDecimal**](BigDecimal.md) | Transaction limit set by the customer for the contact less payments without pin | [optional] 
**pos_spending_limit_amount** | **Float** | Point Sale Transaction Limit for the Credit card depends on customer selection | [optional] 
**internet_purchase_limit_amount** | **Float** | Non Point of Sale Transaction Limit for the Credit Card. Example: Online Transaction | [optional] 
**daily_atm_withdrawal_limit_amount** | **Float** | Field to indicate the limit on local ATM withdrawal amount | [optional] 
**daily_transaction_limit_amount** | **Float** | This is Daily accumulated Transaction amount Limit and set by customer. | [optional] 
**internet_purchase_activation_flag** | **BOOLEAN** | The indicator to enable/disable online purchase transaction (E-commerce). | [optional] 
**domestic_transaction** | [**DomesticTransaction**](DomesticTransaction.md) |  | [optional] 
**international_transaction** | [**InternationalTransaction**](InternationalTransaction.md) |  | [optional] 

