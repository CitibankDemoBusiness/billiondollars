# SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**customer_name** | **String** | his refers to the name of the customer | 
**product_code** | **String** | A unique code that identifies the product | 
**service_charge_amount** | **String** | Booking Fees Amount | [optional] 
**card_id** | **String** | The customer card identifier in encrypted format | [optional] 
**product_name** | **String** | The name of the product | 
**display_card_number** | **String** | A masked Card number that can be displayed to the customer | 
**pending_transaction** | [**PendingTransaction**](PendingTransaction.md) |  | [optional] 
**statement** | [**Statement**](Statement.md) |  | [optional] 
**epp_offers** | [**Array&lt;EppOffers&gt;**](EppOffers.md) |  | [optional] 

