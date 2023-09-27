# NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**request_id** | **str** | This field provides the unique request ID generated from the VOX platform. Will be used for tracking and audit purposes | 
**vop_transaction_id** | **str** | This field specifies the VOP transaction ID of the original transaction, that triggered the reward. | 
**action_type** | **str** | This field specifies the action to be performed for the request.Valid Value is Notify | 
**distributor_id** | **str** | This field specifies the Distributor ID. Important when an aggregator (who is serving for more than one distributor) is building the API end point. | 
**card_id** | **str** | This field provides the card id generated during cardholder enrolment at VOX. | 
**user_id** | **str** | This field provides the external user id generated during cardholder enrolment at VOX. | 
**credit_status** | **str** | This field specifies the reward credit status.Valid Values are Successful, Eligible, Failed | 
**request_date_time** | **str** | This field specifies the date and time which the reward request is initiated in the format YYYY-MM-DD HH:MM:SS | 
**offer_id** | **int** | This will be the VOX qualified offer ID, which the reward is given, Will be used for tracking and audit purposes. | 
**settlement_currency** | **str** | This field specifies the reward currency of the original offer | 
**reward_settlement_currency** | **float** | This field specifies the cashback reward value in Settlement Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**billing_currency** | **str** | This field specifies the customer purchase currency derived from the VOP transaction. | 
**reward_billing_currency** | **float** | This field specifies the cashback reward value in Settlement Billing Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**merchant_name** | **str** | This field provides the merchant name | 
**transaction_date** | **str** | This field specifies the transaction date retrieved from the VOP Transaction in the format YYYY-MM-DD HH:MM:SS | 
**transaction_billing_amount** | **float** | This field specifies transaction amount in billing currency as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**transaction_settlement_amount** | **float** | This field specifies transaction amount in settlement currency  as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**remarks** | **str** | This field is used to pass additional information required by the partner for their records. This can pass an empty value as well. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

