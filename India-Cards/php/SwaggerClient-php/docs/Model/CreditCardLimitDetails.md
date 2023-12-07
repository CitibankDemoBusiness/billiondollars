# CreditCardLimitDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**current_contactless_wthout_pin_pmt_limit** | **float** | Transaction limit set by the customer for the contact less payments without pin | [optional] 
**pos_spending_limit_amount** | **double** | Point Sale Transaction Limit for the Credit card depends on customer selection | [optional] 
**internet_purchase_limit_amount** | **double** | Non Point of Sale Transaction Limit for the Credit Card. Example: Online Transaction | [optional] 
**daily_atm_withdrawal_limit_amount** | **double** | Field to indicate the limit on local ATM withdrawal amount | [optional] 
**daily_transaction_limit_amount** | **double** | This is Daily accumulated Transaction amount Limit and set by customer. | [optional] 
**internet_purchase_activation_flag** | **bool** | The indicator to enable/disable online purchase transaction (E-commerce). | [optional] 
**domestic_transaction** | [**\Swagger\Client\Model\DomesticTransaction**](DomesticTransaction.md) |  | [optional] 
**international_transaction** | [**\Swagger\Client\Model\InternationalTransaction**](InternationalTransaction.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

