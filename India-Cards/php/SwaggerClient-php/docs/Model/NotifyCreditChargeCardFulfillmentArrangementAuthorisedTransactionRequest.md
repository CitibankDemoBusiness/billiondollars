# NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**request_id** | **string** | This field provides the unique request ID generated from the VOX platform. Will be used for tracking and audit purposes | 
**vop_transaction_id** | **string** | This field specifies the VOP transaction ID of the original transaction, that triggered the reward. | 
**action_type** | **string** | This field specifies the action to be performed for the request.Valid Value is Notify | 
**distributor_id** | **string** | This field specifies the Distributor ID. Important when an aggregator (who is serving for more than one distributor) is building the API end point. | 
**card_id** | **string** | This field provides the card id generated during cardholder enrolment at VOX. | 
**user_id** | **string** | This field provides the external user id generated during cardholder enrolment at VOX. | 
**credit_status** | **string** | This field specifies the reward credit status.Valid Values are Successful, Eligible, Failed | 
**request_date_time** | **string** | This field specifies the date and time which the reward request is initiated in the format YYYY-MM-DD HH:MM:SS | 
**offer_id** | **int** | This will be the VOX qualified offer ID, which the reward is given, Will be used for tracking and audit purposes. | 
**settlement_currency** | **string** | This field specifies the reward currency of the original offer | 
**reward_settlement_currency** | **double** | This field specifies the cashback reward value in Settlement Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**billing_currency** | **string** | This field specifies the customer purchase currency derived from the VOP transaction. | 
**reward_billing_currency** | **double** | This field specifies the cashback reward value in Settlement Billing Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**merchant_name** | **string** | This field provides the merchant name | 
**transaction_date** | **string** | This field specifies the transaction date retrieved from the VOP Transaction in the format YYYY-MM-DD HH:MM:SS | 
**transaction_billing_amount** | **double** | This field specifies transaction amount in billing currency as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**transaction_settlement_amount** | **double** | This field specifies transaction amount in settlement currency  as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**remarks** | **string** | This field is used to pass additional information required by the partner for their records. This can pass an empty value as well. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

